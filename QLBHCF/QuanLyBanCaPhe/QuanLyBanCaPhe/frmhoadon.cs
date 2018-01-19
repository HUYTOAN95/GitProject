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

namespace QuanLyBanCaPhe
{   
    public partial class frmhoadon : Form
    {
        bool add = false;
        CoffeManagerProjectEntities db = new CoffeManagerProjectEntities();
        public frmhoadon()
        {
            InitializeComponent();
        }
        private void loaddata()
        {
            var result = from c in db.tbl_ThucDon

                         select c;

            //var result = db.tbl_Sach.SqlQuery("select * from tbl_Sach");
            gridview.DataSource = result.ToList();
            
        }

        private void LoadMaHD()
        {
            var result = db.sp_hoadon_id();
           txtmahoadon.Text= result.Single();
        }
        

        private void frmhoadon_Load(object sender, EventArgs e)
        {
            loaddata();
            gridview.Columns[6].Visible = false;
           
        }

        private void btnmoi_Click(object sender, EventArgs e)
        {
            LoadMaHD();
            txtmanv.Text = "";
            txtcaso.Text = "";
            add = true;

        }
        public void addnew()
        {
            try
            {
                tbl_HoaDon hd = new tbl_HoaDon();
                hd.MaHD = txtmahoadon.Text;
                hd.MaNV = txtmanv.Text;
                hd.CaSo = Int16.Parse(txtcaso.Text);
                hd.NgayCapNhat = DateTime.Today;
                db.tbl_HoaDon.Add(hd);
               
                db.SaveChanges();
                loaddata();
                MessageBox.Show("Thêm thông tin thành công !");
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra với hệ thống");
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (add == true)
            {
                add = false;
                addnew();
            }
            
        }

        private void IemNhap_Click(object sender, EventArgs e)
        {
            string ID = this.gridview.CurrentRow.Cells[0].Value.ToString();
            string SL = this.gridview.CurrentRow.Cells[4].Value.ToString();
            string KM = this.gridview.CurrentRow.Cells[5].Value.ToString();
            tbl_ChitietHD ct = new tbl_ChitietHD();
            ct.MaHD = txtmahoadon.Text;
            ct.MaSP = ID;
            ct.SoLuong = Int32.Parse(SL);
            ct.KhuyenMai = float.Parse(KM);
            db.tbl_ChitietHD.Add(ct);
            db.SaveChanges();
        }

    }
}
