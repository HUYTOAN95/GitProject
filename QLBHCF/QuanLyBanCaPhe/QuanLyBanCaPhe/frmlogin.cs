using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanCaPhe.Module;
using System.Security.Cryptography;

namespace QuanLyBanCaPhe
{
    public partial class frmlogin : Form
    {
       public int PQ2;
        int dem;
        CoffeManagerProjectEntities db = new CoffeManagerProjectEntities();
        public frmlogin()
        {
            InitializeComponent();
        }

        
        private void btnlogin_Click(object sender, EventArgs e)
        {   //mã hóa md5 cho password 
            string password_md5;
            password_md5 = "";
            byte[] buffer = Encoding.UTF8.GetBytes(txtpassword.Text);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);
            for (int i = 0; i < buffer.Length; i++)
            {
                password_md5 += buffer[i].ToString("x2");
            }
            //check username && password sau khi mã hóa pass
            var result = db.tbl_NgSD.Count(tk => tk.TaiKhoan.Equals(txtusername.Text) && tk.MatKhau.Equals(password_md5));
           
            if (result != 0 && dem <= 3)
            {
                var result2 = db.tbl_NgSD.Count(tk => tk.TaiKhoan.Equals(txtusername.Text) && tk.MatKhau.Equals(password_md5)&&tk.NgayHetHan>=DateTime.Today);
                if (result2 != 0)
                {
                  

                    MessageBox.Show("Đăng Nhập thành Công");
                    frmmain.Current.ItemMnuSystemLoginChange = "Đăng xuất";
                    loadquyen();
                    if(PQ2 == 1)
                    {
                        QuanLyBanCaPhe.SO.PhanQuyen.ShowAll();
                    }
                    else if (PQ2==2)
                    {
                        QuanLyBanCaPhe.SO.PhanQuyen.ShowUser1();
                    }

                    
                    this.Close();
                }
                else 
                {
                    MessageBox.Show("Tài khoản của bạn hết hạn sử dụng!");
                }
            }
            else if (result == 0 && dem<=3 )
            {
                MessageBox.Show("Bạn nhập sai mật khẩu !");
            }
            else
            {
                MessageBox.Show("Bạn đã nhập sai quá 3 lần! Thoát chương trình  ", "Thông Báo", MessageBoxButtons.YesNo);
                this.Close();
            }
            dem = dem + 1;
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            dem = 1;
            if (Properties.Settings.Default.username != string.Empty)
            {
              txtusername.Text = Properties.Settings.Default.username;
                txtpassword.Text = Properties.Settings.Default.password;
            }
        }

        private void chkrememberpass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkrememberpass.Checked)
            {
                Properties.Settings.Default.username = txtusername.Text;
                Properties.Settings.Default.password = txtpassword.Text;
                Properties.Settings.Default.Save();
            }
        }

        public void  loadquyen()
        {
            var result = from c in db.tbl_NgSD where c.TaiKhoan==txtusername.Text select c.QuyenTruyCap;
            PQ2 =Int32.Parse(result.Single());
            //var result2 = from c in db.tbl_NgSD select c.QuyenTruyCap;
            //nsd = result2.Single();
        }

        

       
        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void frmlogin_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            { case Keys.Enter:
                    btnlogin.PerformClick();
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
                default:
                    break;

            }
        }

        
    }
}
