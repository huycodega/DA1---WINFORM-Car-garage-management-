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
using BLL;
using DTO;


namespace GUI
{
    public partial class frm_HangNhap : Form
    {
        
        BLL_HDNhap hd = new BLL_HDNhap();   
        public frm_HangNhap()
        {
            InitializeComponent();
        }

        private void frm_HangNhap_Load(object sender, EventArgs e)
        {
            show_hide(false);
            data_hdnhap.DataSource = hd.get_PhuTung();
        }
        void show_hide(bool kt)
        {
            btn_them.Checked = !kt;
            btn_sua.Checked = !kt;  
            btn_xoa.Checked = !kt;  
            btn_luu.Checked = !kt;  
            btn_dong.Checked = !kt; 
            btn_browser.Checked = !kt;
            btn_huy.Checked = kt;  
            txt_sluong.Enabled = kt;
            txt_ten.Enabled = kt;  
            txt_noicc.Enabled = kt;    
            txt_gia.Enabled = kt;  
            cbo_tinhtrang.Enabled = kt;    
        }

        private void data_hdnhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            int ma;
            string text_id = data_hdnhap[0, hang].Value.ToString();
            byte[] img = (byte[])data_hdnhap[0, hang].Value;
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);
            txt_ten.Text = data_hdnhap[1, hang].Value.ToString();
            txt_sluong.Text = data_hdnhap[2, hang].Value.ToString();
            txt_gia.Text = data_hdnhap[3, hang].Value.ToString();
            date_pt.Text = data_hdnhap[4, hang].Value.ToString();
            txt_noicc.Text = data_hdnhap[5, hang].Value.ToString();
            cbo_tinhtrang.Text = data_hdnhap[6, hang].Value.ToString();
        }
    }
}
