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
    public partial class frmNgach : Form
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
        public frmNgach()
        {
            InitializeComponent();
        }

       

        private void frmNgach_Load(object sender, EventArgs e)
        {
            _pMode = "";
            ViewMode();
            loadData();
            AlignCenterToScreen();
            dgvNgach.EnableHeadersVisualStyles = false;
            dgvNgach.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSeaGreen;
        }
        private void loadData(string _Filter = "")
        {
          
            DataAccess dbA = new DataAccess();
            string sql = "select MaNgach as'Mã Ngạch',Loai as'Loại Công Chức', Nhom as'Nhóm' From tbl_Ngach" + _Filter;
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
            dgvNgach.DataSource = bSource;
            //chỉnh kích thước của cột
            dgvNgach.Columns[0].Width = 100;
            dgvNgach.Columns[1].Width = 200;
            dgvNgach.Columns[2].Width = 100;
            
        }
        private void ViewMode()
        {
            switch (_pMode)
            {
                case "FIND":
                case "ADD":
                    grbbutton.Enabled = false;
                    grbdetail.Show();
                    txtmangach.Text = "";
                    txttenngach.Text = "";
                    txtghichu.Text = "";

                    //dExpiredDate.Text = DateTime.Now;

                    this.Height = 450;
                    break;
                case "EDIT":
                    grbbutton.Enabled = false;
                    grbdetail.Show();
                    dgvNgach.Enabled = false;
                    this.Height = 450;
                    txtmangach.Text = dgvNgach.CurrentRow.Cells[0].Value.ToString();
                    txttenngach.Text = dgvNgach.CurrentRow.Cells[1].Value.ToString();
                    txtghichu.Text = dgvNgach.CurrentRow.Cells[2].Value.ToString();


                    break;
                case "":
                    grbbutton.Enabled = true;
                    grbdetail.Hide();
                    dgvNgach.Enabled = true;

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
                string sql = "insert into tbl_Ngach(MaNgach,Loai,Nhom) values('" + txtmangach.Text + "',N'" + txttenngach.Text + "',N'" + txtghichu.Text + "')";
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
                    if (txtmangach.Text != "")
                    {
                        vFilter = vFilter + " and MaNgach like'%" + txtmangach.Text + "%'";
                    }
                    if (txttenngach.Text != "")
                    {
                        vFilter = vFilter + " and Loai like'%" + txttenngach.Text + "%'";
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
        private void editData()
        {
            try
            {
                DataAccess dbA = new DataAccess();
                String _MaNgach = dgvNgach.CurrentRow.Cells[0].Value.ToString();


                string sql = "UPDATE tbl_Ngach SET Loai =N'" + txttenngach.Text + "',Nhom =N'" + txtghichu.Text + "' where MaNgach='" + _MaNgach + "'";

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
                foreach (System.Windows.Forms.DataGridViewRow dgv in dgvNgach.SelectedRows)
                {
                    string _MaNgach = dgv.Cells[0].Value.ToString().Trim();
                    string _TenNgach = dgv.Cells[1].Value.ToString().Trim();

                    if (MessageBox.Show("Có chắc chắn xóa '" + _MaNgach + " - " + _TenNgach + "' không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            int _rowIdx = dgv.Index;
                            //MessageBox.Show(dgvUsersrows.Index.ToString(), "TB");
                            ds.Tables[0].Rows.RemoveAt(dgv.Index);
                            dgvNgach.Refresh();

                            var result = dgvNgach.DataSource;
                            //result.RemoveAt(_rowIdx);
                            //dataGridView1.DataSource = result;

                            DataAccess dbA = new DataAccess();
                            string sql = "delete From tbl_Ngach where MaNgach = '" + _MaNgach + "'";
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

        private void btnbac_Click(object sender, EventArgs e)
        {
            frmBac frm = new frmBac();
            frm._MaNgach = dgvNgach.CurrentRow.Cells[0].Value.ToString();
            frm._TenNgach = dgvNgach.CurrentRow.Cells[1].Value.ToString();
            frm.ShowDialog();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
          
        }
    }
}
