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
    public partial class Frmsach : Form
    {
        public Frmsach()
        {
            InitializeComponent();

        }
        QuanLyThuVienEntities db = new QuanLyThuVienEntities();
        private void filldata()
        {
            string MaSach = this.gridview.CurrentRow.Cells[0].Value.ToString();
            tbl_Sach ss = db.tbl_Sach.Single(d => d.MaSach.Equals(MaSach));
            txtMaSach.Text = ss.MaSach;
            txtTenSach.Text = ss.TenSach;
            txtSL.Text = ss.SL.ToString();
            txtLoaiSach.Text = ss.MaLoaiSach.ToString();
            txtNXB.Text = ss.MaNXB.ToString();
            txtViTri.Text = ss.MaViTri;
            txtnamxb.Text = ss.NamXB.ToString();

        }
        private void Frmsach_Load(object sender, EventArgs e)
        {
            loaddata();
            filldata();
        }
        private void loaddata()
        {
            var result = from c in db.tbl_Sach
                     
                         select new
                         {
                             c.MaSach,
                             c.TenSach,
                             c.tbl_LoaiSach.TenLoaiSach,
                             c.tbl_ViTri.TenViTri,
                             c.SL,
                             c.tbl_NhaXB.TenNXB,
                             c.NamXB
                         };
            //var result = db.tbl_Sach.SqlQuery("select * from tbl_Sach");
            gridview.DataSource = result.ToList();
        }
        private void delete()
        {
            try
            {
                string MaSach = this.gridview.CurrentRow.Cells[0].Value.ToString();
                tbl_Sach ss = db.tbl_Sach.FirstOrDefault(d => d.MaSach.Equals(MaSach));
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa ?", "Thông Báo ", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    db.tbl_Sach.Remove(ss);
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
                tbl_Sach ss = new tbl_Sach();
                ss.MaSach = "";
                ss.TenSach = txtTenSach.Text;



                db.tbl_Sach.Add(ss);
                db.SaveChanges();
                loaddata();
                MessageBox.Show("bạn đã thêm mới độc giả thành công");
            }
            catch
            {
                MessageBox.Show("Lỗi !");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Frmsach_KeyDown(object sender, KeyEventArgs e)
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

        private void gridview_Click(object sender, EventArgs e)
        {
            filldata();
        }

        private void gridview_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            filldata();
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            var result = from c in db.tbl_Sach
                         where c.TenSach.Contains( txtTenSach.Text)
                         select new
                         {
                             c.MaSach,
                             c.TenSach,
                             c.tbl_LoaiSach.TenLoaiSach,
                             c.tbl_ViTri.TenViTri,
                             c.SL,
                             c.tbl_NhaXB.TenNXB,
                             c.NamXB
                         };
        
            gridview.DataSource = result.ToList();
         
            

        }

        private void txtLoaiSach_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    FrmLoaiSach frm = new FrmLoaiSach();
             
                     using (frm)
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            txtLoaiSach.Text = frm.Selected;
                            txtLoaiSach.SelectionStart = txtLoaiSach.Text.Length;

                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
