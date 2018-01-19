namespace DemoProject.SystemForm
{
    partial class frmNgach
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
            this.dgvNgach = new System.Windows.Forms.DataGridView();
            this.grbbutton = new System.Windows.Forms.GroupBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnbac = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.grbdetail = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtghichu = new System.Windows.Forms.TextBox();
            this.txttenngach = new System.Windows.Forms.TextBox();
            this.txtmangach = new System.Windows.Forms.TextBox();
            this.btnhuybo = new System.Windows.Forms.Button();
            this.btnghinhan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNgach)).BeginInit();
            this.grbbutton.SuspendLayout();
            this.grbdetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNgach
            // 
            this.dgvNgach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNgach.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvNgach.Location = new System.Drawing.Point(12, 11);
            this.dgvNgach.Name = "dgvNgach";
            this.dgvNgach.Size = new System.Drawing.Size(575, 241);
            this.dgvNgach.TabIndex = 0;
            // 
            // grbbutton
            // 
            this.grbbutton.BackColor = System.Drawing.SystemColors.Control;
            this.grbbutton.Controls.Add(this.btnthoat);
            this.grbbutton.Controls.Add(this.btnprint);
            this.grbbutton.Controls.Add(this.btnbac);
            this.grbbutton.Controls.Add(this.btntimkiem);
            this.grbbutton.Controls.Add(this.btnxoa);
            this.grbbutton.Controls.Add(this.btnsua);
            this.grbbutton.Controls.Add(this.btnthem);
            this.grbbutton.Location = new System.Drawing.Point(609, 7);
            this.grbbutton.Name = "grbbutton";
            this.grbbutton.Size = new System.Drawing.Size(114, 245);
            this.grbbutton.TabIndex = 1;
            this.grbbutton.TabStop = false;
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.SeaGreen;
            this.btnthoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthoat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnthoat.Location = new System.Drawing.Point(18, 204);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 30);
            this.btnthoat.TabIndex = 7;
            this.btnthoat.Text = "&Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.SeaGreen;
            this.btnprint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnprint.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnprint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnprint.Location = new System.Drawing.Point(18, 172);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(75, 32);
            this.btnprint.TabIndex = 6;
            this.btnprint.Text = "&IN";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnbac
            // 
            this.btnbac.BackColor = System.Drawing.Color.SeaGreen;
            this.btnbac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnbac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbac.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnbac.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnbac.Location = new System.Drawing.Point(17, 143);
            this.btnbac.Name = "btnbac";
            this.btnbac.Size = new System.Drawing.Size(75, 30);
            this.btnbac.TabIndex = 5;
            this.btnbac.Text = "&Bậc";
            this.btnbac.UseVisualStyleBackColor = false;
            this.btnbac.Click += new System.EventHandler(this.btnbac_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.Color.SeaGreen;
            this.btntimkiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntimkiem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btntimkiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btntimkiem.Location = new System.Drawing.Point(18, 110);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(75, 32);
            this.btntimkiem.TabIndex = 4;
            this.btntimkiem.Text = "&Tìm Kiếm ";
            this.btntimkiem.UseVisualStyleBackColor = false;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.SeaGreen;
            this.btnxoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnxoa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnxoa.Location = new System.Drawing.Point(18, 76);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 32);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "&Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.SeaGreen;
            this.btnsua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsua.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnsua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsua.Location = new System.Drawing.Point(18, 43);
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
            this.btnthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnthem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnthem.Location = new System.Drawing.Point(18, 11);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 32);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "&Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // grbdetail
            // 
            this.grbdetail.BackColor = System.Drawing.SystemColors.Control;
            this.grbdetail.Controls.Add(this.label3);
            this.grbdetail.Controls.Add(this.label2);
            this.grbdetail.Controls.Add(this.label1);
            this.grbdetail.Controls.Add(this.txtghichu);
            this.grbdetail.Controls.Add(this.txttenngach);
            this.grbdetail.Controls.Add(this.txtmangach);
            this.grbdetail.Controls.Add(this.btnhuybo);
            this.grbdetail.Controls.Add(this.btnghinhan);
            this.grbdetail.Location = new System.Drawing.Point(12, 263);
            this.grbdetail.Name = "grbdetail";
            this.grbdetail.Size = new System.Drawing.Size(711, 102);
            this.grbdetail.TabIndex = 2;
            this.grbdetail.TabStop = false;
            this.grbdetail.Text = "Thông tin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(24, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nhóm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(230, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Loại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã Ngạch";
            // 
            // txtghichu
            // 
            this.txtghichu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtghichu.Location = new System.Drawing.Point(96, 70);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(161, 22);
            this.txtghichu.TabIndex = 5;
            // 
            // txttenngach
            // 
            this.txttenngach.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttenngach.Location = new System.Drawing.Point(287, 29);
            this.txttenngach.Name = "txttenngach";
            this.txttenngach.Size = new System.Drawing.Size(165, 22);
            this.txttenngach.TabIndex = 4;
            // 
            // txtmangach
            // 
            this.txtmangach.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtmangach.Location = new System.Drawing.Point(97, 29);
            this.txtmangach.Name = "txtmangach";
            this.txtmangach.Size = new System.Drawing.Size(100, 22);
            this.txtmangach.TabIndex = 3;
            // 
            // btnhuybo
            // 
            this.btnhuybo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnhuybo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhuybo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnhuybo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnhuybo.Location = new System.Drawing.Point(614, 60);
            this.btnhuybo.Name = "btnhuybo";
            this.btnhuybo.Size = new System.Drawing.Size(76, 29);
            this.btnhuybo.TabIndex = 2;
            this.btnhuybo.Text = "&Hủy Bỏ";
            this.btnhuybo.UseVisualStyleBackColor = false;
            this.btnhuybo.Click += new System.EventHandler(this.btnhuybo_Click);
            // 
            // btnghinhan
            // 
            this.btnghinhan.BackColor = System.Drawing.Color.SeaGreen;
            this.btnghinhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnghinhan.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnghinhan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnghinhan.Location = new System.Drawing.Point(615, 25);
            this.btnghinhan.Name = "btnghinhan";
            this.btnghinhan.Size = new System.Drawing.Size(75, 29);
            this.btnghinhan.TabIndex = 1;
            this.btnghinhan.Text = "&Ghi Nhận ";
            this.btnghinhan.UseVisualStyleBackColor = false;
            this.btnghinhan.Click += new System.EventHandler(this.btnghinhan_Click);
            // 
            // frmNgach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(735, 386);
            this.ControlBox = false;
            this.Controls.Add(this.grbdetail);
            this.Controls.Add(this.grbbutton);
            this.Controls.Add(this.dgvNgach);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "frmNgach";
            this.Text = "Ngạch";
            this.Load += new System.EventHandler(this.frmNgach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNgach)).EndInit();
            this.grbbutton.ResumeLayout(false);
            this.grbdetail.ResumeLayout(false);
            this.grbdetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNgach;
        private System.Windows.Forms.GroupBox grbbutton;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.GroupBox grbdetail;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnbac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtghichu;
        private System.Windows.Forms.TextBox txttenngach;
        private System.Windows.Forms.TextBox txtmangach;
        private System.Windows.Forms.Button btnhuybo;
        private System.Windows.Forms.Button btnghinhan;
    }
}