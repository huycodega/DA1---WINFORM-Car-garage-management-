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
    public partial class frm_CTHoaDon : Form
    {
        int id;
        BLL_CTHoaDon chitiet = new BLL_CTHoaDon();
        BLL_CTHDKH ct_kh = new BLL_CTHDKH();
        public frm_CTHoaDon()
        {
            InitializeComponent();
        }

        private void frm_CTHoaDon_Load(object sender, EventArgs e)
        {
            data_ct.DataSource = chitiet.get_CTHD();
        }

        private void data_ct_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            frm_CTHDKH cthdkh = new frm_CTHDKH();
            cthdkh.lb_kh.Text = data_ct[0 , hang ].Value.ToString();
            cthdkh.lb_xe.Text = data_ct[1 , hang ].Value .ToString();
            cthdkh.lb_bsx.Text = data_ct[2 , hang ].Value.ToString() ;
            cthdkh.lb_dv.Text = data_ct[3 , hang ].Value.ToString () ;
            cthdkh.lb_total.Text = data_ct[5 , hang ].Value.ToString ();
            cthdkh.lb_date.Text = data_ct[7 , hang ].Value.ToString ();
            cthdkh.data_cthdkh.DataSource = ct_kh.get_P(id);
            cthdkh.ShowDialog();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Chi tết hoá đơn sẽ bị xoá ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                if (chitiet.xoa_CTHD(id) == true)
                {
                    MessageBox.Show("Xoá chi tiết phiếu thành cônng");
                    data_ct.DataSource = chitiet.get_CTHD();
                }
            }
            
        }

        private void data_ct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex ;
            string ma = chitiet.get_ID().Rows[hang]["id"].ToString();
            int.TryParse( ma, out id);
              
        }
    }
}
