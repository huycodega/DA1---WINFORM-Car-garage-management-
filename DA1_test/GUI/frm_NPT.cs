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
using Microsoft.Office.Interop.Excel;

namespace GUI
{
    public partial class frm_NPT : Form
    {
        bool check_them;
        int ma;
        
        BLL_PT ctpt = new BLL_PT();
        BLL_NPT npt = new BLL_NPT(); 
        public frm_NPT()
        {
            InitializeComponent();
        }

        private void frm_NPT_Load(object sender, EventArgs e)
        {
            show_hide(true);
            data_npt.DataSource = npt.get_NPT();
        }
        void show_hide(bool kt)
        {
            btn_them.Checked = kt;
            btn_sua.Checked = kt;   
            btn_xoa.Checked = kt;   
            btn_luu.Checked = !kt;
            btn_huy.Checked = !kt;
            txt_ten.Enabled = !kt;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            show_hide(false);
            check_them = false;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            
            if (npt.get_Count() > 0)
            {
                if (npt.check_tt(txt_ten.Text) == false)
                {
                    MessageBox.Show("Hãy chọn nhóm phụ tùng", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    show_hide(false);
                    check_them = true;
                }
            }

            else
            {
                show_hide (true);
                MessageBox.Show("Không có nhóm phụ tùng !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);  
            }
            
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            show_hide(true );
            if (npt.get_Count() > 0)
            {   
                if(npt.check_tt(txt_ten.Text) == false)
                {
                    MessageBox.Show("Hãy lựa chọn để xoá thông tin nhóm", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    var result = MessageBox.Show("Bạn có chắc chắn xoá nhóm phụ tùng ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (npt.xoa_NPT(ma) == true)
                        {
                            MessageBox.Show("Xoá thông tin nhóm thành công", "Thông báo", MessageBoxButtons.OK);
                            txt_ten.Clear();
                            data_npt.DataSource = npt.get_NPT();
                        }
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Không có nhóm phụ tùng !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            show_hide(true);
            string name = txt_ten.Text;
            DTO_NPT nhom = new DTO_NPT(name);
            if(check_them == false)
            {
                if(npt.check_tt(name) == false)
                {
                    MessageBox.Show("Thông tin không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (npt.them_NPT(nhom) == true)
                    {
                        MessageBox.Show("Thêm nhóm thành công", "Thông báo", MessageBoxButtons.OK);
                        data_npt.DataSource = npt.get_NPT();
                    }
                }
                
            }
            if(check_them == true)
            {
                
                var result = MessageBox.Show("Bạn có chắc chắn sửa thông tin nhóm", "Thông báo", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    if (npt.sua_NPT(nhom, ma) == true)
                    {
                        MessageBox.Show("Sửa thông tin nhóm thành công", "Thông báo", MessageBoxButtons.OK);
                        data_npt.DataSource = npt.get_NPT();
                    }
                } 
                
            }

        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            show_hide(true);
            txt_ten.Clear();
        }

        private void data_npt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            string id = data_npt[0,hang].Value.ToString();
            int.TryParse(id, out ma);
            txt_ten.Text = data_npt[1,hang].Value.ToString(); 
            
            
        }

        private void data_npt_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frm_CTNPT ct = new frm_CTNPT();
            ct.label1.Text = npt.get_Ten(ma).Rows[0]["ten_nhom"].ToString();
            ct.data_ctpt.DataSource = ctpt.get_CTNPT(ma);
            ct.ShowDialog();
            
            
        }
    }
}
