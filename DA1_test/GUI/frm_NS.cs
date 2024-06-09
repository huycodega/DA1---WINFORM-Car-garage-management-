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
using System.Data.SqlClient;
using System.IO;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
using System.Text.RegularExpressions;

namespace GUI
{
    public partial class frm_NS : Form
    {
        BLL_NhanSu nhansu = new BLL_NhanSu();
        bool check_them;
        int ma;
        List<string> sdt_ns = new List<string>();
        public frm_NS()
        {
            InitializeComponent();
        }
        
        void show_hide(bool kt)
        {
            btn_them.Checked = kt;
            btn_sua.Checked = kt;   
            btn_xoa.Checked = kt;   
            btn_luu.Checked = !kt;
            btn_huy.Checked = !kt;  
            btn_dong.Checked = kt;
            btn_in.Checked = kt;    
            txt_name.Enabled = !kt;  
            date_ns.Enabled = !kt;
            txt_dc.Enabled = !kt;   
            txt_sdt.Enabled = !kt;  
            cbo_gioitinh.Enabled = !kt;
            cbo_chucvu.Enabled = !kt;   
            btn_browser.Enabled = !kt;

        }
        private void frm_NS_Load(object sender, EventArgs e)
        {
            show_hide(true);
            data_ns.DataSource = nhansu.get_Nhansu();
            try {
                for (int i = 0; i < nhansu.get_Nhansu().Rows.Count; i++)
                {
                    sdt_ns.Add(nhansu.get_Nhansu().Rows[i]["sdt"].ToString().Trim());
                }
            }
            catch { }
            
            
        }
        bool check_sdt(string sdt)
        {
            if (sdt_ns.Contains(sdt))
            {
                return true;    
            }
            else
            {
                return false;   
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            show_hide(false);
            check_them = false;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if(nhansu.check_update(txt_name.Text) == false)
            {
                MessageBox.Show("Vui lòng chọn thông tin để sửa thông tin", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (nhansu.get_Count() > 0)
                {
                    show_hide(false);
                    check_them = true;
                }
                else
                {
                    show_hide(true);
                    MessageBox.Show("Không có thông tin của nhân sự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            
            
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            show_hide(true);
            string name = txt_name.Text;
            if (nhansu.get_Count() > 0)
            {
                if(nhansu.check_update(txt_name.Text) == false)
                {
                    MessageBox.Show("Vui lòng chọn thông tin nhân sự để xoá", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    var result = MessageBox.Show("Bạn có chắc chắn xoá thông tin nhân sự ?", "Thông báo", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {

                        if (nhansu.xoa_NS(ma) == true)
                        {
                            sdt_ns.Clear();
                            try {
                                for (int i = 0; i < nhansu.get_Nhansu().Rows.Count; i++)
                                {
                                    sdt_ns.Add(nhansu.get_Nhansu().Rows[i]["sdt"].ToString().Trim());
                                }
                            }
                            catch { }
                            MessageBox.Show("Xoá thông tin thành công", "Thông báo", MessageBoxButtons.OK);
                            txt_name.Clear();
                            txt_dc.Clear();
                            txt_sdt.Clear();

                        }
                    }
                }
 
            }
            else
            {
                MessageBox.Show("Không có thông tin của nhân sự", "Thông báo", MessageBoxButtons.OK);
            }
        }
        void exportExcel(DataGridView g, string tentep)
        {
            
            app obj = new app();      
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 13;
            Range titleRange = obj.get_Range("A1", "G1");
            titleRange.Merge();
            titleRange.Value = "DANH SÁCH CÁC NHÂN SỰ TRONG GARA";
            titleRange.Font.Size = 15;
            titleRange.Font.Bold = true;
            for (int i = 1; i <= g.Columns.Count; i++)
            {
                if (i == 2)
                {

                    continue;
                }
                if (i > 2)
                {
                    obj.Cells[2, i - 1] = g.Columns[i - 1].HeaderText;
                }
                else
                {
                    obj.Cells[2, i] = g.Columns[i - 1].HeaderText;
                }
            }

            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (j == 1)
                    {
                        continue;
                    }
                    if (j > 1)
                    {
                        obj.Cells[i + 3, j] = g.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        obj.Cells[i + 3, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.get_Range("A1", "Z1000").HorizontalAlignment = XlHAlign.xlHAlignCenter;
            obj.ActiveWorkbook.SaveCopyAs( tentep );
            obj.ActiveWorkbook.Saved = true;
        }
        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            // Biểu thức chính quy để kiểm tra số điện thoại Việt Nam
            var regex = new Regex(@"^0\d{9}$");

            return regex.IsMatch(phoneNumber);
        }
        public  bool check_tuoi (DateTime ngay)
        {
            if (DateTime.Now.Year - ngay.Year >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {

            show_hide(true);
            MemoryStream ms = new MemoryStream();   
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();
            string ten = txt_name.Text;
            string dc = txt_dc.Text;    
            string sdt = txt_sdt.Text;
            DateTime ngaysinh = DateTime.Parse(date_ns.Value.ToShortDateString());
            string gioitinh = cbo_gioitinh.Text;    
            string chucvu = cbo_chucvu.Text;    
            DTO_NhanSu nsu = new DTO_NhanSu(img, ten, gioitinh, ngaysinh, dc, sdt, chucvu);
            if(check_them == false)
            {
                if (IsValidPhoneNumber(sdt) == false)
                {
                    MessageBox.Show("Số điện thoại không đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    show_hide(false);
                }
                else if(check_tuoi(ngaysinh) == false)
                {
                    MessageBox.Show("Ngày sinh không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    show_hide(false);
                }
                else if(check_sdt(txt_sdt.Text) == true)
                {
                    MessageBox.Show("Số điện thoại đã có trên hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    show_hide(false);
                }
                else
                {
                    if (nhansu.them_NS(nsu) == true)
                    {
                        sdt_ns.Clear();
                        try
                        {
                            for (int i = 0; i < nhansu.get_Nhansu().Rows.Count; i++)
                            {
                                sdt_ns.Add(nhansu.get_Nhansu().Rows[i]["sdt"].ToString().Trim());
                            }
                        }
                        catch { }
                        MessageBox.Show("Thêm nhân sự thành công", "Thông báo", MessageBoxButtons.OK);
                        txt_name.Clear();
                        txt_sdt.Clear();    
                        txt_dc.Clear();
                        cbo_chucvu.Text = "";
                        cbo_gioitinh.Text = "";
                        data_ns.DataSource = nhansu.get_Nhansu();
                    }
                }
            }
            if(check_them == true)
            {
                if (check_sdt(txt_sdt.Text) == true)
                {
                    MessageBox.Show("Số điện thoại đã có trên hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    show_hide(false);
                }
                else
                {
                    var result = MessageBox.Show("Bạn có chắc chán muốn sửa thông tin nhân sự ?", "Thông báo", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        if (nhansu.sua_NS(nsu, ma) == true)
                        {
                            sdt_ns.Clear();
                            try {
                                for (int i = 0; i < nhansu.get_Nhansu().Rows.Count; i++)
                                {
                                    sdt_ns.Add(nhansu.get_Nhansu().Rows[i]["sdt"].ToString().Trim());
                                }
                            }
                            catch { }
                            
                            MessageBox.Show("Sửa thông tin nhân sự thành công", "Thông báo", MessageBoxButtons.OK);
                            data_ns.DataSource = nhansu.get_Nhansu();
                        }
                    }
                }
                
                
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            show_hide(true);
        }

        private void btn_browser_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Choose Image(* .JPG;*.PNG;*.GIF | *.jpg; *.png; *.gif)";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void data_ns_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;    
        }

        private void data_ns_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            byte[] img = (byte[])data_ns.CurrentRow.Cells[1].Value;
            MemoryStream ms = new MemoryStream(img);   
            pictureBox1.Image = Image.FromStream(ms);
            string id = data_ns[0, hang].Value.ToString();
            int.TryParse(id, out ma);
            txt_name.Text = data_ns[2, hang].Value.ToString();  
            cbo_gioitinh.Text = data_ns[3,hang].Value.ToString();   
            date_ns.Text = data_ns[4,hang].Value.ToString();
            txt_dc.Text = data_ns[5,hang].Value.ToString(); 
            txt_sdt.Text = data_ns[6,hang].Value.ToString();    
            cbo_chucvu.Text = data_ns[7,hang].Value.ToString(); 


        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2013 (*.xls)|*.xls"; 
            if(save.ShowDialog() == DialogResult.OK)
            {
                exportExcel(data_ns, save.FileName);
                MessageBox.Show("Xuất danh sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            
        }
    }
}
