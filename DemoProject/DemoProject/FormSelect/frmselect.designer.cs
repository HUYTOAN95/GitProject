namespace DemoProject.FormSeLect
{
    partial class frmselect
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
            this.dgvselect = new System.Windows.Forms.DataGridView();
            this.btnchon = new System.Windows.Forms.Button();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvselect)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvselect
            // 
            this.dgvselect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvselect.Location = new System.Drawing.Point(12, 12);
            this.dgvselect.Name = "dgvselect";
            this.dgvselect.Size = new System.Drawing.Size(393, 162);
            this.dgvselect.TabIndex = 0;
            this.dgvselect.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvbophan_KeyDown);
            // 
            // btnchon
            // 
            this.btnchon.BackColor = System.Drawing.Color.SeaGreen;
            this.btnchon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnchon.Location = new System.Drawing.Point(422, 34);
            this.btnchon.Name = "btnchon";
            this.btnchon.Size = new System.Drawing.Size(75, 27);
            this.btnchon.TabIndex = 1;
            this.btnchon.Text = "&Chọn";
            this.btnchon.UseVisualStyleBackColor = false;
            this.btnchon.Click += new System.EventHandler(this.btnchon_Click);
            // 
            // btnlammoi
            // 
            this.btnlammoi.BackColor = System.Drawing.Color.SeaGreen;
            this.btnlammoi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnlammoi.Location = new System.Drawing.Point(422, 78);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(75, 29);
            this.btnlammoi.TabIndex = 2;
            this.btnlammoi.Text = "&Làm Mới";
            this.btnlammoi.UseVisualStyleBackColor = false;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.SeaGreen;
            this.btnthoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnthoat.Location = new System.Drawing.Point(423, 122);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 28);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "&Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // frmselect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(507, 199);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnlammoi);
            this.Controls.Add(this.btnchon);
            this.Controls.Add(this.dgvselect);
            this.Name = "frmselect";
            this.Text = "Bảng Chọn";
            this.Load += new System.EventHandler(this.frmselectbophan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvselect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvselect;
        private System.Windows.Forms.Button btnchon;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.Button btnthoat;
    }
}