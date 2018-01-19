using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeWFP
{
    public partial class FrmLoaiSach : Form
    {
        QuanLyThuVienEntities db = new QuanLyThuVienEntities();
        public FrmLoaiSach()
        {
            InitializeComponent();
        }
        private void loaddata()
        {
            gridview.DataSource = db.tbl_LoaiSach.ToList();
        }
        public string Selected { get { return gridview.CurrentRow.Cells[0].Value.ToString(); } }

        private void FrmLoaiSach_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void FrmLoaiSach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
                
               
            }
            if (e.KeyCode == Keys.F5)
            {
                loaddata();
            }
        }

        private void gridview_KeyDown(object sender, KeyEventArgs e)
        {  
          
        }
    }
}
