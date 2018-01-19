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
using System.Data.SqlClient;
using DemoProject.SO;

namespace DemoProject.UsersForm
{
    public partial class frmChamCongNew : Form
    {
        DataSet ds;
        public frmChamCongNew()
        {
            InitializeComponent();
        }
        
        DataGridViewComboBoxColumn col = new DataGridViewComboBoxColumn();
        private void frmChamCongNew_Load(object sender, EventArgs e)
        {
            loadData();
         
            col.HeaderText = "" + dtpkNgayCN.Value.ToString("MM/dd/yyyy"); ;
           
            col.Name = "" + dtpkNgayCN.Value.ToString("MM/dd/yyyy");
            col.Items.Add("K");
            col.Items.Add("C");
            col.Items.Add("P");
            dgrvchamcong.Columns.Add(col);
           

        }
        private void loadData(string _Filter = "")
        {

            DataAccess dbA = new DataAccess();
            string sql = "SELECT U.MaNV as'Mã Nhân Viên' , U.HoTen as'Họ Tên',CV.TenCV as'Chức Vụ',U.TenPB as'Phòng Ban', U.Xoa FROM tbl_ChucVu CV INNER JOIN (SELECT nv.MaNV,nv.HoTen,nv.ChucVu,nv.Xoa, pb.TenPB FROM tbl_NhanVien nv INNER JOIN "+
                "tbl_PhongBan pb on nv.Phong=pb.MaPB) as U on U.ChucVu = CV.MaCV WHERE U.Xoa = 1 " + _Filter;
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
            dgrvchamcong.DataSource = bSource;
            dgrvchamcong.Columns[0].Width = 50;
            dgrvchamcong.Columns[5].Visible = false;
       

            for (int i = 0; i < dgrvchamcong.Rows.Count - 1; i++)
            {
                dgrvchamcong.Rows[i].Cells["STT"].Value = i + 1;
            }
        }

        private void grbchamcong_Enter(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btncapnhat_Click(object sender, EventArgs e)
        {

            try {
                
                   for (int j = 0; j < dgrvchamcong.Rows.Count-1; j++)
                { 
                    string _MaNV = dgrvchamcong.Rows[j].Cells[1].Value.ToString().Trim();
                    string _TenNV = dgrvchamcong.Rows[j].Cells[2].Value.ToString().Trim();
                    string _ChucVu = dgrvchamcong.Rows[j].Cells[3].Value.ToString().Trim();
                    string _PhongBan = dgrvchamcong.Rows[j].Cells[4].Value.ToString().Trim();
                    string _Xoa = dgrvchamcong.Rows[j].Cells[5].Value.ToString().Trim();
                    string _NgayLam = dgrvchamcong.Rows[j].Cells[6].Value.ToString().Trim();

                    SqlConnection cnn = new SqlConnection(MyApp.MSSQLConnectionString);

                    cnn.Open();
                    string sql = "INSERT INTO tbl_ChamCongNew(MaNV,HoTen,ChucVu,PhongBan,Xoa ,NgayLamViec,NgayCapNhat,Thang,Nam) VALUES " +
                        "('" + _MaNV + "',N'" + _TenNV + "',N'" + _ChucVu + "',N'" + _PhongBan + "','" + _Xoa + "','" + _NgayLam + "','" + dtpkNgayCN.Value.ToString("MM/dd/yyyy") + "','" + dtpkNgayCN.Value.ToString("MM") + "','" + dtpkNgayCN.Value.ToString("yyyy") + "')";
                    SqlCommand cmd = new SqlCommand(sql, cnn);
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0) { /*MessageBox.Show("Thành Công");*/ }
                    else
                    {
                        MessageBox.Show("Có lỗi! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    cnn.Close();


                }  MessageBox.Show("Cập Nhật Thành Công");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Có lỗi" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           // col.Items.Clear();*/
        }

        private void dtpkNgayCN_ValueChanged(object sender, EventArgs e)
        {
            col.HeaderText = "" + dtpkNgayCN.Value.ToString("MM/dd/yyyy"); ;

            col.Name = "" + dtpkNgayCN.Value.ToString("MM/dd/yyyy");
         
        }
    }
    }

