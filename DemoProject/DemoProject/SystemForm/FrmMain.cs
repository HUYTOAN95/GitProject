using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoProject.SO;
using DemoProject.DAL;
using System.Data.SqlClient;

namespace DemoProject.SystemForm
{
    public partial class FrmMain : Form
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
        public static FrmMain Current;
      
        public string ItemMnuSystemLoginChange
        {
            get { return ItemMnuDangNhap.Text; }
            set { ItemMnuDangNhap.Text = value; }
        }
        public FrmMain()
        {
           
            InitializeComponent();
            Current = this;
           
            
        }
        public void loadlbltime()
        {
            //AlignCenterToScreen();
          
             
            lbltime.BackColor = Color.Transparent;

            lbldate.BackColor = Color.Transparent;
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
           
            {
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is MdiClient)
                    {
                        ctrl.BackColor = Color.White;
                    }
                }
            }
             AlignCenterToScreen();

             loadlbltime();
             MyApp.gConnected = false;
            //truyền đối tượng This (frmMain) cho class PhanQuyen
            DemoProject.SO.PhanQuyen.frmmain = this;
            //gọi ShowUser để ẩn menu trong class PhanQUyen
            DemoProject.SO.PhanQuyen.ShowUser();
            ItemMnuNSD.Enabled = false;
            ItemMnuDMK.Enabled = false;
            ItemMnuCapNhat.Enabled = false;
            toolStripStatusLbl.Text = "Ready_" + DateTime.Now.ToString("dd/MM/yyyy hh:mm ");
            //timeclocktoday.Start();
            timerclick.Start();
            timershowclock.Start();


    }
      
      

        private void ItemMnuDangNhap_Click(object sender, EventArgs e)
        {
            if (!MyApp.gConnected)
            {
               
               
                frmLogin digForm = new frmLogin();
                
                digForm.ShowDialog();
                //loaduser();
              
              toolstriplbl.Text = "Bạn Đang Đăng Nhập Tài Khoản : " + MyApp.gUserDB + " ";

            }
            else
            {

                if (MessageBox.Show("Có chắc chắn bỏ kết nối?", "Đăng xuất",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    
                {
                    MyApp.gConnected = false;
                    FrmMain.Current.ItemMnuSystemLoginChange = "Đăng nhập";
                    DemoProject.SO.PhanQuyen.ShowUser(); //ẩn tất cả các menu trừ hệ thống
                    toolstriplbl.Text = "Bạn Cần Đăng Nhập Tài Khoản : ";
                    frmLogin digForm = new frmLogin();
                    digForm.ShowDialog();
                    toolstriplbl.Text = "Bạn Đang Đăng Nhập Tài Khoản : " + MyApp.gUserDB + " ";

                   
                  


                }
            }
        }

        private void ItemMnuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timeclocktoday_Tick(object sender, EventArgs e)
        {
            //AlignCenterToScreen();
            lbltime.Text = DateTime.Now.ToString("hh:mm:ss ");
            lbltime.BackColor = Color.Transparent;
            lbldate.Text = DateTime.Now.ToShortDateString();
            lbldate.BackColor = Color.Transparent;
        }

        private void lbldate_Click(object sender, EventArgs e)
        {

        }

        private void lbldate_LocationChanged(object sender, EventArgs e)
        {
           
        }

        private void tmrsliceshow_Tick(object sender, EventArgs e)
        {
           
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            
        }

        private void ItemMnuDMK_Click(object sender, EventArgs e)
        {
            FrmPassChange frm = new FrmPassChange();
            frm.ShowDialog();
        }

        private void ItemMnuNSD_Click(object sender, EventArgs e)
        {
            UsersForm.FrmNguoiSuDung frm = new UsersForm.FrmNguoiSuDung();
            frm.ShowDialog();
         
        }

       
        private void ItemMnuDSNV_Click(object sender, EventArgs e)
        {
        }

       

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

      

        

        
        private void ItemMnuDanhSachNV_Click(object sender, EventArgs e)
        {

            frmNhanVien frm = new frmNhanVien();
            frm.ShowDialog();
        }

        private void ItemMnuThueSuat_Click_1(object sender, EventArgs e)
        {
            frmBangThueSuat frm = new frmBangThueSuat();
            frm.ShowDialog();
        }

        private void ItemMnuDMChucVu_Click(object sender, EventArgs e)
        {
            frmchucvu frm = new frmchucvu();
            frm.ShowDialog();
        }

        private void ItemMnuDMPhongBan_Click(object sender, EventArgs e)
        {

            frmPhongBan frm = new frmPhongBan();
            frm.ShowDialog();
        }

        private void ItemMnuDMNgachNV_Click(object sender, EventArgs e)
        {

            frmNgach frm = new frmNgach();
            frm.ShowDialog();
        }

        private void ItemMnuHSNhanVien_Click(object sender, EventArgs e)
        {
            frmHoSoNV frm = new frmHoSoNV();
            frm.ShowDialog();
            
        }

        private void saoLưuToolStripMenuItem_Click(object sender, EventArgs e)
        {
           UsersForm.FrmBackup  frm = new UsersForm.FrmBackup();
            frm.ShowDialog();
        }

        private void ItemMnuCapNhatNV_Click(object sender, EventArgs e)
        {
            UsersForm.frmCapNhatDSNV frm = new UsersForm.frmCapNhatDSNV();
            frm.ShowDialog();
        }

        private void MnuGioiThieu_Click(object sender, EventArgs e)
        {
            UsersForm.FrmGioiThieu frm = new UsersForm.FrmGioiThieu();
            frm.ShowDialog();

        }

        private void ItemMnuBCNhanVien_Click(object sender, EventArgs e)
        {
            UsersForm.FormReport frm = new UsersForm.FormReport("NhanVien.rpt");
            frm.ShowDialog();
        }

        private void toolstriplbl_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ItemMnuChamCong_Click(object sender, EventArgs e)
        {
           
        }

      

        private void LivItemMnuCapNhat_Click(object sender, EventArgs e)
        {
            UsersForm.frmChamCongNew frm = new UsersForm.frmChamCongNew();
            frm.ShowDialog();
        }

        private void LivItemMnuBangChamCong_Click(object sender, EventArgs e)
        {
            UsersForm.FrmBangChamCong frm = new UsersForm.FrmBangChamCong();
            frm.ShowDialog();
        }

        private void ItemMnuNgoaiGio_Click(object sender, EventArgs e)
        {
            UsersForm.frmLamTheNG frm = new UsersForm.frmLamTheNG();
            frm.ShowDialog();
        }

        private void ItemMnuLuongCoSo_Click(object sender, EventArgs e)
        {
            UsersForm.frmLuongCoSo frm = new UsersForm.frmLuongCoSo();
            frm.ShowDialog();
        }

        private void ItemMnuThueThuNhap_Click(object sender, EventArgs e)
        {
            UsersForm.frmThueTNCN frm = new UsersForm.frmThueTNCN();
            frm.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://cic.org.vn");
        }
        Color[] ten = { Color.Silver,  Color.Orange, Color.RoyalBlue };
        int dem = 0;
        private void timerclick_Tick(object sender, EventArgs e)
        {
           lblName.BackColor= ten[dem];
            dem++;
            if (dem == 3) dem = 0;
        }

        private void ItemMnuBaoHiem_Click(object sender, EventArgs e)
        {
            UsersForm.frmBaoHiem frm = new UsersForm.frmBaoHiem();
            frm.ShowDialog();
        }

        private void ItemMnuBangLuong_Click(object sender, EventArgs e)
        {
            UsersForm.frmBangLuong frm = new UsersForm.frmBangLuong();
            frm.ShowDialog();
        }

        private void ItemMnuBCLuong_Click(object sender, EventArgs e)
        {
            UsersForm.FormReport frm = new UsersForm.FormReport("Luong.rpt");
            frm.ShowDialog();
        }

        private void ItemMnuThueTNCN_Click(object sender, EventArgs e)
        {

            UsersForm.FormReport frm = new UsersForm.FormReport("ThueTNCN.rpt");
            frm.ShowDialog();
        }

        private void ItemMnuBaoCaoBH_Click(object sender, EventArgs e)
        {
            UsersForm.FormReport frm = new UsersForm.FormReport("BaoHiem.rpt");
            frm.ShowDialog();
        }

        private void timershowclock_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            labelTime.BackColor = Color.Transparent;
            lableDate.Text = DateTime.Now.ToShortDateString();
            lableDate.BackColor = Color.Transparent;
        }
    }
}
