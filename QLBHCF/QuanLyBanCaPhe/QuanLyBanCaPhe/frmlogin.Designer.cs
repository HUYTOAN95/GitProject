namespace QuanLyBanCaPhe
{
    partial class frmlogin
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
        public void InitializeComponent()
        {
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lbllabel1 = new System.Windows.Forms.Label();
            this.lbllabel2 = new System.Windows.Forms.Label();
            this.llblinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.chkrememberpass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtusername.Location = new System.Drawing.Point(191, 12);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(181, 26);
            this.txtusername.TabIndex = 0;
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtpassword.Location = new System.Drawing.Point(190, 45);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(181, 26);
            this.txtpassword.TabIndex = 1;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // lbllabel1
            // 
            this.lbllabel1.AutoSize = true;
            this.lbllabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbllabel1.Location = new System.Drawing.Point(19, 15);
            this.lbllabel1.Name = "lbllabel1";
            this.lbllabel1.Size = new System.Drawing.Size(106, 19);
            this.lbllabel1.TabIndex = 2;
            this.lbllabel1.Text = "&Tên Đăng Nhập";
            // 
            // lbllabel2
            // 
            this.lbllabel2.AutoSize = true;
            this.lbllabel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbllabel2.Location = new System.Drawing.Point(22, 49);
            this.lbllabel2.Name = "lbllabel2";
            this.lbllabel2.Size = new System.Drawing.Size(71, 19);
            this.lbllabel2.TabIndex = 3;
            this.lbllabel2.Text = "&Mật Khẩu";
            // 
            // llblinkLabel1
            // 
            this.llblinkLabel1.AutoSize = true;
            this.llblinkLabel1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.llblinkLabel1.Location = new System.Drawing.Point(98, 51);
            this.llblinkLabel1.Name = "llblinkLabel1";
            this.llblinkLabel1.Size = new System.Drawing.Size(86, 15);
            this.llblinkLabel1.TabIndex = 4;
            this.llblinkLabel1.TabStop = true;
            this.llblinkLabel1.Text = "&Quên Mật Khẩu";
            // 
            // btnlogin
            // 
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnlogin.Location = new System.Drawing.Point(123, 101);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(91, 31);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Đăng Nhập";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btncancel
            // 
            this.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btncancel.Location = new System.Drawing.Point(220, 102);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(84, 30);
            this.btncancel.TabIndex = 5;
            this.btncancel.Text = "Hủy Bỏ";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // chkrememberpass
            // 
            this.chkrememberpass.AutoSize = true;
            this.chkrememberpass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkrememberpass.Location = new System.Drawing.Point(191, 73);
            this.chkrememberpass.Name = "chkrememberpass";
            this.chkrememberpass.Size = new System.Drawing.Size(114, 23);
            this.chkrememberpass.TabIndex = 3;
            this.chkrememberpass.Text = "&Nhớ mật khẩu";
            this.chkrememberpass.UseVisualStyleBackColor = true;
            this.chkrememberpass.CheckedChanged += new System.EventHandler(this.chkrememberpass_CheckedChanged);
            // 
            // frmlogin
            // 
            this.AcceptButton = this.btnlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btncancel;
            this.ClientSize = new System.Drawing.Size(399, 144);
            this.Controls.Add(this.chkrememberpass);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.llblinkLabel1);
            this.Controls.Add(this.lbllabel2);
            this.Controls.Add(this.lbllabel1);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.KeyPreview = true;
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.frmlogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmlogin_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label lbllabel1;
        private System.Windows.Forms.Label lbllabel2;
        private System.Windows.Forms.LinkLabel llblinkLabel1;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.CheckBox chkrememberpass;
    }
}