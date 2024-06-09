using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_DN : Form
    {
        BLL_DN dn = new BLL_DN();
        public frm_DN()
        {
            InitializeComponent();
        }
        string matkhau;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try { matkhau = dn.get_DN(txt_tk.Text).Rows[0]["matkhau"].ToString().Trim(); }
            catch(Exception ex) { }           
            if (txt_mk.Text == matkhau)
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK);
                frm_home home = new frm_home();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu chưa chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void frm_DN_Load(object sender, EventArgs e)
        {
            
        }
    }
}
