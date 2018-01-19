namespace CoffeeWFP
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemMnuDG = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ItemMnuSach = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuMuonTra = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.ItemMnuTheLoai = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuHeThong,
            this.MnuDanhMuc,
            this.MnuMuonTra,
            this.MnuTimKiem,
            this.MnuBaoCao,
            this.MnuTroGiup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1166, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuHeThong
            // 
            this.MnuHeThong.Name = "MnuHeThong";
            this.MnuHeThong.Size = new System.Drawing.Size(72, 20);
            this.MnuHeThong.Text = "Hệ Thống";
            // 
            // MnuDanhMuc
            // 
            this.MnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemMnuDG,
            this.toolStripSeparator1,
            this.ItemMnuSach,
            this.toolStripSeparator2,
            this.ItemMnuTheLoai});
            this.MnuDanhMuc.Name = "MnuDanhMuc";
            this.MnuDanhMuc.Size = new System.Drawing.Size(74, 20);
            this.MnuDanhMuc.Text = "Danh Mục";
            // 
            // ItemMnuDG
            // 
            this.ItemMnuDG.Name = "ItemMnuDG";
            this.ItemMnuDG.Size = new System.Drawing.Size(177, 22);
            this.ItemMnuDG.Text = "Danh Mục Độc Giả";
            this.ItemMnuDG.Click += new System.EventHandler(this.ItemMnuDG_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(174, 6);
            // 
            // ItemMnuSach
            // 
            this.ItemMnuSach.Name = "ItemMnuSach";
            this.ItemMnuSach.Size = new System.Drawing.Size(177, 22);
            this.ItemMnuSach.Text = "Danh Mục Sách ";
            this.ItemMnuSach.Click += new System.EventHandler(this.ItemMnuSach_Click);
            // 
            // MnuMuonTra
            // 
            this.MnuMuonTra.Name = "MnuMuonTra";
            this.MnuMuonTra.Size = new System.Drawing.Size(124, 20);
            this.MnuMuonTra.Text = "Quản Lý Mượn - Trả";
            // 
            // MnuTimKiem
            // 
            this.MnuTimKiem.Name = "MnuTimKiem";
            this.MnuTimKiem.Size = new System.Drawing.Size(70, 20);
            this.MnuTimKiem.Text = "Tìm Kiếm";
            // 
            // MnuBaoCao
            // 
            this.MnuBaoCao.Name = "MnuBaoCao";
            this.MnuBaoCao.Size = new System.Drawing.Size(61, 20);
            this.MnuBaoCao.Text = "Báo cáo";
            // 
            // MnuTroGiup
            // 
            this.MnuTroGiup.Name = "MnuTroGiup";
            this.MnuTroGiup.Size = new System.Drawing.Size(64, 20);
            this.MnuTroGiup.Text = "Trợ Giúp";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1166, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // ItemMnuTheLoai
            // 
            this.ItemMnuTheLoai.Name = "ItemMnuTheLoai";
            this.ItemMnuTheLoai.Size = new System.Drawing.Size(177, 22);
            this.ItemMnuTheLoai.Text = "Danh Mục Thể Loại";
            this.ItemMnuTheLoai.Click += new System.EventHandler(this.ItemMnuTheLoai_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(174, 6);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::CoffeeWFP.Properties.Resources.ung_dung_thiet_bi_ma_vach_vao_thu_vien;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1166, 491);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thư Viện";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem MnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem ItemMnuDG;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ItemMnuSach;
        private System.Windows.Forms.ToolStripMenuItem MnuMuonTra;
        private System.Windows.Forms.ToolStripMenuItem MnuTimKiem;
        private System.Windows.Forms.ToolStripMenuItem MnuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem MnuTroGiup;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ItemMnuTheLoai;
    }
}