using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_Lý_Lương
{
    public partial class Form1 : Form
    {
        bool flagInsert;

        public Form1()
        {
            InitializeComponent();
            //chon tab dau tien
            tab_control.SelectTab(tab_luong);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OpenMenu(object sender, EventArgs e)
        {
            //turn on/off tabmenu
            tabMenu.Visible = !tabMenu.Visible;
            
        }


        //set event click cho mỗi button trong menu
        private void btn_luong_Click(object sender, EventArgs e)
        {
            //chuyen tab
            tab_control.SelectTab(tab_luong);
        }

        private void btn_thuong_phat_Click(object sender, EventArgs e)
        {
            //chuyen tab
            tab_control.SelectTab(tab_thuong_phat);
        }

        private void btn_tao_report_Click(object sender, EventArgs e)
        {
            //chuyen tab
            tab_control.SelectTab(tab_report);
        }
        private void btn_chucVu_Click(object sender, EventArgs e)
        {
            tab_control.SelectTab(tab_chucvu);
        }



        // set event click cho mỗi button trong tab luong


        //btn_themNV
        private void btn_themNhanVien_Click(object sender, EventArgs e)
        {
            // chuyển tab
            tab_control.SelectTab(tab_NV);
            // set tab nhan vien de insert
            setTabNV(true);
        }


        //btn_suaNV
        private void btn_suaNV_Click(object sender, EventArgs e)
        {
            //chuyển tab
            tab_control.SelectTab(tab_NV);
            //set tab nhan vien de update
            setTabNV(false);
        }


        //lọc xem Button nào đã nhấn Them hay Sua
        private void setTabNV(bool v)
        {
            if (v)
            {
                setInsert();
            }
            else
            {
                setUpdate();
            }
        }


        // thay doi tabNV de insert
        private void setInsert()
        {
            label_tab_NV.Text = "Them nhan vien:";
            flagInsert = true;
            //clear all tabNV (dong 128)
            txtChucVu.Clear();
            txtHoTen.Clear();
            txtMaNV.Clear();
            txtNgaySinh.Clear();
            nam.Checked= false;
            nu.Checked= false;
        }


        //thay doi tabNV de update
        private void setUpdate()
        {
            label_tab_NV.Text = "Sua nhan vien";
            flagInsert = false;
        }

        //set event click cho button trong tabNV
        private void btn_NV_inTabNV_Click(object sender, EventArgs e)
        {
            //chuyen tab
            tab_control.SelectTab(tab_luong);
            if (flagInsert)
            {
                insert_NV(sender,e);
            }
            else
            {
                update_NV(sender,e);
            }
        }


        //event insert nhan vien
        private void insert_NV(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        //event update nhan vien
        private void update_NV(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        

        private void chon_dong(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            // bắt lỗi khi chọn dòng trống 
            if(dataGridViewLuong.Rows[i].Cells[0].Value== null)
            {
                return;
            }

            //gán giá trị của dòng đã chọn cho tabNV
            txtMaNV.Text = dataGridViewLuong.Rows[i].Cells[0].Value.ToString(); 
            txtHoTen.Text= dataGridViewLuong.Rows[i].Cells[1].Value.ToString();
            txtChucVu.Text= dataGridViewLuong.Rows[i].Cells[2].Value.ToString();
            if (dataGridViewLuong.Rows[i].Cells[3].Value != null && dataGridViewLuong.Rows[i].Cells[3].Value.ToString().Equals("True"))
            {
                nam.Checked= true;
            }
            else
            {
                nu.Checked= true;
            }
            txtNgaySinh.Text= dataGridViewLuong.Rows[i].Cells[4].Value.ToString();
        }


        //button xem lương chi tiết
        private void btn_xem_luong_Click(object sender, EventArgs e)
        {
            tab_control.SelectTab(tab_xemLuong);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void chon_dong_ChucVu(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            // bắt lỗi khi chọn dòng trống 
            if (dataGridView2.Rows[i].Cells[0].Value== null)
            {
                return;
            }
            //gan gia tri
            textBox3.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
            textBox4.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tab_control.SelectTab(tab_luong);
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
