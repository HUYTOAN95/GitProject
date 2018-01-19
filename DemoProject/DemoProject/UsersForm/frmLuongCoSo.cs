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

namespace DemoProject.UsersForm
{
    public partial class frmLuongCoSo : Form
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
        public frmLuongCoSo()
        {
            InitializeComponent();
        }

        private void frmluongcoban_Load(object sender, EventArgs e)
        {
            _pMode = "";
            ViewMode();
            loadData();
            AlignCenterToScreen();
            dgvluong.EnableHeadersVisualStyles = false;
            dgvluong.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSeaGreen;
         
           
        }
        private void loadData(string _Filter = "")
        {

            DataAccess dbA = new DataAccess();
            string sql = "select MaSo as'Mã Số',LuongCS as'Mức Lương Cơ Sở',TuNgay as'Từ Ngày ',DenNgay as' Đến Ngày', CSPL as'Cơ Sở Pháp Lý' From tbl_LuongCS ";
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
            dgvluong.DataSource = bSource;
            //chỉnh kích thước của cột
            

        }
        public void Matutang()
        {

            string s = "";
            if (ds.Tables[0].Rows.Count <= 0)
                s = "MS0001";
            else
            {
                int k;
                s = "MS";
                k = Convert.ToInt32(ds.Tables[0].Rows[ds.Tables[0].Rows.Count - 1][0].ToString().Substring(2, 7));
                k = k + 1;
                if (k < 10) s = s + "000";
                else if (k < 100)
                    s = s + "00";
                else if (k < 1000)
                    s = s + "0";
              
                
                s = s + k.ToString();
            }
            txtmaso.Text = s;
        }

        private void ViewMode()
        {
            switch (_pMode)
            {
                case "FIND":
                case "ADD":
                    grbbutton.Enabled = false;
                    grbdetail.Show();
                   txtmaso.Text = "";
                   txtluongcoban.Text= "";
                    dtpkngayapdung.Text = "";
                  txtcosophaply.Text= "";
                   dtpkhan.Text = "";
                    //dExpiredDate.Text = DateTime.Now;

                    this.Height = 350;
                    break;
                case "EDIT":
                    grbbutton.Enabled = false;
                    grbdetail.Show();
                    dgvluong.Enabled = false;
                    this.Height = 350;
                    txtmaso.Text = dgvluong.CurrentRow.Cells[0].Value.ToString();
                    txtluongcoban.Text = dgvluong.CurrentRow.Cells[1].Value.ToString();
                    dtpkngayapdung.Text = dgvluong.CurrentRow.Cells[2].Value.ToString();
                   txtcosophaply.Text = dgvluong.CurrentRow.Cells[4].Value.ToString();
                    dtpkhan.Text = dgvluong.CurrentRow.Cells[3].Value.ToString();


                    break;
                case "":
                    grbbutton.Enabled = true;
                    grbdetail.Hide();
                    dgvluong.Enabled = true;

                    this.Height = 250;
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
                string sql = "insert into tbl_LuongCS(MaSo,LuongCS,TuNgay,DenNgay,CSPL) values('" + txtmaso.Text + "','" + txtluongcoban.Text + "','" + dtpkngayapdung.Value.ToString("MM/dd/yyyy") + "','" + dtpkhan.Value.ToString("MM/dd/yyyy") + "','" + txtcosophaply.Text + "')";
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
                String _Ma = dgvluong.CurrentRow.Cells[0].Value.ToString();


                string sql = "UPDATE tbl_LuongCS SET LuongCS ='" + txtluongcoban.Text + "',TuNgay='" + dtpkngayapdung.Value.ToString("MM/dd/yyyy") + "',CSPL ='" + txtcosophaply.Text + "',DenNgay='" + dtpkhan.Value.ToString("MM/dd/yyyy") + "' where MaSo='" + _Ma + "'";

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

        private void btnxoa_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (ds.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK);
            }
            else
                foreach (System.Windows.Forms.DataGridViewRow dgv in dgvluong.SelectedRows)
                {
                    string _Ma = dgv.Cells[0].Value.ToString().Trim();
                    string _Ten = dgv.Cells[1].Value.ToString().Trim();

                    if (MessageBox.Show("Có chắc chắn xóa '" + _Ma + " - " + _Ten + "' không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            int _rowIdx = dgv.Index;
                            //MessageBox.Show(dgvUsersrows.Index.ToString(), "TB");
                            ds.Tables[0].Rows.RemoveAt(dgv.Index);
                            dgvluong.Refresh();

                            var result = dgvluong.DataSource;
                            //result.RemoveAt(_rowIdx);
                            //dataGridView1.DataSource = result;

                            DataAccess dbA = new DataAccess();
                            string sql = "delete From tbl_LuongCS where MaSo = '" + _Ma + "'";
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

        private void btnsua_Click(object sender, EventArgs e)
        {

            _pMode = "EDIT";
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

                default:
                    break;
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
          
            _pMode = "ADD";
            ViewMode();
            AlignCenterToScreen();
            Matutang();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
