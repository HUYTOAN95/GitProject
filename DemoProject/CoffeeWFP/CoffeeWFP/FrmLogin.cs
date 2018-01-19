using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeWFP
{
    public partial class FrmLogin : Form
    {
        int dem;
        QuanLyThuVienEntities db = new QuanLyThuVienEntities();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            var result = db.tbl_TaiKhoan.FirstOrDefault(tk => tk.Name.Equals(txtTenTK.Text) && tk.Pass.Equals(txtMatKhau.Text));
            if (result != null && dem<=3)
            {
                MessageBox.Show("Đăng Nhập thành Công");
                FrmMain frm = new FrmMain();
                frm.ShowDialog();
            }
            else if (result == null && dem <= 3)
            {
                MessageBox.Show("Bạn nhập sai mật khẩu !");
            }
            else
            {
                MessageBox.Show("Bạn đã nhập sai quá 3 lần! Thoát chương trình  ","Thông Báo",MessageBoxButtons.YesNo);
                this.Close();
            }
            dem = dem + 1;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            dem = 1;
        }
    }
}
