namespace DemoProject.SystemForm
{
    partial class frmPhongBan
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
            this.dgvPhongBan = new System.Windows.Forms.DataGridView();
            this.grbbutton = new System.Windows.Forms.GroupBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnbophan = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.grbdetail = new System.Windows.Forms.GroupBox();
            this.btnhuybo = new System.Windows.Forms.Button();
            this.btnghinhan = new System.Windows.Forms.Button();
            this.txttenphong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmaphong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).BeginInit();
            this.grbbutton.SuspendLayout();
            this.grbdetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPhongBan
            // 
            this.dgvPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongBan.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvPhongBan.Location = new System.Drawing.Point(12, 22);
            this.dgvPhongBan.Name = "dgvPhongBan";
            this.dgvPhongBan.Size = new System.Drawing.Size(549, 256);
            this.dgvPhongBan.TabIndex = 0;
            // 
            // grbbutton
            // 
            this.grbbutton.BackColor = System.Drawing.SystemColors.Control;
            this.grbbutton.Controls.Add(this.btnthoat);
            this.grbbutton.Controls.Add(this.btntimkiem);
            this.grbbutton.Controls.Add(this.btnprint);
            this.grbbutton.Controls.Add(this.btnbophan);
            this.grbbutton.Controls.Add(this.btnxoa);
            this.grbbutton.Controls.Add(this.btnsua);
            this.grbbutton.Controls.Add(this.btnthem);
            this.grbbutton.Location = new System.Drawing.Point(580, 12);
            this.grbbutton.Name = "grbbutton";
            this.grbbutton.Size = new System.Drawing.Size(106, 266);
            this.grbbutton.TabIndex = 1;
            this.grbbutton.TabStop = false;
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.SeaGreen;
            this.btnthoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnthoat.Location = new System.Drawing.Point(14, 228);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 35);
            this.btnthoat.TabIndex = 6;
            this.btnthoat.Text = "&Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.Color.SeaGreen;
            this.btntimkiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btntimkiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btntimkiem.Location = new System.Drawing.Point(14, 190);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(75, 35);
            this.btntimkiem.TabIndex = 5;
            this.btntimkiem.Text = "&Tìm Kiếm";
            this.btntimkiem.UseVisualStyleBackColor = false;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.SeaGreen;
            this.btnprint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnprint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnprint.Location = new System.Drawing.Point(13, 155);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(75, 35);
            this.btnprint.TabIndex = 4;
            this.btnprint.Text = "&IN";
            this.btnprint.UseVisualStyleBackColor = false;
            // 
            // btnbophan
            // 
            this.btnbophan.BackColor = System.Drawing.Color.SeaGreen;
            this.btnbophan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbophan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnbophan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnbophan.Location = new System.Drawing.Point(14, 115);
            this.btnbophan.Name = "btnbophan";
            this.btnbophan.Size = new System.Drawing.Size(75, 40);
            this.btnbophan.TabIndex = 3;
            this.btnbophan.Text = "&Quản Lý ";
            this.btnbophan.UseVisualStyleBackColor = false;
            this.btnbophan.Click += new System.EventHandler(this.btnbophan_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.SeaGreen;
            this.btnxoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnxoa.Location = new System.Drawing.Point(13, 79);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 35);
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
            this.btnsua.Location = new System.Drawing.Point(13, 44);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 35);
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
            this.btnthem.Location = new System.Drawing.Point(13, 8);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 35);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "&Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // grbdetail
            // 
            this.grbdetail.BackColor = System.Drawing.SystemColors.Control;
            this.grbdetail.Controls.Add(this.btnhuybo);
            this.grbdetail.Controls.Add(this.btnghinhan);
            this.grbdetail.Controls.Add(this.txttenphong);
            this.grbdetail.Controls.Add(this.label2);
            this.grbdetail.Controls.Add(this.txtmaphong);
            this.grbdetail.Controls.Add(this.label1);
            this.grbdetail.Location = new System.Drawing.Point(12, 286);
            this.grbdetail.Name = "grbdetail";
            this.grbdetail.Size = new System.Drawing.Size(674, 109);
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
            this.btnhuybo.Location = new System.Drawing.Point(581, 61);
            this.btnhuybo.Name = "btnhuybo";
            this.btnhuybo.Size = new System.Drawing.Size(75, 30);
            this.btnhuybo.TabIndex = 7;
            this.btnhuybo.Text = "&Hủy Bỏ";
            this.btnhuybo.UseVisualStyleBackColor = false;
            this.btnhuybo.Click += new System.EventHandler(this.btnhuybo_Click);
            // 
            // btnghinhan
            // 
            this.btnghinhan.BackColor = System.Drawing.Color.OrangeRed;
            this.btnghinhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnghinhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnghinhan.Location = new System.Drawing.Point(582, 23);
            this.btnghinhan.Name = "btnghinhan";
            this.btnghinhan.Size = new System.Drawing.Size(74, 32);
            this.btnghinhan.TabIndex = 6;
            this.btnghinhan.Text = "&Ghi Nhận";
            this.btnghinhan.UseVisualStyleBackColor = false;
            this.btnghinhan.Click += new System.EventHandler(this.btnghinhan_Click);
            // 
            // txttenphong
            // 
            this.txttenphong.Location = new System.Drawing.Point(90, 68);
            this.txttenphong.Name = "txttenphong";
            this.txttenphong.Size = new System.Drawing.Size(288, 20);
            this.txttenphong.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(15, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên PB";
            // 
            // txtmaphong
            // 
            this.txtmaphong.Location = new System.Drawing.Point(90, 21);
            this.txtmaphong.Name = "txtmaphong";
            this.txtmaphong.Size = new System.Drawing.Size(130, 20);
            this.txtmaphong.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã PB";
            // 
            // frmPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(698, 416);
            this.ControlBox = false;
            this.Controls.Add(this.grbdetail);
            this.Controls.Add(this.grbbutton);
            this.Controls.Add(this.dgvPhongBan);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "frmPhongBan";
            this.Text = "Phòng Ban";
            this.Load += new System.EventHandler(this.frmPhongBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).EndInit();
            this.grbbutton.ResumeLayout(false);
            this.grbdetail.ResumeLayout(false);
            this.grbdetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhongBan;
        private System.Windows.Forms.GroupBox grbbutton;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnbophan;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.GroupBox grbdetail;
        private System.Windows.Forms.Button btnhuybo;
        private System.Windows.Forms.Button btnghinhan;
        private System.Windows.Forms.TextBox txttenphong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmaphong;
        private System.Windows.Forms.Label label1;
    }
}