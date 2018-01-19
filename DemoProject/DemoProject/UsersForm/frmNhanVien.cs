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
    public partial class frmNhanVien : Form
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
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void txtBoPhan_TextChanged(object sender, EventArgs e)
        {

        }
        private void loadData(string _Filter = "")
        {

            DataAccess dbA = new DataAccess();
            string sql = "SELECT MaNV as 'Mã Nhân Viên',HoTen as' Họ Tên',GioiTinh as' Giới tính',NgaySinh as' Ngày Sinh',NoiSinh as' Nơi Sinh',DCThuongTru as 'Thường Trú',"+
                "DCTamTru as'Tạm Trú',TonGiao as' Tôn Giáo',CMND as'  Số CMND/Hộ Chiếu',"+
                "DanToc as' Dân Tộc',SDT,Gmail,TrinhDo as' Trình Độ',ChucVu as' Chức Vụ',Phong as' Phòng Ban',Ngach as' Ngạch',Bac as ' Bậc',MaSoThue as ' Mã Số Thuế',SNPhuThuoc as' Số NGười Phụ Thuộc', NgayVaoLam as ' Ngày Làm',NgayHT as'Ngày Cập Nhật', GhiChu as ' Ghi Chú'  FROM tbl_NhanVien" + _Filter;
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
            dgvNhanVien.DataSource = bSource;
            dgvNhanVien.Columns[0].Width = 50;

            for (int i = 0; i < dgvNhanVien.Rows.Count - 1; i++)
            {
                dgvNhanVien.Rows[i].Cells["STT"].Value = i + 1;
            }
        }
             private void frmNhanVien_Load(object sender, EventArgs e)
            {
             
            _pMode = "";
            ViewMode();

            String vFilter = " Where (1=1)";

            vFilter = vFilter + " AND Xoa=1 ";

            loadData(vFilter);
            AlignCenterToScreen();
            dgvNhanVien.EnableHeadersVisualStyles = false;
            dgvNhanVien.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSeaGreen;
        
        }
        private void ViewMode()
        {
            switch (_pMode)
            {
                case "FIND":
                case "ADD":
                    grbbutton.Enabled = false;
               


                  
                    break;
                case "EDIT":
                    grbbutton.Enabled = false;
                    
                    break;
                case "":
                    grbbutton.Enabled = true;
                    dgvNhanVien.Enabled = true;
                 
                    break;
                default:
                    break;
            }

        }
       
    
    

      
       /* public void Matutang()
        {

            string s = "";
            if (ds.Tables[0].Rows.Count <= 0)
                s = "NV001";
            else
            {
                int k;
                s = "NV";
                k = Convert.ToInt32(ds.Tables[0].Rows[ds.Tables[0].Rows.Count - 1][1].ToString().Substring(2, 3));
                k = k + 1;
                if (k < 10) s = s + "00";
                else if (k < 100)
                    s = s + "0";
               
                s = s + k.ToString();
            }
           txtMaNV.Text = s;

        }*/
     
     
        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (ds.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK);
            }
            else
                foreach (System.Windows.Forms.DataGridViewRow dgv in dgvNhanVien.SelectedRows)
                {
                    string _MaNV = dgv.Cells[1].Value.ToString().Trim();
                    string _TenNV = dgv.Cells[2].Value.ToString().Trim();

                    if (MessageBox.Show("Có chắc chắn xóa '" + _MaNV + " - " + _TenNV + "' không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            int _rowIdx = dgv.Index;
                            //MessageBox.Show(dgvUsersrows.Index.ToString(), "TB");
                            ds.Tables[0].Rows.RemoveAt(dgv.Index);
                            dgvNhanVien.Refresh();

                            var result = dgvNhanVien.DataSource;
                            //result.RemoveAt(_rowIdx);
                            //dataGridView1.DataSource = result;

                            DataAccess dbA = new DataAccess();
                            string sql = "UPDATE tbl_NhanVien SET Xoa = 0,NgayHT='"+DateTime.Now.ToString("MM/dd/yyy hh:mm:ss")+"' where MaNV = '" + _MaNV + "';"+
                                "UPDATE tbl_ChamCongNew SET Xoa = 0 WHERE MaNV='"+_MaNV+"'";
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

        private void btnloc_Click(object sender, EventArgs e)
        {  
            String vFilter = " Where (1=1)";
           
                vFilter = vFilter + " AND '"+cbbTimKiem.Text+"' = '" + txttimkiem.Text +"'";
           
            loadData(vFilter);

            AlignCenterToScreen();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
           UsersForm.FormReport frm = new UsersForm.FormReport("NhanVien2.rpt");
            frm.ShowDialog();
        }

        private void txtMaPhong_KeyDown(object sender, KeyEventArgs e)
        {
           /* switch (e.KeyCode)
            {
                case Keys.F10:
                    FormSeLect.frmselect frm = new FormSeLect.frmselect();
                    frm._query = "Select MaPhong as'Mã Phòng',TenPhong as'Tên Phòng'from PhongBan ";
                    using (frm)
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            txtMaPhong.Text = frm.Selected;
                            txtMaPhong.SelectionStart = txtMaPhong.Text.Length;
                            txtTenPhong.Text = frm.Selected2;
                            txtTenPhong.SelectionStart = txtTenPhong.Text.Length;
                        }
                    }
                    break;
            }*/
        }

       
      
       
                            
             
              


        private void txtMaCV_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void grbdetail_Enter(object sender, EventArgs e)
        {

        }

       

        private void cbbdoituong_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMaPhong_DoubleClick(object sender, EventArgs e)
        {
            
        }

       

        private void txtMaCV_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           

        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ItemContextXoa_Click(object sender, EventArgs e)
        {
            btnxoa.PerformClick();
        }
    }
}
