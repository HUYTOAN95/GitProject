namespace DemoProject.SystemForm
{
    partial class frmBangThueSuat
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
            this.dgvthuesuat = new System.Windows.Forms.DataGridView();
            this.grbbutton = new System.Windows.Forms.GroupBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.grbdetail = new System.Windows.Forms.GroupBox();
            this.btnhuybo = new System.Windows.Forms.Button();
            this.btnghinhan = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtthuesuat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiatridu = new System.Windows.Forms.TextBox();
            this.txtkhoangden = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtkhoangtu = new System.Windows.Forms.TextBox();
            this.txtbac = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvthuesuat)).BeginInit();
            this.grbbutton.SuspendLayout();
            this.grbdetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvthuesuat
            // 
            this.dgvthuesuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvthuesuat.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvthuesuat.Location = new System.Drawing.Point(12, 21);
            this.dgvthuesuat.Name = "dgvthuesuat";
            this.dgvthuesuat.Size = new System.Drawing.Size(564, 227);
            this.dgvthuesuat.TabIndex = 0;
            // 
            // grbbutton
            // 
            this.grbbutton.BackColor = System.Drawing.SystemColors.Control;
            this.grbbutton.Controls.Add(this.btnthoat);
            this.grbbutton.Controls.Add(this.btnxoa);
            this.grbbutton.Controls.Add(this.btnsua);
            this.grbbutton.Controls.Add(this.btnthem);
            this.grbbutton.Location = new System.Drawing.Point(597, 21);
            this.grbbutton.Name = "grbbutton";
            this.grbbutton.Size = new System.Drawing.Size(97, 227);
            this.grbbutton.TabIndex = 1;
            this.grbbutton.TabStop = false;
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.SeaGreen;
            this.btnthoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnthoat.Location = new System.Drawing.Point(11, 160);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 31);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "&Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.SeaGreen;
            this.btnxoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnxoa.Location = new System.Drawing.Point(11, 121);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 31);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "&Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.SeaGreen;
            this.btnsua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnsua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsua.Location = new System.Drawing.Point(11, 81);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 31);
            this.btnsua.TabIndex = 1;
            this.btnsua.Text = "&Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.SeaGreen;
            this.btnthem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnthem.Location = new System.Drawing.Point(11, 39);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 31);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "&Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // grbdetail
            // 
            this.grbdetail.BackColor = System.Drawing.SystemColors.Control;
            this.grbdetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grbdetail.Controls.Add(this.btnhuybo);
            this.grbdetail.Controls.Add(this.btnghinhan);
            this.grbdetail.Controls.Add(this.label5);
            this.grbdetail.Controls.Add(this.txtthuesuat);
            this.grbdetail.Controls.Add(this.label4);
            this.grbdetail.Controls.Add(this.txtGiatridu);
            this.grbdetail.Controls.Add(this.txtkhoangden);
            this.grbdetail.Controls.Add(this.label3);
            this.grbdetail.Controls.Add(this.label2);
            this.grbdetail.Controls.Add(this.label1);
            this.grbdetail.Controls.Add(this.txtkhoangtu);
            this.grbdetail.Controls.Add(this.txtbac);
            this.grbdetail.Cursor = System.Windows.Forms.Cursors.Default;
            this.grbdetail.Location = new System.Drawing.Point(12, 256);
            this.grbdetail.Name = "grbdetail";
            this.grbdetail.Size = new System.Drawing.Size(682, 110);
            this.grbdetail.TabIndex = 2;
            this.grbdetail.TabStop = false;
            this.grbdetail.Text = "Thông Tin";
            // 
            // btnhuybo
            // 
            this.btnhuybo.BackColor = System.Drawing.Color.SeaGreen;
            this.btnhuybo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhuybo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnhuybo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnhuybo.Location = new System.Drawing.Point(596, 62);
            this.btnhuybo.Name = "btnhuybo";
            this.btnhuybo.Size = new System.Drawing.Size(75, 35);
            this.btnhuybo.TabIndex = 11;
            this.btnhuybo.Text = "&Hủy  Bỏ";
            this.btnhuybo.UseVisualStyleBackColor = false;
            this.btnhuybo.Click += new System.EventHandler(this.btnhuybo_Click);
            // 
            // btnghinhan
            // 
            this.btnghinhan.BackColor = System.Drawing.Color.SeaGreen;
            this.btnghinhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnghinhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnghinhan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnghinhan.Location = new System.Drawing.Point(596, 15);
            this.btnghinhan.Name = "btnghinhan";
            this.btnghinhan.Size = new System.Drawing.Size(75, 35);
            this.btnghinhan.TabIndex = 10;
            this.btnghinhan.Text = "&Ghi Nhận";
            this.btnghinhan.UseVisualStyleBackColor = false;
            this.btnghinhan.Click += new System.EventHandler(this.btnghinhan_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(234, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Thuế Suất ";
            // 
            // txtthuesuat
            // 
            this.txtthuesuat.Location = new System.Drawing.Point(324, 76);
            this.txtthuesuat.Name = "txtthuesuat";
            this.txtthuesuat.Size = new System.Drawing.Size(94, 20);
            this.txtthuesuat.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(6, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Giá Trị Thuế Suất";
            // 
            // txtGiatridu
            // 
            this.txtGiatridu.Location = new System.Drawing.Point(124, 75);
            this.txtGiatridu.Name = "txtGiatridu";
            this.txtGiatridu.Size = new System.Drawing.Size(90, 20);
            this.txtGiatridu.TabIndex = 6;
            // 
            // txtkhoangden
            // 
            this.txtkhoangden.Location = new System.Drawing.Point(376, 35);
            this.txtkhoangden.Name = "txtkhoangden";
            this.txtkhoangden.Size = new System.Drawing.Size(100, 20);
            this.txtkhoangden.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(336, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(190, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Từ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bậc";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtkhoangtu
            // 
            this.txtkhoangtu.Location = new System.Drawing.Point(220, 35);
            this.txtkhoangtu.Name = "txtkhoangtu";
            this.txtkhoangtu.Size = new System.Drawing.Size(100, 20);
            this.txtkhoangtu.TabIndex = 1;
            // 
            // txtbac
            // 
            this.txtbac.Location = new System.Drawing.Point(103, 34);
            this.txtbac.Name = "txtbac";
            this.txtbac.Size = new System.Drawing.Size(66, 20);
            this.txtbac.TabIndex = 0;
            // 
            // frmBangThueSuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(706, 375);
            this.ControlBox = false;
            this.Controls.Add(this.grbdetail);
            this.Controls.Add(this.grbbutton);
            this.Controls.Add(this.dgvthuesuat);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "frmBangThueSuat";
            this.Text = "Bảng Thuế Suất";
            this.Load += new System.EventHandler(this.frmBangThueSuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvthuesuat)).EndInit();
            this.grbbutton.ResumeLayout(false);
            this.grbdetail.ResumeLayout(false);
            this.grbdetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvthuesuat;
        private System.Windows.Forms.GroupBox grbbutton;
        private System.Windows.Forms.GroupBox grbdetail;
        private System.Windows.Forms.TextBox txtGiatridu;
        private System.Windows.Forms.TextBox txtkhoangden;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtkhoangtu;
        private System.Windows.Forms.TextBox txtbac;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnhuybo;
        private System.Windows.Forms.Button btnghinhan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtthuesuat;
        private System.Windows.Forms.Label label4;
    }
}