namespace QuanLyBanCaPhe
{
    partial class frmreportviewer
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
            this.crystalportview = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.NhanVien1 = new QuanLyBanCaPhe.Report.NhanVien();
            this.SuspendLayout();
            // 
            // crystalportview
            // 
            this.crystalportview.ActiveViewIndex = -1;
            this.crystalportview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalportview.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalportview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalportview.Location = new System.Drawing.Point(0, 0);
            this.crystalportview.Name = "crystalportview";
            this.crystalportview.Size = new System.Drawing.Size(835, 432);
            this.crystalportview.TabIndex = 0;
            this.crystalportview.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmreportviewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 432);
            this.Controls.Add(this.crystalportview);
            this.Name = "frmreportviewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalportview;
        public Report.NhanVien NhanVien1;
    }
}