using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DemoProject.SO;
using DemoProject.SystemForm;


namespace DemoProject.SO
{
    class PhanQuyen
    {
        public static FrmMain frmmain = null;


        private static string _sPubItemMnu = ";mnuSystem;ItemMnuSystemLogin;ItemMnuSystemExit;".ToUpper();
        /// <summary>
        /// Ẩn các menu trước khi kết nối thành công
        /// </summary>
        public static void HideAll()
        {
            //Duy menu bar (ngang)
            for (int i = 0; i < frmmain.MainMenuStrip.Items.Count; i++)
            {
                if (frmmain.MainMenuStrip.Items[i].GetType().ToString() == "System.Windows.Forms.ToolStripMenuItem")
                {

                    //Bắt đầu từ menu cấp 1
                    ToolStripMenuItem item1 = (ToolStripMenuItem)frmmain.MainMenuStrip.Items[i];

                    //Kiem tra neu itemmenu nam tong danh sach public
                    if (_sPubItemMnu.Contains(";" + item1.Name.ToUpper() + ";"))
                    {
                        //thi quay lai vong lap
                        //continue; // không de conti/
                    }
                    else
                    {  
                        frmmain.menuStrip1.Items[0].Visible = false;
                        //frmmain.menuStrip1.Items[0].Enabled = true;
                        item1.Visible = false; //ẩn menu cấp 1 (menu bar)    
                    }

                    //tiếp tục xử lý ẩn menu cấp 2
                    if (item1.DropDownItems.Count > 1)
                    {
                        for (int j = 0; j < item1.DropDownItems.Count; j++)
                        {
                            if (item1.DropDownItems[j].GetType().ToString() == "System.Windows.Forms.ToolStripSeparator") // bỏ qua phân cách menu
                            {
                                continue;
                            }
                            else
                            {
                                ToolStripMenuItem item2 = (ToolStripMenuItem)item1.DropDownItems[j];
                                if (_sPubItemMnu.Contains(";" + item2.Name.ToUpper() + ";"))
                                    continue;
                                else
                                    item2.Enabled = false;  // làm mờ menu cấp 2 (dropdown of menubar)
                            }

                        }
                    }                    
                }
            }

            //Hien thi len 1 so menu chinh (manual)
            //frmmain.menuStrip1.MnuHeThong.Visible = true;
            //frmmain.ItemMnuSystemLogin.Visible = true;
        }
        /// <summary>
        /// Hiển thị các menu theo quyền
        /// </summary>
        public static void ShowAll()
        {
             //Duy menu bar (ngang)
            for (int i = 0; i < frmmain.MainMenuStrip.Items.Count; i++)
            {
                if (frmmain.MainMenuStrip.Items[i].GetType().ToString() == "System.Windows.Forms.ToolStripMenuItem")
                {
                    // bắt đầu từ menu cấp 1
                    ToolStripMenuItem item1 = (ToolStripMenuItem)frmmain.MainMenuStrip.Items[i];
                    item1.Visible = true;

                    // xử lý menu cấp 2
                    if (item1.DropDownItems.Count > 0)
                    {
                        for (int j = 0; j < item1.DropDownItems.Count; j++)
                        {
                            if (item1.DropDownItems[j].GetType().ToString() == "System.Windows.Forms.ToolStripSeparator")
                            {
                                continue;
                            }
                            else
                            {
                                ToolStripMenuItem item2 = (ToolStripMenuItem)item1.DropDownItems[j];
                                item2.Enabled = true;
                            }
                            
                        }
                    }                    
                }
            }
        }
     
    public static void ShowUser()
        {
            //Duy menu bar (ngang)
            for (int i = 0; i < frmmain.menuStrip1.Items.Count; i++)
            {
                if (frmmain.menuStrip1.Items[i].GetType().ToString() == "System.Windows.Forms.ToolStripMenuItem")
                {
                    // bắt đầu từ menu cấp 1
                    ToolStripMenuItem item1 = (ToolStripMenuItem)frmmain.menuStrip1.Items[i];
                    frmmain.menuStrip1.Items[0].Visible = true;
                   
                    
                   /* frmmain.menuStrip1.Items[1].Visible = false;
                    frmmain.menuStrip1.Items[2].Visible = false;
                    frmmain.menuStrip1.Items[3].Visible = false;
                    frmmain.menuStrip1.Items[4].Visible = false;
                    frmmain.menuStrip1.Items[5].Visible = false;*/
                    item1.Visible = false;

                    // xử lý menu cấp 2
                    if (item1.DropDownItems.Count > 0)
                    {
                        for (int j = 0; j < item1.DropDownItems.Count; j++)
                        {
                            if (item1.DropDownItems[j].GetType().ToString() == "System.Windows.Forms.ToolStripSeparator")
                            {
                                continue;
                            }
                            else
                            {
                                ToolStripMenuItem item2 = (ToolStripMenuItem)item1.DropDownItems[j];
                                item2.Enabled = true;
                            }

                        }
                    }
                }
            }
        }
    public static void ShowUser1()
    {
        //Duy menu bar (ngang)
        for (int i = 0; i < frmmain.menuStrip1.Items.Count; i++)
        {
            if (frmmain.menuStrip1.Items[i].GetType().ToString() == "System.Windows.Forms.ToolStripMenuItem")
            {
                // bắt đầu từ menu cấp 1
                ToolStripMenuItem item1 = (ToolStripMenuItem)frmmain.menuStrip1.Items[i];
                frmmain.menuStrip1.Items[0].Visible = true;
                frmmain.menuStrip1.Items[1].Visible = true;
                 frmmain.menuStrip1.Items[2].Visible = true;
                 frmmain.menuStrip1.Items[3].Visible = true;
                 /*frmmain.menuStrip1.Items[4].Visible = false;
                 frmmain.menuStrip1.Items[5].Visible = false;*/
                item1.Visible = false;

                // xử lý menu cấp 2
                if (item1.DropDownItems.Count > 0)
                {
                    for (int j = 0; j < item1.DropDownItems.Count; j++)
                    {
                        if (item1.DropDownItems[j].GetType().ToString() == "System.Windows.Forms.ToolStripSeparator")
                        {
                            continue;
                        }
                        else
                        {
                            ToolStripMenuItem item2 = (ToolStripMenuItem)item1.DropDownItems[j];
                            item2.Enabled = true;
                        }

                    }
                }
            }
        }
    }
    
    
    }
}
