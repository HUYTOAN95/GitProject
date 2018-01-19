namespace DemoProject.UsersForm
{
    partial class FrmBackup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbbselect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSelect = new System.Windows.Forms.DataGridView();
            this.btnrestore = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.grbbutton = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelect)).BeginInit();
            this.grbbutton.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbselect
            // 
            this.cbbselect.FormattingEnabled = true;
            this.cbbselect.Items.AddRange(new object[] {
            "Nhân Viên",
            "Phòng Ban"});
            this.cbbselect.Location = new System.Drawing.Point(114, 20);
            this.cbbselect.Name = "cbbselect";
            this.cbbselect.Size = new System.Drawing.Size(132, 21);
            this.cbbselect.TabIndex = 0;
            this.cbbselect.SelectedIndexChanged += new System.EventHandler(this.cbbselect_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(44, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dữ Liệu ";
            // 
            // dgvSelect
            // 
            this.dgvSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelect.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvSelect.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvSelect.Location = new System.Drawing.Point(12, 61);
            this.dgvSelect.Name = "dgvSelect";
            this.dgvSelect.Size = new System.Drawing.Size(800, 243);
            this.dgvSelect.TabIndex = 2;
            // 
            // btnrestore
            // 
            this.btnrestore.BackColor = System.Drawing.Color.SeaGreen;
            this.btnrestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnrestore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnrestore.Location = new System.Drawing.Point(20, 9);
            this.btnrestore.Name = "btnrestore";
            this.btnrestore.Size = new System.Drawing.Size(85, 35);
            this.btnrestore.TabIndex = 3;
            this.btnrestore.Text = "&Phục Hồi ";
            this.btnrestore.UseVisualStyleBackColor = false;
            this.btnrestore.Click += new System.EventHandler(this.btnrestore_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.SeaGreen;
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndelete.Location = new System.Drawing.Point(115, 9);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(81, 35);
            this.btndelete.TabIndex = 4;
            this.btndelete.Text = "&Xóa  Bỏ";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.Firebrick;
            this.btnthoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnthoat.Location = new System.Drawing.Point(725, 310);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 34);
            this.btnthoat.TabIndex = 5;
            this.btnthoat.Text = "&Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // grbbutton
            // 
            this.grbbutton.BackColor = System.Drawing.Color.Transparent;
            this.grbbutton.Controls.Add(this.btnrestore);
            this.grbbutton.Controls.Add(this.btndelete);
            this.grbbutton.Location = new System.Drawing.Point(604, 6);
            this.grbbutton.Name = "grbbutton";
            this.grbbutton.Size = new System.Drawing.Size(208, 49);
            this.grbbutton.TabIndex = 6;
            this.grbbutton.TabStop = false;
            // 
            // FrmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(824, 355);
            this.ControlBox = false;
            this.Controls.Add(this.grbbutton);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.dgvSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbselect);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FrmBackup";
            this.ShowIcon = false;
            this.Text = "Sao Lưu";
            this.Load += new System.EventHandler(this.FrmBackup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelect)).EndInit();
            this.grbbutton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbselect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSelect;
        private System.Windows.Forms.Button btnrestore;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.GroupBox grbbutton;
    }
}