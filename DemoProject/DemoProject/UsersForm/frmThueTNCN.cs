using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoProject.DAL;
using DemoProject.SO;
using System.Data.SqlClient;

namespace DemoProject.UsersForm
{
    public partial class frmThueTNCN : Form
    {
        DataSet ds;
        public frmThueTNCN()
        {
            InitializeComponent();
        }

        private void frmThueTNCN_Load(object sender, EventArgs e)
        {
            string year = Convert.ToString(DateTime.Today.ToString("yyyy/MM"));



            cbbNam.Text = year.Substring(0, 4);

            cbbthang.Text = year.Substring(5, 2);
            loadData();
            LoadNV();
            LoadMST();
        }
        private void loadData(string _Filter = "")
        {

            DataAccess dbA = new DataAccess();
            string sql = "SELECT MaSoThue as'Mã Số Thuế',MaNV as'Mã Nhân Viên',TongThuNhap as'Tổng Thu Nhập',ThuNhapMienThue as'Thu Nhập Miễn Thuê',"+
                "ThuNhapChiuThue as' Thu Nhập Chịu Thuế',BHBB'Bảo Hiểm Bắt Buộc',BanThan as'Số Tiền Giảm trừ bản Thân',SoGiam as'Số Tiền Giảm trừ Phụ Thuộc',"+
                "SoNguoi as'Số Người Phụ Thuộc',ThuNhapTinhThue as 'Thu Nhập Tính Thuế',ThueSuat as'Thuế Suất',ThueThuNhapCaNhan as'Thuế Thu Nhập Cá Nhân',"+
                "NgayCapNhat as'Ngày Cập Nhât' FROM tbl_ThueTNCN " + _Filter;
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
            dgrvThueTNCN.DataSource = bSource;
            dgrvThueTNCN.Columns[0].Width = 50;

            for (int i = 0; i < dgrvThueTNCN.Rows.Count - 1; i++)
            {
                dgrvThueTNCN.Rows[i].Cells["STT"].Value = i + 1;
            }
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
        private void LoadMST()
        {
            try
            {
                SqlConnection cnn = new SqlConnection(MyApp.MSSQLConnectionString);
                string sql = "SELECT MaSoThue,SNPhuThuoc  FROM tbl_NhanVien WHERE  MaNV='" + cbbMaNV.Text+"'";
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sql, cnn);

                //SqlDataAdapter da = new SqlDataAdapter(cmd);

                SqlDataReader dr = cmd.ExecuteReader();
                //DataSet ds = new DataSet();



                if (dr.Read())
                {
                    txtMaSoThue.Text = dr[0].ToString();
                    txtSNPT.Text = dr[1].ToString();
                }
            }
            catch (Exception es)
            {
                MessageBox.Show("Có lỗi" + es.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMST();
            String vFilter = " Where (1=1)";

            vFilter = vFilter + " AND MaNV = '" + cbbMaNV.Text + "'  AND Thang ='" + cbbthang.Text + "' AND Nam='" + cbbNam.Text + "'";


            //
            loadData(vFilter);
        }
        private void addNew()
        {
            try
            {
                DataAccess dbA = new DataAccess();
                string sql = "INSERT INTO tbl_ThueTNCN(MaSoThue,MaNV,Thang,Nam,BanThan,SoNguoi,SoGiam,NgayCapNhat)VALUES " +
                    "('" + txtMaSoThue.Text + "','" + cbbMaNV.Text + "','" + cbbthang.Text + "','" + cbbNam.Text + "','" + txtGTBT.Text + "'," +
                    "'" + txtSNPT.Text + "','" + txtGTPT.Text + "','" + DateTime.Today.ToString("MM/dd/yyyy") + "');" +
                    " UPDATE  tbl_ThueTNCN SET " +
                    "TongThuNhap =(SELECT DISTINCT ROUND(U.LuongCS*(U.HSCV+U.HSL)*2.6/22*U.SoNL + ng.ThuNhap,0) FROM tbl_NgoaiGio ng " +
                    "INNER JOIN (SELECT nv.HSL,nv.HSCV, nv.MaNV,nv.LuongCS,cc.SoNL FROM tbl_NhanVien nv INNER JOIN tbl_ChamCongNew cc ON nv.MaNV=cc.MaNV " +
                    "WHERE nv.MaNV='" + cbbMaNV.Text + "'AND cc.Thang='" + cbbthang.Text + "' AND cc.Nam='" + cbbNam.Text + "' ) AS U ON U.MaNV=ng.MaNV " +
                    "WHERE U.MaNV ='" + cbbMaNV.Text + "'AND ng.Thang='" + cbbthang.Text + "'AND ng.Nam='" + cbbNam.Text + "')," +
                     "ThuNhapMienThue=(SELECT ThuNhap FROM tbl_NgoaiGio  WHERE MaNV='" + cbbMaNV.Text + "' AND Nam='" + cbbNam.Text + "' AND Thang='" + cbbthang.Text + "' )" +
                     "WHERE MaNV='" + cbbMaNV.Text + "' AND Nam='" + cbbNam.Text + "' AND Thang='" + cbbthang.Text + "';" +
                   " UPDATE tbl_ThueTNCN SET ThuNhapChiuThue= TongThuNhap-ThuNhapMienThue ," +
                    "BHBB =(SELECT SoTien FROM tbl_BaoHiem WHERE MaNV ='" + cbbMaNV.Text + "' AND Thang='" + cbbthang.Text + "' AND Nam='" + cbbNam.Text + "')" +
                      "WHERE MaNV='" + cbbMaNV.Text + "' AND Nam='" + cbbNam.Text + "' AND Thang='" + cbbthang.Text + "';" +

                     " UPDATE tbl_ThueTNCN SET ThuNhapTinhThue =ThuNhapChiuThue-BanThan-SoGiam*SoNguoi " +
                      "WHERE MaNV='" + cbbMaNV.Text + "' AND Nam='" + cbbNam.Text + "' AND Thang='" + cbbthang.Text + "';" +
                     " UPDATE tbl_ThueTNCN SET  ThueSuat = (SELECT ThueSuat FROM tbl_ThueSuat WHERE tbl_ThueTNCN.ThuNhapTinhThue >=Tu AND tbl_ThueTNCN.ThuNhapTinhThue<=Den)," +
                     "GiaTri = (SELECT GiaTriTinh  FROM tbl_ThueSuat WHERE tbl_ThueTNCN.ThuNhapTinhThue >=Tu AND tbl_ThueTNCN.ThuNhapTinhThue<=Den)" +
                     "WHERE MaNV='" + cbbMaNV.Text + "' AND Nam='" + cbbNam.Text + "' AND Thang='" + cbbthang.Text + "';" +
                     "UPDATE tbl_ThueTNCN SET  ThueThuNhapCaNhan=ROUND(ThuNhapTinhThue*ThueSuat+GiaTri,0) " +
                     "WHERE MaNV='" + cbbMaNV.Text + "' AND Nam='" + cbbNam.Text + "' AND Thang='" + cbbthang.Text + "'";
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

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            addNew();
            txtSNPT.Clear();
           
        }

        private void cbbthang_SelectedIndexChanged(object sender, EventArgs e)
        {
            String vFilter = " Where (1=1)";

            vFilter = vFilter + " AND Thang ='" + cbbthang.Text + "' AND Nam='" + cbbNam.Text + "'";


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

        private void btnxoa_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (ds.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK);
            }
            else
                foreach (System.Windows.Forms.DataGridViewRow dgv in dgrvThueTNCN.SelectedRows)
                {
                    string _MaNV = dgv.Cells[2].Value.ToString().Trim();


                    if (MessageBox.Show("Có chắc chắn xóa Thuế Thu Nhập CN của Nhân Viên " + _MaNV + " Tháng " + cbbthang.Text + " Năm " + cbbNam.Text + "' không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            int _rowIdx = dgv.Index;
                            //MessageBox.Show(dgvUsersrows.Index.ToString(), "TB");
                            ds.Tables[0].Rows.RemoveAt(dgv.Index);
                            dgrvThueTNCN.Refresh();

                            var result = dgrvThueTNCN.DataSource;
                            //result.RemoveAt(_rowIdx);
                            //dataGridView1.DataSource = result;

                            DataAccess dbA = new DataAccess();
                            string sql = "DELETE  tbl_ThueTNCN  WHERE MaNV='" + _MaNV + "' AND Thang ='" + cbbthang.Text + "' AND Nam='" + cbbNam.Text + "'";
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
