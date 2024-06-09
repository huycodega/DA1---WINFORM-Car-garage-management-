using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace GUI
{
    public partial class frm_HoaDon : Form
    {
        BLL_PT pt = new BLL_PT();
        int id;
        int total, sl_dung;
        int count = 0;
        int id_max;
        bool check_them;
        BLL_PhieuLL phieu = new BLL_PhieuLL();
        BLL_CTHoaDon cthhd = new BLL_CTHoaDon();
        BLL_CTHDKH cthdkh = new BLL_CTHDKH();
        BLL_DV dv = new BLL_DV();
        BLL_NPT npt = new BLL_NPT();
        BLL_HangBan hb = new BLL_HangBan();
        PrintDocument print_in = new PrintDocument();
        public frm_HoaDon()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbo_pt_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbo_sl.Items.Clear();
            string ma = cbo_pt.SelectedValue.ToString();
            int.TryParse(ma, out id);
            cbo_sl.DataSource = null;
            try
            {
                int ban;
                string gia_ban = pt.get_Gia(id).Rows[0]["gia"].ToString();
                int.TryParse(gia_ban, out ban);
                txt_gia.Text = (ban * 0.3).ToString();

            }
            catch { }
            try
            {
                string soluong = pt.get_SL(id).Rows[0]["soluong"].ToString();
                int sl;
                int.TryParse(soluong, out sl);
                for (int i = 1; i <= sl; i++)
                {
                    cbo_sl.Items.Add(i);
                }
            }
            catch { }
        }

        private void cbo_sl_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        bool check_thanhtoan(string tt)
        {
            if (tt == "Chưa thanh toán")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void frm_HoaDon_Load(object sender, EventArgs e)
        {
            check_them = true;
            string thanhtoan = txt_tt.Text;
            if (check_thanhtoan(thanhtoan) == false)
            {
                btn_in.Enabled = false;
            }
            else
            {
                btn_in.Enabled = true;
            }

            total = frm_LL.gia;
            if (sl_bd == 0)
            {
                if (pt.sua_TT() == true)
                {

                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            string ma_idphieu;
            string ma_nhom = npt.get_Ma().Rows[0]["id"].ToString();
            int id_nhom = int.Parse(ma_nhom);

            if (check_them == true)
            {
                
                MessageBox.Show("Bạn chưa tạo phiếu hoá đơn !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string text_max = cthhd.get_IDMAX().Rows[0]["id"].ToString();
                    int.TryParse(text_max, out id_max);
                }
                catch { }
                PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
                printPreviewDialog1.Document = printDocument1;
                DialogResult result = printPreviewDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    printDocument1.Print();
                }
                for (int i = 0; i < data_hd.Rows.Count; i++)
                {
                    if (data_hd.Rows[i].Cells[0].Value != null && data_hd.Rows[i].Cells[1].Value != null && data_hd.Rows[i].Cells[2].Value != null)
                    {
                        int sldung;
                        int gia_ptung;
                        
                        int id_ptung = int.Parse(pt.get_ID(data_hd.Rows[i].Cells[0].Value.ToString()).Rows[0]["id"].ToString());
                        if (int.TryParse(data_hd.Rows[i].Cells[1].Value.ToString(), out sldung) && int.TryParse(data_hd.Rows[i].Cells[2].Value.ToString(), out gia_ptung))
                        {
                            DTO_CTHDKH cthd_kh = new DTO_CTHDKH(data_hd.Rows[i].Cells[0].Value.ToString(), sldung, gia_ptung);
                            if (cthdkh != null && cthdkh.them_tt(cthd_kh, id_max, id_ptung) == true)
                            {

                            }
                            DateTime ngayban = DateTime.Now;
                            DTO_HangBan hangban = new DTO_HangBan(data_hd.Rows[i].Cells[0].Value.ToString(), sldung, gia_ptung, ngayban);
                            if (hb.them_HangBan(hangban, id_ptung) == true)
                            {

                            }
                        }

                    }
                }
            }

            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            print_in.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            Bitmap bmp = new Bitmap(guna2Panel1.Width, guna2Panel1.Height);

            // Vẽ Panel vào bitmap
            guna2Panel1.DrawToBitmap(bmp, new Rectangle(0, 0, guna2Panel1.Width, guna2Panel1.Height));

            int x = (e.PageBounds.Width - bmp.Width) / 2;
            int y = (e.PageBounds.Height - bmp.Height) / 2 - 300;

            // Vẽ bitmap lên tài liệu tại vị trí đã tính toán
            e.Graphics.DrawImage(bmp, x, y);
        }
        int tongthanhtoan(int soluongpt, int gia_pt)
        {
            return soluongpt * gia_pt;
        }
        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {

            frm_LL laplich = new frm_LL();
            int ma = frm_LL.id_kh;
            string thanhtoan = txt_tt.Text;
            if (phieu.sua_TTTT(thanhtoan, ma, frm_LL.id) == true)
            {

                txt_tt.Text = "Đã thanh toán";
                laplich.data_phieu.DataSource = phieu.get_Phieu();
                MessageBox.Show("Cập nhật trạng thái thành công", "Thông báo", MessageBoxButtons.OK);
                btn_in.Enabled = true;
            }
            else
            {
                MessageBox.Show("Trạng thái đã được cập nhật", "Thông báo", MessageBoxButtons.OK);
            }
            DateTime date = DateTime.Now;
            label19.Text = date.ToString();
        }
        public static int sl_bd;
        private void guna2Button4_Click(object sender, EventArgs e)
        {

            check_them = false;
            int sl = 0;
            int gia_pt = 0;
            string tex_sl = cbo_sl.Text;
            string text_gia = txt_gia.Text;
            try { sl += int.Parse(tex_sl); }
            catch { }
            try { gia_pt += int.Parse(text_gia); }
            catch { }
            count += sl;
            total += tongthanhtoan(sl, gia_pt);
            data_hd.Rows.Add(cbo_pt.Text, cbo_sl.Text, txt_gia.Text);
            lb_total.Text = total.ToString();
            try
            {
                string soluong = pt.get_SL(id).Rows[0]["soluong"].ToString();
                int sl_dung;
                int.TryParse(soluong, out sl_bd);
                string text_sldung = cbo_sl.Text;
                sl_dung = int.Parse(text_sldung);
                int slconlai = sl_bd - sl_dung;
                if (pt.sua_SL(id, slconlai) == true)
                {

                }

            }
            catch
            { }
            
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void btn_taohd_Click(object sender, EventArgs e)
        {
            check_them = false;
            if (check_them == false)
            {
                
                MessageBox.Show("Tạo phiếu hoá đơn thành công", "Thông báo", MessageBoxButtons.OK);
                DateTime ngaytt = DateTime.Now;
                label22.Text = ngaytt.ToString();   
                DTO_CTHoaDon ct = new DTO_CTHoaDon(txt_tenkh.Text, txt_xe.Text, txt_bsx.Text, txt_dv.Text, count, total, txt_tt.Text, ngaytt);
                if (cthhd.them_CTHD(ct, frm_LL.id_kh) == true)
                {

                }
            }
            

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            data_hd.Rows.Clear();
            if (pt.sua_SL(id,sl_bd) == true)
            {

            }
            lb_total.Text = frm_LL.gia.ToString();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}
