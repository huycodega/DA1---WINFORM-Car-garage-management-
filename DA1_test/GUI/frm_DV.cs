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
    public partial class frm_DV : Form
    {
        BLL_DV dvu = new BLL_DV();
        int ma;
        bool check_them;
        public frm_DV()
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
            txt_ten.Enabled = !kt;
            txt_gia.Enabled = !kt;  
        }
        private void frm_DV_Load(object sender, EventArgs e)
        {
            show_hide(true);    
            data_dv.DataSource = dvu.get_DV();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            show_hide(false);
            check_them = false;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            
            if (dvu.get_Count() > 0)
            {
                if(dvu.check_tt(txt_ten.Text) == false)
                {
                    MessageBox.Show("Vui lòng chọn dịch vụ để sửa", "Thông báo", MessageBoxButtons.OK);
                   
                }
                else
                {
                    show_hide(false);
                    check_them = true;
                }
            }
            else
            {
                show_hide(true);
                MessageBox.Show("Không có dịch vụ !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            show_hide(true);
            if (dvu.get_Count() > 0)
            {
                if (dvu.check_tt(txt_ten.Text) == false)
                {
                    MessageBox.Show("Vui lòng chọn dịch vụ để sửa", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    var result = MessageBox.Show("Dịch vụ sẽ bị xoá !!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (dvu.xoa_DV(ma) == true)
                        {
                            MessageBox.Show("Xoá dịch vụ thành công", "Thông báo", MessageBoxButtons.OK);
                            data_dv.DataSource = dvu.get_DV();
                        }
                    }
                }                              
            }
            else
            {
                MessageBox.Show("Không có dịch vụ !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private bool CheckPriceFormat(string input)
        {
            if (decimal.TryParse(input, out decimal price) && price >= 0 && price <= 1000000)
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
            int gia;
            string ten = txt_ten.Text;
            string text_gia = txt_gia.Text; 
            int.TryParse(text_gia, out gia);    
            DTO_DV dv = new DTO_DV(ten, gia);
            if(check_them == false)
            {
                if(dvu.check_tt(ten) == false)
                {
                    MessageBox.Show("Thông tin không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    show_hide(false);
                }
                else if(CheckPriceFormat(text_gia) == false)
                {
                    MessageBox.Show("Định dạng giá không đúng Vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    show_hide(false);   
                }
                else
                {
                    if(dvu.them_DV(dv) == true)
                {
                    MessageBox.Show("Thêm dịch vụ thành công", "Thông báo", MessageBoxButtons.OK);
                    data_dv.DataSource = dvu.get_DV();  
                }
                }
                
            }
            if( check_them == true)
            {
                if(CheckPriceFormat(text_gia) == false)
                {
                    MessageBox.Show("Định dạng giá không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var result = MessageBox.Show("Thông tin dịch vụ sẽ bị sửa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (dvu.sua_DV(dv, ma) == true)
                        {
                            MessageBox.Show("Sửa dịch vụ thành công", "Thông báo", MessageBoxButtons.OK);
                            data_dv.DataSource = dvu.get_DV();
                        }
                    }
                }
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            show_hide(true);
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {

        }

        private void data_dv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            string id = data_dv[0, hang].Value.ToString();
            int.TryParse(id, out ma);
            txt_ten.Text = data_dv[1, hang].Value.ToString();
            txt_gia.Text = data_dv[2, hang].Value.ToString();
        }
    }
}
