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
    public partial class frm_DkiLL : Form
    {
        int id_xe, id_ns, id_dv;
        BLL_KH kh = new BLL_KH();   
        BLL_PhieuLL phieu = new BLL_PhieuLL();  
         
        public frm_DkiLL()
        {
            InitializeComponent();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void frm_DkiLL_Load(object sender, EventArgs e)
        {
            
            //cbo_xe.DataSource = kh.get_Xe(3);
            cbo_xe.DisplayMember = "ten_xe";
            cbo_xe.ValueMember = "id";
            
        }

        private void cbo_xe_SelectedIndexChanged(object sender, EventArgs e)
        {

            string ma = cbo_xe.SelectedValue.ToString();
            int.TryParse(ma, out id_xe);
            try { txt_bsx.Text = kh.get_BSX(id_xe).Rows[0]["bienso"].ToString(); }
            catch(Exception ex) {  }
            
           
        }

        private void cbo_dv_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbo_dv.ValueMember = "id";
            string ma_dv = cbo_dv.SelectedValue.ToString();
            int.TryParse(ma_dv, out id_dv);
        }

        private void cbo_ns_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ma = cbo_ns.SelectedValue.ToString();
            int.TryParse(ma, out id_ns);
        }
        bool check_ngay(DateTime ngay)
        {
            TimeSpan timeDifference = ngay - DateTime.Now;
            return Math.Abs(timeDifference.TotalDays) <= 7;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            
            int a = frm_KH.ma;
            int tuoi;
            string ten_kh = txt_tenkh.Text;
            string text_tuoi = txt_tuoi.Text;   
            int.TryParse (text_tuoi, out tuoi);   
            string dc = txt_diachi.Text;    
            string sdt = txt_sdt.Text;
            string ten_xe = cbo_xe.Text;
            string bienso = txt_bsx.Text;
            string dv = cbo_dv.Text;    
            string ns = cbo_ns.Text;    
            DateTime ngay_hen  = DateTime.Parse(date_phieu.Value.ToShortDateString());
            string tt = "";
            DTO_PhieuLL phieull = new DTO_PhieuLL(ten_kh, tuoi, dc, sdt, ten_xe, bienso, ns, dv, ngay_hen, tt);
            if(check_ngay(ngay_hen) == true )
            {
                if (phieu.them_Phieu(phieull, a, id_ns, id_dv) == true)
                {
                    MessageBox.Show("Tạo phiếu thành công", "Thông báo", MessageBoxButtons.OK);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Ngày hẹn đã vượt quá 1 tuần !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
        }
    }
}
