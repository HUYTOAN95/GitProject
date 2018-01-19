using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Globalization;
using ICSharpCode;
using Excel=Microsoft.Office.Interop.Excel;
using ExcelDataReader;
using DemoProject.SO;

namespace DemoProject.UsersForm
{
    public partial class frmCapNhatDSNV : Form
    {
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
        public frmCapNhatDSNV()
        {
            InitializeComponent();
        }
        DataSet result;
        private void openfile_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog open = new OpenFileDialog() { Filter = "All file(*.*)|*.*|Excel |*.xlsx|Excel|*.xls", ValidateNames = true })
                {
                    if (open.ShowDialog() == DialogResult.OK)
                    {
                        this.txtopenfile.Text = open.FileName;
                        FileStream fs = File.Open(open.FileName, FileMode.Open, FileAccess.Read);
                        IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(fs);
                        result = reader.AsDataSet();
                        cbbselectsheet.Items.Clear();
                        foreach (DataTable dt in result.Tables)
                            cbbselectsheet.Items.Add(dt.TableName);
                        reader.Close();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi! " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbbselectsheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvCapNhat.DataSource = result.Tables[cbbselectsheet.SelectedIndex];
        }

        private void frmCapNhatDSNV_Load(object sender, EventArgs e)
        {

            AlignCenterToScreen();
            dgvCapNhat.EnableHeadersVisualStyles = false;
            dgvCapNhat.ColumnHeadersDefaultCellStyle.BackColor = Color.SkyBlue;
        }

        private void btnCapNhatNV_Click(object sender, EventArgs e)
        {
            try
            {
                for (int j = 0; j < dgvCapNhat.Rows.Count - 1; j++)
                {
                    string _HoTen = dgvCapNhat.Rows[j].Cells[0].Value.ToString().Trim();
                    string _GioiTinh = dgvCapNhat.Rows[j].Cells[1].Value.ToString().Trim();
                    string _NgaySinh = dgvCapNhat.Rows[j].Cells[2].Value.ToString().Trim();
                    String NgaySinh = DateTime.Parse(_NgaySinh).ToString("s");
                    string _NoiSinh = dgvCapNhat.Rows[j].Cells[3].Value.ToString().Trim();
                    string _DiaChi = dgvCapNhat.Rows[j].Cells[4].Value.ToString().Trim();
                    string _CMND = dgvCapNhat.Rows[j].Cells[5].Value.ToString().Trim();
                    string _DanToc = dgvCapNhat.Rows[j].Cells[6].Value.ToString().Trim();
                    string _SDT = dgvCapNhat.Rows[j].Cells[7].Value.ToString().Trim();
                    string _Gmail = dgvCapNhat.Rows[j].Cells[8].Value.ToString().Trim();
                    string _TrinhDo = dgvCapNhat.Rows[j].Cells[9].Value.ToString().Trim();
                    string MaSoThue = dgvCapNhat.Rows[j].Cells[10].Value.ToString().Trim();
                    string _NgayVaoLam = dgvCapNhat.Rows[j].Cells[11].Value.ToString().Trim();
                    String NgayVaoLam = DateTime.Parse(_NgayVaoLam).ToString("s");




                    string sql = "INSERT INTO tbl_NhanVien(MaNV,HoTen,GioiTinh,NgaySinh,NoiSinh,DiaChi,CMND,DanToc,SDT,Gmail,TrinhDo,MaSoThue,NgayVaoLam) " +
                        "VALUES('',N'" + _HoTen + "','" + NgaySinh + "',N'" + _GioiTinh + "','" + NgaySinh + "','" + _NoiSinh + "','" + _DiaChi + "'," +
                        "'" + _CMND + "',N'" + _DanToc + "','" + _SDT + "','" + _Gmail + "','" + _TrinhDo + "','" + MaSoThue + "','" + NgayVaoLam + "')";
                    SqlConnection cn = new SqlConnection(MyApp.MSSQLConnectionString);
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0) { MessageBox.Show("Thành Công"); }
                    else
                    {
                        MessageBox.Show("Có lỗi! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    cn.Close();
                }
            }
            catch (Exception ex )
            { MessageBox.Show("Có lỗi! " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
           
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
