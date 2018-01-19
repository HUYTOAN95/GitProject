namespace DemoProject.SystemForm
{
    partial class frmBac
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
            this.dgvBac = new System.Windows.Forms.DataGridView();
            this.grbbutton = new System.Windows.Forms.GroupBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.grbdetail = new System.Windows.Forms.GroupBox();
            this.dtpkDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpkTuNgay = new System.Windows.Forms.DateTimePicker();
            this.btnhuybo = new System.Windows.Forms.Button();
            this.btnghinhan = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbmangach = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHeSoLuong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmabac = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBac)).BeginInit();
            this.grbbutton.SuspendLayout();
            this.grbdetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBac
            // 
            this.dgvBac.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvBac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBac.Location = new System.Drawing.Point(12, 14);
            this.dgvBac.Name = "dgvBac";
            this.dgvBac.Size = new System.Drawing.Size(557, 201);
            this.dgvBac.TabIndex = 0;
            // 
            // grbbutton
            // 
            this.grbbutton.BackColor = System.Drawing.SystemColors.Control;
            this.grbbutton.Controls.Add(this.btnthoat);
            this.grbbutton.Controls.Add(this.btnprint);
            this.grbbutton.Controls.Add(this.btnsua);
            this.grbbutton.Controls.Add(this.btnxoa);
            this.grbbutton.Controls.Add(this.btnthem);
            this.grbbutton.Location = new System.Drawing.Point(584, 15);
            this.grbbutton.Name = "grbbutton";
            this.grbbutton.Size = new System.Drawing.Size(103, 201);
            this.grbbutton.TabIndex = 1;
            this.grbbutton.TabStop = false;
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.SeaGreen;
            this.btnthoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnthoat.Location = new System.Drawing.Point(12, 155);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 29);
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
            this.btnprint.Location = new System.Drawing.Point(12, 122);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(75, 29);
            this.btnprint.TabIndex = 4;
            this.btnprint.Text = "&IN";
            this.btnprint.UseVisualStyleBackColor = false;
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.SeaGreen;
            this.btnsua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnsua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsua.Location = new System.Drawing.Point(12, 88);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 29);
            this.btnsua.TabIndex = 3;
            this.btnsua.Text = "&Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.SeaGreen;
            this.btnxoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnxoa.Location = new System.Drawing.Point(12, 54);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 29);
            this.btnxoa.TabIndex = 1;
            this.btnxoa.Text = "&Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.SeaGreen;
            this.btnthem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnthem.Location = new System.Drawing.Point(12, 19);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 29);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "&Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // grbdetail
            // 
            this.grbdetail.BackColor = System.Drawing.SystemColors.Control;
            this.grbdetail.Controls.Add(this.dtpkDenNgay);
            this.grbdetail.Controls.Add(this.dtpkTuNgay);
            this.grbdetail.Controls.Add(this.btnhuybo);
            this.grbdetail.Controls.Add(this.btnghinhan);
            this.grbdetail.Controls.Add(this.label5);
            this.grbdetail.Controls.Add(this.cbbmangach);
            this.grbdetail.Controls.Add(this.label4);
            this.grbdetail.Controls.Add(this.label3);
            this.grbdetail.Controls.Add(this.txtHeSoLuong);
            this.grbdetail.Controls.Add(this.label2);
            this.grbdetail.Controls.Add(this.label1);
            this.grbdetail.Controls.Add(this.txtmabac);
            this.grbdetail.Location = new System.Drawing.Point(12, 222);
            this.grbdetail.Name = "grbdetail";
            this.grbdetail.Size = new System.Drawing.Size(675, 96);
            this.grbdetail.TabIndex = 2;
            this.grbdetail.TabStop = false;
            this.grbdetail.Text = "Thông Tin";
            // 
            // dtpkDenNgay
            // 
            this.dtpkDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpkDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkDenNgay.Location = new System.Drawing.Point(282, 61);
            this.dtpkDenNgay.Name = "dtpkDenNgay";
            this.dtpkDenNgay.Size = new System.Drawing.Size(100, 22);
            this.dtpkDenNgay.TabIndex = 13;
            // 
            // dtpkTuNgay
            // 
            this.dtpkTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpkTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkTuNgay.Location = new System.Drawing.Point(72, 59);
            this.dtpkTuNgay.Name = "dtpkTuNgay";
            this.dtpkTuNgay.Size = new System.Drawing.Size(119, 22);
            this.dtpkTuNgay.TabIndex = 12;
            // 
            // btnhuybo
            // 
            this.btnhuybo.BackColor = System.Drawing.Color.SeaGreen;
            this.btnhuybo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhuybo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnhuybo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnhuybo.Location = new System.Drawing.Point(575, 53);
            this.btnhuybo.Name = "btnhuybo";
            this.btnhuybo.Size = new System.Drawing.Size(75, 30);
            this.btnhuybo.TabIndex = 11;
            this.btnhuybo.Text = "&Hủy Bỏ";
            this.btnhuybo.UseVisualStyleBackColor = false;
            this.btnhuybo.Click += new System.EventHandler(this.btnhuybo_Click);
            // 
            // btnghinhan
            // 
            this.btnghinhan.BackColor = System.Drawing.Color.SeaGreen;
            this.btnghinhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnghinhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnghinhan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnghinhan.Location = new System.Drawing.Point(575, 16);
            this.btnghinhan.Name = "btnghinhan";
            this.btnghinhan.Size = new System.Drawing.Size(75, 30);
            this.btnghinhan.TabIndex = 10;
            this.btnghinhan.Text = "&Ghi Nhận";
            this.btnghinhan.UseVisualStyleBackColor = false;
            this.btnghinhan.Click += new System.EventHandler(this.btnghinhan_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(206, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Đến Ngày";
            // 
            // cbbmangach
            // 
            this.cbbmangach.Enabled = false;
            this.cbbmangach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbmangach.FormattingEnabled = true;
            this.cbbmangach.Location = new System.Drawing.Point(445, 23);
            this.cbbmangach.Name = "cbbmangach";
            this.cbbmangach.Size = new System.Drawing.Size(96, 24);
            this.cbbmangach.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(357, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã Ngạch";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Từ Ngày";
            // 
            // txtHeSoLuong
            // 
            this.txtHeSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHeSoLuong.Location = new System.Drawing.Point(251, 24);
            this.txtHeSoLuong.Name = "txtHeSoLuong";
            this.txtHeSoLuong.Size = new System.Drawing.Size(100, 22);
            this.txtHeSoLuong.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(148, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hệ Số Lương ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bậc";
            // 
            // txtmabac
            // 
            this.txtmabac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtmabac.Location = new System.Drawing.Point(59, 24);
            this.txtmabac.Name = "txtmabac";
            this.txtmabac.Size = new System.Drawing.Size(85, 22);
            this.txtmabac.TabIndex = 0;
            // 
            // frmBac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 329);
            this.ControlBox = false;
            this.Controls.Add(this.grbdetail);
            this.Controls.Add(this.grbbutton);
            this.Controls.Add(this.dgvBac);
            this.Name = "frmBac";
            this.Text = "Bậc Lương";
            this.Load += new System.EventHandler(this.frmBac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBac)).EndInit();
            this.grbbutton.ResumeLayout(false);
            this.grbdetail.ResumeLayout(false);
            this.grbdetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBac;
        private System.Windows.Forms.GroupBox grbbutton;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.GroupBox grbdetail;
        private System.Windows.Forms.Button btnhuybo;
        private System.Windows.Forms.Button btnghinhan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbmangach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHeSoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmabac;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.DateTimePicker dtpkDenNgay;
        private System.Windows.Forms.DateTimePicker dtpkTuNgay;
    }
}