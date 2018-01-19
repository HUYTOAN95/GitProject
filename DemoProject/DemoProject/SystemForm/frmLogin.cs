using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DemoProject.SO;
using DemoProject.DAL;
using DemoProject.SystemForm;
using System.Data.SqlClient;

namespace DemoProject.SystemForm
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            
        }


        private void frmLogin_Load(object sender, EventArgs e)
        {
            ckbshowpass.Checked =false;
         
                }

        #region login method
       
    
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Thực hiện đăng nhập vào ứng Demo với thông tin trên
            string loginApp = LoginProvider.LoginApp(
                MyApp.gHostDB, MyApp.gPortDB, MyApp.gServiceNameDB, txtUserName.Text, txtPassword.Text,
                txtUserName.Text, txtPassword.Text);
            if (loginApp.Equals("true"))
            {
                MyApp.gConnected = true;
                MyApp.gUserDB = txtUserName.Text;
                MyApp.gPwdDB = txtPassword.Text;
              FrmMain.Current.ItemMnuSystemLoginChange = "Đăng xuất";

                //Goi phan quyen o day
           
              DemoProject.SO.PhanQuyen.ShowAll(); 
               //else if (_PhanQuyen == "user01")
              //{ DemoProject.SO.PhanQuyen.ShowUser1(); }


                //txtPassword.PasswordChar = default(char);
               
                        //close form
                 this.Close();
                
            }
            else
            {                
                //e.Result = string.Format("Đăng nhập vào {0} không thành công. Bạn hãy kiểm tra lại các thông tin đăng nhập.\r\n{1}", MyApp.gAppCoded, loginApp);
                string mMessage;
                mMessage = string.Format("Đăng nhập vào {0} không thành công. Bạn hãy kiểm tra lại các thông tin đăng nhập.\r\n{1}", MyApp.gHostDB, loginApp);
                MessageBox.Show(mMessage);
            }

           
        }
       
        #endregion

       
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
             
            
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.SelectionStart = 0;
            txtPassword.SelectionLength = txtPassword.Text.Length;

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void ckbshowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbshowpass.Checked==false)
            {
                txtPassword.UseSystemPasswordChar = true;
                //txtnhaplai.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
                //txtnhaplai.UseSystemPasswordChar = true;
            }
        }

       
    }
}
