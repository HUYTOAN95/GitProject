namespace CoffeeWFP
{
    partial class FrmPhieuMuon
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
            this.pnlpanel1 = new System.Windows.Forms.Panel();
            this.lbllabel1 = new System.Windows.Forms.Label();
            this.grbdetail = new System.Windows.Forms.GroupBox();
            this.gridview = new System.Windows.Forms.DataGridView();
            this.btnsave = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnpreview = new System.Windows.Forms.Button();
            this.pnlpanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlpanel1
            // 
            this.pnlpanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlpanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlpanel1.Controls.Add(this.lbllabel1);
            this.pnlpanel1.Location = new System.Drawing.Point(166, 14);
            this.pnlpanel1.Name = "pnlpanel1";
            this.pnlpanel1.Size = new System.Drawing.Size(362, 48);
            this.pnlpanel1.TabIndex = 0;
            // 
            // lbllabel1
            // 
            this.lbllabel1.AutoSize = true;
            this.lbllabel1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbllabel1.Location = new System.Drawing.Point(93, 11);
            this.lbllabel1.Name = "lbllabel1";
            this.lbllabel1.Size = new System.Drawing.Size(175, 24);
            this.lbllabel1.TabIndex = 0;
            this.lbllabel1.Text = "Phiếu Mượn Sách ";
            // 
            // grbdetail
            // 
            this.grbdetail.Location = new System.Drawing.Point(22, 75);
            this.grbdetail.Name = "grbdetail";
            this.grbdetail.Size = new System.Drawing.Size(704, 149);
            this.grbdetail.TabIndex = 1;
            this.grbdetail.TabStop = false;
            // 
            // gridview
            // 
            this.gridview.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview.Location = new System.Drawing.Point(22, 242);
            this.gridview.Name = "gridview";
            this.gridview.Size = new System.Drawing.Size(704, 218);
            this.gridview.TabIndex = 2;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(489, 481);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "Cập Nhật";
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(570, 481);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 4;
            this.btndelete.Text = "&Xóa";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // btnpreview
            // 
            this.btnpreview.Location = new System.Drawing.Point(651, 481);
            this.btnpreview.Name = "btnpreview";
            this.btnpreview.Size = new System.Drawing.Size(75, 23);
            this.btnpreview.TabIndex = 5;
            this.btnpreview.Text = "&IN";
            this.btnpreview.UseVisualStyleBackColor = true;
            // 
            // FrmPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(738, 532);
            this.Controls.Add(this.btnpreview);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.gridview);
            this.Controls.Add(this.grbdetail);
            this.Controls.Add(this.pnlpanel1);
            this.Name = "FrmPhieuMuon";
            this.Text = "Phiếu Mượn Sách ";
            this.pnlpanel1.ResumeLayout(false);
            this.pnlpanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlpanel1;
        private System.Windows.Forms.Label lbllabel1;
        private System.Windows.Forms.GroupBox grbdetail;
        private System.Windows.Forms.DataGridView gridview;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnpreview;
    }
}