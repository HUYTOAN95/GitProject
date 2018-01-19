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
    public partial class frmnguoiquanly : Form
    {
        DataSet ds = new DataSet();
      
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
        public frmnguoiquanly()
        {
            InitializeComponent();
        }

        private void frmnguoiquanly_Load(object sender, EventArgs e)
        {
            
            loadData();
            AlignCenterToScreen();
            dgvQuanLi.EnableHeadersVisualStyles = false;
            dgvQuanLi.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSeaGreen;
            this.Text="Can Bo Quan Ly Phòng _ "+_Tenphong+"_"+_Maphong+"";
         
        }
        private void loadData(string _Filter = "")
        {

            DataAccess dbA = new DataAccess();
            string sql = "SELECT MaNV as'Mã CB',HoTen as'Tên ', ChucVu as'Chức Vụ' FROM tbl_NhanVien  WHERE Phong ='" + _Maphong + "' AND ( ChucVu ='PP' OR ChucVu='TP' OR ChucVu='TL') ";
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
            dgvQuanLi.DataSource = bSource;
            //chỉnh kích thước của cột
            dgvQuanLi.Columns[0].Width = 100;
            dgvQuanLi.Columns[1].Width = 200;
            dgvQuanLi.Columns[2].Width = 200;

        }
        public string _Maphong { get; set; }
        public string _Tenphong { get; set; }
       

       
        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbbophan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtmacb_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmacb_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            /*FormSeLect.frmselect frm = new FormSeLect.frmselect();
            frm._query = "Select MaNV as 'Mã Cán Bộ ',HoTenNV as'Họ Tên',ChucVu as'Chức vụ' From  NhanVien where Phong ='"+_Maphong+"'";
            using (frm)
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    txtmacb.Text = frm.Selected;
                    txtmacb.SelectionStart = txtmacb.Text.Length;
                    txtten.Text = frm.Selected2;
                    txtten.SelectionStart = txtten.Text.Length;
                    txtchucvu.Text = frm.Selected3;
                    txtchucvu.SelectionStart = txtchucvu.Text.Length;
                    


                }
            }*/
        }

        private void grbdetail_Enter(object sender, EventArgs e)
        {

        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {

            String vFilter = " Where (1=1)";

            vFilter = vFilter + " AND MaNV = '" + txttimkiem.Text + "'";

            loadData(vFilter);
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
