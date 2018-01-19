namespace DemoProject.UsersForm
{
    partial class frmCapNhatDSNV
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
            this.openfile = new System.Windows.Forms.Button();
            this.txtopenfile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbselectsheet = new System.Windows.Forms.ComboBox();
            this.dgvCapNhat = new System.Windows.Forms.DataGridView();
            this.btnCapNhatNV = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxHeader = new System.Windows.Forms.GroupBox();
            this.groupBoxbelow = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapNhat)).BeginInit();
            this.groupBoxHeader.SuspendLayout();
            this.groupBoxbelow.SuspendLayout();
            this.SuspendLayout();
            // 
            // openfile
            // 
            this.openfile.BackColor = System.Drawing.Color.SeaGreen;
            this.openfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.openfile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.openfile.Location = new System.Drawing.Point(19, 20);
            this.openfile.Name = "openfile";
            this.openfile.Size = new System.Drawing.Size(82, 31);
            this.openfile.TabIndex = 0;
            this.openfile.Text = "Open_File";
            this.openfile.UseVisualStyleBackColor = false;
            this.openfile.Click += new System.EventHandler(this.openfile_Click);
            // 
            // txtopenfile
            // 
            this.txtopenfile.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtopenfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtopenfile.Location = new System.Drawing.Point(118, 25);
            this.txtopenfile.Name = "txtopenfile";
            this.txtopenfile.Size = new System.Drawing.Size(203, 22);
            this.txtopenfile.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(359, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn Sheet";
            // 
            // cbbselectsheet
            // 
            this.cbbselectsheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbselectsheet.FormattingEnabled = true;
            this.cbbselectsheet.Location = new System.Drawing.Point(452, 26);
            this.cbbselectsheet.Name = "cbbselectsheet";
            this.cbbselectsheet.Size = new System.Drawing.Size(164, 24);
            this.cbbselectsheet.TabIndex = 3;
            this.cbbselectsheet.SelectedIndexChanged += new System.EventHandler(this.cbbselectsheet_SelectedIndexChanged);
            // 
            // dgvCapNhat
            // 
            this.dgvCapNhat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCapNhat.Location = new System.Drawing.Point(12, 89);
            this.dgvCapNhat.Name = "dgvCapNhat";
            this.dgvCapNhat.Size = new System.Drawing.Size(676, 330);
            this.dgvCapNhat.TabIndex = 4;
            // 
            // btnCapNhatNV
            // 
            this.btnCapNhatNV.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCapNhatNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhatNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCapNhatNV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCapNhatNV.Location = new System.Drawing.Point(20, 16);
            this.btnCapNhatNV.Name = "btnCapNhatNV";
            this.btnCapNhatNV.Size = new System.Drawing.Size(99, 28);
            this.btnCapNhatNV.TabIndex = 5;
            this.btnCapNhatNV.Text = "Cập Nhật ";
            this.btnCapNhatNV.UseVisualStyleBackColor = false;
            this.btnCapNhatNV.Click += new System.EventHandler(this.btnCapNhatNV_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.SeaGreen;
            this.btnthoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnthoat.Location = new System.Drawing.Point(125, 16);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 28);
            this.btnthoat.TabIndex = 6;
            this.btnthoat.Text = "&Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // groupBoxHeader
            // 
            this.groupBoxHeader.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxHeader.Controls.Add(this.txtopenfile);
            this.groupBoxHeader.Controls.Add(this.openfile);
            this.groupBoxHeader.Controls.Add(this.label1);
            this.groupBoxHeader.Controls.Add(this.cbbselectsheet);
            this.groupBoxHeader.Location = new System.Drawing.Point(12, 12);
            this.groupBoxHeader.Name = "groupBoxHeader";
            this.groupBoxHeader.Size = new System.Drawing.Size(676, 63);
            this.groupBoxHeader.TabIndex = 7;
            this.groupBoxHeader.TabStop = false;
            // 
            // groupBoxbelow
            // 
            this.groupBoxbelow.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxbelow.Controls.Add(this.btnCapNhatNV);
            this.groupBoxbelow.Controls.Add(this.btnthoat);
            this.groupBoxbelow.Location = new System.Drawing.Point(464, 425);
            this.groupBoxbelow.Name = "groupBoxbelow";
            this.groupBoxbelow.Size = new System.Drawing.Size(224, 56);
            this.groupBoxbelow.TabIndex = 8;
            this.groupBoxbelow.TabStop = false;
            // 
            // frmCapNhatDSNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(709, 489);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxbelow);
            this.Controls.Add(this.groupBoxHeader);
            this.Controls.Add(this.dgvCapNhat);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "frmCapNhatDSNV";
            this.Text = "Cập Nhật Danh Sách Nhân Viên";
            this.Load += new System.EventHandler(this.frmCapNhatDSNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapNhat)).EndInit();
            this.groupBoxHeader.ResumeLayout(false);
            this.groupBoxHeader.PerformLayout();
            this.groupBoxbelow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openfile;
        private System.Windows.Forms.TextBox txtopenfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbselectsheet;
        private System.Windows.Forms.DataGridView dgvCapNhat;
        private System.Windows.Forms.Button btnCapNhatNV;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox groupBoxHeader;
        private System.Windows.Forms.GroupBox groupBoxbelow;
    }
}