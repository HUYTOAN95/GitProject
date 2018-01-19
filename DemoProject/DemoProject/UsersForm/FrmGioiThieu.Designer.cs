namespace DemoProject.UsersForm
{
    partial class FrmGioiThieu
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
            this.listboxGT = new System.Windows.Forms.ListBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // listboxGT
            // 
            this.listboxGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.listboxGT.FormattingEnabled = true;
            this.listboxGT.ItemHeight = 16;
            this.listboxGT.Items.AddRange(new object[] {
            "Phần mềm kế toán Lương Nhân Viên  Trung tâm tín dụng CIC là đề án do",
            "Sinh Viên Nguyễn Huy Toàn_11146217",
            "Khoa Tin Học Kinh Tế  - ĐH Kinh Tế Quốc Dân ",
            "thực hiện dưới sự Hướng Dẫn có Giảng Viên  ",
            "PGS.TS Lê Văn Năm",
            "Phần mềm này có chức năng quản lý lương cho nhân viên của trung tâm",
            "cà báo cáo định kì về thu nhập của nhân viên. ",
            "Là một phần mềm được thực hiện bởi một sinh viên tham gia đề án , phần ",
            "lớn chú trọng về cách giải quyết bài toán , bên cạnh đó có một số điểm",
            "cần hạn chế hoặc chưa đáp ứng thỏa mãn các yêu cầu khác",
            "",
            "Sinh Viên: Nguyễn Huy Toàn",
            "Mọi vấn đề xin liên lạc link sau: "});
            this.listboxGT.Location = new System.Drawing.Point(38, 27);
            this.listboxGT.Name = "listboxGT";
            this.listboxGT.Size = new System.Drawing.Size(472, 228);
            this.listboxGT.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(231, 223);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(73, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Link Truy Câp";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FrmGioiThieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(536, 290);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.listboxGT);
            this.Name = "FrmGioiThieu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giới Thiệu ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listboxGT;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}