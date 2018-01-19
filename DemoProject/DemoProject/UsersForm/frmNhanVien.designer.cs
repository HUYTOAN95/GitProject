namespace DemoProject.SystemForm
{
    partial class frmNhanVien
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
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.contextdgrvdsnv = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ItemContextXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.grbbutton = new System.Windows.Forms.GroupBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnloc = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.cbbTimKiem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.contextdgrvdsnv.SuspendLayout();
            this.grbbutton.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.ContextMenuStrip = this.contextdgrvdsnv;
            this.dgvNhanVien.Location = new System.Drawing.Point(12, 12);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(987, 503);
            this.dgvNhanVien.TabIndex = 0;
            this.dgvNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellContentClick);
            // 
            // contextdgrvdsnv
            // 
            this.contextdgrvdsnv.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemContextXoa});
            this.contextdgrvdsnv.Name = "contextdgrvdsnv";
            this.contextdgrvdsnv.Size = new System.Drawing.Size(95, 26);
            // 
            // ItemContextXoa
            // 
            this.ItemContextXoa.Name = "ItemContextXoa";
            this.ItemContextXoa.Size = new System.Drawing.Size(94, 22);
            this.ItemContextXoa.Text = "Xóa";
            this.ItemContextXoa.Click += new System.EventHandler(this.ItemContextXoa_Click);
            // 
            // grbbutton
            // 
            this.grbbutton.BackColor = System.Drawing.Color.Transparent;
            this.grbbutton.Controls.Add(this.btnthoat);
            this.grbbutton.Controls.Add(this.btnprint);
            this.grbbutton.Controls.Add(this.btnloc);
            this.grbbutton.Controls.Add(this.btnxoa);
            this.grbbutton.Location = new System.Drawing.Point(560, 521);
            this.grbbutton.Name = "grbbutton";
            this.grbbutton.Size = new System.Drawing.Size(435, 58);
            this.grbbutton.TabIndex = 1;
            this.grbbutton.TabStop = false;
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.SeaGreen;
            this.btnthoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnthoat.Location = new System.Drawing.Point(334, 16);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 33);
            this.btnthoat.TabIndex = 5;
            this.btnthoat.Text = "&Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.SeaGreen;
            this.btnprint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnprint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnprint.Location = new System.Drawing.Point(125, 17);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(75, 33);
            this.btnprint.TabIndex = 4;
            this.btnprint.Text = "&IN";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnloc
            // 
            this.btnloc.BackColor = System.Drawing.Color.SeaGreen;
            this.btnloc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnloc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnloc.Location = new System.Drawing.Point(21, 17);
            this.btnloc.Name = "btnloc";
            this.btnloc.Size = new System.Drawing.Size(75, 33);
            this.btnloc.TabIndex = 3;
            this.btnloc.Text = "&Tìm Kiếm ";
            this.btnloc.UseVisualStyleBackColor = false;
            this.btnloc.Click += new System.EventHandler(this.btnloc_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.SeaGreen;
            this.btnxoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnxoa.Location = new System.Drawing.Point(228, 16);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 33);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "&Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // cbbTimKiem
            // 
            this.cbbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbTimKiem.FormattingEnabled = true;
            this.cbbTimKiem.Items.AddRange(new object[] {
            "MaNV",
            "HoTen",
            "DiaChi",
            "Phong",
            "TrinhDo",
            "Ngach",
            "ChucVu"});
            this.cbbTimKiem.Location = new System.Drawing.Point(103, 542);
            this.cbbTimKiem.Name = "cbbTimKiem";
            this.cbbTimKiem.Size = new System.Drawing.Size(86, 24);
            this.cbbTimKiem.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 546);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tìm Kiếm";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttimkiem.Location = new System.Drawing.Point(195, 542);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(151, 24);
            this.txttimkiem.TabIndex = 4;
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1011, 591);
            this.ControlBox = false;
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbTimKiem);
            this.Controls.Add(this.grbbutton);
            this.Controls.Add(this.dgvNhanVien);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "frmNhanVien";
            this.Text = "Danh Sách Nhân Viên";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.contextdgrvdsnv.ResumeLayout(false);
            this.grbbutton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.GroupBox grbbutton;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnloc;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.ComboBox cbbTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.ContextMenuStrip contextdgrvdsnv;
        private System.Windows.Forms.ToolStripMenuItem ItemContextXoa;
    }
}