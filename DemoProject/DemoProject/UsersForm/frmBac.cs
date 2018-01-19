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
    public partial class frmBac : Form
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
        public frmBac()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        public string _MaNgach { get; set; }
        public string _TenNgach { get; set; }
        private void frmBac_Load(object sender, EventArgs e)
        {
            _pMode = "";
            ViewMode();
            loadData();
            AlignCenterToScreen();
            dgvBac.EnableHeadersVisualStyles = false;
            dgvBac.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSeaGreen;
            cbbmangach.Text = _MaNgach;
            this.Text = "Danh Sách Bậc Lương Của Ngạch_" + _TenNgach + "";
        }
        private void loadData(string _Filter = "")
        {

            DataAccess dbA = new DataAccess();
            string sql = "select Bac as'Mã Bậc',HSLuong as'Hệ Số Lương',TuNgay as'Áp Dụng Ngày', DenNgay as'Đến Ngày', MaNgach as'Mã Ngạch' From tbl_Bac where MaNgach='" + _MaNgach + "'";
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
            dgvBac.DataSource = bSource;
            //chỉnh kích thước của cột
            dgvBac.Columns[0].Width = 100;
            dgvBac.Columns[1].Width = 50;
            dgvBac.Columns[2].Width = 100;
            dgvBac.Columns[3].Width = 100;
            dgvBac.Columns[4].Width = 50;

        }
        private void ViewMode()
        {
            switch (_pMode)
            {
                case "FIND":
                case "ADD":
                    grbbutton.Enabled = false;
                    grbdetail.Show();
                    txtmabac.Text = "";
                    txtHeSoLuong.Text = "";
                  
                    //dExpiredDate.Text = DateTime.Now;

                    this.Height = 400;
                    break;
                case "EDIT":
                    grbbutton.Enabled = false;
                    grbdetail.Show();
                    dgvBac.Enabled = false;
                    this.Height = 400;
                    txtmabac.Text = dgvBac.CurrentRow.Cells[0].Value.ToString();
                    txtHeSoLuong.Text = dgvBac.CurrentRow.Cells[1].Value.ToString();
                    dtpkTuNgay.Text = dgvBac.CurrentRow.Cells[2].Value.ToString();
                    dtpkDenNgay.Text = dgvBac.CurrentRow.Cells[3].Value.ToString();


                    break;
                case "":
                    grbbutton.Enabled = true;
                    grbdetail.Hide();
                    dgvBac.Enabled = true;

                    this.Height = 280;
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
                string sql = "insert into tbl_Bac(Bac,HSLuong,TuNgay,DenNgay,MaNgach) values(N'" + txtmabac.Text + "','" + txtHeSoLuong.Text + "',"+
                    "'" + dtpkTuNgay.Value.ToString("MM/dd/yyyy") + "','" + dtpkDenNgay.Value.ToString("MM/dd/yyyy") + "','" + cbbmangach.Text + "')";
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
                String _MaBac = dgvBac.CurrentRow.Cells[0].Value.ToString();


                string sql = "UPDATE tbl_Bac SET HSLuong ='" + txtHeSoLuong.Text + "',DenNgay='" +dtpkDenNgay.Value.ToString("MM/dd/yyyy")+ "',TuNgay ='" + dtpkTuNgay.Value.ToString("MM/dd/yyyy") + "' where Bac='" + _MaBac + "' and MaNgach='" + cbbmangach.Text + "'";

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
                foreach (System.Windows.Forms.DataGridViewRow dgv in dgvBac.SelectedRows)
                {
                    string _MaBac = dgv.Cells[0].Value.ToString().Trim();
                    string _TenBac = dgv.Cells[1].Value.ToString().Trim();

                    if (MessageBox.Show("Có chắc chắn xóa '" + _MaBac + " - " + _TenBac + "' không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            int _rowIdx = dgv.Index;
                            //MessageBox.Show(dgvUsersrows.Index.ToString(), "TB");
                            ds.Tables[0].Rows.RemoveAt(dgv.Index);
                            dgvBac.Refresh();

                            var result = dgvBac.DataSource;
                            //result.RemoveAt(_rowIdx);
                            //dataGridView1.DataSource = result;

                            DataAccess dbA = new DataAccess();
                            string sql = "delete From tbl_Bac where Bac = '" + _MaBac + "'";
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
            //Matutang();
        }
       /* public void Matutang()
        {

            string s = "";
            if (ds.Tables[0].Rows.Count <= 0)
                s = "B01";
            else
            {
                int k;
                s = "B";
                k = Convert.ToInt32(ds.Tables[0].Rows[ds.Tables[0].Rows.Count - 1][0].ToString().Substring(1, 2));
                k = k + 1;
                if (k < 10) s = s + "0";
                

                s = s + k.ToString();
            }
          txtmabac.Text = s;

        }*/

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
               
                default:
                    break;
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
