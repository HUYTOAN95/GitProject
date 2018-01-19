namespace QuanLyBanCaPhe
{
    partial class frmhoadon
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
            this.grbdetail = new System.Windows.Forms.GroupBox();
            this.lbllabel4 = new System.Windows.Forms.Label();
            this.lbllabel3 = new System.Windows.Forms.Label();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.txtmahoadon = new System.Windows.Forms.TextBox();
            this.lbllabel2 = new System.Windows.Forms.Label();
            this.lbllabel1 = new System.Windows.Forms.Label();
            this.gridview = new System.Windows.Forms.DataGridView();
            this.btnmoi = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.contextmnst = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.IemNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemHuy = new System.Windows.Forms.ToolStripMenuItem();
            this.txtcaso = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbdetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            this.contextmnst.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbdetail
            // 
            this.grbdetail.Controls.Add(this.txtcaso);
            this.grbdetail.Controls.Add(this.lbllabel4);
            this.grbdetail.Controls.Add(this.lbllabel3);
            this.grbdetail.Controls.Add(this.txtmanv);
            this.grbdetail.Controls.Add(this.txtmahoadon);
            this.grbdetail.Controls.Add(this.lbllabel2);
            this.grbdetail.Location = new System.Drawing.Point(66, 50);
            this.grbdetail.Name = "grbdetail";
            this.grbdetail.Size = new System.Drawing.Size(664, 100);
            this.grbdetail.TabIndex = 0;
            this.grbdetail.TabStop = false;
            // 
            // lbllabel4
            // 
            this.lbllabel4.AutoSize = true;
            this.lbllabel4.Location = new System.Drawing.Point(35, 58);
            this.lbllabel4.Name = "lbllabel4";
            this.lbllabel4.Size = new System.Drawing.Size(36, 13);
            this.lbllabel4.TabIndex = 5;
            this.lbllabel4.Text = "Ca Số";
            // 
            // lbllabel3
            // 
            this.lbllabel3.AutoSize = true;
            this.lbllabel3.Location = new System.Drawing.Point(309, 21);
            this.lbllabel3.Name = "lbllabel3";
            this.lbllabel3.Size = new System.Drawing.Size(75, 13);
            this.lbllabel3.TabIndex = 3;
            this.lbllabel3.Text = "&Mã Nhân Viên";
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(432, 17);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(169, 20);
            this.txtmanv.TabIndex = 2;
            // 
            // txtmahoadon
            // 
            this.txtmahoadon.Location = new System.Drawing.Point(117, 17);
            this.txtmahoadon.Name = "txtmahoadon";
            this.txtmahoadon.Size = new System.Drawing.Size(169, 20);
            this.txtmahoadon.TabIndex = 1;
            // 
            // lbllabel2
            // 
            this.lbllabel2.AutoSize = true;
            this.lbllabel2.Location = new System.Drawing.Point(35, 20);
            this.lbllabel2.Name = "lbllabel2";
            this.lbllabel2.Size = new System.Drawing.Size(68, 13);
            this.lbllabel2.TabIndex = 0;
            this.lbllabel2.Text = "&Mã Hóa Đơn";
            // 
            // lbllabel1
            // 
            this.lbllabel1.AutoSize = true;
            this.lbllabel1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbllabel1.Location = new System.Drawing.Point(316, 10);
            this.lbllabel1.Name = "lbllabel1";
            this.lbllabel1.Size = new System.Drawing.Size(173, 23);
            this.lbllabel1.TabIndex = 1;
            this.lbllabel1.Text = "Hóa Đơn Bán Hàng";
            // 
            // gridview
            // 
            this.gridview.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TenSP,
            this.DVT,
            this.Gia,
            this.SL,
            this.KM});
            this.gridview.ContextMenuStrip = this.contextmnst;
            this.gridview.Location = new System.Drawing.Point(66, 156);
            this.gridview.Name = "gridview";
            this.gridview.Size = new System.Drawing.Size(664, 235);
            this.gridview.TabIndex = 2;
            // 
            // btnmoi
            // 
            this.btnmoi.Location = new System.Drawing.Point(411, 407);
            this.btnmoi.Name = "btnmoi";
            this.btnmoi.Size = new System.Drawing.Size(75, 23);
            this.btnmoi.TabIndex = 3;
            this.btnmoi.Text = "&Mới";
            this.btnmoi.UseVisualStyleBackColor = true;
            this.btnmoi.Click += new System.EventHandler(this.btnmoi_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(493, 407);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 4;
            this.btnluu.Text = "&Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(655, 407);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 23);
            this.btnhuy.TabIndex = 5;
            this.btnhuy.Text = "&Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(574, 407);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(75, 23);
            this.btnprint.TabIndex = 6;
            this.btnprint.Text = "&IN";
            this.btnprint.UseVisualStyleBackColor = true;
            // 
            // contextmnst
            // 
            this.contextmnst.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IemNhap,
            this.ItemHuy});
            this.contextmnst.Name = "contextmnst";
            this.contextmnst.Size = new System.Drawing.Size(104, 48);
            // 
            // IemNhap
            // 
            this.IemNhap.Name = "IemNhap";
            this.IemNhap.Size = new System.Drawing.Size(152, 22);
            this.IemNhap.Text = "Nhập";
            this.IemNhap.Click += new System.EventHandler(this.IemNhap_Click);
            // 
            // ItemHuy
            // 
            this.ItemHuy.Name = "ItemHuy";
            this.ItemHuy.Size = new System.Drawing.Size(103, 22);
            this.ItemHuy.Text = "Hủy";
            // 
            // txtcaso
            // 
            this.txtcaso.Location = new System.Drawing.Point(117, 58);
            this.txtcaso.Name = "txtcaso";
            this.txtcaso.Size = new System.Drawing.Size(62, 20);
            this.txtcaso.TabIndex = 6;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "Ten";
            this.TenSP.HeaderText = "Tên ";
            this.TenSP.Name = "TenSP";
            this.TenSP.Width = 250;
            // 
            // DVT
            // 
            this.DVT.DataPropertyName = "DVT";
            this.DVT.HeaderText = "Đơn vị tính";
            this.DVT.Name = "DVT";
            this.DVT.Width = 50;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "DonGia";
            this.Gia.HeaderText = "Đơn Giá";
            this.Gia.Name = "Gia";
            this.Gia.Width = 120;
            // 
            // SL
            // 
            this.SL.HeaderText = "Số Lượng";
            this.SL.Name = "SL";
            this.SL.Width = 50;
            // 
            // KM
            // 
            this.KM.HeaderText = "Giảm Giá";
            this.KM.Name = "KM";
            this.KM.Width = 50;
            // 
            // frmhoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(774, 436);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnmoi);
            this.Controls.Add(this.gridview);
            this.Controls.Add(this.lbllabel1);
            this.Controls.Add(this.grbdetail);
            this.Name = "frmhoadon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa Đơn";
            this.Load += new System.EventHandler(this.frmhoadon_Load);
            this.grbdetail.ResumeLayout(false);
            this.grbdetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.contextmnst.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbdetail;
        private System.Windows.Forms.Label lbllabel4;
        private System.Windows.Forms.Label lbllabel3;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.TextBox txtmahoadon;
        private System.Windows.Forms.Label lbllabel2;
        private System.Windows.Forms.Label lbllabel1;
        private System.Windows.Forms.DataGridView gridview;
        private System.Windows.Forms.Button btnmoi;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.ContextMenuStrip contextmnst;
        private System.Windows.Forms.ToolStripMenuItem IemNhap;
        private System.Windows.Forms.ToolStripMenuItem ItemHuy;
        private System.Windows.Forms.TextBox txtcaso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn KM;
    }
}