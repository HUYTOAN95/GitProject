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
    public partial class FrmBangChamCong : Form
    {
        DataSet ds;
        public FrmBangChamCong()
        {
            InitializeComponent();
        }

        private void FrmBangChamCong_Load(object sender, EventArgs e)
        {
            string year = Convert.ToString(DateTime.Today.ToString("yyyy/MM"));



            cbbNam.Text = year.Substring(0, 4);

            cbbthang.Text = year.Substring(5, 2);

            loadcbbmasv();
            String vFilter = " Where (1=1)";

            vFilter = vFilter + " AND MaNV like'%" + cbbMaNV.Text + "%' AND MONTH(NgayCapNhat) = " + cbbthang.Text + " AND YEAR(NgayCapNhat)=" + cbbNam.Text + " AND Xoa=1 ";

            //
            loadData(vFilter);
            loadNgayCong();
            loadNgayNghi();
        }
        private void loadData(string _Filter = "")
        {

            DataAccess dbA = new DataAccess();
            string sql = "SELECT MaNV as'Mã Nhân Viên',HoTen as'Họ Tên', ChucVu as' Chức Vụ', PhongBan as'Phòng Ban',NgayLamViec as'Ngày Công',NgayCapNhat as'Ngày Làm'" +
                "From tbl_ChamCongNew " + _Filter + "ORDER BY NgayCapNhat DESC ";
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
            dgrvBangChamCong.DataSource = bSource;
            dgrvBangChamCong.Columns[0].Width = 50;

            for (int i = 0; i < dgrvBangChamCong.Rows.Count - 1; i++)
            {
                dgrvBangChamCong.Rows[i].Cells["STT"].Value = i + 1;
            }
        }
        private void loadcbbmasv()
        { try
            {
                SqlConnection cnn = new SqlConnection(MyApp.MSSQLConnectionString);
                DataGridViewComboBoxColumn col = new DataGridViewComboBoxColumn();
                col.HeaderText = "Mã NV";
                col.Name = "MaNV";

                //load dữ liệu

                string sql = "SELECT MaNV FROM tbl_NhanVien WHERE Xoa =  1";
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
        private void loadNgayCong()
        {
            try
            {
                SqlConnection cnn = new SqlConnection(MyApp.MSSQLConnectionString);
                cnn.Open();
                string sql = "SELECT DISTINCT COUNT(NgayLamViec) FROM tbl_ChamCongNew WHERE " +
                    "MaNV ='" + cbbMaNV.Text + "' AND Xoa =1 AND Thang = " + cbbthang.Text + " AND Nam =" + cbbNam.Text + " AND (NgayLamViec = 'C'  OR  NgayLamViec = 'P' ) ;" +
                    "UPDATE tbl_ChamCongNew SET SoNL = (SELECT DISTINCT COUNT(NgayLamViec) FROM tbl_ChamCongNew WHERE MaNV ='" + cbbMaNV.Text + "' AND Xoa =1 AND Thang = '" + cbbthang.Text + "' AND Nam ='" + cbbNam.Text + "' AND (NgayLamViec = 'C'  OR  NgayLamViec = 'P' ))" +
                    "WHERE MaNV ='" + cbbMaNV.Text + "'AND Thang = '" + cbbthang.Text + "' AND Nam ='" + cbbNam.Text + "' ";




                SqlCommand cmd = new SqlCommand(sql, cnn);
                //SqlDataAdapter da = new SqlDataAdapter(cmd);

                SqlDataReader dr = cmd.ExecuteReader();
                //DataSet ds = new DataSet();



                if (dr.Read())
                {
                    txtconglam.Text = dr[0].ToString();
                }
            }
            catch (Exception es)
            {
                MessageBox.Show("Có lỗi" + es.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void loadNgayNghi()
        {
            try
            {
                SqlConnection cnn = new SqlConnection(MyApp.MSSQLConnectionString);
                cnn.Open();
                string sql = "SELECT DISTINCT COUNT(NgayLamViec) FROM tbl_ChamCongNew WHERE " +
                    "MaNV ='" + cbbMaNV.Text + "' AND Xoa =1 AND Thang = " + cbbthang.Text + " AND Nam =" + cbbNam.Text + " AND NgayLamViec = 'K' ;" +
                    "UPDATE tbl_ChamCongNew SET SoNN = (SELECT DISTINCT COUNT(NgayLamViec) FROM tbl_ChamCongNew WHERE MaNV ='" + cbbMaNV.Text + "' AND Xoa =1 AND Thang = '" + cbbthang.Text + "' AND Nam ='" + cbbNam.Text + "' AND NgayLamViec = 'K')" +
                    "WHERE MaNV ='" + cbbMaNV.Text + "' AND Thang = '" + cbbthang.Text + "' AND Nam ='" + cbbNam.Text + "' ";


                SqlCommand cmd = new SqlCommand(sql, cnn);
                //SqlDataAdapter da = new SqlDataAdapter(cmd);

                SqlDataReader dr = cmd.ExecuteReader();
                //DataSet ds = new DataSet();



                if (dr.Read())
                {
                    txtsongaynghi.Text = dr[0].ToString();
                }
            }
            catch (Exception es)
            {
                MessageBox.Show("Có lỗi" + es.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cbbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            String vFilter = " Where (1=1)";

            vFilter = vFilter + " AND MaNV like'%" + cbbMaNV.Text + "%' AND MONTH(NgayCapNhat) = " + cbbthang.Text + " AND YEAR(NgayCapNhat)=" + cbbNam.Text + "AND Xoa=1";

            //
            loadData(vFilter);
            loadNgayCong();
            loadNgayNghi();
        }

        private void cbbthang_SelectedIndexChanged(object sender, EventArgs e)
        {
            String vFilter = " Where (1=1)";

            vFilter = vFilter + " AND Thang = " + cbbthang.Text + " AND Nam=" + cbbNam.Text + "AND Xoa=1";

            //
            loadData(vFilter);
            loadNgayCong();
            loadNgayNghi();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

            int i = 0;
            if (ds.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK);
            }
            else
                foreach (System.Windows.Forms.DataGridViewRow dgv in dgrvBangChamCong.SelectedRows)
                {
                    string _MaNV = dgv.Cells[1].Value.ToString().Trim();
                    string _NgayCapNhat= dgv.Cells[6].Value.ToString().Trim();


                    if (MessageBox.Show("Có chắc chắn xóa ngày làm việc của Nhân Viên " + _MaNV + " Ngày "+_NgayCapNhat+" Tháng " + cbbthang.Text + " Năm " + cbbNam.Text + " không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            int _rowIdx = dgv.Index;
                            //MessageBox.Show(dgvUsersrows.Index.ToString(), "TB");
                            ds.Tables[0].Rows.RemoveAt(dgv.Index);
                            dgrvBangChamCong.Refresh();

                            var result = dgrvBangChamCong.DataSource;
                            //result.RemoveAt(_rowIdx);
                            //dataGridView1.DataSource = result;

                            DataAccess dbA = new DataAccess();
                            string sql = "DELETE  tbl_ChamCongNew  WHERE MaNV='" + _MaNV + "' AND NgayCapNhat='"+_NgayCapNhat+"'AND Thang ='" + cbbthang.Text + "' AND Nam='" + cbbNam.Text + "'";
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
            editData();
        }
        private void editData()
        {
            try
            {
                foreach (System.Windows.Forms.DataGridViewRow dgv in dgrvBangChamCong.SelectedRows)
                {
                    DataAccess dbA = new DataAccess();
                    string _MaNV = dgv.Cells[1].Value.ToString().Trim();
                    string _NgayCapNhat = dgv.Cells[6].Value.ToString().Trim();
                    if (MessageBox.Show("Có chắc chắn Sửa Ngày Công  của Nhân Viên " + _MaNV + " Ngày " + _NgayCapNhat + " Tháng " + cbbthang.Text + " Năm " + cbbNam.Text + " không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string sql = "UPDATE tbl_ChamCongNew SET NgayLamViec ='" + dgv.Cells[5].Value.ToString().Trim() + "' WHERE MaNV='" + _MaNV + "' AND NgayCapNhat='" + _NgayCapNhat + "'AND Thang ='" + cbbthang.Text + "' AND Nam='" + cbbNam.Text + "'";

                        int i = dbA.ExecuteData(sql);
                        if (i > 0)
                        {
                            MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadData();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnxpatatca_Click(object sender, EventArgs e)
        {
            
                if (MessageBox.Show("Có chắc chắn Xóa tất cả Ngày công  của Nhân Viên " + cbbMaNV.Text+ "  Tháng " + cbbthang.Text + " Năm " + cbbNam.Text + " không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DataAccess dbA = new DataAccess();
                    string sql = "DELETE  tbl_ChamCongNew   WHERE MaNV='" + cbbMaNV.Text + "' AND Thang ='" + cbbthang.Text + "' AND Nam='" + cbbNam.Text + "'";

                    int i = dbA.ExecuteData(sql);
                    if (i > 0)
                    {
                        MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();

                    }
                }
                else
                {
                    MessageBox.Show("Có lỗi! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
           
        }
    }
}
