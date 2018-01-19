namespace CoffeeWFP
{
    partial class FrmDocGia
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
            this.MaDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbdetail = new System.Windows.Forms.GroupBox();
            this.datetime = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbGioiTinh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.lbllabel1 = new System.Windows.Forms.Label();
            this.ttptoolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deletemenustrip = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            this.grbdetail.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridview
            // 
            this.gridview.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDG,
            this.MaSV,
            this.TenSV,
            this.GioiTinh,
            this.NgaySinh,
            this.DiaChi});
            this.gridview.ContextMenuStrip = this.contextMenuStrip1;
            this.gridview.Location = new System.Drawing.Point(21, 164);
            this.gridview.Name = "gridview";
            this.gridview.Size = new System.Drawing.Size(892, 263);
            this.gridview.StandardTab = true;
            this.gridview.TabIndex = 0;
            this.gridview.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridview_RowLeave);
            this.gridview.Click += new System.EventHandler(this.gridview_Click);
            this.gridview.Move += new System.EventHandler(this.gridview_Move);
            // 
            // MaDG
            // 
            this.MaDG.DataPropertyName = "MaDG";
            this.MaDG.HeaderText = "Mã Độc Giả";
            this.MaDG.Name = "MaDG";
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.HeaderText = "Mã Sinh Viên";
            this.MaSV.Name = "MaSV";
            // 
            // TenSV
            // 
            this.TenSV.DataPropertyName = "TenDG";
            this.TenSV.HeaderText = "Tên Sinh Viên";
            this.TenSV.Name = "TenSV";
            this.TenSV.Width = 200;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 250;
            // 
            // grbdetail
            // 
            this.grbdetail.Controls.Add(this.datetime);
            this.grbdetail.Controls.Add(this.btnDelete);
            this.grbdetail.Controls.Add(this.btnUpdate);
            this.grbdetail.Controls.Add(this.btnadd);
            this.grbdetail.Controls.Add(this.txtDiaChi);
            this.grbdetail.Controls.Add(this.label4);
            this.grbdetail.Controls.Add(this.label3);
            this.grbdetail.Controls.Add(this.cbbGioiTinh);
            this.grbdetail.Controls.Add(this.label2);
            this.grbdetail.Controls.Add(this.txtTenSV);
            this.grbdetail.Controls.Add(this.label1);
            this.grbdetail.Controls.Add(this.txtMaSV);
            this.grbdetail.Controls.Add(this.lbllabel1);
            this.grbdetail.Location = new System.Drawing.Point(21, 13);
            this.grbdetail.Name = "grbdetail";
            this.grbdetail.Size = new System.Drawing.Size(892, 145);
            this.grbdetail.TabIndex = 1;
            this.grbdetail.TabStop = false;
            this.grbdetail.Text = "Thông Tin";
            // 
            // datetime
            // 
            this.datetime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetime.Location = new System.Drawing.Point(547, 51);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(117, 20);
            this.datetime.TabIndex = 4;
            this.ttptoolTip1.SetToolTip(this.datetime, "Nhập ngày sinh");
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(765, 90);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "&Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Location = new System.Drawing.Point(765, 55);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "&Cập Nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.Location = new System.Drawing.Point(765, 24);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "&Thêm";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(112, 87);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(552, 20);
            this.txtDiaChi.TabIndex = 5;
            this.ttptoolTip1.SetToolTip(this.txtDiaChi, "Nhập thông tin địa chỉ");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Địa Chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày Sinh";
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbGioiTinh.Location = new System.Drawing.Point(372, 51);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(97, 21);
            this.cbbGioiTinh.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Giới Tính ";
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(112, 52);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(191, 20);
            this.txtTenSV.TabIndex = 2;
            this.ttptoolTip1.SetToolTip(this.txtTenSV, "Nhập thông tin tên sinh viên");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên Sinh viên";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(112, 19);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(141, 20);
            this.txtMaSV.TabIndex = 1;
            this.ttptoolTip1.SetToolTip(this.txtMaSV, "Nhập thông tin mã sinh viên");
            // 
            // lbllabel1
            // 
            this.lbllabel1.AutoSize = true;
            this.lbllabel1.Location = new System.Drawing.Point(36, 24);
            this.lbllabel1.Name = "lbllabel1";
            this.lbllabel1.Size = new System.Drawing.Size(70, 13);
            this.lbllabel1.TabIndex = 0;
            this.lbllabel1.Text = "Mã Sinh Viên";
            // 
            // ttptoolTip1
            // 
            this.ttptoolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttptoolTip1.ToolTipTitle = "Nhập đầy đủ các thông tin";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deletemenustrip});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            // 
            // deletemenustrip
            // 
            this.deletemenustrip.Name = "deletemenustrip";
            this.deletemenustrip.Size = new System.Drawing.Size(152, 22);
            this.deletemenustrip.Text = "Xóa";
            this.deletemenustrip.Click += new System.EventHandler(this.deletemenustrip_Click);
            // 
            // FrmDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(941, 439);
            this.Controls.Add(this.grbdetail);
            this.Controls.Add(this.gridview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "FrmDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Độc Giả";
            this.Load += new System.EventHandler(this.FrmDocGia_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmDocGia_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.grbdetail.ResumeLayout(false);
            this.grbdetail.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.GroupBox grbdetail;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label lbllabel1;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbGioiTinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DateTimePicker datetime;
        private System.Windows.Forms.ToolTip ttptoolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deletemenustrip;
    }
}