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
    public partial class frm_CTNPT : Form
    {
        BLL_PT ctpt = new BLL_PT();
        BLL_NPT ten = new BLL_NPT();
        
        
        public frm_CTNPT()
        {
            InitializeComponent();
        }
        
        private void frm_CTNPT_Load(object sender, EventArgs e)
        {   
            
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            frm_PT pt = new frm_PT();
            pt.ShowDialog();
        }

       
    }
}
