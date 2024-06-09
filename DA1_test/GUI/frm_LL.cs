using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class frm_LL : Form
    {
        BLL_PhieuLL phieu = new BLL_PhieuLL();
        BLL_NhanSu nsu = new BLL_NhanSu();
        BLL_DV dv = new BLL_DV();
        BLL_PT pt = new BLL_PT();
        public static int id_kh, id_ns, id, gia;
        bool check_sua;
        public frm_LL()
        {
            InitializeComponent();
        }

        private void frm_LL_Load(object sender, EventArgs e)
        {
            check_sua = true;
            show_hide(true);
            data_phieu.DataSource = phieu.get_Phieu();           
            cbo_ns.DataSource = nsu.get_Nhansu();
            cbo_ns.DisplayMember = "ten_ns";
            cbo_ns.ValueMember = "id"; 
            cbo_dv.DataSource = dv.get_DV();
            cbo_dv.DisplayMember = "ten_dv";
            cbo_dv.ValueMember = "id";  
            
            
        }
        void show_hide(bool kt)
        {
            btn_sua.Checked = kt;
            btn_xoa.Checked = kt;   
            btn_luu.Checked = !kt;
            btn_huy.Checked = !kt;
            btn_dong.Checked = kt;              
            cbo_dv.Enabled = !kt;   
            cbo_ns.Enabled = !kt;   
            date_ll.Enabled = !kt;  
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (phieu.get_Count() > 0)
            {
                show_hide(false);
                check_sua = false;
            }
            else
            {
                show_hide(true );
                MessageBox.Show("Không có thông tin phiếu !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            show_hide(true);
            if(phieu.get_Count() > 0)
            {
               var result = MessageBox.Show("Phiếu lập lịch sẽ bị xoá !", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);   
                if(result == DialogResult.Yes)
                {
               
                    if(phieu.xoa_Phieu(id) == true)
                    {
                        data_phieu.DataSource = phieu.get_Phieu();
                        MessageBox.Show("Xoá thông tin phiếu thành công", "Thôngg báo", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có thông tin phiếu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error );  
            }
        }
        bool check_ngay(DateTime ngay)
        {
            TimeSpan timeDifference = ngay - DateTime.Now;
            return Math.Abs(timeDifference.TotalDays) <= 7;
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            int tuoi;
            string ten_kh = txt_tenkh.Text;
            string text_tuoi = txt_tuoikh.Text; 
            int.TryParse(text_tuoi, out tuoi);  
            string diachi = txt_dc.Text;    
            string sdt = txt_sdt.Text;  
            string ten_xe = txt_tenxe.Text;
            string bsx = txt_bsx.Text;  
            string nhansu = cbo_ns.Text;
            string dichvu = cbo_dv.Text;
            DateTime ngay_hen = DateTime.Parse(date_ll.Value.ToShortDateString());
            string tt = "";
            DTO_PhieuLL phieull = new DTO_PhieuLL(ten_kh, tuoi, diachi, sdt, ten_xe, bsx, nhansu, dichvu, ngay_hen,tt);
            show_hide(true);
            if(check_ngay(ngay_hen)== true)
            {
                if (check_sua == false)
                {
                    var resul = MessageBox.Show("Thông tin phiếu sẽ bị sửa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resul == DialogResult.Yes)
                    {
                        if (phieu.sua_Phieu(phieull, id_kh, id_ns, id) == true)
                        {
                            MessageBox.Show("Sửa thông tin phiếu thành công", "Thông báo", MessageBoxButtons.OK);
                            data_phieu.DataSource = phieu.get_Phieu();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Ngày hẹn đã vượt quá 1 tuần!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                show_hide(false);   
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            show_hide(true) ;
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {

        }

        private void data_phieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            string ma_id = data_phieu[0,hang].Value.ToString(); 
            int.TryParse(ma_id, out id);
            string ma_idkh = data_phieu[1,hang].Value.ToString();
            int.TryParse(ma_idkh, out id_kh);
            txt_tenkh.Text = data_phieu[2, hang].Value.ToString();
            txt_tuoikh.Text = data_phieu[3, hang].Value.ToString();
            txt_dc.Text = data_phieu[4, hang].Value.ToString();
            txt_sdt.Text = data_phieu[5, hang].Value.ToString();
            txt_tenxe.Text = data_phieu[6, hang].Value.ToString();
            txt_bsx.Text = data_phieu[7, hang].Value.ToString();
            date_ll.Text = data_phieu[10, hang].Value.ToString();   
            cbo_dv.Text = data_phieu[9, hang].Value.ToString();
            cbo_ns.Text = data_phieu[8, hang].Value.ToString();
            

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frm_CTHoaDon ct = new frm_CTHoaDon();
            ct.ShowDialog();
        }

        private void data_phieu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int hang = e.RowIndex;
            string ten_dv = data_phieu[9, hang].Value.ToString();
            frm_HoaDon hoadon = new frm_HoaDon();
            hoadon.txt_tenkh.Text = data_phieu[2,hang].Value.ToString();
            hoadon.txt_xe.Text = data_phieu[6,hang].Value.ToString();   
            hoadon.txt_bsx.Text = data_phieu[7,hang].Value.ToString();  
            hoadon.txt_dv.Text = data_phieu[9,hang].Value.ToString();            
            hoadon.lb_kh.Text = data_phieu[2,hang].Value.ToString() ;
            hoadon.lb_xe.Text = data_phieu[6, hang].Value.ToString();
            hoadon.lb_bsx.Text = data_phieu[7, hang].Value.ToString();   
            hoadon.lb_dv.Text = data_phieu[9, hang].Value.ToString();
            hoadon.txt_tt.Text = data_phieu[11, hang].Value.ToString();
            hoadon.cbo_pt.DataSource = pt.get_hangcong();
            hoadon.cbo_pt.DisplayMember = "ten_pt";
            hoadon.lb_total.Text = dv.get_Gia(ten_dv).Rows[0]["gia"].ToString();
            string text_gia = dv.get_Gia(ten_dv).Rows[0]["gia"].ToString();
            int.TryParse(text_gia, out gia);
            hoadon.cbo_pt.ValueMember = "id";
            hoadon.ShowDialog();   
            
        }

        private void cbo_ns_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ma_ns = cbo_ns.SelectedValue.ToString();
            int.TryParse(ma_ns, out id_ns); 

        }

        private void cbo_dv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
