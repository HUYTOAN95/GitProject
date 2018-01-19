namespace DemoProject.UsersForm
{
    partial class frmLamTheNG
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
            this.drgvNgoaiGio = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbThang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbNam = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbMaNV = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSGNT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSGNN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSGNL = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.drgvNgoaiGio)).BeginInit();
            this.SuspendLayout();
            // 
            // drgvNgoaiGio
            // 
            this.drgvNgoaiGio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drgvNgoaiGio.Location = new System.Drawing.Point(14, 120);
            this.drgvNgoaiGio.Name = "drgvNgoaiGio";
            this.drgvNgoaiGio.Size = new System.Drawing.Size(729, 204);
            this.drgvNgoaiGio.TabIndex = 0;
            this.drgvNgoaiGio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drgvNgoaiGio_CellClick);
            this.drgvNgoaiGio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drgvNgoaiGio_CellContentClick);
            this.drgvNgoaiGio.Click += new System.EventHandler(this.drgvNgoaiGio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "&Tháng";
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
            this.cbbThang.Location = new System.Drawing.Point(124, 10);
            this.cbbThang.Name = "cbbThang";
            this.cbbThang.Size = new System.Drawing.Size(140, 23);
            this.cbbThang.TabIndex = 2;
            this.cbbThang.SelectedIndexChanged += new System.EventHandler(this.cbbThang_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "&Năm";
            // 
            // cbbNam
            // 
            this.cbbNam.FormattingEnabled = true;
            this.cbbNam.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
            this.cbbNam.Location = new System.Drawing.Point(337, 7);
            this.cbbNam.Name = "cbbNam";
            this.cbbNam.Size = new System.Drawing.Size(130, 23);
            this.cbbNam.TabIndex = 4;
            this.cbbNam.SelectedIndexChanged += new System.EventHandler(this.cbbNam_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "&Mã Nhân Viên";
            // 
            // cbbMaNV
            // 
            this.cbbMaNV.FormattingEnabled = true;
            this.cbbMaNV.Location = new System.Drawing.Point(124, 47);
            this.cbbMaNV.Name = "cbbMaNV";
            this.cbbMaNV.Size = new System.Drawing.Size(140, 23);
            this.cbbMaNV.TabIndex = 6;
            this.cbbMaNV.SelectedIndexChanged += new System.EventHandler(this.cbbMaNV_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "&Số giờ Ngày Thường";
            // 
            // txtSGNT
            // 
            this.txtSGNT.Location = new System.Drawing.Point(157, 90);
            this.txtSGNT.Name = "txtSGNT";
            this.txtSGNT.Size = new System.Drawing.Size(58, 21);
            this.txtSGNT.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "&Số giờ Ngày Nghỉ";
            // 
            // txtSGNN
            // 
            this.txtSGNN.Location = new System.Drawing.Point(371, 92);
            this.txtSGNN.Name = "txtSGNN";
            this.txtSGNN.Size = new System.Drawing.Size(58, 21);
            this.txtSGNN.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(450, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "&Số giờ Ngày Lễ";
            // 
            // txtSGNL
            // 
            this.txtSGNL.Location = new System.Drawing.Point(573, 90);
            this.txtSGNL.Name = "txtSGNL";
            this.txtSGNL.Size = new System.Drawing.Size(58, 21);
            this.txtSGNL.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(518, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 60);
            this.label7.TabIndex = 13;
            this.label7.Text = "Hệ số Lương Làm Ngoài Giờ : \r\nHệ số làm Ngày Thường : 150%\r\nHệ số làm Ngày Nghỉ: " +
    "200%\r\nHệ Số làm Ngày Lễ : 300%";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.BackColor = System.Drawing.Color.SeaGreen;
            this.btncapnhat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncapnhat.Location = new System.Drawing.Point(402, 340);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(75, 32);
            this.btncapnhat.TabIndex = 14;
            this.btncapnhat.Text = "&Cập Nhật";
            this.btncapnhat.UseVisualStyleBackColor = false;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.SeaGreen;
            this.btnthoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnthoat.Location = new System.Drawing.Point(668, 340);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 32);
            this.btnthoat.TabIndex = 15;
            this.btnthoat.Text = "&Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.SeaGreen;
            this.btnedit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnedit.Location = new System.Drawing.Point(494, 341);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 32);
            this.btnedit.TabIndex = 18;
            this.btnedit.Text = "&Sửa Đổi";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.SeaGreen;
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.Location = new System.Drawing.Point(587, 340);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 32);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmLamTheNG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 375);
            this.ControlBox = false;
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btncapnhat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSGNL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSGNN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSGNT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbMaNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbNam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbThang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drgvNgoaiGio);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "frmLamTheNG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Làm Thêm Ngoài Giờ";
            this.Load += new System.EventHandler(this.frmLamTheNG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drgvNgoaiGio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView drgvNgoaiGio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbThang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbNam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbMaNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSGNT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSGNN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSGNL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnXoa;
    }
}