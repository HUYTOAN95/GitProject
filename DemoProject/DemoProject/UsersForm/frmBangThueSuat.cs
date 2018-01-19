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
    public partial class frmBangThueSuat : Form
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
        public frmBangThueSuat()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void frmBangThueSuat_Load(object sender, EventArgs e)
        {

            _pMode = "";
            ViewMode();
            loadData();
            AlignCenterToScreen();
            dgvthuesuat.EnableHeadersVisualStyles = false;
            dgvthuesuat.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSeaGreen;
            
        }
        private void loadData(string _Filter = "")
        {

            DataAccess dbA = new DataAccess();
            string sql = "SELECT Bac as'Bậc',Tu as'Từ',Den as' Đến',GiaTriTinh as'Giá trị',ThueSuat as'Thuế Suất' From tbl_ThueSuat " + _Filter ;
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
            dgvthuesuat.DataSource = bSource;
            dgvthuesuat.Rows[7].Visible = false;
            //chỉnh kích thước của cột



        }
        private void ViewMode()
        {
            switch (_pMode)
            {
                case "FIND":
                case "ADD":
                    grbbutton.Enabled = false;
                    grbdetail.Show();
                    dgvthuesuat.Enabled = false;
                    txtbac.Text = "";
                    txtGiatridu.Text="";
                    txtkhoangden.Text = "";
                    txtkhoangtu.Text = "";
                    txtthuesuat.Text = "";




                    this.Height = 400;
                    break;
                case "EDIT":
                    grbbutton.Enabled = false;
                    grbdetail.Show();
                    dgvthuesuat.Enabled = false;

                    //grBoxbtn.Enabled = false;
                    this.Height = 400;
                    //

                    txtbac.Text = dgvthuesuat.CurrentRow.Cells[0].Value.ToString();
                    txtkhoangtu.Text = dgvthuesuat.CurrentRow.Cells[1].Value.ToString();


                    txtkhoangden.Text = dgvthuesuat.CurrentRow.Cells[2].Value.ToString();
                    txtGiatridu.Text = dgvthuesuat.CurrentRow.Cells[3].Value.ToString();
                    txtthuesuat.Text = dgvthuesuat.CurrentRow.Cells[4].Value.ToString();






                    break;
                case "":
                    grbbutton.Enabled = true;
                    dgvthuesuat.Enabled = true;
                    grbdetail.Hide();
                    //grBoxbtn.Enabled = true;
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




                string sql = "insert into tbl_ThueSuat(Bac,Tu,Den,GiaTriTinh,ThueSuat)" +
                    "values ('" +txtbac.Text+ "','" + txtkhoangtu.Text + "','" + txtkhoangden.Text + "','" +txtGiatridu.Text + "','" +txtthuesuat.Text+ "')";
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
                String _MaBac = dgvthuesuat.CurrentRow.Cells[0].Value.ToString();


                string sql = "UPDATE tbl_ThueSuat SET  Tu ='" + txtkhoangtu.Text + "', Den='" + txtkhoangden.Text + "',GiaTriTinh='" + txtGiatridu.Text + "',ThueSuat='" + txtthuesuat.Text + "'" +
                    "where Bac='" + _MaBac + "'";

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

        private void btnghinhan_Click(object sender, EventArgs e)
        {
            switch (_pMode)
            {
                case "ADD":
                    addNew();
                    break;
                case "EDIT":
                    editData();
                    break;


                default:
                    break;
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

            int i = 0;
            if (ds.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK);
            }
            else
                foreach (System.Windows.Forms.DataGridViewRow dgv in dgvthuesuat.SelectedRows)
                {
                    string _MaBac = dgv.Cells[0].Value.ToString().Trim();


                    if (MessageBox.Show("Có chắc chắn xóa '" + _MaBac + " ' không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            int _rowIdx = dgv.Index;
                            //MessageBox.Show(dgvUsersrows.Index.ToString(), "TB");
                            ds.Tables[0].Rows.RemoveAt(dgv.Index);
                            dgvthuesuat.Refresh();

                            var result = dgvthuesuat.DataSource;
                            //result.RemoveAt(_rowIdx);
                            //dataGridView1.DataSource = result;

                            DataAccess dbA = new DataAccess();
                            string sql = "delete from tbl_ThueSuat where Bac = '" + _MaBac + "'";
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

        private void btnthem_Click(object sender, EventArgs e)
        {
            _pMode = "ADD";
            ViewMode();
            AlignCenterToScreen();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            _pMode = "EDIT";
            ViewMode();
            AlignCenterToScreen();
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

    }
}
