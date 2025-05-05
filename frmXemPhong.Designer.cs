namespace Đồ_Án
{
    partial class frmXemPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXemPhong));
            this.lblUpdate = new System.Windows.Forms.Label();
            this.picAnhPhong = new System.Windows.Forms.PictureBox();
            this.btnUpAnh = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUpdate
            // 
            this.lblUpdate.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblUpdate.Font = new System.Drawing.Font("Microsoft JhengHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdate.ForeColor = System.Drawing.Color.White;
            this.lblUpdate.Location = new System.Drawing.Point(0, 543);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(998, 43);
            this.lblUpdate.TabIndex = 8;
            this.lblUpdate.Text = "Hình ảnh chỉ mang tính chất minh họa";
            this.lblUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUpdate.Click += new System.EventHandler(this.lblUpdate_Click);
            // 
            // picAnhPhong
            // 
            this.picAnhPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.picAnhPhong.Image = ((System.Drawing.Image)(resources.GetObject("picAnhPhong.Image")));
            this.picAnhPhong.Location = new System.Drawing.Point(0, 0);
            this.picAnhPhong.Name = "picAnhPhong";
            this.picAnhPhong.Size = new System.Drawing.Size(998, 494);
            this.picAnhPhong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnhPhong.TabIndex = 9;
            this.picAnhPhong.TabStop = false;
            // 
            // btnUpAnh
            // 
            this.btnUpAnh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnUpAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpAnh.ForeColor = System.Drawing.Color.Red;
            this.btnUpAnh.Location = new System.Drawing.Point(12, 500);
            this.btnUpAnh.Name = "btnUpAnh";
            this.btnUpAnh.Size = new System.Drawing.Size(124, 40);
            this.btnUpAnh.TabIndex = 10;
            this.btnUpAnh.Text = "Tải Ảnh";
            this.btnUpAnh.UseVisualStyleBackColor = false;
            this.btnUpAnh.Click += new System.EventHandler(this.btnUpAnh_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Red;
            this.btnThoat.Location = new System.Drawing.Point(862, 500);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(124, 40);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmXemPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(998, 586);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnUpAnh);
            this.Controls.Add(this.picAnhPhong);
            this.Controls.Add(this.lblUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmXemPhong";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem Phòng";
            this.Load += new System.EventHandler(this.frmXemPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAnhPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.PictureBox picAnhPhong;
        private System.Windows.Forms.Button btnUpAnh;
        private System.Windows.Forms.Button btnThoat;
    }
}