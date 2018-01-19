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

namespace DemoProject.UsersForm
{
    public partial class frmBangLuong : Form
    {
        DataSet ds;
        public frmBangLuong()
        {
            InitializeComponent();
        }

        private void frmBangLuong_Load(object sender, EventArgs e)
        {
            string year = Convert.ToString(DateTime.Today.ToString("yyyy/MM"));



            cbbNam.Text = year.Substring(0, 4);

            cbbThang.Text = year.Substring(5, 2);
            loadData();
            LoadNV();
        }
        private void LoadNV()
        {
            try
            {
                SqlConnection cnn = new SqlConnection(MyApp.MSSQLConnectionString);
                string sql = "SELECT MaNV  FROM tbl_NhanVien WHERE Xoa =  1";
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sql, cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                cbbMaNV.DataSource = ds.Tables[0];
                cbbMaNV.DisplayMember = "MaNV";
                cbbMaNV.ValueMember = "MaNV";

            }
            catch (Exception es)
            {
                MessageBox.Show("Có lỗi" + es.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void loadData(string _Filter = "")
        {

            DataAccess dbA = new DataAccess();
            string sql = " SELECT MaNV as'Mã Nhân Viên',ThuNhapChinh as'Thu Nhập Chính',ThuNhapThem as' Thu Nhập Làm Ngoài Giờ'," +
                "KhoanTrichBH as'Số tiền trích từ Bảo Hiểm',ThueTNCN as'Thuế TNCN' ,TamUng as' Tạm Ứng',KhenThuong as' Khen thưởng'," +
                "TienPhat as'Tiền Phạt',LuongConLai as 'Lương Còn Lại' ,NgayCapNhat as'Ngày Cập Nhật' FROM tbl_BangLuong " + _Filter + "ORDER BY NgayCapNhat DESC";
            try
            {
                ds = dbA.ExecuteAsDataSetSql(sql);
            }
            catch (Exception es)
            {
                MessageBox.Show("Có lỗi" + es.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            BindingSource bSource = new BindingSource();
            bSource.DataSource = ds.Tables[0];
            DataColumn col = ds.Tables[0].Columns.Add("STT", typeof(int));
            col.SetOrdinal(0);
            dgrvLoadLuong.DataSource = bSource;
            dgrvLoadLuong.Columns[0].Width = 50;

            for (int i = 0; i < dgrvLoadLuong.Rows.Count - 1; i++)
            {
                dgrvLoadLuong.Rows[i].Cells["STT"].Value = i + 1;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            addNew();
            txtKhenThuong.Clear();
            txtTamUng.Clear();
            txtTienPhat.Clear();
        }
        private void addNew()
        {
            try
            {
                DataAccess dbA = new DataAccess();
                string sql = "INSERT tbl_BangLuong(MaNV,Thang,Nam,TamUng,KhenThuong,TienPhat,NgayCapNhat) VALUES" +
                    "('" + cbbMaNV.Text + "','" + cbbThang.Text + "','" + cbbNam.Text + "','" + txtTamUng.Text + "','" + txtKhenThuong.Text + "','" + txtTienPhat.Text + "','" + DateTime.Today.ToString("MM/dd/yyyy") + "');" +
                    "UPDATE tbl_BangLuong SET ThuNhapChinh=(SELECT DISTINCT nv.LuongCS*(nv.HSCV+nv.HSL)*2.6*cc.SoNL/22 FROM tbl_NhanVien nv INNER JOIN tbl_ChamCongNew cc ON nv.MaNV=cc.MaNV " +
                    "WHERE nv.MaNV='" + cbbMaNV.Text + "'AND cc.Thang='" + cbbThang.Text + "' AND cc.Nam='" + cbbNam.Text + "')," +
                    "ThuNhapThem=(SELECT ThuNhap FROM tbl_NgoaiGio  WHERE MaNV='" + cbbMaNV.Text + "' AND Nam='" + cbbNam.Text + "' AND Thang='" + cbbThang.Text + "' )," +
                    "KhoanTrichBH=(SELECT SoTien FROM tbl_BaoHiem WHERE MaNV ='" + cbbMaNV.Text + "' AND Thang='" + cbbThang.Text + "' AND Nam='" + cbbNam.Text + "'), " +
                    "ThueTNCN=(SELECT ThueThuNhapCaNhan FROM tbl_ThueTNCN WHERE MaNV ='" + cbbMaNV.Text + "' AND Thang='" + cbbThang.Text + "' AND Nam='" + cbbNam.Text + "')" +

                   " WHERE MaNV='" + cbbMaNV.Text + "'AND Thang='" + cbbThang.Text + "'AND Nam='" + cbbNam.Text + "';" +
                   "UPDATE tbl_BangLuong SET LuongConLai=ThuNhapChinh+ThuNhapThem-KhoanTrichBH-ThueTNCN-TamUng + KhenThuong-TienPhat" +
                   " WHERE MaNV='" + cbbMaNV.Text + "'AND Thang='" + cbbThang.Text + "'AND Nam='" + cbbNam.Text + "'";





                int i = dbA.ExecuteData(sql);
                if (i > 0)
                {
                    //MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                    loadData();

                }
                else
                {
                    MessageBox.Show("Có lỗi! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi! " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (ds.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK);
            }
            else
                foreach (System.Windows.Forms.DataGridViewRow dgv in dgrvLoadLuong.SelectedRows)
                {
                    string _MaNV = dgv.Cells[1].Value.ToString().Trim();


                    if (MessageBox.Show("Có chắc chắn xóa Lương Nhận của Nhân Viên " + _MaNV + " Tháng " + cbbThang.Text + " Năm " + cbbNam.Text + "' không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            int _rowIdx = dgv.Index;
                            //MessageBox.Show(dgvUsersrows.Index.ToString(), "TB");
                            ds.Tables[0].Rows.RemoveAt(dgv.Index);
                            dgrvLoadLuong.Refresh();

                            var result = dgrvLoadLuong.DataSource;
                            //result.RemoveAt(_rowIdx);
                            //dataGridView1.DataSource = result;

                            DataAccess dbA = new DataAccess();
                            string sql = "DELETE  tbl_BangLuong  WHERE MaNV='" + _MaNV + "' AND Thang ='" + cbbThang.Text + "' AND Nam='" + cbbNam.Text + "'";
                            int _ok = dbA.ExecuteData(sql);
                            if (_ok > 0)
                            {
                                //MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Có lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Có lỗi" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    i++;

                }
        }

        private void btnsuadoi_Click(object sender, EventArgs e)
        {
            edit();
            txtKhenThuong.Clear();
            txtTamUng.Clear();
            txtTienPhat.Clear();
        }
        private void edit()
        {
            try
            {
                DataAccess dbA = new DataAccess();
                String _MaNV = dgrvLoadLuong.CurrentRow.Cells[1].Value.ToString();


                string sql = "UPDATE tbl_BangLuong  SET TamUng ='" + txtTamUng.Text + "',KhenThuong='" + txtKhenThuong.Text + "',TienPhat='" + txtTienPhat.Text + "';"+
                       "UPDATE tbl_BangLuong SET LuongConLai=ThuNhapChinh+ThuNhapThem-KhoanTrichBH-ThueTNCN-TamUng + KhenThuong-TienPhat" +
                    " WHERE MaNV='" + _MaNV + "' AND Thang='"+cbbThang.Text+"'AND Nam='"+cbbNam.Text+"'";

                int i = dbA.ExecuteData(sql);
                if (i > 0)
                {
                    MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();

                }
                else
                {
                    MessageBox.Show("Có lỗi! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi! " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgrvLoadLuong_Click(object sender, EventArgs e)
        {
            txtTamUng.Text = dgrvLoadLuong.CurrentRow.Cells[6].Value.ToString();
            txtKhenThuong.Text = dgrvLoadLuong.CurrentRow.Cells[7].Value.ToString();
            txtTienPhat.Text = dgrvLoadLuong.CurrentRow.Cells[8].Value.ToString();
        }

        private void cbbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            String vFilter = " Where (1=1)";

            vFilter = vFilter + " AND Thang ='" + cbbThang.Text + "' AND Nam='" + cbbNam.Text + "'";


            //
            loadData(vFilter);
        }

        private void cbbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            String vFilter = " Where (1=1)";

            vFilter = vFilter + "  AND Nam='" + cbbNam.Text + "'";


            //
            loadData(vFilter);
        }

        private void cbbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            String vFilter = " Where (1=1)";

            vFilter = vFilter + " AND MaNV = '" + cbbMaNV.Text + "'  AND Thang ='" + cbbThang.Text + "' AND Nam='" + cbbNam.Text + "'";


            //
            loadData(vFilter);
        }

        private void btnhuybo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
