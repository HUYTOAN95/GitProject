namespace QuanLyBanCaPhe
{
    partial class frmnsd
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
            this.gridview = new System.Windows.Forms.DataGridView();
            this.TenTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHetHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbllabel1 = new System.Windows.Forms.Label();
            this.lbllabel2 = new System.Windows.Forms.Label();
            this.lbllabel3 = new System.Windows.Forms.Label();
            this.lbllabel4 = new System.Windows.Forms.Label();
            this.lbllabel5 = new System.Windows.Forms.Label();
            this.txttaikhoan = new System.Windows.Forms.TextBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.cbbquyen = new System.Windows.Forms.ComboBox();
            this.datetime = new System.Windows.Forms.DateTimePicker();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // gridview
            // 
            this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenTK,
            this.MatKhau,
            this.MaNV,
            this.Quyen,
            this.NgayHetHan});
            this.gridview.Location = new System.Drawing.Point(12, 13);
            this.gridview.Name = "gridview";
            this.gridview.Size = new System.Drawing.Size(613, 398);
            this.gridview.TabIndex = 0;
            this.gridview.Click += new System.EventHandler(this.gridview_Click);
            // 
            // TenTK
            // 
            this.TenTK.DataPropertyName = "TaiKhoan";
            this.TenTK.HeaderText = "Tên Tài Khoản";
            this.TenTK.Name = "TenTK";
            this.TenTK.Width = 120;
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật Khẩu";
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.Width = 200;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.Name = "MaNV";
            // 
            // Quyen
            // 
            this.Quyen.DataPropertyName = "QuyenTruyCap";
            this.Quyen.HeaderText = "Quyền";
            this.Quyen.Name = "Quyen";
            this.Quyen.Width = 50;
            // 
            // NgayHetHan
            // 
            this.NgayHetHan.DataPropertyName = "NgayHetHan";
            this.NgayHetHan.HeaderText = "Ngày Hết Hạn";
            this.NgayHetHan.Name = "NgayHetHan";
            // 
            // lbllabel1
            // 
            this.lbllabel1.AutoSize = true;
            this.lbllabel1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbllabel1.Location = new System.Drawing.Point(628, 81);
            this.lbllabel1.Name = "lbllabel1";
            this.lbllabel1.Size = new System.Drawing.Size(97, 17);
            this.lbllabel1.TabIndex = 1;
            this.lbllabel1.Text = "Tên Tài Khoản";
            // 
            // lbllabel2
            // 
            this.lbllabel2.AutoSize = true;
            this.lbllabel2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbllabel2.Location = new System.Drawing.Point(631, 128);
            this.lbllabel2.Name = "lbllabel2";
            this.lbllabel2.Size = new System.Drawing.Size(68, 17);
            this.lbllabel2.TabIndex = 2;
            this.lbllabel2.Text = "Mật Khẩu";
            this.lbllabel2.Click += new System.EventHandler(this.lbllabel2_Click);
            // 
            // lbllabel3
            // 
            this.lbllabel3.AutoSize = true;
            this.lbllabel3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbllabel3.Location = new System.Drawing.Point(627, 168);
            this.lbllabel3.Name = "lbllabel3";
            this.lbllabel3.Size = new System.Drawing.Size(95, 17);
            this.lbllabel3.TabIndex = 3;
            this.lbllabel3.Text = "&Mã Nhân Viên";
            // 
            // lbllabel4
            // 
            this.lbllabel4.AutoSize = true;
            this.lbllabel4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbllabel4.Location = new System.Drawing.Point(628, 203);
            this.lbllabel4.Name = "lbllabel4";
            this.lbllabel4.Size = new System.Drawing.Size(106, 17);
            this.lbllabel4.TabIndex = 4;
            this.lbllabel4.Text = "&Quyền Truy Cập";
            // 
            // lbllabel5
            // 
            this.lbllabel5.AutoSize = true;
            this.lbllabel5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbllabel5.Location = new System.Drawing.Point(631, 242);
            this.lbllabel5.Name = "lbllabel5";
            this.lbllabel5.Size = new System.Drawing.Size(95, 17);
            this.lbllabel5.TabIndex = 5;
            this.lbllabel5.Text = "Ngày Hết Hạn";
            // 
            // txttaikhoan
            // 
            this.txttaikhoan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttaikhoan.Location = new System.Drawing.Point(736, 77);
            this.txttaikhoan.Name = "txttaikhoan";
            this.txttaikhoan.Size = new System.Drawing.Size(184, 25);
            this.txttaikhoan.TabIndex = 6;
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtmatkhau.Location = new System.Drawing.Point(736, 120);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(184, 25);
            this.txtmatkhau.TabIndex = 7;
            // 
            // txtmanv
            // 
            this.txtmanv.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtmanv.Location = new System.Drawing.Point(736, 165);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(116, 25);
            this.txtmanv.TabIndex = 8;
            // 
            // cbbquyen
            // 
            this.cbbquyen.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbquyen.FormattingEnabled = true;
            this.cbbquyen.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            ""});
            this.cbbquyen.Location = new System.Drawing.Point(736, 200);
            this.cbbquyen.Name = "cbbquyen";
            this.cbbquyen.Size = new System.Drawing.Size(116, 25);
            this.cbbquyen.TabIndex = 9;
            // 
            // datetime
            // 
            this.datetime.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.datetime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetime.Location = new System.Drawing.Point(736, 237);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(116, 25);
            this.datetime.TabIndex = 10;
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnnew.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnnew.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnnew.Location = new System.Drawing.Point(655, 348);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(75, 29);
            this.btnnew.TabIndex = 11;
            this.btnnew.Text = "&Mới";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnsave.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnsave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsave.Location = new System.Drawing.Point(736, 348);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 29);
            this.btnsave.TabIndex = 12;
            this.btnsave.Text = "&Lưu";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btndelete.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndelete.Location = new System.Drawing.Point(818, 348);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 29);
            this.btndelete.TabIndex = 13;
            this.btndelete.Text = "&Xóa";
            this.btndelete.UseVisualStyleBackColor = false;
            // 
            // frmnsd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 442);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.datetime);
            this.Controls.Add(this.cbbquyen);
            this.Controls.Add(this.txtmanv);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.txttaikhoan);
            this.Controls.Add(this.lbllabel5);
            this.Controls.Add(this.lbllabel4);
            this.Controls.Add(this.lbllabel3);
            this.Controls.Add(this.lbllabel2);
            this.Controls.Add(this.lbllabel1);
            this.Controls.Add(this.gridview);
            this.Name = "frmnsd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Người Sử Dụng";
            this.Load += new System.EventHandler(this.frmnsd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHetHan;
        private System.Windows.Forms.Label lbllabel1;
        private System.Windows.Forms.Label lbllabel2;
        private System.Windows.Forms.Label lbllabel3;
        private System.Windows.Forms.Label lbllabel4;
        private System.Windows.Forms.Label lbllabel5;
        private System.Windows.Forms.TextBox txttaikhoan;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.ComboBox cbbquyen;
        private System.Windows.Forms.DateTimePicker datetime;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btndelete;
    }
}