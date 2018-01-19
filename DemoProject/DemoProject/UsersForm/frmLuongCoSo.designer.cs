namespace DemoProject.UsersForm
{
    partial class frmLuongCoSo
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
            this.dgvluong = new System.Windows.Forms.DataGridView();
            this.grbbutton = new System.Windows.Forms.GroupBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.grbdetail = new System.Windows.Forms.GroupBox();
            this.txtcosophaply = new System.Windows.Forms.TextBox();
            this.dtpkhan = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpkngayapdung = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtluongcoban = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmaso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnhuybo = new System.Windows.Forms.Button();
            this.btnghinhan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvluong)).BeginInit();
            this.grbbutton.SuspendLayout();
            this.grbdetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvluong
            // 
            this.dgvluong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvluong.Location = new System.Drawing.Point(12, 12);
            this.dgvluong.Name = "dgvluong";
            this.dgvluong.Size = new System.Drawing.Size(404, 150);
            this.dgvluong.TabIndex = 0;
            // 
            // grbbutton
            // 
            this.grbbutton.BackColor = System.Drawing.Color.Transparent;
            this.grbbutton.Controls.Add(this.btnthoat);
            this.grbbutton.Controls.Add(this.btnxoa);
            this.grbbutton.Controls.Add(this.btnsua);
            this.grbbutton.Controls.Add(this.btnthem);
            this.grbbutton.Location = new System.Drawing.Point(458, 12);
            this.grbbutton.Name = "grbbutton";
            this.grbbutton.Size = new System.Drawing.Size(88, 160);
            this.grbbutton.TabIndex = 1;
            this.grbbutton.TabStop = false;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(7, 124);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(74, 26);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "&Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(6, 86);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 32);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "&Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(7, 54);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(74, 26);
            this.btnsua.TabIndex = 1;
            this.btnsua.Text = "&Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(7, 19);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 29);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "&Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // grbdetail
            // 
            this.grbdetail.BackColor = System.Drawing.SystemColors.Control;
            this.grbdetail.Controls.Add(this.txtcosophaply);
            this.grbdetail.Controls.Add(this.dtpkhan);
            this.grbdetail.Controls.Add(this.label6);
            this.grbdetail.Controls.Add(this.label5);
            this.grbdetail.Controls.Add(this.label4);
            this.grbdetail.Controls.Add(this.dtpkngayapdung);
            this.grbdetail.Controls.Add(this.label3);
            this.grbdetail.Controls.Add(this.txtluongcoban);
            this.grbdetail.Controls.Add(this.label2);
            this.grbdetail.Controls.Add(this.txtmaso);
            this.grbdetail.Controls.Add(this.label1);
            this.grbdetail.Controls.Add(this.btnhuybo);
            this.grbdetail.Controls.Add(this.btnghinhan);
            this.grbdetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbdetail.Location = new System.Drawing.Point(12, 178);
            this.grbdetail.Name = "grbdetail";
            this.grbdetail.Size = new System.Drawing.Size(534, 130);
            this.grbdetail.TabIndex = 2;
            this.grbdetail.TabStop = false;
            this.grbdetail.Text = "Thông Tin";
            // 
            // txtcosophaply
            // 
            this.txtcosophaply.Location = new System.Drawing.Point(297, 49);
            this.txtcosophaply.Name = "txtcosophaply";
            this.txtcosophaply.Size = new System.Drawing.Size(107, 21);
            this.txtcosophaply.TabIndex = 16;
            // 
            // dtpkhan
            // 
            this.dtpkhan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkhan.Location = new System.Drawing.Point(287, 85);
            this.dtpkhan.Name = "dtpkhan";
            this.dtpkhan.Size = new System.Drawing.Size(102, 21);
            this.dtpkhan.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Đến";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Từ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cơ Sở Pháp Lý";
            // 
            // dtpkngayapdung
            // 
            this.dtpkngayapdung.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkngayapdung.Location = new System.Drawing.Point(65, 86);
            this.dtpkngayapdung.Name = "dtpkngayapdung";
            this.dtpkngayapdung.Size = new System.Drawing.Size(102, 21);
            this.dtpkngayapdung.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Thời Điểm Áp Dụng";
            // 
            // txtluongcoban
            // 
            this.txtluongcoban.Location = new System.Drawing.Point(297, 14);
            this.txtluongcoban.Name = "txtluongcoban";
            this.txtluongcoban.Size = new System.Drawing.Size(107, 21);
            this.txtluongcoban.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lương";
            // 
            // txtmaso
            // 
            this.txtmaso.Location = new System.Drawing.Point(65, 17);
            this.txtmaso.Name = "txtmaso";
            this.txtmaso.Size = new System.Drawing.Size(75, 21);
            this.txtmaso.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã Số";
            // 
            // btnhuybo
            // 
            this.btnhuybo.BackColor = System.Drawing.Color.SeaGreen;
            this.btnhuybo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnhuybo.Location = new System.Drawing.Point(452, 72);
            this.btnhuybo.Name = "btnhuybo";
            this.btnhuybo.Size = new System.Drawing.Size(76, 34);
            this.btnhuybo.TabIndex = 4;
            this.btnhuybo.Text = "&Hủy Bỏ";
            this.btnhuybo.UseVisualStyleBackColor = false;
            this.btnhuybo.Click += new System.EventHandler(this.btnhuybo_Click);
            // 
            // btnghinhan
            // 
            this.btnghinhan.BackColor = System.Drawing.Color.Orange;
            this.btnghinhan.Location = new System.Drawing.Point(452, 31);
            this.btnghinhan.Name = "btnghinhan";
            this.btnghinhan.Size = new System.Drawing.Size(75, 35);
            this.btnghinhan.TabIndex = 4;
            this.btnghinhan.Text = "&Ghi Nhận";
            this.btnghinhan.UseVisualStyleBackColor = false;
            this.btnghinhan.Click += new System.EventHandler(this.btnghinhan_Click);
            // 
            // frmLuongCoSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(558, 320);
            this.ControlBox = false;
            this.Controls.Add(this.grbdetail);
            this.Controls.Add(this.grbbutton);
            this.Controls.Add(this.dgvluong);
            this.Name = "frmLuongCoSo";
            this.Text = "Lương Cơ Bản";
            this.Load += new System.EventHandler(this.frmluongcoban_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvluong)).EndInit();
            this.grbbutton.ResumeLayout(false);
            this.grbdetail.ResumeLayout(false);
            this.grbdetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvluong;
        private System.Windows.Forms.GroupBox grbbutton;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.GroupBox grbdetail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpkngayapdung;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtluongcoban;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmaso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnhuybo;
        private System.Windows.Forms.Button btnghinhan;
        private System.Windows.Forms.DateTimePicker dtpkhan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcosophaply;
    }
}