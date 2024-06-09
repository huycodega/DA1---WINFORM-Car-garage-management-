using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using BLL;
using DevExpress.Utils.Gesture;
using DTO;

namespace GUI
{
    public partial class frm_PT : Form
    {
        BLL_PT pt = new BLL_PT();
        BLL_HDNhap nhap_pt = new BLL_HDNhap();  
        bool check_them;
        public static int ma;
        int ma_cbo;
        public frm_PT()
        {
            InitializeComponent();
        }
        void show_hide(bool kt)
        {
            btn_them.Checked = kt;  
            btn_sua.Checked = kt;   
            btn_xoa.Checked = kt;   
            btn_luu.Checked = !kt;
            btn_huy.Checked = !kt;  
            btn_dong.Checked = kt;
            txt_ten.Enabled = !kt;
            txt_sluong.Enabled = !kt;   
            txt_gia.Enabled = !kt;  
            txt_noicc.Enabled = !kt;    
            cbo_tinhtrang.Enabled = !kt;    
            btn_browser.Enabled = !kt;  
            btn_addNhom.Enabled = !kt;
            date_pt.Enabled = !kt;
            cbo_nhom.Enabled = !kt;
        }
        private void frm_PT_Load(object sender, EventArgs e)
        {
            check_them = true;
            show_hide(true);
            data_pt.DataSource = pt.get_PhuTung();
            try {
                cbo_nhom.DataSource = pt.get_Cbo();
                cbo_nhom.DisplayMember = "ten_nhom";
                cbo_nhom.ValueMember = "id";
            }
            catch { }
            
            check_them = true;
            

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            show_hide(false);
            check_them = false;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (pt.get_Count() > 0)
            {
                if (pt.check_tt(txt_ten.Text, txt_sluong.Text, txt_gia.Text, txt_noicc.Text) == false)
                {
                    MessageBox.Show("Vui lòng chọn phụ tùng để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    show_hide(false);
                    check_them = true;
                }
            }
            else
            {
                MessageBox.Show("Không có thông tin phụ tùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            show_hide(true );
            if(pt.get_Count() > 0)
            {
                var result = MessageBox.Show("Thông tin của phụ tùng sẽ bị xoá ?", "Thông báo", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    if (nhap_pt.xoa_pt(ma) == true)
                    {

                    }
                    if (pt.xoa_CT(ma) == true)
                    {

                    }
                        if (pt.xoa_pt(ma) == true)
                    {
                        MessageBox.Show("Xoá phụ tùng thành công");
                        data_pt.DataSource = pt.get_PhuTung();
                        
                    }
                } 
            }
        }
        bool check_ngay(DateTime ngay)
        {
            if(DateTime.Now.Day - ngay.Day < 0)
            {
                return false;
            }
            else
            {
                return true;    
            }
        }
        private bool CheckPriceFormat(string input)
        {
            if (decimal.TryParse(input, out decimal price) && price >= 0 && price <= 1000000)
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
            int gia, soluong;
            char char_gia , char_soluong;   
            show_hide(true);
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();
            string ten = txt_ten.Text;
            string text_soluong = txt_sluong.Text;
            int.TryParse(text_soluong, out soluong);
            char.TryParse(text_soluong, out char_soluong);
            string text_gia = txt_gia.Text;
            int.TryParse(text_gia, out gia);
            char.TryParse(text_gia , out char_gia); 
            DateTime ngay = DateTime.Parse(date_pt.Value.ToShortDateString());
            string noicungcap = txt_noicc.Text;
            string tinhtrang = cbo_tinhtrang.Text;
            DTO_PT phutung = new DTO_PT(img, ten, soluong, gia, ngay, noicungcap, tinhtrang.Trim());
            DTO_HDNhap hd = new DTO_HDNhap(img, ten, soluong, gia, ngay, noicungcap, tinhtrang.Trim());
            if (check_them == false)
            {
                if(pt.check_tt(ten,text_soluong,text_gia,noicungcap) == false){
                    MessageBox.Show("Thông tin không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    show_hide(false);
                }
                else
                {
                    CheckPriceFormat(txt_sluong.Text);
                    if (check_ngay(ngay) == false)
                    {
                        MessageBox.Show("Ngày không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        show_hide(false);
                    }
                    else if (CheckPriceFormat(txt_sluong.Text) == false)
                    {
                        MessageBox.Show("Không đúng định dạng của số lượng hoặc vượt quá giới hạn cho phép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        show_hide(false);
                    }
                    else if(CheckPriceFormat(txt_gia.Text) == false)
                    {
                        MessageBox.Show("Không đúng định dạng của giá hoặc vượt quá giới hạn cho phép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        show_hide(false);
                    }
                    else
                    {
                        if (pt.them_pt(phutung) == true)
                        {
                            MessageBox.Show("Thêm thông tin phụ tùng thành công", "Thông báo", MessageBoxButtons.OK);
                            data_pt.DataSource = pt.get_PhuTung();
                            int id_pt = int.Parse(pt.get_IDmax().Rows[0]["id"].ToString());
                            if (nhap_pt.them_pt(hd, id_pt) == true)
                            {

                            }
                        }

                        
                    }
                }
                
            }
            if (check_them == true)
            {
                if (pt.check_tt(ten, text_soluong, text_gia, noicungcap) == false)
                {
                    MessageBox.Show("Thông tin không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    show_hide(false);
                }
                else
                {
                    CheckPriceFormat(txt_sluong.Text);
                    if (check_ngay(ngay) == false)
                    {
                        MessageBox.Show("Ngày không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        show_hide(false);
                    }
                    else if (CheckPriceFormat(txt_sluong.Text) == false)
                    {
                        MessageBox.Show("Không đúng định dạng của số lượng hoặc vượt quá giới hạn cho phép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        show_hide(false);
                    }
                    else if (CheckPriceFormat(txt_gia.Text) == false)
                    {
                        MessageBox.Show("Không đúng định dạng của giá hoặc vượt quá giới hạn cho phép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        show_hide(false);
                    }
                    else
                    {
                        var result = MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin phụ tùng ?", "Thông báo", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            if (pt.sua_pt(phutung, ma) == true)
                            {
                                MessageBox.Show("Sửa thông tin phụ tùng thành công", "Thông báo", MessageBoxButtons.OK);
                                data_pt.DataSource = pt.get_PhuTung();
                                if (nhap_pt.sua_pt(hd, ma) == true)
                                {

                                }
                            }
                        }
                    }


                }
            }
        }
        private void btn_browser_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Choose Image(* .JPG;*.PNG;*.GIF | *.jpg; *.png; *.gif)";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void data_pt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            string text_id = data_pt[0, hang].Value.ToString();
            int.TryParse(text_id, out ma);
            byte[] img = (byte[])data_pt[1,hang].Value;
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);
            txt_ten.Text = data_pt[2, hang].Value.ToString();
            txt_sluong.Text = data_pt[3,hang].Value.ToString();
            txt_gia.Text = data_pt[4,hang].Value.ToString(); 
            date_pt.Text = data_pt[5,hang].Value.ToString();    
            txt_noicc.Text = data_pt[6,hang].Value.ToString();
            cbo_tinhtrang.Text = data_pt[7,hang].Value.ToString();  
        }

        private void data_pt_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_addNhom_Click(object sender, EventArgs e)
        {
            if(cbo_nhom.Text == "")
            {
                MessageBox.Show("Không tồn tại nhóm phụ tùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                int soluong, gia;
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] img = ms.ToArray();
                string ten = txt_ten.Text;
                string text_soluong = txt_sluong.Text;
                int.TryParse(text_soluong, out soluong);
                string text_gia = txt_gia.Text;
                int.TryParse(text_gia, out gia);
                DateTime ngay = DateTime.Parse(date_pt.Value.ToShortDateString());
                string noicungcap = txt_noicc.Text;
                string tinhtrang = cbo_tinhtrang.Text;
                DTO_PT phutung = new DTO_PT(img, ten, soluong, gia, ngay, noicungcap, tinhtrang);
                pt.them_CT(phutung, ma_cbo, ma);
                MessageBox.Show("Thêm nhóm thành công", "Thông báo", MessageBoxButtons.OK);
            }
            
        }

        private void cbo_nhom_SelectedValueChanged(object sender, EventArgs e)
        {
           if (check_them == true) {
                try
                {
                    string ma_kh = cbo_nhom.SelectedValue.ToString();
                    int.TryParse(ma_kh, out ma_cbo);
                }
                catch
                {
                    
                }
            }
            else
            {
                try
                {

                }
                catch
                {
                    string ma_kh = cbo_nhom.SelectedValue.ToString();
                    int.TryParse(ma_kh, out ma_cbo);
                }
            }                   
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frm_HangNhap nhap = new frm_HangNhap(); 
            nhap.ShowDialog();
        }

        private void data_pt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_tk_Click(object sender, EventArgs e)
        {
            data_pt.DataSource = pt.get_Find(int.Parse(textBox1.Text));
        }
    }
}
