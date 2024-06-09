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
    public partial class frm_CC : Form
    {
        public static int id, ngaycong;
        bool check_them;
        BLL_BangCong bangcong = new BLL_BangCong();
        public frm_CC()
        {
            InitializeComponent();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {

        }

        private void frm_CC_Load(object sender, EventArgs e)
        {
            show_hide(true);    
            check_them = true;
            data_bangcong.DataSource = bangcong.get_BC();
        }
        void show_hide(bool kt)
        {
            btn_them.Checked  = kt; 
            btn_sua.Checked = kt;   
            btn_xoa.Checked = kt;   
            btn_xembc.Checked = kt; 
            btn_in.Checked = kt;
            btn_luu.Checked = !kt;
            cbo_nam.Enabled = !kt;
            cbo_thang.Enabled = !kt;    
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            show_hide(false);
            check_them = false;
        }
        public static int demngaycongtrongthang(int thang, int nam)
        {

            DateTime startDate = new DateTime(nam, thang, 1);
            int totalDays = startDate.AddMonths(1).Subtract(startDate).Days;
            int songaychunhat = Enumerable.Range(1, DateTime.DaysInMonth(nam, thang))
    .Select(item => new DateTime(nam, thang, item))
                .Where(date => date.DayOfWeek == DayOfWeek.Sunday)
                .Count();
            int result = DateTime.DaysInMonth(nam, thang) - songaychunhat;
            return result;

        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            show_hide(false);
            check_them = true;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            show_hide(true);
            var result = MessageBox.Show("Bảng công sẽ bị xoá ?!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
            if(result == DialogResult.Yes)
            {
                if(bangcong.xoa_BC(id) == true)
                {
                    MessageBox.Show("Bảng công đã được xoá", "Thông báo", MessageBoxButtons.OK);
                    data_bangcong.DataSource = bangcong.get_BC();
                }
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            
            show_hide(true);
            if(check_them == false)
            {
                int nam = int.Parse(cbo_nam.Text);
                int thang = int.Parse(cbo_thang.Text);
                DateTime ngaytinhcong = DateTime.Now;
                 ngaycong = demngaycongtrongthang(thang, nam);
                DTO_BangCong bc = new DTO_BangCong(thang, nam, ngaytinhcong, ngaycong);
                if(bangcong.them_BC(bc) == true)
                {
                    MessageBox.Show("Thêm bảng công thành công", "Thông báo", MessageBoxButtons.OK);
                    data_bangcong.DataSource = bangcong.get_BC();   
                }
            }
        }

        private void btn_xembc_Click(object sender, EventArgs e)
        {
            frm_CTBC ct = new frm_CTBC();
            ct.ShowDialog();    
        }

        private void btn_in_Click(object sender, EventArgs e)
        {

        }

        private void data_bangcong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            string ma_bangcong = data_bangcong[0,hang].Value.ToString();
            int.TryParse(ma_bangcong, out id);    
            cbo_nam.Text = data_bangcong[1,hang].Value.ToString();
            cbo_thang.Text = data_bangcong[2, hang].Value.ToString();

        }

        private void btn_tk_Click(object sender, EventArgs e)
        {

        }

        private void data_bangcong_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;  
            frm_CTBC ctbc  = new frm_CTBC();    
            ctbc.label4.Text = data_bangcong[2, hang].Value.ToString();
            ctbc.label2.Text = data_bangcong[1, hang].Value.ToString();
            ctbc.ShowDialog();
        }
    }
}
