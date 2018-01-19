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
using System.Data.EntityModel;
namespace QuanLyBanCaPhe
{  
    public partial class frmnhanvien : Form
    {
        bool add = false;
        bool print = false;
        string GT;
     
 
        
       
        CoffeManagerProjectEntities db = new CoffeManagerProjectEntities();
        public frmnhanvien()
        {
            InitializeComponent();
        }

        private void frmnhanvien_Load(object sender, EventArgs e)
        {
            loaddata();
           
            gridview.Columns[4].Visible = false;
            gridview.Columns[5].Visible = false;
            gridview.Columns[6].Visible = false;
           
       
        }
        private void loaddata()
        {
            var  result = from c in db.tbl_NhanVien

                         select c;
          
            //var result = db.tbl_Sach.SqlQuery("select * from tbl_Sach");
            gridview.DataSource = result.ToList();
            napgrid();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            add= true;
            LoadMaNV();
            txtTenNV.Text = "";
            txtdiachi.Text = "";
            txtsdt.Text = "";
            datengaysinh.Text = "02/02/1990";
          
        }
        public void addnew ()
        {
            try
            {
                tbl_NhanVien nv = new tbl_NhanVien();
                nv.MaNV = txtMaNV.Text;
                nv.TenNV = txtTenNV.Text;
                nv.GioiTinh = GT;
                //nv.NgaySinh = DateTime.Parse(datengaysinh.Text);
                nv.NgaySinh = datengaysinh.Value.Date;
                nv.DiaChi = txtdiachi.Text;
                nv.SDT = txtsdt.Text;
                db.tbl_NhanVien.Add(nv);
                db.SaveChanges();
                loaddata();
                MessageBox.Show("Thêm thông tin thành công !");
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra với hệ thống");
            }
        }
        
        private void editdata()
        {
            try
            {
                string MaNV = this.gridview.CurrentRow.Cells[0].Value.ToString();
                tbl_NhanVien nv = db.tbl_NhanVien.SingleOrDefault(d => d.MaNV.Equals(MaNV));

                nv.TenNV = txtTenNV.Text;
                nv.GioiTinh = GT;
                nv.NgaySinh = DateTime.Parse(datengaysinh.Text);
                nv.DiaChi = txtdiachi.Text;
                nv.SDT = txtsdt.Text;
                db.Entry(nv).State = EntityState.Modified;
                db.SaveChanges();
                loaddata();
                MessageBox.Show("cập nhật  thông tin thành công !");
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra với hệ thống");
            }
        }
        private void delete()
        {
            try
            {
           
                string _MaNV = gridview.CurrentRow.Cells[0].Value.ToString().Trim();

                tbl_NhanVien nv = db.tbl_NhanVien.SingleOrDefault(d => d.MaNV == _MaNV);
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa ?", "Thông Báo ", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes && nv != null)
                {
                    db.tbl_NhanVien.Remove(nv);
                    db.SaveChanges();
                }
                loaddata();
                MessageBox.Show("Xóa thông tin độc giả thành công ");
               
            }
            catch
            {
                MessageBox.Show("Có Lỗi xảy ra với hệ thống !");
            }
        }
        private void radnam_CheckedChanged(object sender, EventArgs e)
        {
            if (radnam.Checked == true)
            {
                GT = "Nam";
            }
            else
                GT = "Nữ";
        }
        private void  LoadMaNV()
        {
            var result = db.sp_nhanvien_id();
            txtMaNV.Text = result.Single();
        }

        public void napgrid()
        {
            //if (db.tbl_NhanVien.Count() > 0)
            //{
            //    string MaNV = this.gridview.CurrentRow.Cells[0].Value.ToString();
            //    tbl_NhanVien nv = db.tbl_NhanVien.SingleOrDefault(d => d.MaNV.Equals(MaNV));
            //    txtMaNV.Text = nv.MaNV;
            //    txtTenNV.Text = nv.TenNV;
            //    GT = nv.GioiTinh;
            //    if (GT == "Nam ")
            //    {
            //        radnam.Checked = true;
            //    }
            //    else
            //        radnu.Checked = true;
            //    datengaysinh.Text = nv.NgaySinh.Value.ToShortDateString();
            //    txtdiachi.Text = nv.DiaChi;
            //    txtsdt.Text = nv.SDT;
            //}
            txtMaNV.Text = gridview.CurrentRow.Cells[0].Value.ToString();
            txtTenNV.Text = gridview.CurrentRow.Cells[1].Value.ToString();
            GT = gridview.CurrentRow.Cells[2].Value.ToString();
            if (GT == "Nam ")
            {
                radnam.Checked = true;
            }
            else
                radnu.Checked = true;
            datengaysinh.Text = gridview.CurrentRow.Cells[3].Value.ToString();
            txtdiachi.Text = gridview.CurrentRow.Cells[4].Value.ToString();
            txtsdt.Text = gridview.CurrentRow.Cells[5].Value.ToString();

          
        }

        private void gridview_Click(object sender, EventArgs e)
        {
            napgrid();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {  if(add==true)
        {
            add = false;
            addnew();
        }
        else
            editdata();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            print = true;
            if (txtTenNV.Text != null)
            {
                var result = from c in db.tbl_NhanVien
                             where c.TenNV.Contains(txtTenNV.Text)
                             select c;

                gridview.DataSource = result.ToList();
            }
            else if(txtdiachi.Text!=null)
            {
                var result = from c in db.tbl_NhanVien
                            where c.DiaChi.Contains(txtdiachi.Text)
                            select c;

                gridview.DataSource = result.ToList();
            }
          
        }

        private void gridview_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmnhanvien_KeyDown(object sender, KeyEventArgs e)
        {
            switch( e.KeyCode)
            { case Keys.D0:
                    radnam.Checked = true;
                    break;
                case Keys.D1:
                    radnu.Checked = true;
                    break;
                case Keys.Enter:
                    btnedit.PerformClick();
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.F5:
                    loaddata();
                    break;
                default:
                    break;


            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
           
            //ReportDocument cryRpt = new ReportDocument();
            Report.NhanVien cryRpt = new Report.NhanVien();
            if (print == false)
            {
                var result = (from c in db.tbl_NhanVien

                              select c).ToList();

                if (result != null)
                {
                    cryRpt.SetDataSource(result);
                    frmreportviewer f = new frmreportviewer();

                    f.crystalportview.ReportSource = cryRpt;
                    f.crystalportview.Refresh();
                    f.ShowDialog();
                }
            }
            else
            {
                var result = (from c in db.tbl_NhanVien
                             where c.TenNV.Contains(txtTenNV.Text)
                             select c).ToList();
                if (result != null)
                {
                    cryRpt.SetDataSource(result);
                    frmreportviewer f = new frmreportviewer();

                    f.crystalportview.ReportSource = cryRpt;
                    f.crystalportview.Refresh();
                    f.ShowDialog();
                }
            }
            print = false;
          

        }

}
}
