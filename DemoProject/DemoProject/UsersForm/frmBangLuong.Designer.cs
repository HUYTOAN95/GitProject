namespace DemoProject.UsersForm
{
    partial class frmBangLuong
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
            this.dgrvLoadLuong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbThang = new System.Windows.Forms.ComboBox();
            this.cbbMaNV = new System.Windows.Forms.ComboBox();
            this.cbbNam = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTamUng = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKhenThuong = new System.Windows.Forms.TextBox();
            this.txtTienPhat = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnhuybo = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnsuadoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvLoadLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrvLoadLuong
            // 
            this.dgrvLoadLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvLoadLuong.Location = new System.Drawing.Point(12, 143);
            this.dgrvLoadLuong.Name = "dgrvLoadLuong";
            this.dgrvLoadLuong.Size = new System.Drawing.Size(1084, 316);
            this.dgrvLoadLuong.TabIndex = 0;
            this.dgrvLoadLuong.Click += new System.EventHandler(this.dgrvLoadLuong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "&Mã Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Tháng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "&Năm";
            // 
            // cbbThang
            // 
            this.cbbThang.FormattingEnabled = true;
            this.cbbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbbThang.Location = new System.Drawing.Point(136, 33);
            this.cbbThang.Name = "cbbThang";
            this.cbbThang.Size = new System.Drawing.Size(150, 24);
            this.cbbThang.TabIndex = 4;
            this.cbbThang.SelectedIndexChanged += new System.EventHandler(this.cbbThang_SelectedIndexChanged);
            // 
            // cbbMaNV
            // 
            this.cbbMaNV.FormattingEnabled = true;
            this.cbbMaNV.Location = new System.Drawing.Point(136, 85);
            this.cbbMaNV.Name = "cbbMaNV";
            this.cbbMaNV.Size = new System.Drawing.Size(150, 24);
            this.cbbMaNV.TabIndex = 5;
            this.cbbMaNV.SelectedIndexChanged += new System.EventHandler(this.cbbMaNV_SelectedIndexChanged);
            // 
            // cbbNam
            // 
            this.cbbNam.FormattingEnabled = true;
            this.cbbNam.Location = new System.Drawing.Point(387, 33);
            this.cbbNam.Name = "cbbNam";
            this.cbbNam.Size = new System.Drawing.Size(143, 24);
            this.cbbNam.TabIndex = 6;
            this.cbbNam.SelectedIndexChanged += new System.EventHandler(this.cbbNam_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "&Tạm ứng";
            // 
            // txtTamUng
            // 
            this.txtTamUng.Location = new System.Drawing.Point(387, 87);
            this.txtTamUng.Name = "txtTamUng";
            this.txtTamUng.Size = new System.Drawing.Size(163, 22);
            this.txtTamUng.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(579, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "&Khen Thưởng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(590, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "&Tiền Phạt";
            // 
            // txtKhenThuong
            // 
            this.txtKhenThuong.Location = new System.Drawing.Point(683, 34);
            this.txtKhenThuong.Name = "txtKhenThuong";
            this.txtKhenThuong.Size = new System.Drawing.Size(163, 22);
            this.txtKhenThuong.TabIndex = 11;
            // 
            // txtTienPhat
            // 
            this.txtTienPhat.Location = new System.Drawing.Point(683, 90);
            this.txtTienPhat.Name = "txtTienPhat";
            this.txtTienPhat.Size = new System.Drawing.Size(163, 22);
            this.txtTienPhat.TabIndex = 12;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCapNhat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCapNhat.Location = new System.Drawing.Point(892, 36);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(99, 29);
            this.btnCapNhat.TabIndex = 13;
            this.btnCapNhat.Text = "&Cập Nhât";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnhuybo
            // 
            this.btnhuybo.BackColor = System.Drawing.Color.SeaGreen;
            this.btnhuybo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnhuybo.Location = new System.Drawing.Point(997, 86);
            this.btnhuybo.Name = "btnhuybo";
            this.btnhuybo.Size = new System.Drawing.Size(99, 29);
            this.btnhuybo.TabIndex = 14;
            this.btnhuybo.Text = "&Hủy Bỏ";
            this.btnhuybo.UseVisualStyleBackColor = false;
            this.btnhuybo.Click += new System.EventHandler(this.btnhuybo_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.SeaGreen;
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.Location = new System.Drawing.Point(997, 35);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(99, 29);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnsuadoi
            // 
            this.btnsuadoi.BackColor = System.Drawing.Color.SeaGreen;
            this.btnsuadoi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsuadoi.Location = new System.Drawing.Point(892, 87);
            this.btnsuadoi.Name = "btnsuadoi";
            this.btnsuadoi.Size = new System.Drawing.Size(99, 29);
            this.btnsuadoi.TabIndex = 16;
            this.btnsuadoi.Text = "&Sửa Đổi";
            this.btnsuadoi.UseVisualStyleBackColor = false;
            this.btnsuadoi.Click += new System.EventHandler(this.btnsuadoi_Click);
            // 
            // frmBangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 471);
            this.ControlBox = false;
            this.Controls.Add(this.btnsuadoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnhuybo);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.txtTienPhat);
            this.Controls.Add(this.txtKhenThuong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTamUng);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbNam);
            this.Controls.Add(this.cbbMaNV);
            this.Controls.Add(this.cbbThang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgrvLoadLuong);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "frmBangLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng Lương Nhân Viên";
            this.Load += new System.EventHandler(this.frmBangLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvLoadLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrvLoadLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbThang;
        private System.Windows.Forms.ComboBox cbbMaNV;
        private System.Windows.Forms.ComboBox cbbNam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTamUng;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKhenThuong;
        private System.Windows.Forms.TextBox txtTienPhat;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnhuybo;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnsuadoi;
    }
}