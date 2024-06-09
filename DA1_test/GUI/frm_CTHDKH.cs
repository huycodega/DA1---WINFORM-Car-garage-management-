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
    public partial class frm_CTHDKH : Form
    {
        BLL_CTHDKH cthdkh = new BLL_CTHDKH();   
        public frm_CTHDKH()
        {
            InitializeComponent();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_CTHDKH_Load(object sender, EventArgs e)
        {
            

        }
    }
}
