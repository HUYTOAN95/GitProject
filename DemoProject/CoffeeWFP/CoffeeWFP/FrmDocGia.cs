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
    public partial class FrmDocGia : Form
    {
        Boolean addnew = false;
        public FrmDocGia()
        {
            InitializeComponent();
        }
        QuanLyThuVienEntities db = new QuanLyThuVienEntities();
        private void FrmDocGia_Load(object sender, EventArgs e)
        {
            loaddata();
            filldata();
        }
        private void loaddata()
        {
            var result = from c in db.tbl_DocGia select new { c.MaDG, c.MaSV, c.TenDG, c.GioiTinh, c.NgaySinh, c.DiaChi };
            gridview.DataSource = result.ToArray();
          
        }
        public void filldata()
        {
            string MaDG = this.gridview.CurrentRow.Cells[0].Value.ToString();
            tbl_DocGia dg = db.tbl_DocGia.FirstOrDefault(d => d.MaDG.Equals(MaDG));
            txtMaSV.Text = dg.MaSV;
            txtTenSV.Text = dg.TenDG;
            txtDiaChi.Text = dg.DiaChi;
            datetime.Text = dg.NgaySinh.Value.ToShortDateString();
            cbbGioiTinh.Text = dg.GioiTinh;
        }
        private void gridview_Click(object sender, EventArgs e)
        {

            filldata(); 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            delete();
        }
        private void delete()
        {
            try
            {
                string MaDG = this.gridview.CurrentRow.Cells[0].Value.ToString();
                tbl_DocGia dg = db.tbl_DocGia.FirstOrDefault(d => d.MaDG.Equals(MaDG));
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa ?", "Thông Báo ", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    db.tbl_DocGia.Remove(dg);
                    db.SaveChanges();
                }
                loaddata();
                MessageBox.Show("Xóa thông tin độc giả thành công ");
            }
            catch
            {
                MessageBox.Show("Lỗi !");
            } 
        }
        private void add()
        {
            try
            {
                tbl_DocGia dg = new tbl_DocGia();
                dg.MaDG = "";
                dg.MaSV = txtMaSV.Text;
                dg.TenDG = txtTenSV.Text;
                dg.GioiTinh = cbbGioiTinh.Text;
                dg.NgaySinh = DateTime.Parse(datetime.Text);
                dg.DiaChi = txtDiaChi.Text;
                db.tbl_DocGia.Add(dg);
                db.SaveChanges();
                loaddata();
                MessageBox.Show("bạn đã thêm mới độc giả thành công");
            }
            catch
            {
                MessageBox.Show("Lỗi !");
            }

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            addnew = true;
            txtMaSV.Clear();
            txtTenSV.Clear();
            txtDiaChi.Clear();
           

        }
        private void update ()
        {
            try
            {
               
                string MaDG = this.gridview.CurrentRow.Cells[0].Value.ToString();
                tbl_DocGia dg = db.tbl_DocGia.Single(d => d.MaDG.Equals(MaDG));
                DialogResult dr = MessageBox.Show("Bạn có chắc cập nhật thông tin ?", "Thông Báo ", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                   
                    dg.MaSV = txtMaSV.Text;
                    dg.TenDG = txtTenSV.Text;
                    dg.GioiTinh = cbbGioiTinh.Text;
                    dg.NgaySinh = DateTime.Parse(datetime.Text);
                    dg.DiaChi = txtDiaChi.Text;

                    db.SaveChanges();
                    loaddata();
                    MessageBox.Show("bạn đã cập nhật thông tin độc giả thành công");
                }
            }
            catch
            {
                MessageBox.Show("lỗi !");
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(addnew==true )
            {
                addnew = false;
                add();
               
            }
            else if (addnew==false)
            {
                update();
               
            }
        }

        private void gridview_Move(object sender, EventArgs e)
        {
            filldata(); 
        }

        private void gridview_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void FrmDocGia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.F5)
            {
                loaddata();
            }
        }

        

        private void deletemenustrip_Click(object sender, EventArgs e)
        {
            delete();
        }
    }
}
