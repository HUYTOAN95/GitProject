namespace DemoProject.UsersForm
{
    partial class frmChamCongNew
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
            this.grbchamcong = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpkNgayCN = new System.Windows.Forms.DateTimePicker();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.dgrvchamcong = new System.Windows.Forms.DataGridView();
            this.grbchamcong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvchamcong)).BeginInit();
            this.SuspendLayout();
            // 
            // grbchamcong
            // 
            this.grbchamcong.Controls.Add(this.label1);
            this.grbchamcong.Controls.Add(this.label3);
            this.grbchamcong.Controls.Add(this.dtpkNgayCN);
            this.grbchamcong.Controls.Add(this.btnThoat);
            this.grbchamcong.Controls.Add(this.btncapnhat);
            this.grbchamcong.Controls.Add(this.dgrvchamcong);
            this.grbchamcong.Location = new System.Drawing.Point(14, 14);
            this.grbchamcong.Name = "grbchamcong";
            this.grbchamcong.Size = new System.Drawing.Size(735, 565);
            this.grbchamcong.TabIndex = 4;
            this.grbchamcong.TabStop = false;
            this.grbchamcong.Text = "&Chấm Công";
            this.grbchamcong.Enter += new System.EventHandler(this.grbchamcong_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 501);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "C : Có Thực Hiện CV\r\nP:  Nghỉ  Có Lương\r\nK: Nghỉ Không Lương";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "&Ngày Cập Nhật";
            // 
            // dtpkNgayCN
            // 
            this.dtpkNgayCN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkNgayCN.Location = new System.Drawing.Point(133, 27);
            this.dtpkNgayCN.Name = "dtpkNgayCN";
            this.dtpkNgayCN.Size = new System.Drawing.Size(130, 21);
            this.dtpkNgayCN.TabIndex = 3;
            this.dtpkNgayCN.ValueChanged += new System.EventHandler(this.dtpkNgayCN_ValueChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.SeaGreen;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.Location = new System.Drawing.Point(622, 519);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 39);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.BackColor = System.Drawing.Color.SeaGreen;
            this.btncapnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btncapnhat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncapnhat.Location = new System.Drawing.Point(505, 519);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(92, 39);
            this.btncapnhat.TabIndex = 1;
            this.btncapnhat.Text = "&Cập Nhật";
            this.btncapnhat.UseVisualStyleBackColor = false;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // dgrvchamcong
            // 
            this.dgrvchamcong.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgrvchamcong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvchamcong.Location = new System.Drawing.Point(10, 63);
            this.dgrvchamcong.Name = "dgrvchamcong";
            this.dgrvchamcong.Size = new System.Drawing.Size(703, 434);
            this.dgrvchamcong.TabIndex = 0;
            // 
            // frmChamCongNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(763, 607);
            this.ControlBox = false;
            this.Controls.Add(this.grbchamcong);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "frmChamCongNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chấm Công";
            this.Load += new System.EventHandler(this.frmChamCongNew_Load);
            this.grbchamcong.ResumeLayout(false);
            this.grbchamcong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvchamcong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbchamcong;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.DataGridView dgrvchamcong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpkNgayCN;
        private System.Windows.Forms.Label label1;
    }
}