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

namespace DemoProject.SystemForm
{
    public partial class frmPhongBan : Form
    {
        DataSet ds = new DataSet();
        string _pMode = "";
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
        public frmPhongBan()
        {
            InitializeComponent();
        }

        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            _pMode = "";
            ViewMode();
            String vFilter = " Where (1=1)";

            vFilter = vFilter + " AND Xoa=1 ";

            loadData(vFilter);
            AlignCenterToScreen();
            dgvPhongBan.EnableHeadersVisualStyles = false;
            dgvPhongBan.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSeaGreen;
        }
        private void loadData(string _Filter = "")
        {

            DataAccess dbA = new DataAccess();
            string sql = "SELECT MaPB as'Mã Phòng',TenPB as'Tên Phòng', SLNV as'Số Lượng Nhân Viên'  From tbl_PhongBan  " + _Filter;
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
            dgvPhongBan.DataSource = bSource;
            //chỉnh kích thước của cột
            dgvPhongBan.Columns[0].Width = 100;
            dgvPhongBan.Columns[1].Width = 200;
            dgvPhongBan.Columns[2].Width = 200;

        }
        private void ViewMode()
        {
            switch (_pMode)
            {
                case "FIND":
                case "ADD":
                    grbbutton.Enabled = false;
                    grbdetail.Show();
                   txtmaphong.Text = "";
                   txttenphong.Text = "";
                    
                    //dExpiredDate.Text = DateTime.Now;

                    this.Height = 450;
                    break;
                case "EDIT":
                    grbbutton.Enabled = false;
                    grbdetail.Show();
                    dgvPhongBan.Enabled = false;
                    this.Height = 450;
                    txtmaphong.Text = dgvPhongBan.CurrentRow.Cells[0].Value.ToString();
                    txttenphong.Text = dgvPhongBan.CurrentRow.Cells[1].Value.ToString();
                   


                    break;
                case "":
                    grbbutton.Enabled = true;
                    grbdetail.Hide();
                    dgvPhongBan.Enabled = true;

                    this.Height = 340;
                    break;
                default:
                    break;
            }
        }
        private void addNew()
        {
            try
            {
                DataAccess dbA = new DataAccess();
                string sql = "insert into tbl_PhongBan(MaPB,TenPB) values('" + txtmaphong.Text + "',N'" + txttenphong.Text + "')";
                int i = dbA.ExecuteData(sql);
                if (i > 0)
                {
                    //MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                    loadData();
                    _pMode = "";
                    ViewMode();
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
        private void editData()
        {
            try
            {
                DataAccess dbA = new DataAccess();
                String _MaPhong = dgvPhongBan.CurrentRow.Cells[0].Value.ToString();


                string sql = "UPDATE tbl_PhongBan SET TenPB =N'" + txttenphong.Text + "' where MaPB='" + _MaPhong + "'";

                int i = dbA.ExecuteData(sql);
                if (i > 0)
                {
                    //MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                    _pMode = "";
                    ViewMode();
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

        private void btnsua_Click(object sender, EventArgs e)
        {
            _pMode = "EDIT";
            ViewMode();
            AlignCenterToScreen();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            _pMode = "FIND";
            ViewMode();
            AlignCenterToScreen();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (ds.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK);
            }
            else
                foreach (System.Windows.Forms.DataGridViewRow dgv in dgvPhongBan.SelectedRows)
                {
                    string _MaPhong = dgv.Cells[0].Value.ToString().Trim();
                    string _TenPhong = dgv.Cells[1].Value.ToString().Trim();

                    if (MessageBox.Show("Có chắc chắn xóa '" + _MaPhong + " - " + _TenPhong + "' không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            int _rowIdx = dgv.Index;
                            //MessageBox.Show(dgvUsersrows.Index.ToString(), "TB");
                            ds.Tables[0].Rows.RemoveAt(dgv.Index);
                            dgvPhongBan.Refresh();

                            var result = dgvPhongBan.DataSource;
                            //result.RemoveAt(_rowIdx);
                            //dataGridView1.DataSource = result;

                            DataAccess dbA = new DataAccess();
                            string sql = "UPDATE  tbl_PhongBan SET Xoa = '0' WHERE MaPB='"+_MaPhong+"'";
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

        private void btnhuybo_Click(object sender, EventArgs e)
        {
            _pMode = "";
            ViewMode();
            AlignCenterToScreen();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            _pMode = "ADD";
            ViewMode();
            AlignCenterToScreen();
        }

        private void btnghinhan_Click(object sender, EventArgs e)
        {

            switch (_pMode)
            {
                case "ADD":
                    addNew();
                    break;
                case "EDIT":
                    editData();
                    //
                    break;
                case "FIND":
                    String vFilter = " Where (1=1)";
                    if (txtmaphong.Text != "")
                    {
                        vFilter = vFilter + " and MaPB like'%" + txtmaphong.Text + "%'";
                    }
                    if (txttenphong.Text!= "")
                    {
                        vFilter = vFilter + " and TenPB like'%" + txttenphong.Text + "%'";
                    }

                    //
                    loadData(vFilter);
                    _pMode = "";
                    ViewMode();
                    //
                    break;
                default:
                    break;
            }
        }

        private void btnbophan_Click(object sender, EventArgs e)
        {

            frmnguoiquanly frm = new frmnguoiquanly();
            frm._Maphong  = dgvPhongBan.CurrentRow.Cells[0].Value.ToString();
            frm._Tenphong = dgvPhongBan.CurrentRow.Cells[1].Value.ToString();
            frm.ShowDialog();
        }
    }
}
