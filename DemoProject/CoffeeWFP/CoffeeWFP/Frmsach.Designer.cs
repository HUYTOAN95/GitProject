namespace CoffeeWFP
{
    partial class Frmsach
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
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNXB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLoaiSach = new System.Windows.Forms.TextBox();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btntim = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtViTri = new System.Windows.Forms.TextBox();
            this.ttptoolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.txtnamxb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // gridview
            // 
            this.gridview.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach,
            this.SL,
            this.LoaiSach,
            this.ViTri,
            this.NhaXB,
            this.NamXB});
            this.gridview.Location = new System.Drawing.Point(2, 1);
            this.gridview.Name = "gridview";
            this.gridview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridview.Size = new System.Drawing.Size(492, 424);
            this.gridview.StandardTab = true;
            this.gridview.TabIndex = 0;
            this.gridview.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridview_RowLeave);
            this.gridview.Click += new System.EventHandler(this.gridview_Click);
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã Sách ";
            this.MaSach.Name = "MaSach";
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên Sách ";
            this.TenSach.Name = "TenSach";
            this.TenSach.Width = 250;
            // 
            // SL
            // 
            this.SL.DataPropertyName = "SL";
            this.SL.HeaderText = "Số Lượng";
            this.SL.Name = "SL";
            // 
            // LoaiSach
            // 
            this.LoaiSach.DataPropertyName = "TenLoaiSach";
            this.LoaiSach.HeaderText = "Loại Sách ";
            this.LoaiSach.Name = "LoaiSach";
            // 
            // ViTri
            // 
            this.ViTri.DataPropertyName = "TenViTri";
            this.ViTri.HeaderText = "Vị Trí";
            this.ViTri.Name = "ViTri";
            // 
            // NhaXB
            // 
            this.NhaXB.DataPropertyName = "TenNXB";
            this.NhaXB.HeaderText = "Nhà Xuất Bản";
            this.NhaXB.Name = "NhaXB";
            // 
            // NamXB
            // 
            this.NamXB.DataPropertyName = "NamXB";
            this.NamXB.HeaderText = "Năm Xuất Bản";
            this.NamXB.Name = "NamXB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(563, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Sách ";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(633, 44);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(100, 20);
            this.txtMaSach.TabIndex = 1;
            this.ttptoolTip1.SetToolTip(this.txtMaSach, "Nhập thông tin mã sách");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(563, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên  Sách ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(633, 91);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(182, 20);
            this.txtTenSach.TabIndex = 2;
            this.ttptoolTip1.SetToolTip(this.txtTenSach, "Nhập thông tin tên sách ");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(563, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số Lượng";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(633, 136);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(47, 20);
            this.txtSL.TabIndex = 3;
            this.ttptoolTip1.SetToolTip(this.txtSL, "Nhập số lượng sách ");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(553, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nhà Xuất Bản";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtNXB
            // 
            this.txtNXB.Location = new System.Drawing.Point(633, 214);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(100, 20);
            this.txtNXB.TabIndex = 5;
            this.ttptoolTip1.SetToolTip(this.txtNXB, "Nhập thông tin nhà xuất bản - F2");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(558, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Loại Sách ";
            // 
            // txtLoaiSach
            // 
            this.txtLoaiSach.Location = new System.Drawing.Point(633, 179);
            this.txtLoaiSach.Name = "txtLoaiSach";
            this.txtLoaiSach.Size = new System.Drawing.Size(100, 20);
            this.txtLoaiSach.TabIndex = 4;
            this.ttptoolTip1.SetToolTip(this.txtLoaiSach, "Nhập thể loại sách - F2");
            this.txtLoaiSach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLoaiSach_KeyDown);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(548, 322);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 8;
            this.btnluu.Text = "&Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(641, 322);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 9;
            this.btnxoa.Text = "&Xóa ";
            this.btnxoa.UseVisualStyleBackColor = true;
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(739, 322);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(75, 23);
            this.btntim.TabIndex = 10;
            this.btntim.Text = "&Tìm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(563, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Vj Trí";
            // 
            // txtViTri
            // 
            this.txtViTri.Location = new System.Drawing.Point(633, 250);
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.Size = new System.Drawing.Size(75, 20);
            this.txtViTri.TabIndex = 6;
            this.ttptoolTip1.SetToolTip(this.txtViTri, "Nhập thông tin vị trí - F2");
            // 
            // ttptoolTip1
            // 
            this.ttptoolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttptoolTip1.ToolTipTitle = "Nhập đầy đủ các thông tin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(545, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Năm Xuất Bản";
            // 
            // txtnamxb
            // 
            this.txtnamxb.Location = new System.Drawing.Point(633, 277);
            this.txtnamxb.Name = "txtnamxb";
            this.txtnamxb.Size = new System.Drawing.Size(75, 20);
            this.txtnamxb.TabIndex = 7;
            this.ttptoolTip1.SetToolTip(this.txtnamxb, "Nhập thông tin vị trí - F2");
            // 
            // Frmsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(848, 424);
            this.Controls.Add(this.txtnamxb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtViTri);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.txtLoaiSach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNXB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridview);
            this.KeyPreview = true;
            this.Name = "Frmsach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sách";
            this.Load += new System.EventHandler(this.Frmsach_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frmsach_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNXB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLoaiSach;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtViTri;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViTri;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhaXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamXB;
        private System.Windows.Forms.ToolTip ttptoolTip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnamxb;
    }
}

