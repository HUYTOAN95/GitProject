using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DemoProject.DAL;
using DemoProject.SO;
namespace DemoProject.UsersForm
{ 
    public partial class frmLamTheNG : Form
    {
        DataSet ds;
        public frmLamTheNG()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmLamTheNG_Load(object sender, EventArgs e)
        {
            string year = Convert.ToString(DateTime.Today.ToString("yyyy/MM"));


         
            cbbNam.Text = year.Substring(0, 4);

            cbbThang.Text = year.Substring(5, 2);
            loadData();
         
            LoadNV();
            
        }
        private void loadData(string _Filter = "")
        {

            DataAccess dbA = new DataAccess();
            string sql = "SELECT MaNV as'Mã Nhân Viên' ,SGNT as'Số Giờ Ngày Thường',SGNN as'Số Giờ Ngày Nghỉ',SGNL as'Số Giờ Ngày lế', ThuNhap as'Thu Nhập', NgayCapNhat as' Ngày Thực Hiện' FROM tbl_NgoaiGio" + _Filter + " ORDER BY NgayCapNhat DESC";


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
            drgvNgoaiGio.DataSource = bSource;
            drgvNgoaiGio.Columns[0].Width = 50;

            for (int i = 0; i < drgvNgoaiGio.Rows.Count - 1; i++)
            {
                drgvNgoaiGio.Rows[i].Cells["STT"].Value = i + 1;
            }
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            addNew();
            txtSGNL.Clear();
            txtSGNN.Clear();
            txtSGNT.Clear();


        }
        private void addNew()
        {
            try
            {
                DataAccess dbA = new DataAccess();
                string sql = "INSERT INTO tbl_NgoaiGio(MaNV,Thang,Nam,SGNT,SGNN,SGNL,NgayCapNhat)VALUES " +
                    "('" + cbbMaNV.Text + "','" + cbbThang.Text + "','" + cbbNam.Text + "','" + txtSGNT.Text + "'," +
                    "'" + txtSGNN.Text + "','" + txtSGNL.Text + "','" + DateTime.Today.ToString("MM/dd/yyyy") + "');" +
                   "UPDATE tbl_NgoaiGio SET ThuNhap=(SELECT ROUND( (SGNT*1.5+SGNN*2+SGNL*3)*(nv.LuongCS*(nv.HSL+nv.HSCV)*2.6/22)/8,0) " +
                   "FROM tbl_NgoaiGio ng INNER JOIN tbl_NhanVien nv ON ng.MaNV=nv.MaNV WHERE ng.MaNV='"+cbbMaNV.Text+"' AND ng.Thang='"+cbbThang.Text+"'AND ng.Nam='"+cbbNam.Text+"')"+
                   "WHERE MaNV='" + cbbMaNV.Text + "' AND Thang='" + cbbThang.Text + "'AND Nam='" + cbbNam.Text + "'";
                    
                int i = dbA.ExecuteData(sql);
                if (i > 0)
                {
                    //MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                    loadData();
                   
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
        private void edit()
        {
            try
            {
                DataAccess dbA = new DataAccess();
                String _MaNV = drgvNgoaiGio.CurrentRow.Cells[1].Value.ToString();


                string sql = "UPDATE tbl_NgoaiGio SET SGNT ='" + txtSGNT.Text+ "',SGNN='"+txtSGNN.Text+ "',SGNL='"+txtSGNL.Text+"'"+
                    "WHERE MaNV='"+_MaNV+"'AND Thang='"+cbbThang.Text+"' AND Nam='"+cbbNam.Text+"'";

                int i = dbA.ExecuteData(sql);
                if (i > 0)
                {
                    //MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                    
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
        
        
        private void LoadNV()
        {
            try
            {
                SqlConnection cnn = new SqlConnection(MyApp.MSSQLConnectionString);
                string sql = "SELECT MaNV FROM tbl_NhanVien WHERE Xoa =  1";
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sql, cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                
               
                cbbMaNV.DataSource = ds.Tables[0];
                cbbMaNV.DisplayMember = "MaNV";
                cbbMaNV.ValueMember = "MaNV";
            }
            catch (Exception es)
            {
                MessageBox.Show("Có lỗi" + es.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void cbbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            String vFilter = " Where (1=1)";
           
                vFilter = vFilter + " AND Thang ='" + cbbThang.Text + "' AND Nam='"+cbbNam.Text+"'";
            

            //
            loadData(vFilter);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void drgvNgoaiGio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
           
        }

        private void drgvNgoaiGio_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void drgvNgoaiGio_Click(object sender, EventArgs e)
        {
            txtSGNN.Text = drgvNgoaiGio.CurrentRow.Cells[2].Value.ToString();
            txtSGNL.Text = drgvNgoaiGio.CurrentRow.Cells[3].Value.ToString();
            txtSGNT.Text = drgvNgoaiGio.CurrentRow.Cells[4].Value.ToString();
        }

        private void cbbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            String vFilter = " Where (1=1)";

            vFilter = vFilter + "  AND Nam='" + cbbNam.Text + "'";


            //
            loadData(vFilter);
        }

        private void cbbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            String vFilter = " Where (1=1)";

            vFilter = vFilter + " AND MaNV = '"+cbbMaNV.Text+"'  AND Thang ='" + cbbThang.Text + "' AND Nam='" + cbbNam.Text + "'";


            //
            loadData(vFilter);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            edit();
            txtSGNL.Clear();
            txtSGNN.Clear();
            txtSGNT.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            int i = 0;
            if (ds.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK);
            }
            else
                foreach (System.Windows.Forms.DataGridViewRow dgv in drgvNgoaiGio.SelectedRows)
                {
                    string _MaNV = dgv.Cells[1].Value.ToString().Trim();


                    if (MessageBox.Show("Có chắc chắn xóa thu nhập làm thêm của Nhân Viên " + _MaNV + " Tháng " + cbbThang.Text + " Năm " + cbbNam.Text + "' không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            int _rowIdx = dgv.Index;
                            //MessageBox.Show(dgvUsersrows.Index.ToString(), "TB");
                            ds.Tables[0].Rows.RemoveAt(dgv.Index);
                            drgvNgoaiGio.Refresh();

                            var result = drgvNgoaiGio.DataSource;
                            //result.RemoveAt(_rowIdx);
                            //dataGridView1.DataSource = result;

                            DataAccess dbA = new DataAccess();
                            string sql = "DELETE  tbl_NgoaiGio  WHERE MaNV='" + _MaNV + "' AND Thang ='" + cbbThang.Text + "' AND Nam='" + cbbNam.Text + "'";
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
    }
}
