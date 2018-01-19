namespace QuanLyBanCaPhe
{
    partial class frmnhanvien
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
            this.components = new System.ComponentModel.Container();
            this.gridview = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.lbllabel1 = new System.Windows.Forms.Label();
            this.lbllabel2 = new System.Windows.Forms.Label();
            this.lbllabel3 = new System.Windows.Forms.Label();
            this.lbllabel4 = new System.Windows.Forms.Label();
            this.radnam = new System.Windows.Forms.RadioButton();
            this.radnu = new System.Windows.Forms.RadioButton();
            this.lbllabel5 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.datengaysinh = new System.Windows.Forms.DateTimePicker();
            this.btnsave = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnfind = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lbllabel6 = new System.Windows.Forms.Label();
            this.ttptoolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtsdt = new System.Windows.Forms.MaskedTextBox();
            this.btnprint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // gridview
            // 
            this.gridview.AllowUserToResizeColumns = false;
            this.gridview.AllowUserToResizeRows = false;
            this.gridview.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.GioiTinh,
            this.NgaySinh});
            this.gridview.Location = new System.Drawing.Point(3, 1);
            this.gridview.Name = "gridview";
            this.gridview.ReadOnly = true;
            this.gridview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridview.Size = new System.Drawing.Size(523, 462);
            this.gridview.StandardTab = true;
            this.gridview.TabIndex = 0;
            this.gridview.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridview_RowLeave);
            this.gridview.Click += new System.EventHandler(this.gridview_Click);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên Nhân Viên";
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            this.TenNV.Width = 200;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            this.GioiTinh.Width = 80;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenNV.Location = new System.Drawing.Point(642, 90);
            this.txtTenNV.MaxLength = 50;
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(194, 25);
            this.txtTenNV.TabIndex = 2;
            this.ttptoolTip1.SetToolTip(this.txtTenNV, "Nhập tên nhân viên");
            // 
            // lbllabel1
            // 
            this.lbllabel1.AutoSize = true;
            this.lbllabel1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbllabel1.Location = new System.Drawing.Point(534, 93);
            this.lbllabel1.Name = "lbllabel1";
            this.lbllabel1.Size = new System.Drawing.Size(98, 17);
            this.lbllabel1.TabIndex = 2;
            this.lbllabel1.Text = "&Tên Nhân Viên";
            // 
            // lbllabel2
            // 
            this.lbllabel2.AutoSize = true;
            this.lbllabel2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbllabel2.Location = new System.Drawing.Point(550, 180);
            this.lbllabel2.Name = "lbllabel2";
            this.lbllabel2.Size = new System.Drawing.Size(69, 17);
            this.lbllabel2.TabIndex = 3;
            this.lbllabel2.Text = "Ngày Sinh";
            // 
            // lbllabel3
            // 
            this.lbllabel3.AutoSize = true;
            this.lbllabel3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbllabel3.Location = new System.Drawing.Point(550, 219);
            this.lbllabel3.Name = "lbllabel3";
            this.lbllabel3.Size = new System.Drawing.Size(53, 17);
            this.lbllabel3.TabIndex = 4;
            this.lbllabel3.Text = "Địa Chỉ";
            // 
            // lbllabel4
            // 
            this.lbllabel4.AutoSize = true;
            this.lbllabel4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbllabel4.Location = new System.Drawing.Point(543, 259);
            this.lbllabel4.Name = "lbllabel4";
            this.lbllabel4.Size = new System.Drawing.Size(92, 17);
            this.lbllabel4.TabIndex = 5;
            this.lbllabel4.Text = "Số Điện Thoại";
            // 
            // radnam
            // 
            this.radnam.AutoSize = true;
            this.radnam.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radnam.Location = new System.Drawing.Point(642, 131);
            this.radnam.Name = "radnam";
            this.radnam.Size = new System.Drawing.Size(55, 21);
            this.radnam.TabIndex = 3;
            this.radnam.TabStop = true;
            this.radnam.Text = "&Nam";
            this.radnam.UseVisualStyleBackColor = true;
            this.radnam.CheckedChanged += new System.EventHandler(this.radnam_CheckedChanged);
            // 
            // radnu
            // 
            this.radnu.AutoSize = true;
            this.radnu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radnu.Location = new System.Drawing.Point(713, 131);
            this.radnu.Name = "radnu";
            this.radnu.Size = new System.Drawing.Size(45, 21);
            this.radnu.TabIndex = 4;
            this.radnu.TabStop = true;
            this.radnu.Text = "&Nữ";
            this.radnu.UseVisualStyleBackColor = true;
            // 
            // lbllabel5
            // 
            this.lbllabel5.AutoSize = true;
            this.lbllabel5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbllabel5.Location = new System.Drawing.Point(557, 135);
            this.lbllabel5.Name = "lbllabel5";
            this.lbllabel5.Size = new System.Drawing.Size(62, 17);
            this.lbllabel5.TabIndex = 8;
            this.lbllabel5.Text = "&Giới Tính";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtdiachi.Location = new System.Drawing.Point(641, 216);
            this.txtdiachi.MaxLength = 50;
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(293, 25);
            this.txtdiachi.TabIndex = 6;
            this.ttptoolTip1.SetToolTip(this.txtdiachi, "Nhập địa chỉ nhân viên");
            // 
            // datengaysinh
            // 
            this.datengaysinh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.datengaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datengaysinh.Location = new System.Drawing.Point(641, 174);
            this.datengaysinh.Name = "datengaysinh";
            this.datengaysinh.Size = new System.Drawing.Size(100, 25);
            this.datengaysinh.TabIndex = 5;
            this.ttptoolTip1.SetToolTip(this.datengaysinh, "Nhập ngày sinh nhân viên");
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnsave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnsave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsave.Location = new System.Drawing.Point(544, 356);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 32);
            this.btnsave.TabIndex = 8;
            this.btnsave.Text = "&Mới";
            this.ttptoolTip1.SetToolTip(this.btnsave, "Thêm mới nhân viên");
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btndelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndelete.Location = new System.Drawing.Point(697, 356);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 32);
            this.btndelete.TabIndex = 10;
            this.btndelete.Text = "&Xóa";
            this.ttptoolTip1.SetToolTip(this.btndelete, "Xóa nhân viên");
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnfind
            // 
            this.btnfind.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnfind.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnfind.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnfind.Location = new System.Drawing.Point(778, 356);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(75, 32);
            this.btnfind.TabIndex = 11;
            this.btnfind.Text = "&Tìm";
            this.ttptoolTip1.SetToolTip(this.btnfind, "Tìm kiếm nhân viên theo Tên hoặc Địa Chỉ");
            this.btnfind.UseVisualStyleBackColor = false;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnedit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnedit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnedit.Location = new System.Drawing.Point(620, 356);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 32);
            this.btnedit.TabIndex = 9;
            this.btnedit.Text = "&Lưu";
            this.ttptoolTip1.SetToolTip(this.btnedit, "Cập nhật nhân viên");
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaNV.Location = new System.Drawing.Point(641, 55);
            this.txtMaNV.MaxLength = 6;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(154, 25);
            this.txtMaNV.TabIndex = 1;
            this.ttptoolTip1.SetToolTip(this.txtMaNV, "Nhập mã nhân viên");
            // 
            // lbllabel6
            // 
            this.lbllabel6.AutoSize = true;
            this.lbllabel6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbllabel6.Location = new System.Drawing.Point(540, 58);
            this.lbllabel6.Name = "lbllabel6";
            this.lbllabel6.Size = new System.Drawing.Size(95, 17);
            this.lbllabel6.TabIndex = 17;
            this.lbllabel6.Text = "&Mã Nhân Viên";
            // 
            // ttptoolTip1
            // 
            this.ttptoolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // txtsdt
            // 
            this.txtsdt.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtsdt.Location = new System.Drawing.Point(641, 254);
            this.txtsdt.Mask = "(999) 000-0000";
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(167, 25);
            this.txtsdt.TabIndex = 7;
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnprint.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnprint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnprint.Location = new System.Drawing.Point(859, 356);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(75, 31);
            this.btnprint.TabIndex = 18;
            this.btnprint.Text = "&IN";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // frmnhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(947, 466);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.lbllabel6);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.datengaysinh);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.lbllabel5);
            this.Controls.Add(this.radnu);
            this.Controls.Add(this.radnam);
            this.Controls.Add(this.lbllabel4);
            this.Controls.Add(this.lbllabel3);
            this.Controls.Add(this.lbllabel2);
            this.Controls.Add(this.lbllabel1);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.gridview);
            this.KeyPreview = true;
            this.Name = "frmnhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.frmnhanvien_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmnhanvien_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label lbllabel1;
        private System.Windows.Forms.Label lbllabel2;
        private System.Windows.Forms.Label lbllabel3;
        private System.Windows.Forms.Label lbllabel4;
        private System.Windows.Forms.RadioButton radnam;
        private System.Windows.Forms.RadioButton radnu;
        private System.Windows.Forms.Label lbllabel5;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.DateTimePicker datengaysinh;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lbllabel6;
        private System.Windows.Forms.ToolTip ttptoolTip1;
        private System.Windows.Forms.MaskedTextBox txtsdt;
        private System.Windows.Forms.Button btnprint;
    }
}