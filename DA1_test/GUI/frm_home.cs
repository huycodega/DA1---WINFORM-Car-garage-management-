using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_home : Form
    {
        public frm_home()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            container(new frm_KH());
        }
        private void container(object _form)
        {
            if(guna2Panel_container.Controls.Count > 0) guna2Panel_container.Controls.Clear();
            Form kh = _form as Form;
            kh.TopLevel = false;
            kh.FormBorderStyle = FormBorderStyle.None;  
            kh.Dock = DockStyle.Fill;
            guna2Panel_container.Controls.Add(kh);
            guna2Panel_container.Tag = kh;
            kh.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            container(new frm_Cars());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            container(new frm_NS());
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            container(new frm_PT());    
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            container(new frm_DV());
        }

        private void frm_home_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            container(new frm_LL());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            container(new frm_NPT());   
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            container(new frm_CC());    
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            container(new frm_LN());    
        }
    }
}
