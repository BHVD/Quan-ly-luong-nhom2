using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public Form1()
        {
            InitializeComponent();
            tab_control.SelectTab(tab_luong);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OpenMenu(object sender, EventArgs e)
        {
            tabMenu.Visible = !tabMenu.Visible;
            
        }

        private void tab_excel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_luong_Click(object sender, EventArgs e)
        {
            tab_control.SelectTab(tab_luong);
        }

        private void btn_thuong_phat_Click(object sender, EventArgs e)
        {
            tab_control.SelectTab(tab_thuong_phat);
        }

        private void btn_tao_report_Click(object sender, EventArgs e)
        {
            tab_control.SelectTab(tab_report);
        }

        private void btn_xuat_excel_Click(object sender, EventArgs e)
        {
            tab_control.SelectTab(tab_excel);
        }
    }
}
