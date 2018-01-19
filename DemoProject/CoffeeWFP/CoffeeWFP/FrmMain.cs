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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void ItemMnuDG_Click(object sender, EventArgs e)
        {
            FrmDocGia frm = new FrmDocGia();
            frm.ShowDialog();
        }

        private void ItemMnuSach_Click(object sender, EventArgs e)
        {
            Frmsach frm = new Frmsach();
            frm.ShowDialog();
        }

        private void ItemMnuTheLoai_Click(object sender, EventArgs e)
        {
            FrmLoaiSach frm = new FrmLoaiSach();
            frm.ShowDialog();
        }
    }
}
