using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DemoProject.DAL;
using DemoProject.SO;

namespace DemoProject.SystemForm
{
    public partial class FrmPassChange : Form
    {
        protected void AlignCenterToScreen()
        {
            //grbdetailkhoabomon.Show();
            Screen screen = Screen.FromControl(this);

            Rectangle workingArea = screen.WorkingArea;
            this.Location = new Point()
            {
                X = Math.Max(workingArea.X, workingArea.X + (workingArea.Width - this.Width) / 2),
                Y = Math.Max(workingArea.Y, workingArea.Y + (workingArea.Height - this.Height) / 2)
            };
        }
        public FrmPassChange()
        {
            InitializeComponent();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(MyApp.MSSQLConnectionString);
            cnn.Open();
            if (txtTenDN.Text == MyApp.gUserDB)
            {
                if (txtMatKhauCu.Text == MyApp.gPwdDB)
                {
                    if (txtMatKhauMoi.Text == txtNhapLai.Text)
                    {
                        string newpass = txtMatKhauMoi.Text;
                        SqlConnection.ChangePassword(MyApp.MSSQLConnectionString, newpass);
                        MyApp.gPwdDB = txtMatKhauMoi.Text;
                        MessageBox.Show("Đổi mật khẩu thành công! ");
                    }
                    else { MessageBox.Show("Lỗi thay đổi mật khẩu!"); }
                }
                else { MessageBox.Show("Mật khẩu cũ không đúng!"); }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập không đúng! ");
            }
        }

        private void FrmPassChange_Load(object sender, EventArgs e)
        {
            AlignCenterToScreen();
            txtTenDN.Text = MyApp.gUserDB;
            txtMatKhauCu.Text = MyApp.gPwdDB;
        }

        private void txtNhapLai_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void ckbcheckpass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbcheckpass.Checked == false)
            {
                txtMatKhauCu.UseSystemPasswordChar = true;
                txtMatKhauMoi.UseSystemPasswordChar = true;
                txtNhapLai.UseSystemPasswordChar = true;
                //txtnhaplai.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhauCu.UseSystemPasswordChar = false;
                txtMatKhauMoi.UseSystemPasswordChar = false;
                txtNhapLai.UseSystemPasswordChar = false;
            }
        }
    }
}
