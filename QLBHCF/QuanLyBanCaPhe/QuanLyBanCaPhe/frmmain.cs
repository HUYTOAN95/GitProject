using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanCaPhe
{  
    public partial class frmmain : Form
    {
        public bool connect = false;
       
        QuanLyBanCaPhe.Module.CoffeManagerProjectEntities db = new Module.CoffeManagerProjectEntities();
        public frmmain()
        {
            InitializeComponent();
            Current = this;
        }
        public static frmmain Current;

        public string ItemMnuSystemLoginChange
        {
            get { return ItemMnuDN.Text; }
            set { ItemMnuDN.Text = value; }
        }
        private void frmmain_Load(object sender, EventArgs e)
        {
            QuanLyBanCaPhe.SO.PhanQuyen.frmmain = this;
            //gọi ShowUser để ẩn menu trong class PhanQUyen
            QuanLyBanCaPhe.SO.PhanQuyen.ShowUser();
            
        }
        
        private void ItemMnuDN_Click(object sender, EventArgs e)
        {
            if (connect==false )
            {
               
                frmlogin frm = new frmlogin();
                frm.ShowDialog();
                connect = true;
               
            }
            else 
            {
               
                if (MessageBox.Show("Có chắc chắn bỏ kết nối?", "Đăng xuất",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                   
                    frmmain.Current.ItemMnuSystemLoginChange = "Đăng nhập";
                    QuanLyBanCaPhe.SO.PhanQuyen.ShowUser(); //ẩn tất cả các menu trừ hệ thống

                    frmlogin digForm = new frmlogin();
                    digForm.ShowDialog();
             
                }
            }
              
            
            
        }

        private void ItemMnuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ItemMnuNV_Click(object sender, EventArgs e)
        {
            frmnhanvien frm = new frmnhanvien();
            frm.ShowDialog();
        }

        private void frmmain_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.F1:
                    MnuHT.ShowDropDown();
                    break;
                case Keys.F2:
                    MnuDM.ShowDropDown();
                    break;
                  
                case Keys.F3:
                    MnuBH.ShowDropDown();
                    break;
                  
                case Keys.F4:
                    MnuTK.ShowDropDown();
                    break;
                  
                case Keys.F5:
                    MnuBC.ShowDropDown();
                    break;
                  
                case Keys.F6:
                    MnuTG.ShowDropDown();
                    break;
                     
            }
        }

        private void ItemMnuNSD_Click(object sender, EventArgs e)
        {
            frmnsd frm = new frmnsd();
            frm.ShowDialog();
        }

        
        
    }
}
