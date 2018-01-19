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

namespace DemoProject.FormSeLect
{
        
    public partial class frmselect : Form
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
        public frmselect()
        {
            InitializeComponent();
        }

        private void frmselectbophan_Load(object sender, EventArgs e)
        {
            loadData();
            AlignCenterToScreen();
            dgvselect.EnableHeadersVisualStyles = false;
            dgvselect.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSeaGreen;
        }
        private void loadData(string _Filter = "")
        {

            DataAccess dbA = new DataAccess();
            string sql = _query;
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
            dgvselect.DataSource = bSource;
            //chỉnh kích thước của cột
            this.Text = "Bảng Chọn '" + _Tên + "'";


        }
        public string Selected { get { return dgvselect.CurrentRow.Cells[0].Value.ToString(); } }
        public string Selected2 { get { return dgvselect.CurrentRow.Cells[1].Value.ToString(); } }
        public string Selected3 { get { return dgvselect.CurrentRow.Cells[2].Value.ToString(); } }
        public string Selected4 { get { return dgvselect.CurrentRow.Cells[3].Value.ToString(); } }
        public string Selected5 { get { return dgvselect.CurrentRow.Cells[4].Value.ToString(); } }
        public string Selected6 { get { return dgvselect.CurrentRow.Cells[5].Value.ToString(); } }
        public string Selected7 { get { return dgvselect.CurrentRow.Cells[6].Value.ToString(); } }
        public string _query { get; set; }
        public string _Tên { get; set; }
        private void btnchon_Click(object sender, EventArgs e)
        {
           
            
                this.DialogResult = DialogResult.OK;
                this.Close();
         
        }

        private void dgvbophan_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.Escape:
                    {
                        //e.SuppressKeyPress = true;
                        DialogResult rs = MessageBox.Show("Are you sure you  want to exit?", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        ///this.DialogResult = DialogResult.
                        if (rs == DialogResult.No)
                        {
                            return;
                        }
                        this.Close();
                    } break;
                case Keys.Enter:
                    {
                        e.Handled = true;
                        btnchon.PerformClick();
                    } break;
                case Keys.F5:
                    {
                        btnlammoi.PerformClick();
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            dgvselect.Refresh();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
