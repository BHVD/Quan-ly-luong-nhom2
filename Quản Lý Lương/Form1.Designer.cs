using System.Drawing;

namespace Quản_Lý_Lương
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabMenu = new System.Windows.Forms.Panel();
            this.btn_luong = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_tao_report = new System.Windows.Forms.Button();
            this.btn_thuong_phat = new System.Windows.Forms.Button();
            this.tab_control = new System.Windows.Forms.TabControl();
            this.tab_luong = new System.Windows.Forms.TabPage();
            this.tab_thuong_phat = new System.Windows.Forms.TabPage();
            this.btn_xuat_excel = new System.Windows.Forms.Button();
            this.tab_report = new System.Windows.Forms.TabPage();
            this.tab_excel = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col_ma_nhan_vien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ho_ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_chuc_vu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_gioi_tinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ngay_sinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_xem_luong = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabMenu.SuspendLayout();
            this.tab_control.SuspendLayout();
            this.tab_luong.SuspendLayout();
            this.tab_thuong_phat.SuspendLayout();
            this.tab_report.SuspendLayout();
            this.tab_excel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMenu
            // 
            this.tabMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMenu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tabMenu.Controls.Add(this.btn_xuat_excel);
            this.tabMenu.Controls.Add(this.btn_thuong_phat);
            this.tabMenu.Controls.Add(this.btn_tao_report);
            this.tabMenu.Controls.Add(this.btn_luong);
            this.tabMenu.Location = new System.Drawing.Point(0, -3);
            this.tabMenu.Margin = new System.Windows.Forms.Padding(0);
            this.tabMenu.MaximumSize = new System.Drawing.Size(400, 3000);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Size = new System.Drawing.Size(181, 556);
            this.tabMenu.TabIndex = 3;
            this.tabMenu.Visible = false;
            // 
            // btn_luong
            // 
            this.btn_luong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_luong.Location = new System.Drawing.Point(0, 86);
            this.btn_luong.Name = "btn_luong";
            this.btn_luong.Size = new System.Drawing.Size(181, 49);
            this.btn_luong.TabIndex = 1;
            this.btn_luong.Text = "Lương";
            this.btn_luong.UseVisualStyleBackColor = true;
            this.btn_luong.Click += new System.EventHandler(this.btn_luong_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "Menu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.OpenMenu);
            // 
            // btn_tao_report
            // 
            this.btn_tao_report.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_tao_report.Location = new System.Drawing.Point(0, 196);
            this.btn_tao_report.Name = "btn_tao_report";
            this.btn_tao_report.Size = new System.Drawing.Size(181, 49);
            this.btn_tao_report.TabIndex = 2;
            this.btn_tao_report.Text = "Tạo Report";
            this.btn_tao_report.UseVisualStyleBackColor = true;
            this.btn_tao_report.Click += new System.EventHandler(this.btn_tao_report_Click);
            // 
            // btn_thuong_phat
            // 
            this.btn_thuong_phat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_thuong_phat.Location = new System.Drawing.Point(0, 141);
            this.btn_thuong_phat.Name = "btn_thuong_phat";
            this.btn_thuong_phat.Size = new System.Drawing.Size(181, 49);
            this.btn_thuong_phat.TabIndex = 3;
            this.btn_thuong_phat.Text = "Thưởng/Phạt";
            this.btn_thuong_phat.UseVisualStyleBackColor = true;
            this.btn_thuong_phat.Click += new System.EventHandler(this.btn_thuong_phat_Click);
            // 
            // tab_control
            // 
            this.tab_control.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_control.Controls.Add(this.tab_thuong_phat);
            this.tab_control.Controls.Add(this.tab_report);
            this.tab_control.Controls.Add(this.tab_excel);
            this.tab_control.Controls.Add(this.tab_luong);
            this.tab_control.Location = new System.Drawing.Point(0, -29);
            this.tab_control.Name = "tab_control";
            this.tab_control.SelectedIndex = 0;
            this.tab_control.Size = new System.Drawing.Size(790, 616);
            this.tab_control.TabIndex = 4;
            // 
            // tab_luong
            // 
            this.tab_luong.Controls.Add(this.panel1);
            this.tab_luong.Controls.Add(this.dataGridView1);
            this.tab_luong.Controls.Add(this.label4);
            this.tab_luong.Location = new System.Drawing.Point(4, 25);
            this.tab_luong.Name = "tab_luong";
            this.tab_luong.Padding = new System.Windows.Forms.Padding(3);
            this.tab_luong.Size = new System.Drawing.Size(782, 587);
            this.tab_luong.TabIndex = 0;
            this.tab_luong.Text = "Luong";
            this.tab_luong.UseVisualStyleBackColor = true;
            // 
            // tab_thuong_phat
            // 
            this.tab_thuong_phat.Controls.Add(this.label3);
            this.tab_thuong_phat.Location = new System.Drawing.Point(4, 25);
            this.tab_thuong_phat.Name = "tab_thuong_phat";
            this.tab_thuong_phat.Padding = new System.Windows.Forms.Padding(3);
            this.tab_thuong_phat.Size = new System.Drawing.Size(893, 574);
            this.tab_thuong_phat.TabIndex = 1;
            this.tab_thuong_phat.Text = "thuong/phat";
            this.tab_thuong_phat.UseVisualStyleBackColor = true;
            // 
            // btn_xuat_excel
            // 
            this.btn_xuat_excel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_xuat_excel.Location = new System.Drawing.Point(0, 254);
            this.btn_xuat_excel.Name = "btn_xuat_excel";
            this.btn_xuat_excel.Size = new System.Drawing.Size(181, 49);
            this.btn_xuat_excel.TabIndex = 4;
            this.btn_xuat_excel.Text = "Xuất Excel";
            this.btn_xuat_excel.UseVisualStyleBackColor = true;
            this.btn_xuat_excel.Click += new System.EventHandler(this.btn_xuat_excel_Click);
            // 
            // tab_report
            // 
            this.tab_report.Controls.Add(this.label2);
            this.tab_report.Location = new System.Drawing.Point(4, 25);
            this.tab_report.Name = "tab_report";
            this.tab_report.Padding = new System.Windows.Forms.Padding(3);
            this.tab_report.Size = new System.Drawing.Size(893, 574);
            this.tab_report.TabIndex = 2;
            this.tab_report.Text = "report";
            this.tab_report.UseVisualStyleBackColor = true;
            // 
            // tab_excel
            // 
            this.tab_excel.Controls.Add(this.label1);
            this.tab_excel.Location = new System.Drawing.Point(4, 25);
            this.tab_excel.Name = "tab_excel";
            this.tab_excel.Padding = new System.Windows.Forms.Padding(3);
            this.tab_excel.Size = new System.Drawing.Size(893, 574);
            this.tab_excel.TabIndex = 3;
            this.tab_excel.Text = "excel";
            this.tab_excel.UseVisualStyleBackColor = true;
            this.tab_excel.Click += new System.EventHandler(this.tab_excel_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(435, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xuất ra Excel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(417, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tạo Report";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(395, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 36);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thưởng/Phạt";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(282, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 36);
            this.label4.TabIndex = 2;
            this.label4.Text = "Lương";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ma_nhan_vien,
            this.col_ho_ten,
            this.col_chuc_vu,
            this.col_gioi_tinh,
            this.col_ngay_sinh});
            this.dataGridView1.Location = new System.Drawing.Point(34, 268);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(680, 150);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // col_ma_nhan_vien
            // 
            this.col_ma_nhan_vien.DataPropertyName = "manv";
            this.col_ma_nhan_vien.HeaderText = "Mã nhân viên";
            this.col_ma_nhan_vien.MinimumWidth = 6;
            this.col_ma_nhan_vien.Name = "col_ma_nhan_vien";
            this.col_ma_nhan_vien.Width = 125;
            // 
            // col_ho_ten
            // 
            this.col_ho_ten.HeaderText = "Họ và tên";
            this.col_ho_ten.MinimumWidth = 6;
            this.col_ho_ten.Name = "col_ho_ten";
            this.col_ho_ten.Width = 125;
            // 
            // col_chuc_vu
            // 
            this.col_chuc_vu.HeaderText = "Chức vụ";
            this.col_chuc_vu.MinimumWidth = 6;
            this.col_chuc_vu.Name = "col_chuc_vu";
            this.col_chuc_vu.Width = 125;
            // 
            // col_gioi_tinh
            // 
            this.col_gioi_tinh.HeaderText = "Nam/Nữ";
            this.col_gioi_tinh.MinimumWidth = 6;
            this.col_gioi_tinh.Name = "col_gioi_tinh";
            this.col_gioi_tinh.Width = 125;
            // 
            // col_ngay_sinh
            // 
            this.col_ngay_sinh.HeaderText = "Ngày sinh";
            this.col_ngay_sinh.MinimumWidth = 6;
            this.col_ngay_sinh.Name = "col_ngay_sinh";
            this.col_ngay_sinh.Width = 125;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(398, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "Thanh toán(Xóa)";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(223, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sửa chức vụ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_xem_luong
            // 
            this.btn_xem_luong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_xem_luong.Location = new System.Drawing.Point(3, 45);
            this.btn_xem_luong.Name = "btn_xem_luong";
            this.btn_xem_luong.Size = new System.Drawing.Size(143, 40);
            this.btn_xem_luong.TabIndex = 3;
            this.btn_xem_luong.Text = "Xem Lương";
            this.btn_xem_luong.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.btn_xem_luong);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(34, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 89);
            this.panel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tabMenu);
            this.Controls.Add(this.tab_control);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabMenu.ResumeLayout(false);
            this.tab_control.ResumeLayout(false);
            this.tab_luong.ResumeLayout(false);
            this.tab_luong.PerformLayout();
            this.tab_thuong_phat.ResumeLayout(false);
            this.tab_thuong_phat.PerformLayout();
            this.tab_report.ResumeLayout(false);
            this.tab_report.PerformLayout();
            this.tab_excel.ResumeLayout(false);
            this.tab_excel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel tabMenu;
        private System.Windows.Forms.Button btn_luong;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_thuong_phat;
        private System.Windows.Forms.Button btn_tao_report;
        private System.Windows.Forms.Button btn_xuat_excel;
        private System.Windows.Forms.TabControl tab_control;
        private System.Windows.Forms.TabPage tab_luong;
        private System.Windows.Forms.TabPage tab_thuong_phat;
        private System.Windows.Forms.TabPage tab_report;
        private System.Windows.Forms.TabPage tab_excel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ma_nhan_vien;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ho_ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_chuc_vu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_gioi_tinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ngay_sinh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_xem_luong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

