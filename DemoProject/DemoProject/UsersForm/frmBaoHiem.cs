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
    public partial class frmBaoHiem : Form
    {
        DataSet ds;
        public frmBaoHiem()
        {
            InitializeComponent();
        }

        private void frmKhoanTrich_Load(object sender, EventArgs e)
        {
            string year = Convert.ToString(DateTime.Today.ToString("yyyy/MM"));



            cbbNam.Text = year.Substring(0, 4);

            cbbThang.Text = year.Substring(5, 2);
            loadData();
            LoadNV();
        }
        private void loadData(string _Filter = "")
        {

            DataAccess dbA = new DataAccess();
            string sql = "SELECT MaNV as 'Mã Nhân Viên',TLBHYT as 'Tỷ Lệ BHYT',TLBHXH as'Tỷ Lệ BHXH' ,TLBHTN as' Tỷ Lệ BHTN' ,SoTien as' Số Tiền Phải Nộp', NgayCapNhat as'Ngày Cập Nhật' FROM tbl_BaoHiem " + _Filter + "ORDER BY NgayCapNhat DESC";
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
            dgrvBaoHiem.DataSource = bSource;
            dgrvBaoHiem.Columns[0].Width = 50;

            for (int i = 0; i < dgrvBaoHiem.Rows.Count - 1; i++)
            {
                dgrvBaoHiem.Rows[i].Cells["STT"].Value = i + 1;
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

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            addNew();
        }
        private void addNew()
        {
            try
            {
                DataAccess dbA = new DataAccess();
                string sql = "INSERT INTO tbl_BaoHiem(MaNV,Thang,Nam,TLBHYT,TLBHXH,TLBHTN,NgayCapNhat)VALUES " +
                    "('" + cbbMaNV.Text + "','" + cbbThang.Text + "','" + cbbNam.Text + "','" + txtBHYT.Text + "'," +
                    "'" + txtBHXH.Text + "','" + txtBHTN.Text + "','" + DateTime.Today.ToString("MM/dd/yyyy") + "');" +
                   "UPDATE tbl_BaoHiem SET SoTien = (  SELECT nv.LuongCS*(nv.HSL+nv.HSCV)*2.6 *(bh.TLBHYT+bh.TLBHXH+bh.TLBHTN )" +
                   "FROM tbl_NhanVien nv INNER JOIN tbl_BaoHiem bh ON nv.MaNV=bh.MaNV  WHERE nv.MaNV='"+cbbMaNV.Text+"' AND bh.Thang='"+cbbThang.Text+"' AND bh.Nam='"+cbbNam.Text+"' )"+
                   "WHERE MaNV='"+cbbMaNV.Text+"' AND Thang='"+cbbThang.Text+"' AND Nam='"+cbbNam.Text+"'";
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
                foreach (System.Windows.Forms.DataGridViewRow dgv in dgrvBaoHiem.SelectedRows)
                {
                    string _MaNV = dgv.Cells[1].Value.ToString().Trim();
                  

                    if (MessageBox.Show("Có chắc chắn xóa khoản trích BH của Nhân Viên " + _MaNV + " Tháng " + cbbThang.Text + " Năm "+cbbNam.Text+"' không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            int _rowIdx = dgv.Index;
                            //MessageBox.Show(dgvUsersrows.Index.ToString(), "TB");
                            ds.Tables[0].Rows.RemoveAt(dgv.Index);
                            dgrvBaoHiem.Refresh();

                            var result = dgrvBaoHiem.DataSource;
                            //result.RemoveAt(_rowIdx);
                            //dataGridView1.DataSource = result;

                            DataAccess dbA = new DataAccess();
                            string sql = "DELETE  tbl_BaoHiem  WHERE MaNV='" + _MaNV + "' AND Thang ='"+cbbThang.Text+"' AND Nam='"+cbbNam.Text+"'";
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

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            String vFilter = " Where (1=1)";

            vFilter = vFilter + " AND Thang ='" + cbbThang.Text + "' AND Nam='" + cbbNam.Text + "'";


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

        private void cbbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            String vFilter = " Where (1=1)";

            vFilter = vFilter + "  AND Nam='" + cbbNam.Text + "'";


            //
            loadData(vFilter);
        }
    }
}
