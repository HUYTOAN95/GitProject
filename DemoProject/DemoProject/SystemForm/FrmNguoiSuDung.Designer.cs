namespace DemoProject.UsersForm
{
    partial class FrmNguoiSuDung
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
            this.dgrUsers = new System.Windows.Forms.DataGridView();
            this.grbdetail = new System.Windows.Forms.GroupBox();
            this.cbbtranseraccess = new System.Windows.Forms.ComboBox();
            this.btncance = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRegistrationDate = new System.Windows.Forms.TextBox();
            this.txtUsersName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbcontrol = new System.Windows.Forms.GroupBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrUsers)).BeginInit();
            this.grbdetail.SuspendLayout();
            this.grbcontrol.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgrUsers
            // 
            this.dgrUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrUsers.Location = new System.Drawing.Point(12, 12);
            this.dgrUsers.Name = "dgrUsers";
            this.dgrUsers.Size = new System.Drawing.Size(504, 209);
            this.dgrUsers.TabIndex = 0;
            // 
            // grbdetail
            // 
            this.grbdetail.BackColor = System.Drawing.SystemColors.Control;
            this.grbdetail.Controls.Add(this.cbbtranseraccess);
            this.grbdetail.Controls.Add(this.btncance);
            this.grbdetail.Controls.Add(this.btnsave);
            this.grbdetail.Controls.Add(this.label5);
            this.grbdetail.Controls.Add(this.label4);
            this.grbdetail.Controls.Add(this.txtRegistrationDate);
            this.grbdetail.Controls.Add(this.txtUsersName);
            this.grbdetail.Controls.Add(this.label3);
            this.grbdetail.Controls.Add(this.txtPassWord);
            this.grbdetail.Controls.Add(this.label2);
            this.grbdetail.Controls.Add(this.txtLoginName);
            this.grbdetail.Controls.Add(this.label1);
            this.grbdetail.Location = new System.Drawing.Point(12, 227);
            this.grbdetail.Name = "grbdetail";
            this.grbdetail.Size = new System.Drawing.Size(613, 117);
            this.grbdetail.TabIndex = 1;
            this.grbdetail.TabStop = false;
            this.grbdetail.Text = "Thông Tin";
            this.grbdetail.Enter += new System.EventHandler(this.grbdetail_Enter);
            // 
            // cbbtranseraccess
            // 
            this.cbbtranseraccess.FormattingEnabled = true;
            this.cbbtranseraccess.Items.AddRange(new object[] {
            "admin",
            "",
            ""});
            this.cbbtranseraccess.Location = new System.Drawing.Point(119, 86);
            this.cbbtranseraccess.Name = "cbbtranseraccess";
            this.cbbtranseraccess.Size = new System.Drawing.Size(100, 21);
            this.cbbtranseraccess.TabIndex = 16;
            // 
            // btncance
            // 
            this.btncance.BackColor = System.Drawing.Color.SeaGreen;
            this.btncance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btncance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncance.Location = new System.Drawing.Point(521, 61);
            this.btncance.Name = "btncance";
            this.btncance.Size = new System.Drawing.Size(75, 34);
            this.btncance.TabIndex = 15;
            this.btncance.Text = "&Hủy";
            this.btncance.UseVisualStyleBackColor = false;
            this.btncance.Click += new System.EventHandler(this.btncance_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnsave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsave.Location = new System.Drawing.Point(521, 21);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 34);
            this.btnsave.TabIndex = 14;
            this.btnsave.Text = "&Lưu ";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(12, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "&Quyền Truy Cập ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(248, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "&Ngày Đăng Ký";
            // 
            // txtRegistrationDate
            // 
            this.txtRegistrationDate.Location = new System.Drawing.Point(361, 54);
            this.txtRegistrationDate.Name = "txtRegistrationDate";
            this.txtRegistrationDate.Size = new System.Drawing.Size(100, 20);
            this.txtRegistrationDate.TabIndex = 10;
            // 
            // txtUsersName
            // 
            this.txtUsersName.Location = new System.Drawing.Point(361, 23);
            this.txtUsersName.Name = "txtUsersName";
            this.txtUsersName.Size = new System.Drawing.Size(100, 20);
            this.txtUsersName.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(246, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "&Tên Người Dùng";
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(119, 54);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(121, 20);
            this.txtPassWord.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(22, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "&Mật Khẩu";
            // 
            // txtLoginName
            // 
            this.txtLoginName.Location = new System.Drawing.Point(119, 26);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(121, 20);
            this.txtLoginName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên Đăng Nhập";
            // 
            // grbcontrol
            // 
            this.grbcontrol.BackColor = System.Drawing.SystemColors.Control;
            this.grbcontrol.Controls.Add(this.btnexit);
            this.grbcontrol.Controls.Add(this.btndelete);
            this.grbcontrol.Controls.Add(this.btnedit);
            this.grbcontrol.Controls.Add(this.btnadd);
            this.grbcontrol.Location = new System.Drawing.Point(522, 12);
            this.grbcontrol.Name = "grbcontrol";
            this.grbcontrol.Size = new System.Drawing.Size(103, 209);
            this.grbcontrol.TabIndex = 2;
            this.grbcontrol.TabStop = false;
            this.grbcontrol.Enter += new System.EventHandler(this.grbcontrol_Enter);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.SeaGreen;
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnexit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnexit.Location = new System.Drawing.Point(11, 150);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 34);
            this.btnexit.TabIndex = 3;
            this.btnexit.Text = "&Thoát";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.SeaGreen;
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndelete.Location = new System.Drawing.Point(11, 110);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 34);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "&Xóa";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.SeaGreen;
            this.btnedit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnedit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnedit.Location = new System.Drawing.Point(11, 70);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 34);
            this.btnedit.TabIndex = 1;
            this.btnedit.Text = "&Sửa Đổi";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnadd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnadd.Location = new System.Drawing.Point(10, 28);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 34);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "&Thêm";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // FrmNguoiSuDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(639, 356);
            this.ControlBox = false;
            this.Controls.Add(this.grbcontrol);
            this.Controls.Add(this.grbdetail);
            this.Controls.Add(this.dgrUsers);
            this.Name = "FrmNguoiSuDung";
            this.ShowIcon = false;
            this.Text = "Người Sử Dụng ";
            this.Load += new System.EventHandler(this.FrmNguoiSuDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrUsers)).EndInit();
            this.grbdetail.ResumeLayout(false);
            this.grbdetail.PerformLayout();
            this.grbcontrol.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrUsers;
        private System.Windows.Forms.GroupBox grbdetail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRegistrationDate;
        private System.Windows.Forms.TextBox txtUsersName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbcontrol;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btncance;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.ComboBox cbbtranseraccess;
    }
}