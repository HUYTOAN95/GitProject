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
using System.IO;
using System.Drawing.Imaging;



namespace DemoProject.SystemForm
{

    public partial class frmHoSoNV : Form
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
        public frmHoSoNV()
        {
            InitializeComponent();
        }

        private void frmHoSoNV_Load(object sender, EventArgs e)
        {
            _pMode = "";
            ViewMode();
            AlignCenterToScreen();

            String vFilter = " Where (1=1)";

            vFilter = vFilter + " AND Xoa=1 ";
            loaddata(vFilter);
            loadfillitem();

          
            loadfillcbbphongban();
           
            

            //ptrAnh.Image = image;

        }
   
        private void loaddata(string _Filter = "")
        {
            try
            {
                SqlConnection cnn = new SqlConnection(MyApp.MSSQLConnectionString);
                cnn.Open();
                string sql = "SELECT MaNV,HoTen,GioiTinh,NgaySinh,NoiSinh,DCThuongTru,SDT,Gmail,TrinhDo,ChucVu,Phong,HSCV,HSL,MaSoThue,SNPhuThuoc," +
                    "NgayVaoLam,GhiChu,DanToc,Anh,TenKhac,DCTamTru,NoiCap,NgayCap,TonGiao,QuocTich,TinhTrang,CMND,Ngach,Bac,LuongCS FROM tbl_NhanVien " + _Filter;

                SqlCommand cmd = new SqlCommand(sql, cnn);
                //SqlDataAdapter da = new SqlDataAdapter(cmd);

                SqlDataReader dr = cmd.ExecuteReader();
                //DataSet ds = new DataSet();



                if (dr.Read())
                {
                    cbbMaNV.Text = dr[0].ToString();
                    txtHoTen.Text = dr[1].ToString();
                    cbbGioiTinh.Text = dr[2].ToString();
                    dtpkNgaySinh.Text = dr[3].ToString();
                    txtNoiSinh.Text = dr[4].ToString();
                    txtThuongTru.Text = dr[5].ToString();
                    txtSDT.Text = dr[6].ToString();
                    txtEmail.Text = dr[7].ToString();
                    cbbTrinhDo.Text = dr[8].ToString();
                    txtChucVu.Text = dr[9].ToString();
                    cbbphongban.Text = dr[10].ToString();
                    txtHSCV.Text = dr[11].ToString();
                    txtHSL.Text = dr[12].ToString();
                    txtMaSoThue.Text = dr[13].ToString();
                    txtSNPT.Text = dr[14].ToString();
                    dtpkNgayVL.Text = dr[15].ToString();
                    txtGhiChu.Text = dr[16].ToString();
                    cbbdantoc.Text = dr[17].ToString();
                    txtTenKhac.Text = dr[19].ToString();
                    txtTamTru.Text = dr[20].ToString();
                    txtNoiCap.Text = dr[21].ToString();
                    dtpkNgayCap.Text = dr[22].ToString();
                    cbbTonGiao.Text = dr[23].ToString();
                    
                    cbbQuocTich.Text = dr[24].ToString();
                    cbbTinhTrang.Text = dr[25].ToString();
                    txtCMTND.Text = dr[26].ToString();
                    txtNgach.Text = dr[27].ToString();
                    txtBac.Text = dr[28].ToString();
                    txtMucLuongCs.Text = dr[29].ToString();

                    byte[] img = (byte[])dr[18];
                    if (img == null)
                    {
                        //ptrAnh.Image = null;
                        ptrAnh.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        ptrAnh.Image = Image.FromStream(ms);


                    }
                }
            }
            catch (Exception es)
            {
                MessageBox.Show("Có lỗi" + es.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        
        }
       
        private void loadfillitem()
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
  
        private void loadfillcbbphongban()
        {
            try
            {
                SqlConnection cnn = new SqlConnection(MyApp.MSSQLConnectionString);
                string sql = "SELECT DISTINCT MaPB FROM tbl_PhongBan WHERE Xoa =  1";
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sql, cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                cbbphongban.DataSource = ds.Tables[0];
                cbbphongban.DisplayMember = "MaPB";
                cbbphongban.ValueMember = "MaPB";
            }
            catch (Exception es)
            {
                MessageBox.Show("Có lỗi" + es.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
       
       
        SqlConnection cnn = new SqlConnection(MyApp.MSSQLConnectionString);
        string imagelocation = @"G:\MyProject\Specialized_Projects\DemoProject\DemoProject\Resources\people_contact-128.png";
        SqlCommand cmd;
      

        private void btnchange_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All files(*.*)|*.*|JPG(*.JPG)|*.jpg | PNG(*.PNG)|*.png ";

            //Kiểm tra xem người dùng đã chọn file chưa
            if (open.ShowDialog() == DialogResult.OK)
            {


                // Gán ảnh


                imagelocation = open.FileName.ToString();
                ptrAnh.ImageLocation = imagelocation;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
          
            _pMode = "ADD";
            ViewMode();
            AlignCenterToScreen();
        }

       /* private void btnsave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.DefaultExt = "ptrAnh";
            saveFileDialog1.Filter = "ptrAnh|*.png";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.Title = "Where do you want to save the file?";
            saveFileDialog1.InitialDirectory = @"F:\MyProject\Specialized_Projects\DemoProject\DemoProject\Image";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Youcted the file: " + saveFileDialog1.FileName);
            }
            else
            {
                MessageBox.Show("Youcancel or closed the dialog.");
            }
            saveFileDialog1.Dispose();
            saveFileDialog1 = null;
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "JPG(*.JPG)|*.jpg | PNG(*.PNG)|*.png | All files(*.*)|*.*";
            save.InitialDirectory = @"F:\MyProject\Specialized_Projects\DemoProject\DemoProject\Image";

            if (save.ShowDialog() == DialogResult.OK)
            {
               
              MessageBox.Show("Bạn Đã Lưu Thay Đổi Thành Công");
            }
        }
    */



        private void ViewMode()
        {
            switch (_pMode)
            {
                case "FIND":
                case "ADD":
                 
                    cbbMaNV.Visible = false;
                    lblMaNV.Visible = false;
                    txtHoTen.Text = "";
                    txtTenKhac.Text = "";
                    txtThuongTru.Text = "";
                    cbbTonGiao.Text = "";
                    txtTamTru.Text = "";
                    cbbQuocTich.Text = "";
                    cbbTinhTrang.Text = "";
                    cbbGioiTinh.Text = "";
                    cbbdantoc.Text = "";
                    cbbTrinhDo.Text = "";
                    txtSDT.Text = "";
                    txtSNPT.Text = "";
                    txtHSCV.Text = "";
                    txtHSL.Text = "";
                    txtNoiSinh.Text = "";
                    cbbphongban.Text = "";
                    txtHSL.Text = "";
                    txtChucVu.Text = "";
                    txtNoiCap.Text = "";
                    txtEmail.Text = "";
                    txtMaSoThue.Text = "";
                    txtGhiChu.Text = "";
                    dtpkNgayCap.Text = "";
                    dtpkNgaySinh.Text = "";
                    dtpkNgayVL.Text = "";
                    txtCMTND.Text = "";
                    txtNgach.Text = "";
                    txtBac.Text = "";
                
                    grbcontrol.Enabled = false;
                    PanelNoiDung.Enabled = true;
                   
                    btnchange.Enabled = true;
                    ptrAnh.Image = null;
                    ptrAnh.Refresh();
                    //ptrAnh.Image = new Bitmap(@"F:\CodeWinform\DemoProject\DemoProject\Resources\people_contact-128.png");
                    break;
                case "EDIT":

                    grbcontrol.Enabled = false;
                    PanelNoiDung.Enabled = true;
                    btnchange.Enabled = true;

                    break;
                case "":
                    grbcontrol.Enabled = true;
                    PanelNoiDung.Enabled = false;
                    cbbMaNV.Visible = true;
                    lblMaNV.Visible = true;
                    btnchange.Enabled = false;
                    
                    break;
                default:
                    break;
            }
        }

        /*public void Matutang()
        {

            string s = "";
            if (ds.Tables[0].Rows.Count <= 0)
                s = "000001";
            else
            {
                int k;
                s = "NV";
                k = Convert.ToInt32(ds.Tables[0].Rows[ds.Tables[0].Rows.Count - 1][1].ToString().Substring(0, 6));
                k = k + 1;
                if (k < 10) s = s + "00000";
                else if (k < 100)
                    s = s + "0000";
                else if (k < 1000)
                    s = s + "000";
                else if (k < 10000)
                    s = s + "00";

                s = s + k.ToString();
            }
            cbbMaNV.Text = s;

        }*/
       
       
       
        private void Them()
        {

            try
            {
                SqlConnection cnn = new SqlConnection(MyApp.MSSQLConnectionString);
                cnn.Open();
                byte[] images = null;

                FileStream streem = new FileStream(imagelocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(streem);
                images = brs.ReadBytes((int)streem.Length);
                string query = "INSERT INTO tbl_NhanVien(MaNV,Anh,HoTen,GioiTinh,NgaySinh,NoiSinh,DCThuongTru,SDT,Gmail," +
                "TrinhDo,ChucVu,Phong,HSCV,HSL,MaSoThue,SNPhuThuoc,NgayVaoLam,GhiChu,DanToc,TenKhac,DCTamTru,NoiCap,NgayCap,TonGiao,QuocTich,TinhTrang,CMND,LuongCS,Ngach,Bac)" + "VALUES" +
                "('',@images,N'" + txtHoTen.Text + "',N'" + cbbGioiTinh.Text + "','" + dtpkNgaySinh.Value.ToString("MM/dd/yyyy") + "'," +
                "N'" + txtNoiSinh.Text + "',N'" + txtThuongTru.Text + "','" + txtSDT.Text + "','" + txtEmail.Text + "','" + cbbTrinhDo.Text + "'," +
                "'" + txtChucVu.Text + "','" + cbbphongban.Text + "','" + txtHSCV.Text + "','" + txtHSL.Text + "','" + txtMaSoThue.Text + "'," +
                "'" + txtSNPT.Text + "','" + dtpkNgayVL.Value.ToString("MM/dd/yyyy") + "',N'" + txtGhiChu.Text + "',N'" + cbbdantoc.Text + "'," +
                "N'" + txtTenKhac.Text + "',N'" + txtTamTru.Text + "',N'" + txtNoiCap.Text + "','" + dtpkNgayCap.Value.ToString("MM/dd/yyyy") + "'," +
                "N'" + cbbTonGiao.Text + "',N'" + cbbQuocTich.Text + "',N'" + cbbTinhTrang.Text + "','" + txtCMTND.Text + "','" + txtMucLuongCs.Text + "','"+txtNgach.Text+"','"+txtBac.Text+"' )" + ";" +
                "UPDATE tbl_PhongBan SET SLNV= (SELECT COUNT(*) FROM tbl_NhanVien WHERE tbl_NhanVien.Phong=tbl_PhongBan.MaPB)";

                cmd = new SqlCommand(query, cnn);
                cmd.Parameters.Add(new SqlParameter("@images", images));
                int N = cmd.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Dữ liệu Được thêm thành công");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Có Lỗi" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void Sua()
        {

                cnn.Open();
                byte[] images = null;
                FileStream streem = new FileStream(imagelocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(streem);
                images = brs.ReadBytes((int)streem.Length);
                
                string query = "UPDATE  tbl_NhanVien SET Anh=@images,HoTen=N'" + txtHoTen.Text + "',GioiTinh=N'" + cbbGioiTinh.Text + "',"+
                    "NgaySinh='" + dtpkNgaySinh.Value.ToString("MM/dd/yyyy") + "'," +
                    " NoiSinh=N'" + txtNoiSinh.Text + "',DCThuongTru=N'" + txtThuongTru.Text + "',SDT='" + txtSDT.Text + "',Gmail='" + txtEmail.Text + "',"+
                    "TrinhDo='" + cbbTrinhDo.Text + "',ChucVu='" + txtChucVu.Text + "'," +
                    "Phong='" + cbbphongban.Text + "',MaSoThue='" + txtMaSoThue.Text + "',"+
                    "SNPhuThuoc='" + txtSNPT.Text + "',NgayVaoLam='" + dtpkNgayVL.Value.ToString("MM/dd/yyyy") + "'," +
                    "GhiChu=N'" + txtGhiChu.Text + "',DanToc=N'" + cbbdantoc.Text + "',TenKhac=N'" + txtTenKhac.Text + "',DCTamTru=N'" + txtTamTru.Text + "',"+
                    "NoiCap=N'" + txtNoiCap.Text + "',NgayCap='" + dtpkNgayCap.Value.ToString("MM/dd/yyyy") + "'," +
                    "TonGiao=N'" + cbbTonGiao.Text + "',QuocTich=N'" + cbbQuocTich.Text + "',TinhTrang=N'" + cbbTinhTrang.Text + "',CMND='" + txtCMTND.Text + "', "+
                    "LuongCS='"+txtMucLuongCs.Text+"',HSCV ='"+ txtHSCV.Text + "',HSL='"+ txtHSL.Text + "' ,NgayHT='"+DateTime.Today.ToString("MM/dd/yyyy hh:mm:ss")+"', Ngach='"+txtNgach.Text+"',Bac='"+txtBac.Text+"' WHERE MaNV='" + cbbMaNV.Text + "'";
                cmd = new SqlCommand(query, cnn);
                cmd.Parameters.Add(new SqlParameter("@images", images));
                int N = cmd.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Dữ liệu Được Thay đổi thành công");
                /*  }
                  catch (Exception ex)
                  { MessageBox.Show("Có Lỗi" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }*/
            }
        private void btnghinhan_Click(object sender, EventArgs e)
        {

            switch (_pMode)
            {
                case "ADD":
                    Them();

                    loaddata();
                    loadfillitem();
                    _pMode = "";
                    ViewMode();
                    break;
                case "EDIT":
                    //editData();
                    Sua();



                    loaddata();
                    loadfillitem();
                    _pMode = "";
                    ViewMode();
                    break;
                default:
                   
                    break;
            }
        }

        private void cbbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            String vFilter = " Where (1=1)";

            vFilter = vFilter + " AND MaNV ='"+cbbMaNV.Text+"' ";
            loaddata(vFilter);
        }

        private void btnhuybo_Click(object sender, EventArgs e)
        {
            _pMode = "";
            ViewMode();
            loaddata();
            loadfillitem();
            AlignCenterToScreen();
        }

        private void bthSua_Click(object sender, EventArgs e)
        {
            _pMode = "EDIT";
           
            ViewMode();
            AlignCenterToScreen();
            String vFilter = " Where (1=1)";

            vFilter = vFilter + " AND Xoa=1 AND MaNV='"+cbbMaNV.Text+"' ";
            loaddata(vFilter);
            //loadfillitem();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPhongBan_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void txtPhongBan_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }

       

        private void cbbphongban_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void txtPhongBan_Click(object sender, EventArgs e)
        {
          
        }

        

        private void txtNgach_TextChanged(object sender, EventArgs e)
        {
            
        }

        

        private void btnfont_Click(object sender, EventArgs e)
        {  

            //fontDialog1.ShowDialog();
            if( fontDialog1.ShowDialog()== DialogResult.OK)
            {
                txtHoTen.Font = fontDialog1.Font;
                txtTenKhac.Font = fontDialog1.Font;
                txtThuongTru.Font = fontDialog1.Font;
                cbbTonGiao.Font = fontDialog1.Font;
                txtTamTru.Font = fontDialog1.Font;
                cbbQuocTich.Font = fontDialog1.Font;
                cbbTinhTrang.Font = fontDialog1.Font;
                cbbGioiTinh.Font = fontDialog1.Font;
                cbbdantoc.Font = fontDialog1.Font;
                cbbTrinhDo.Font = fontDialog1.Font;
                txtSDT.Font = fontDialog1.Font;
                txtSNPT.Font = fontDialog1.Font;
              
                txtNoiSinh.Font = fontDialog1.Font;
                cbbphongban.Font = fontDialog1.Font;
                txtHSL.Font = fontDialog1.Font;
                txtChucVu.Font = fontDialog1.Font;
                txtNoiCap.Font = fontDialog1.Font;
                txtEmail.Font = fontDialog1.Font;
                txtMaSoThue.Font = fontDialog1.Font;
                txtGhiChu.Font = fontDialog1.Font;
                dtpkNgayCap.Font = fontDialog1.Font;
                dtpkNgaySinh.Font = fontDialog1.Font;
                dtpkNgayVL.Font = fontDialog1.Font;
                txtCMTND.Font = fontDialog1.Font;
                cbbMaNV.Font = fontDialog1.Font;
                //
                txtNgach.Font = fontDialog1.Font;
                txtBac.Font = fontDialog1.Font;
                txtMucLuongCs.Font = fontDialog1.Font;
                txtHSCV.Font = fontDialog1.Font;
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {  txtTamTru.ForeColor= colorDialog1.Color;
                txtHoTen.ForeColor = colorDialog1.Color;
                txtTenKhac.ForeColor = colorDialog1.Color;
                txtThuongTru.ForeColor = colorDialog1.Color;
                cbbTonGiao.ForeColor = colorDialog1.Color;
                cbbQuocTich.ForeColor = colorDialog1.Color;
                cbbTinhTrang.ForeColor = colorDialog1.Color;
                cbbGioiTinh.ForeColor = colorDialog1.Color;
                cbbdantoc.ForeColor = colorDialog1.Color;
                cbbTrinhDo.ForeColor = colorDialog1.Color;
                txtSDT.ForeColor = colorDialog1.Color;
                txtSNPT.ForeColor = colorDialog1.Color;
                txtSNPT.ForeColor = colorDialog1.Color;
                txtBac.ForeColor = colorDialog1.Color;
                cbbphongban.ForeColor = colorDialog1.Color;
                txtHSL.ForeColor = colorDialog1.Color;
                txtChucVu.ForeColor = colorDialog1.Color;
                txtNoiCap.ForeColor = colorDialog1.Color;
                txtEmail.ForeColor = colorDialog1.Color;
                txtMaSoThue.ForeColor = colorDialog1.Color;
                txtGhiChu.ForeColor = colorDialog1.Color;
                dtpkNgayCap.ForeColor = colorDialog1.Color;
                dtpkNgaySinh.ForeColor = colorDialog1.Color;
                dtpkNgayVL.ForeColor = colorDialog1.Color;
                txtCMTND.ForeColor = colorDialog1.Color;
                cbbMaNV.ForeColor = colorDialog1.Color;
                txtNgach.ForeColor = colorDialog1.Color;
                txtHSCV.ForeColor = colorDialog1.Color;
                txtMucLuongCs.ForeColor = colorDialog1.Color;
            }
                }

        private void cbbQuocTich_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ItemContextAdd_Click(object sender, EventArgs e)
        { cbbQuocTich.Items.Add(cbbQuocTich.Text); }
           

        private void ItemContextDelete_Click(object sender, EventArgs e)
        {
            cbbQuocTich.Items.Remove(cbbQuocTich.Text);
        }

        private void txtChucVu_Click(object sender, EventArgs e)
        {
            
        }

        private void txtNgach_Click(object sender, EventArgs e)
        {
           
        }

        private void txtBac_Click(object sender, EventArgs e)
        {
            toolTipNote.SetToolTip(txtHSL, "Bậc Lương Không được để trông , double click để lựa chọn !");
        }

        private void thêmToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            cbbdantoc.Items.Add(cbbdantoc.Text);
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbbdantoc.Items.Remove(cbbdantoc.Text);
        }

        private void cbbphongban_Click(object sender, EventArgs e)
        {
            toolTipNote.SetToolTip(cbbphongban, "Phòng Ban Không được để trông, F10 để lựa chọn  !");
        }

        private void cbbphongban_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void cbbphongban_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F10:
                    FormSeLect.frmselect frm = new FormSeLect.frmselect();
                    frm._query = "Select MaPB as'Mã Phòng',TenPB as'Tên Phòng'from tbl_PhongBan ";
                    using (frm)
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            cbbphongban.Text = frm.Selected;
                            cbbphongban.SelectionStart = cbbphongban.Text.Length;
                           
                        }
                    }
                    break;
            }
        }

        private void cbbphongban_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cbbChucVu_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void cbbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbChucVu_Click(object sender, EventArgs e)
        {
            toolTipNote.SetToolTip(txtChucVu, " chức Vụ Không được để trông Nhấn F10 để lựa chọn !");
        }

        private void txtTenKhac_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelNoiDung_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtChucVu_DoubleClick(object sender, EventArgs e)
        {
            FormSeLect.frmselect frm = new FormSeLect.frmselect();
            frm._query = "Select MaCV as'Mã Chức Vụ', HSCV as 'Hệ Số'  from tbl_ChucVu ";
            using (frm)
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    txtChucVu.Text = frm.Selected;
                    txtChucVu.SelectionStart = txtChucVu.Text.Length;
                    txtHSCV.Text = frm.Selected2;
                    txtHSCV.SelectionStart = txtHSCV.Text.Length;



                }
            }
        }

        private void txtChucVu_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F10:
                    FormSeLect.frmselect frm = new FormSeLect.frmselect();
                    frm._query = "Select MaCV as'Mã Chức Vụ',HSCV as'Hệ Số Công Việc' from tbl_ChucVu ";
                    using (frm)
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            txtChucVu.Text = frm.Selected;
                            txtChucVu.SelectionStart = txtHSCV.Text.Length;
                            txtHSCV.Text = frm.Selected2;
                            txtHSCV.SelectionStart = txtHSCV.Text.Length;

                        }
                    }
                    break;
            }
        }

        private void txtChucVu_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNgach_DoubleClick(object sender, EventArgs e)
        {
            FormSeLect.frmselect frm = new FormSeLect.frmselect();
            frm._query = "Select MaNgach as'Ngạch', Loai as 'Loại'  from tbl_Ngach ";
            using (frm)
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    txtNgach.Text = frm.Selected;
                    txtNgach.SelectionStart = txtNgach.Text.Length;
                   



                }
            }
        }

        private void txtBac_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBac_DoubleClick(object sender, EventArgs e)
        { if (txtNgach.Text != "")
            {
                FormSeLect.frmselect frm = new FormSeLect.frmselect();
                frm._query = "Select Bac as'Bậc', HSLuong as 'Hệ Số Lương'  from tbl_Bac where MaNgach='" + txtNgach.Text + "' ";
                using (frm)
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        txtBac.Text = frm.Selected;
                        txtBac.SelectionStart = txtBac.Text.Length;
                        txtHSL.Text = frm.Selected2;
                        txtHSL.SelectionStart = txtHSL.Text.Length;




                    }
                }
            }
        else { MessageBox.Show("Bạn Chưa Nhập Ngạch Công Chức!"); }
        }

        private void txtMucLuongCs_DoubleClick(object sender, EventArgs e)
        {
           
                FormSeLect.frmselect frm = new FormSeLect.frmselect();
                frm._query = "SELECT LuongCS  FROM tbl_LuongCS WHERE  TuNgay<= '" + DateTime.Today.ToString("MM/dd/yyyy") + "' AND DenNgay >='" + DateTime.Today.ToString("MM/dd/yyyy") + "' ";
                using (frm)
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        txtMucLuongCs.Text = frm.Selected;
                        txtMucLuongCs.SelectionStart = txtMucLuongCs.Text.Length;
                        




                    }
                }
            }

        private void Add_Click(object sender, EventArgs e)
        {
           
        }

        private void Add_Click_1(object sender, EventArgs e)
        {
            cbbTonGiao.Items.Add(cbbTonGiao.Text);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            cbbTonGiao.Items.Remove(cbbTonGiao.Text);
        }

        private void ItemDelete_Click(object sender, EventArgs e)
        {
            cbbdantoc.Items.Remove(cbbdantoc.Text);
        }

        private void ItemAdd_Click(object sender, EventArgs e)
        {
            cbbdantoc.Items.Add(cbbdantoc.Text);
        }
    }
}

        
    

