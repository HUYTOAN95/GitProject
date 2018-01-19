namespace DemoProject.UsersForm
{
    partial class FrmBangChamCong
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
            this.dgrvBangChamCong = new System.Windows.Forms.DataGridView();
            this.cbbthang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbNam = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbMaNV = new System.Windows.Forms.ComboBox();
            this.txtconglam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsongaynghi = new System.Windows.Forms.TextBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsuadoi = new System.Windows.Forms.Button();
            this.btnxpatatca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvBangChamCong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrvBangChamCong
            // 
            this.dgrvBangChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvBangChamCong.Location = new System.Drawing.Point(4, 41);
            this.dgrvBangChamCong.Margin = new System.Windows.Forms.Padding(4);
            this.dgrvBangChamCong.Name = "dgrvBangChamCong";
            this.dgrvBangChamCong.Size = new System.Drawing.Size(900, 390);
            this.dgrvBangChamCong.TabIndex = 0;
            // 
            // cbbthang
            // 
            this.cbbthang.FormattingEnabled = true;
            this.cbbthang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbbthang.Location = new System.Drawing.Point(396, 9);
            this.cbbthang.Margin = new System.Windows.Forms.Padding(4);
            this.cbbthang.Name = "cbbthang";
            this.cbbthang.Size = new System.Drawing.Size(147, 24);
            this.cbbthang.TabIndex = 1;
            this.cbbthang.SelectedIndexChanged += new System.EventHandler(this.cbbthang_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(307, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "&Tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(595, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "&Năm";
            // 
            // cbbNam
            // 
            this.cbbNam.FormattingEnabled = true;
            this.cbbNam.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.cbbNam.Location = new System.Drawing.Point(655, 9);
            this.cbbNam.Margin = new System.Windows.Forms.Padding(4);
            this.cbbNam.Name = "cbbNam";
            this.cbbNam.Size = new System.Drawing.Size(147, 24);
            this.cbbNam.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(17, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "&Mã Nhân Viên";
            // 
            // cbbMaNV
            // 
            this.cbbMaNV.FormattingEnabled = true;
            this.cbbMaNV.Location = new System.Drawing.Point(128, 8);
            this.cbbMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.cbbMaNV.Name = "cbbMaNV";
            this.cbbMaNV.Size = new System.Drawing.Size(137, 24);
            this.cbbMaNV.TabIndex = 6;
            this.cbbMaNV.SelectedIndexChanged += new System.EventHandler(this.cbbMaNV_SelectedIndexChanged);
            // 
            // txtconglam
            // 
            this.txtconglam.Location = new System.Drawing.Point(425, 441);
            this.txtconglam.Margin = new System.Windows.Forms.Padding(4);
            this.txtconglam.Name = "txtconglam";
            this.txtconglam.Size = new System.Drawing.Size(116, 22);
            this.txtconglam.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(330, 444);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số Công Làm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(550, 443);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số Ngày Nghỉ";
            // 
            // txtsongaynghi
            // 
            this.txtsongaynghi.Location = new System.Drawing.Point(655, 439);
            this.txtsongaynghi.Margin = new System.Windows.Forms.Padding(4);
            this.txtsongaynghi.Name = "txtsongaynghi";
            this.txtsongaynghi.Size = new System.Drawing.Size(114, 22);
            this.txtsongaynghi.TabIndex = 10;
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.SeaGreen;
            this.btnthoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnthoat.Location = new System.Drawing.Point(791, 431);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(117, 38);
            this.btnthoat.TabIndex = 11;
            this.btnthoat.Text = "&Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.SeaGreen;
            this.btnxoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnxoa.Location = new System.Drawing.Point(96, 440);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(81, 33);
            this.btnxoa.TabIndex = 12;
            this.btnxoa.Text = "&Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsuadoi
            // 
            this.btnsuadoi.BackColor = System.Drawing.Color.SeaGreen;
            this.btnsuadoi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsuadoi.Location = new System.Drawing.Point(12, 440);
            this.btnsuadoi.Name = "btnsuadoi";
            this.btnsuadoi.Size = new System.Drawing.Size(78, 33);
            this.btnsuadoi.TabIndex = 13;
            this.btnsuadoi.Text = "&Sửa Đổi";
            this.btnsuadoi.UseVisualStyleBackColor = false;
            this.btnsuadoi.Click += new System.EventHandler(this.btnsuadoi_Click);
            // 
            // btnxpatatca
            // 
            this.btnxpatatca.BackColor = System.Drawing.Color.SeaGreen;
            this.btnxpatatca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnxpatatca.Location = new System.Drawing.Point(183, 441);
            this.btnxpatatca.Name = "btnxpatatca";
            this.btnxpatatca.Size = new System.Drawing.Size(90, 33);
            this.btnxpatatca.TabIndex = 15;
            this.btnxpatatca.Text = "&Xóa Tất Cả ";
            this.btnxpatatca.UseVisualStyleBackColor = false;
            this.btnxpatatca.Click += new System.EventHandler(this.btnxpatatca_Click);
            // 
            // FrmBangChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(915, 474);
            this.ControlBox = false;
            this.Controls.Add(this.btnxpatatca);
            this.Controls.Add(this.btnsuadoi);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.txtsongaynghi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtconglam);
            this.Controls.Add(this.cbbMaNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbNam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbthang);
            this.Controls.Add(this.dgrvBangChamCong);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBangChamCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng Chấm Công của Nhân Viên";
            this.Load += new System.EventHandler(this.FrmBangChamCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvBangChamCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrvBangChamCong;
        private System.Windows.Forms.ComboBox cbbthang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbNam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbMaNV;
        private System.Windows.Forms.TextBox txtconglam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsongaynghi;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsuadoi;
        private System.Windows.Forms.Button btnxpatatca;
    }
}