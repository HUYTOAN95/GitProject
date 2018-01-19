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
    public partial class frmnsd : Form
    {
        bool add = false;
        CoffeManagerProjectEntities db = new CoffeManagerProjectEntities();
        public frmnsd()
        {
            InitializeComponent();
        }
        private void loaddata()
        {
            var result = from c in db.tbl_NgSD

                         select c;

            //var result = db.tbl_Sach.SqlQuery("select * from tbl_Sach");
            gridview.DataSource = result.ToList();
            
        }

        private void frmnsd_Load(object sender, EventArgs e)
        {
            loaddata();
            gridview.Columns[4].Visible = false;
        }

        private void lbllabel2_Click(object sender, EventArgs e)
        {

        }
        public void addnew()
        {
            try
            {
                string password_md5;
                password_md5 = "";
                byte[] buffer = Encoding.UTF8.GetBytes(txtmatkhau.Text);
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                buffer = md5.ComputeHash(buffer);
                for (int i = 0; i < buffer.Length; i++)
                {
                    password_md5 += buffer[i].ToString("x2");
                }
                tbl_NgSD nsd = new tbl_NgSD();
                nsd.TaiKhoan = txttaikhoan.Text;
                nsd.MatKhau = password_md5;
                nsd.MaNV = txtmanv.Text;
                nsd.QuyenTruyCap = cbbquyen.Text;
                nsd.NgayDangKi = DateTime.Today;
                nsd.NgayHetHan = datetime.Value.Date;
                db.tbl_NgSD.Add(nsd);
                db.SaveChanges();
                loaddata();
                MessageBox.Show("Thêm thông tin thành công !");
            }
            //catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            //{
            //    Exception raise = dbEx;
            //    foreach (var validationErrors in dbEx.EntityValidationErrors)
            //    {
            //        foreach (var validationError in validationErrors.ValidationErrors)
            //        {
            //            string message = string.Format("{0}:{1}",
            //                validationErrors.Entry.Entity.ToString(),
            //                validationError.ErrorMessage);
            //            // raise a new exception nesting
            //            // the current instance as InnerException
            //            raise = new InvalidOperationException(message, raise);
            //        }
            //    }
            //    throw raise;
            //}
            ////}
            catch
            {
                MessageBox.Show("Có lỗi xảy ra với hệ thống");
            }
        }
        private void editdata()
        {
            try
            {
                string password_md5;
                password_md5 = "";
                byte[] buffer = Encoding.UTF8.GetBytes(txtmatkhau.Text);
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                buffer = md5.ComputeHash(buffer);
                for (int i = 0; i < buffer.Length; i++)
                {
                    password_md5 += buffer[i].ToString("x2");
                }
                string _taikhoan = this.gridview.CurrentRow.Cells[0].Value.ToString();
                tbl_NgSD nsd = db.tbl_NgSD.SingleOrDefault(d => d.TaiKhoan.Equals(_taikhoan));
                nsd.MatKhau = password_md5;
                nsd.MaNV = txtmanv.Text;
                nsd.QuyenTruyCap = cbbquyen.Text;
                nsd.NgayHetHan = datetime.Value.Date;
               
                db.SaveChanges();
                loaddata();
                MessageBox.Show("cập nhật  thông tin thành công !");
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra với hệ thống");
            }
        }
        private void napgrid()
        {
          txttaikhoan.Text = gridview.CurrentRow.Cells[0].Value.ToString();
          //txtmatkhau.Text= gridview.CurrentRow.Cells[1].Value.ToString();
          txtmatkhau.Clear();
          txtmanv.Text= gridview.CurrentRow.Cells[2].Value.ToString();
          cbbquyen.Text = gridview.CurrentRow.Cells[3].Value.ToString().Trim();
          datetime.Text = gridview.CurrentRow.Cells[5].Value.ToString();
        }
        private void btnnew_Click(object sender, EventArgs e)
        {
            add = true;
            txttaikhoan.Text = "";
            txtmatkhau.Text = "";
            txtmanv.Text = "";
            cbbquyen.Text = "";
            DateTime now = DateTime.Today;
            
            DateTime newdate = now.AddYears(2);
           datetime.Text = newdate.ToString();
        }

        private void gridview_Click(object sender, EventArgs e)
        {
            napgrid();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (add == true)
            {
                add = false;
                addnew();
            }
            else
                editdata();
        }
        
    }
}
