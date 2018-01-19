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

namespace DemoProject.UsersForm
{

    public partial class FrmBackup : Form
    {
        DataSet ds = new DataSet();
        protected void AlignCenterToScreen()
        {
            //grbdetailkhoabomon.Show();
            Screen screen = Screen.FromControl(this);

            Rectangle workingArea = screen.WorkingArea;
            this.Location = new Point()
            {
                X = Math.Max(workingArea.X, workingArea.X + (workingArea.Width - this.Width) / 2),
                Y = Math.Max(workingArea.Y, workingArea.Y + (workingArea.Height - this.Height) / 2)
            };
        }
        public FrmBackup()
        {
            InitializeComponent();
        }

        private void cbbselect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbselect.Text == "Nhân Viên")
            {
                String vFilter = " SELECT NgayHT as'Thời Gian Xóa ', MaNV as 'Mã Nhân Viên',HoTen as' Họ Tên',GioiTinh as' Giới tính',NgaySinh as' Ngày Sinh',NoiSinh as' Nơi Sinh',DCThuongTru as 'Thường Trú'," +
                "DanToc as' Dân Tộc',SDT,Gmail,TrinhDo as' Trình Độ',ChucVu as' Chức Vụ',Phong as' Phòng Ban',Ngach as' Ngạch',Bac as ' Bậc',MaSoThue as ' Mã Số Thuế',SNPhuThuoc as' Số NGười Phụ Thuộc', NgayVaoLam as ' Ngày Làm', GhiChu as ' Ghi Chú'   FROM tbl_NhanVien WHERE Xoa=0";

                // vFilter = vFilter + "WHERE Xoa = 0";

                loadData(vFilter);
            }
            else if (cbbselect.Text == "Phòng Ban")
            {
                String vFilter = "SELECT NgayHT as' Thời Gian Xóa ', MaPB as'Mã Phòng',TenPB as'Tên Phòng', SLNV as'Số Lượng Nhân Viên'   From tbl_PhongBan WHERE Xoa = 0";

                // vFilter = vFilter + "WHERE Xoa = 0";

                loadData(vFilter);
            }
        }
        private void loadData(string _Filter = "")
        {

            DataAccess dbA = new DataAccess();
            string sql = _Filter;
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
            dgvSelect.DataSource = bSource;
            dgvSelect.Columns[0].Width = 50;
            dgvSelect.Columns[1].Width = 150;

            for (int i = 0; i < dgvSelect.Rows.Count - 1; i++)
            {
                dgvSelect.Rows[i].Cells["STT"].Value = i + 1;
            }
            dgvSelect.EnableHeadersVisualStyles = false;
            dgvSelect.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSeaGreen;
        }

        private void FrmBackup_Load(object sender, EventArgs e)
        {
            AlignCenterToScreen();
        }

        private void btnrestore_Click(object sender, EventArgs e)
        {
            if (cbbselect.Text == "Nhân Viên")
            {
                String vquery = "UPDATE tbl_NhanVien SET Xoa = 1 WHERE MaNV ";
                   ;

                // vFilter = vFilter + "WHERE Xoa = 0";

                Restore(vquery);
            }
            else if (cbbselect.Text == "Phòng Ban")
            {
                String vquery = "UPDATE tbl_PhongBan SET Xoa = 1 WHERE MaPB";

                // vFilter = vFilter + "WHERE Xoa = 0";

                Restore(vquery);
            }
        }
        private void Restore(string _query = "")
        {
            foreach (System.Windows.Forms.DataGridViewRow dgv in dgvSelect.SelectedRows)
            {
                string _Ma = dgv.Cells[2].Value.ToString().Trim();
                string _Ten = dgv.Cells[3].Value.ToString().Trim();

                if (MessageBox.Show("Có chắc chắn Restore '" + _Ma + " - " + _Ten + "' vào bộ dữ liệu không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        int _rowIdx = dgv.Index;
                        //MessageBox.Show(dgvUsersrows.Index.ToString(), "TB");
                        ds.Tables[0].Rows.RemoveAt(dgv.Index);
                        dgvSelect.Refresh();

                        var result = dgvSelect.DataSource;
                        //result.RemoveAt(_rowIdx);
                        //dataGridView1.DataSource = result;

                        DataAccess dbA = new DataAccess();
                        string sql = _query + "= '" + _Ma + "';" + "UPDATE tbl_ChamCongNew SET Xoa= 1 Where MaNV ='"+_Ma+"'";
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


            }
        }

        private void btndelete_Click(object sender, EventArgs e)

        {
            if (cbbselect.Text == "Nhân Viên")
            {
                String vdelete = "DELETE FROM tbl_NhanVien WHERE MaNV";
                   

                // vFilter = vFilter + "WHERE Xoa = 0";

                Delete(vdelete);
            }
            else if (cbbselect.Text == "Phòng Ban")
            {
                String vdelete = "DELETE FROM tbl_PhongBan  WHERE MaPB";

                // vFilter = vFilter + "WHERE Xoa = 0";

                Delete(vdelete);
            }
        }
        private void Delete(string _delete = "")
        {
            try
            {
                foreach (System.Windows.Forms.DataGridViewRow dgv in dgvSelect.SelectedRows)
                {
                    string _Ma = dgv.Cells[2].Value.ToString().Trim();
                    string _Ten = dgv.Cells[3].Value.ToString().Trim();

                    if (MessageBox.Show("Có chắc chắn Xóa Bỏ '" + _Ma + " - " + _Ten + "' Khỏi bộ dữ liệu không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            int _rowIdx = dgv.Index;
                            //MessageBox.Show(dgvUsersrows.Index.ToString(), "TB");
                            ds.Tables[0].Rows.RemoveAt(dgv.Index);
                            dgvSelect.Refresh();

                            var result = dgvSelect.DataSource;
                            //result.RemoveAt(_rowIdx);
                            //dataGridView1.DataSource = result;

                            DataAccess dbA = new DataAccess();
                            string sql = _delete + "= '" + _Ma + "';" + "DELETE FROM tbl_ChamCongNew WHERE MaNV='"+_Ma+"' ";
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
                }
            }






            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    




        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
