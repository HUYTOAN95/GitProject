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
    public partial class FrmNguoiSuDung : Form
    {
        DataSet ds = new DataSet();
        string _pMode = "";

        protected void AlignCenterToScreen()
        {

            Screen screen = Screen.FromControl(this);

            Rectangle workingArea = screen.WorkingArea;
            this.Location = new Point()
            {
                X = Math.Max(workingArea.X, workingArea.X + (workingArea.Width - this.Width) / 2),
                Y = Math.Max(workingArea.Y, workingArea.Y + (workingArea.Height - this.Height) / 2)
            };
        }
        public FrmNguoiSuDung()
        {
            InitializeComponent();
        }

        private void FrmNguoiSuDung_Load(object sender, EventArgs e)
        {
            _pMode = "";
            ViewMode();
            loadData();
            AlignCenterToScreen();
            dgrUsers.EnableHeadersVisualStyles = false;
            dgrUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSeaGreen;
        }
        private void loadData(string _Filter = "")
        {

            DataAccess dbA = new DataAccess();
            string sql = "SELECT TenSuDung as'Tên Đăng Nhập', MatKhau as'Mật Khẩu', TenNguoiDung as'Họ và Tên ',"+
                "NgayDangKi as'Ngày Đăng Kí ',QuyenTruyCap as'Quyền truy cập' FROM tbl_NguoiDung " + _Filter;
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
            dgrUsers.DataSource = bSource;
            //dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        }
        private void ViewMode()
        {
            switch (_pMode)
            {
                case "FIND":
                case "ADD":
                  grbcontrol.Enabled = false;

                    grbdetail.Show();
                  txtLoginName.Text = "";
                  txtPassWord.Text = "";
                  txtUsersName.Text = "";
                  txtRegistrationDate.Text = DateTime.Today.ToString("MM / dd / yyyy");
                    //dExpiredDate.Text = DateTime.Now;
                   
                    
                    this.Height = 400;
                    break;
                case "EDIT":
                    grbcontrol.Enabled = false;
                    grbdetail.Enabled = true;
                    grbdetail.Show();
                    this.Height = 400;
                    //
                    txtLoginName.Text = dgrUsers.CurrentRow.Cells[0].Value.ToString();
                    txtPassWord.Text = dgrUsers.CurrentRow.Cells[1].Value.ToString();
                    txtUsersName.Text = dgrUsers.CurrentRow.Cells[2].Value.ToString();
                    txtRegistrationDate.Text = dgrUsers.CurrentRow.Cells[3].Value.ToString();
                    cbbtranseraccess.Text = dgrUsers.CurrentRow.Cells[4].Value.ToString();

                    //
                    break;
                case "":
                    grbcontrol.Enabled = true;
                    dgrUsers.Enabled = true;
                    grbdetail.Hide();
                    this.Height = 300;
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
                //Char vChangeAtLogon = ckbDoiMK.Checked ? 'Y' : 'N';

                string sql = "insert into tbl_NguoiDung(TenSuDung,MatKhau,TenNguoiDung,NgayDangKi,QuyenTruyCap) values"+
                    "('" + txtLoginName.Text + "','" + txtPassWord.Text + "',N'" + txtUsersName.Text + "',"+
                    "'" + txtRegistrationDate.Text + "','" + cbbtranseraccess.Text + "')";
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
                String _TenDN = dgrUsers.CurrentRow.Cells[0].Value.ToString();
                //Char vChangeAtLogon = ckbDoiMK.Checked ? 'Y' : 'N';


                string sql = "update tbl_NguoiDung set TenNguoiDung =N'" +txtUsersName.Text + "',MatKhau='" +txtPassWord.Text + "',"+
                    "QuyenTruyCap='" + cbbtranseraccess.Text + "' where TenSuDung='" + _TenDN + "'";


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

        private void btnsave_Click(object sender, EventArgs e)
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
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            _pMode = "ADD";
            ViewMode();
            AlignCenterToScreen();   
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            _pMode = "EDIT";
            ViewMode();
            AlignCenterToScreen();   
        }

        private void btncance_Click(object sender, EventArgs e)
        {
            _pMode = "";
            ViewMode();
            AlignCenterToScreen();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            int i = 0;
            if (ds.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK);
            }
            else
                foreach (System.Windows.Forms.DataGridViewRow dgr in dgrUsers.SelectedRows)
                {
                    string _TenDN = dgr.Cells[0].Value.ToString().Trim();
                    string _TenNguoiDung  = dgr.Cells[2].Value.ToString().Trim();

                    if (MessageBox.Show("Có chắc chắn xóa '" + _TenDN + " - " + _TenNguoiDung + "' không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            int _rowIdx = dgr.Index;
                            //MessageBox.Show(dgvUsersrows.Index.ToString(), "TB");
                            ds.Tables[0].Rows.RemoveAt(dgr.Index);
                            dgrUsers.Refresh();

                            var result = dgrUsers.DataSource;
                            //result.RemoveAt(_rowIdx);
                            //dataGridView1.DataSource = result;

                            DataAccess dbA = new DataAccess();
                            string sql = "delete from tbl_NguoiDung where TenSuDung = '" + _TenDN + "'";
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

        private void grbdetail_Enter(object sender, EventArgs e)
        {

        }

        private void grbcontrol_Enter(object sender, EventArgs e)
        {

        }
    }
}
