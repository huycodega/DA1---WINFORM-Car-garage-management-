using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DevExpress.Data.Svg;
using DTO;

namespace GUI
{
    public partial class frm_Cars : Form
    {
        int ma;
        bool check_them;
        BLL_Xe bllxe = new BLL_Xe();    
        List<string> lst_bsx = new List<string>();  
        public frm_Cars()
        {
            InitializeComponent();
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
            txt_bsx.Enabled = !kt;
            txt_tinhtrang.Enabled = !kt;    
            cbo_bhx.Enabled = !kt;
            cbo_csh.Enabled = !kt;
        }
        
        int id;
        private void frm_Cars_Load(object sender, EventArgs e)
        {
            check_them = true;  
            show_hide(true);
            data_xe.DataSource = bllxe.getXe();
            
            cbo_csh.DataSource = bllxe.get_Cbo();
            cbo_csh.DisplayMember  = "ten";
            cbo_csh.ValueMember = "id";
            try {
                for (int i = 0; i < bllxe.getXe().Rows.Count; i++)
                {
                    lst_bsx.Add(bllxe.getXe().Rows[i]["bienso"].ToString().Trim());
                }
            }
            catch { }
            
        }
        bool check_bs(string biensoxe)
        {
            if(lst_bsx.Contains(biensoxe) == true)
            {
                return true;
            }  
            else { return false; }
        }
       
        private void data_xe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            string id = data_xe[0, hang].Value.ToString();
            int.TryParse(id, out ma);
            txt_name.Text = data_xe[1, hang].Value.ToString();
            txt_bsx.Text = data_xe[2,hang].Value.ToString();
            txt_tinhtrang.Text  = data_xe[3,hang].Value.ToString();
            cbo_bhx.Text = Convert.ToBoolean(data_xe[4, hang].Value) ? "Còn sử dụng" : "Đã hết";

            cbo_csh.Text = data_xe[5,hang].Value.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            show_hide(false);
            check_them = false;
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            if(bllxe.check_update(txt_name.Text) == false)
            {
                show_hide(true);
                MessageBox.Show("Vui lòng chọn xe để sửa thông tin");
            }
            else
            {
                if (bllxe.get_Count() > 0)
                {
                    show_hide(false);
                    check_them = true;
                }
                else
                {
                    show_hide(true);
                    MessageBox.Show("Không có thông tin của khách hàng", "Thông báo", MessageBoxButtons.OK);

                }

            }
            
        }
        
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            show_hide(true) ;
            if (bllxe.get_Count() > 0)
            {
                if(bllxe.check_update(txt_name.Text)== false)
                {
                    MessageBox.Show("Vui lòng chọn thông tin xe để xoá", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    var result = MessageBox.Show("Bạn có chắc chắn xoá thông tin xe ?", "Thông báo", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        if (bllxe.xoaXe(ma) == true)
                        {
                            lst_bsx.Clear();
                            try {
                                for (int i = 0; i < bllxe.getXe().Rows.Count; i++)
                                {
                                    lst_bsx.Add(bllxe.getXe().Rows[i]["bienso"].ToString());
                                }
                            }
                            catch { }   
                            MessageBox.Show("Xoá thông tin xe thành công", "Thông báo", MessageBoxButtons.OK);
                            txt_name.Clear();
                            txt_bsx.Clear();
                            txt_tinhtrang.Clear();
                            data_xe.DataSource = bllxe.getXe();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có thông tin của Xe", "Thông báo", MessageBoxButtons.OK);
            }
        }
        int check_bhx(string values)
        {
            if(values == "Còn sử dụng")
            {
                return 1;
            }
            else if (values == "Đã hết")
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
        private bool IsValidLicensePlate(string licensePlate)
        {
            // Định dạng biển số xe Việt Nam
            string pattern = @"^\d{2}[A-Z]{1}-\d{4,5}$|^\d{2}[A-Z]{1}-\d{3}\.\d{2}$|^\d{2}-\d{4}$|^\d{2}[A-Z]{1}-\d{4}$|^\d{2}[A-Z]{1}[A-Z]{1}-\d{4,5}$";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(licensePlate);
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {  
            show_hide(true);
            string name = txt_name.Text;
            string bsx = txt_bsx.Text;
            string tinhtrang = txt_tinhtrang.Text;  
            string chusohuu = cbo_csh.Text; 
            string bhx = cbo_bhx.Text;
            int tinhtrang_bhx = check_bhx(bhx);
            DTO_Xe xe = new DTO_Xe(name, bsx, tinhtrang, tinhtrang_bhx, chusohuu);           
            if (check_them == false)
            {
                if( bllxe.check_ttxe(name,chusohuu,bhx,tinhtrang) == false)
                {
                    MessageBox.Show("Thông tin không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (IsValidLicensePlate(txt_bsx.Text) == false)
                    {
                        MessageBox.Show("Biển số xe không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        show_hide(false);
                    }
                    else if (check_bs(txt_bsx.Text) == true)
                    {
                        MessageBox.Show("Biển số xe đã tồn tại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        show_hide(false);
                    }
                    else if (check_bs(txt_bsx.Text) == false)
                    {
                        if (bllxe.themXe(xe, id) == true)
                        {
                            lst_bsx.Clear();
                            try
                            {
                                for (int i = 0; i < bllxe.getXe().Rows.Count; i++)
                                {
                                    lst_bsx.Add(bllxe.getXe().Rows[i]["bienso"].ToString().Trim());
                                }
                            }
                            catch { }   
                            MessageBox.Show("Thêm thông tin xe thành công", "Thông báo", MessageBoxButtons.OK);
                            txt_name.Clear();
                            txt_bsx.Clear();
                            txt_tinhtrang.Clear();
                            cbo_bhx.Text = "";
                            cbo_csh.Text = "";
                            data_xe.DataSource = bllxe.getXe();
                        }

                    }
                }
            }
            else
            {
                if (check_bs(bsx) == false)
                {
                    MessageBox.Show("Biển số xe đã tồn tại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    show_hide(false);   
                }
                else
                {
                    var result = MessageBox.Show("Bạn có chắc chắn sửa thông tin xe ?", "Thông báo", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        if (bllxe.suaXe(xe, ma) == true)
                        { 
                            lst_bsx.Clear();
                            try
                            {
                                for (int i = 0; i < bllxe.getXe().Rows.Count; i++)
                                {
                                    lst_bsx.Add(bllxe.getXe().Rows[i]["bienso"].ToString().Trim());
                                }
                            }
                            catch { }
                            MessageBox.Show("Sửa thông tin thành công", "Thông báo", MessageBoxButtons.OK);
                            txt_name.Clear();
                            txt_bsx.Clear();
                            txt_tinhtrang.Clear();
                            cbo_bhx.Text = "";
                            cbo_csh.Text = "";
                            data_xe.DataSource = bllxe.getXe();
                        }

                    }
                }
                
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            show_hide(true) ;   
        }
        private void cbo_csh_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            string ma_kh = cbo_csh.SelectedValue.ToString();
            int.TryParse(ma_kh, out id);
        }

        private void data_xe_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (data_xe.Columns[e.ColumnIndex].Name == "bhx" && e.Value != null)
            {
                // Chuyển đổi giá trị bit sang chuỗi
                if ((bool)e.Value == true)
                {
                    e.Value = "Còn sử dụng";
                }
                else
                {
                    e.Value = "Đã hết";
                }
                e.FormattingApplied = true;
            }
        }
    }
}
