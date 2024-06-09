using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using BLL;
using System.Windows.Forms;
using System.Xml.Linq;
using DevExpress.Utils.Filtering;
using System.Text.RegularExpressions;
using Microsoft.Office.Interop.Excel;

namespace GUI
{
    public partial class frm_KH : Form
    {
        List<string>  sdt_kh = new List<string>();  
        public static int ma;
        bool check_them;
        BLL_KH bllkh = new BLL_KH();    
        BLL_Xe bllxe = new BLL_Xe();    
        
        public frm_KH()
        {
            InitializeComponent();
        }

        private void frm_KH_Load(object sender, EventArgs e)
        {
            data_kh.DataSource = bllkh.getKhachang();
            show_hide(true);
            try
            {
                for (int i = 0; i < bllkh.getKhachang().Rows.Count; i++)
                {
                    sdt_kh.Add(bllkh.getKhachang().Rows[i]["sdt"].ToString());
                }
            }
            catch { }
            
        }
        bool check_sdt(string sdt_trung)
        {
            if(sdt_kh.Contains(sdt_trung) == true)
            {
                return true;
            }
            else { return false; }
        }
        void show_hide(bool kt)
        {
            btn_them.Checked = kt;  
            btn_sua.Checked = kt;   
            btn_xoa.Checked = kt;   
            btn_luu.Checked = !kt;
            btn_dong.Checked = kt;
            btn_huy.Checked = !kt;  
            txt_name.Enabled = !kt;
            txt_dc.Enabled = !kt;   
            txt_sdt.Enabled = !kt;  
            txt_tuoi.Enabled = !kt; 
            cbo_gtinh.Enabled = !kt;
        }
        private void data_kh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            string id = data_kh[0, hang].Value.ToString();
            ma = int.Parse(id);   

            txt_name .Text = data_kh[1, hang].Value.ToString();
            txt_tuoi.Text = data_kh[2, hang].Value.ToString(); 
           cbo_gtinh.Text = data_kh[3,hang].Value.ToString();    
            txt_dc.Text = data_kh[4,hang].Value.ToString();
            txt_sdt.Text = data_kh[5,hang].Value.ToString();    
            
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
           show_hide(false);
            check_them = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {   
            show_hide(true);
            string name = txt_name.Text;
            if (bllkh.get_Count() > 0)
            {
                if(bllkh.check_update(name) == false)
                {
                    MessageBox.Show("Vui lòng chọn khách hàng để xoá", "Thông báo", MessageBoxButtons.OK);

                }
                else
                {
                    var result = MessageBox.Show("Bạn có chắc chắn xoá thông tin khách hàng ?", "Thông báo", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        try { bllxe.xoaXeKh(ma); }
                        catch { }

                        if (bllkh.xoaKH(ma) == true)
                        {
                            sdt_kh.Clear();
                            try
                            {
                                for (int i = 0; i < bllkh.getKhachang().Rows.Count; i++)
                                {
                                    sdt_kh.Add(bllkh.getKhachang().Rows[i]["sdt"].ToString());
                                }
                            }
                            catch { }
                            MessageBox.Show("Xoá thông tin thành công", "Thông báo", MessageBoxButtons.OK);
                            txt_name.Clear();
                            txt_dc.Clear();
                            txt_sdt.Clear();
                            txt_tuoi.Clear();
                            data_kh.DataSource = bllkh.getKhachang();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có thông tin của khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            // Biểu thức chính quy để kiểm tra số điện thoại Việt Nam
            var regex = new Regex(@"^0\d{9}$");

            return regex.IsMatch(phoneNumber);
        }
        private bool CheckPriceFormat(string input)
        {
            if (decimal.TryParse(input, out decimal price) && price > 0 && price <= 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            show_hide(true);
            int tuoi;           
            string trade = txt_tuoi.Text;
            int.TryParse(trade,out tuoi);           
            string name = txt_name.Text;
            string diachi = txt_dc.Text;
            string text_sdt = txt_sdt.Text;           
            string gioitinh = cbo_gtinh.Text;
            DTO_Khachhang kh = new DTO_Khachhang(name, tuoi, diachi, gioitinh, text_sdt);
            if (check_them == false) {        
                if(IsValidPhoneNumber(text_sdt) == false)
                {
                    MessageBox.Show("Số điện thoại không đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    show_hide(false);   
                }
                else if(check_sdt(text_sdt) == true)
                {
                    MessageBox.Show("Số điện thoại đã tồn tại trên hệ thống !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    show_hide(false);
                }
                else if (CheckPriceFormat(txt_tuoi.Text) == false){
                    MessageBox.Show("Tuổi khônng đúng với định dạng Vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    show_hide(false);
                }
                else
                {
                    if(bllkh.check_tt(kh.ten, kh.diachi, kh.tuoi, kh.gioi_tinh) == false)
                    {
                        MessageBox.Show("Thông tin không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        show_hide(false);
                    }
                    else
                    {
                        if(bllkh.themKH(kh) == true)
                        {
                            sdt_kh.Clear();
                            try
                            {
                                for (int i = 0; i < bllkh.getKhachang().Rows.Count; i++)
                                {
                                    sdt_kh.Add(bllkh.getKhachang().Rows[i]["sdt"].ToString());
                                }
                            }
                            catch { }
                            MessageBox.Show("Thêm khách hàng thành công", "Thông báo", MessageBoxButtons.OK);
                            data_kh.DataSource = bllkh.getKhachang();
                        }
                          
                       
                    }
                }
                              
            }
            if (check_them == true) {
                
                var result = MessageBox.Show("Bạn có chắc chắn sửa thông tin khách hàng ?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                     if (CheckPriceFormat(txt_tuoi.Text) == false)
                    {
                        MessageBox.Show("Tuổi khônng đúng với định dạng Vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        show_hide(false);
                    }
                    else
                    {
                        if (bllkh.suaKH(kh, ma) == true)
                        {
                            sdt_kh.Clear();
                            try
                            {
                                for (int i = 0; i < bllkh.getKhachang().Rows.Count; i++)
                                {
                                    sdt_kh.Add(bllkh.getKhachang().Rows[i]["sdt"].ToString());
                                }
                            }
                            catch { }
                            MessageBox.Show("Sửa thông tin thành công", "Thông báo", MessageBoxButtons.OK);
                            txt_name.Clear();
                            txt_dc.Clear();
                            txt_sdt.Clear();
                            txt_tuoi.Clear();
                            data_kh.DataSource = bllkh.getKhachang();
                        }
                    }
                  
                }
            }
            
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            check_them = true ;
            string name = txt_name.Text;
            if (bllkh.check_update(name) == false)
            {
                show_hide(true);    
                MessageBox.Show("Vui lòng chọn khách hàng để sửa", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (bllkh.get_Count() > 0)
                {
                    show_hide(false);
                }
                else
                {
                    show_hide(true);
                    MessageBox.Show("Không có thông tin của khách hàng", "Thông báo", MessageBoxButtons.OK);

                }
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            show_hide(true);
            txt_name.Clear();
            txt_dc.Clear();
            txt_sdt.Clear();
            txt_tuoi.Clear();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {

        }
        public int ma_xe
        {
            get { return ma; }
        }
        private void data_kh_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id_xe;
            int hang = e.RowIndex;
            frm_DkiLL frm = new frm_DkiLL();
            frm.txt_tenkh.Text = data_kh[1, hang].Value.ToString();
            frm.txt_tuoi.Text = data_kh[2, hang].Value.ToString();
            frm.txt_diachi.Text = data_kh[4, hang].Value.ToString(); 
            frm.txt_sdt.Text = data_kh[5, hang].Value.ToString();
            frm.cbo_xe.DataSource = bllkh.get_Xe(ma);        
            frm.cbo_dv.DataSource = bllkh.get_DV();
            frm.cbo_dv.DisplayMember = "ten_dv";
            frm.cbo_dv.ValueMember = "id";
            frm.cbo_ns.DataSource = bllkh.get_NS(); 
            frm.cbo_ns.DisplayMember = "ten_ns";
            frm.cbo_ns.ValueMember = "id";
            frm.ShowDialog();
        }
    }
}
