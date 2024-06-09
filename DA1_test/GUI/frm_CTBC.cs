using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace GUI
{
    public partial class frm_CTBC : Form
    {
        BLL_CTBangCong ctbangcong = new BLL_CTBangCong();   
        BLL_NhanSu ns = new BLL_NhanSu();   
        public frm_CTBC()
        {
            InitializeComponent();
        }

        private void btn_tao_Click(object sender, EventArgs e)
        {
            int tongngaycong = frm_CC.ngaycong;
            int ngayphep = 0;
            int id_bc = frm_CC.id;
            string text_idnv = ns.get_Nhansu().Rows[0]["id"].ToString();
            int id_nv = int.Parse(text_idnv);
            string text_hoten = ns.get_Nhansu().Rows[0]["ten_ns"].ToString();
            DTO_CTBangCong ct = new DTO_CTBangCong(id_bc, id_nv, text_hoten,tongngaycong,0, tongngaycong );
            if(ctbangcong.them_TT(ct) == true )
            {
                
                    MessageBox.Show("Tạo bảng thành công", "Thông báo", MessageBoxButtons.OK);
                
            }
            for (int i =1; i <= 27; i++)
            {
                if(ctbangcong.them_Ngay(i) == true)
                {

                }
            }
        }

        private void frm_CTBC_Load(object sender, EventArgs e)
        {
            data_ctbc.DataSource = ctbangcong.get_CT(frm_CC.id);
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
