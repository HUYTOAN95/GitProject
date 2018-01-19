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
    public partial class frmchucvu : Form
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

        public frmchucvu()
        {
            InitializeComponent();
        }

        private void frmchucvu_Load(object sender, EventArgs e)
        {
            _pMode = "";
            ViewMode();
            loadData();
            AlignCenterToScreen();
            dgvchucvu.EnableHeadersVisualStyles = false;
            dgvchucvu.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSeaGreen;
        }
        private void loadData(string _Filter = "")
        {

            DataAccess dbA = new DataAccess();
            string sql = "select MaCV as' Mã chức Vụ', TenCV as'Tên Chức Vụ',HSCV as'Hệ Số Chức Vụ' From tbl_ChucVu " + _Filter;
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
            dgvchucvu.DataSource = bSource;
            //chỉnh kích thước của cột
            dgvchucvu.Columns[0].Width = 100;
            dgvchucvu.Columns[1].Width = 200;
            dgvchucvu.Columns[2].Width = 200;

        }
        private void ViewMode()
        {
            switch (_pMode)
            {
                case "FIND":
                case "ADD":
                    grbbutton.Enabled = false;
                    grbdetail.Show();
                   txtmachucvu.Text = "";
                  txttenchucvu.Text= "";
                   txtheso.Text = "";
                    

                    this.Height = 450;
                    break;
                case "EDIT":
                    grbbutton.Enabled = false;
                    grbdetail.Show();
                    dgvchucvu.Enabled = false;
                    this.Height = 450;
                    txtmachucvu.Text = dgvchucvu.CurrentRow.Cells[0].Value.ToString();
                    txttenchucvu.Text = dgvchucvu.CurrentRow.Cells[1].Value.ToString();
                    txtheso.Text = dgvchucvu.CurrentRow.Cells[2].Value.ToString();
                


                    break;
                case "":
                    grbbutton.Enabled = true;
                    grbdetail.Hide();
                    dgvchucvu.Enabled = true;

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
                string sql = "insert into tbl_ChucVu(MaCV,TenCV,HSCV) values('" + txtmachucvu.Text + "',N'" + txttenchucvu.Text + "','" + txtheso.Text + "')";
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
                String _MaCV = dgvchucvu.CurrentRow.Cells[0].Value.ToString();


                string sql = "UPDATE tbl_ChucVu SET TenCV =N'" + txttenchucvu.Text + "',HSCV='" + txtheso.Text + "' where MaCV='" + _MaCV + "'";

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

        private void btnxoa_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (ds.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK);
            }
            else
                foreach (System.Windows.Forms.DataGridViewRow dgv in dgvchucvu.SelectedRows)
                {
                    string _MaCV = dgv.Cells[0].Value.ToString().Trim();
                    string _TenCV = dgv.Cells[1].Value.ToString().Trim();

                    if (MessageBox.Show("Có chắc chắn xóa '" + _MaCV + " - " + _TenCV + "' không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            int _rowIdx = dgv.Index;
                            //MessageBox.Show(dgvUsersrows.Index.ToString(), "TB");
                            ds.Tables[0].Rows.RemoveAt(dgv.Index);
                            dgvchucvu.Refresh();

                            var result = dgvchucvu.DataSource;
                            //result.RemoveAt(_rowIdx);
                            //dataGridView1.DataSource = result;

                            DataAccess dbA = new DataAccess();
                            string sql = "delete From tbl_ChucVu where MaCV = '" + _MaCV + "'";
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
                    if (txtmachucvu.Text != "")
                    {
                        vFilter = vFilter + " and MaCV like'%" + txtmachucvu.Text + "%'";
                    }
                    if (txttenchucvu.Text != "")
                    {
                        vFilter = vFilter + " and TenCV like'%" + txttenchucvu.Text + "%'";
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

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            _pMode = "FIND";
            ViewMode();
            AlignCenterToScreen();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
