namespace Đồ_Án
{
    partial class frmQuanLyDichVu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyDichVu));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.btnQLP = new System.Windows.Forms.Button();
            this.btnQLDV = new System.Windows.Forms.Button();
            this.btnQLKH = new System.Windows.Forms.Button();
            this.btnQLHD = new System.Windows.Forms.Button();
            this.btnQLHDon = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtDichVu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.grpDichVu = new System.Windows.Forms.GroupBox();
            this.btnReset2 = new System.Windows.Forms.Button();
            this.richTextboxMota = new System.Windows.Forms.RichTextBox();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtGiaDV = new System.Windows.Forms.TextBox();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblGiaDV = new System.Windows.Forms.Label();
            this.lblMaDv = new System.Windows.Forms.Label();
            this.lblTenDV = new System.Windows.Forms.Label();
            this.lblTextRun = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblQuanLyDichVu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            this.grpDichVu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 69);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.picIcon);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1193, 651);
            this.splitContainer1.SplitterDistance = 261;
            this.splitContainer1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnTrangChu);
            this.flowLayoutPanel1.Controls.Add(this.btnQLP);
            this.flowLayoutPanel1.Controls.Add(this.btnQLDV);
            this.flowLayoutPanel1.Controls.Add(this.btnQLKH);
            this.flowLayoutPanel1.Controls.Add(this.btnQLHD);
            this.flowLayoutPanel1.Controls.Add(this.btnQLHDon);
            this.flowLayoutPanel1.Controls.Add(this.btnDangXuat);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 180);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(255, 422);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTrangChu.FlatAppearance.BorderSize = 0;
            this.btnTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChu.ForeColor = System.Drawing.Color.Black;
            this.btnTrangChu.Image = ((System.Drawing.Image)(resources.GetObject("btnTrangChu.Image")));
            this.btnTrangChu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangChu.Location = new System.Drawing.Point(3, 3);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(252, 52);
            this.btnTrangChu.TabIndex = 5;
            this.btnTrangChu.Text = "         Trang Chủ";
            this.btnTrangChu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangChu.UseVisualStyleBackColor = false;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click_1);
            // 
            // btnQLP
            // 
            this.btnQLP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQLP.FlatAppearance.BorderSize = 0;
            this.btnQLP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLP.ForeColor = System.Drawing.Color.Black;
            this.btnQLP.Image = ((System.Drawing.Image)(resources.GetObject("btnQLP.Image")));
            this.btnQLP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLP.Location = new System.Drawing.Point(3, 61);
            this.btnQLP.Name = "btnQLP";
            this.btnQLP.Size = new System.Drawing.Size(252, 52);
            this.btnQLP.TabIndex = 2;
            this.btnQLP.Text = "         Quản Lý Phòng";
            this.btnQLP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLP.UseVisualStyleBackColor = false;
            this.btnQLP.Click += new System.EventHandler(this.btnQLP_Click_1);
            // 
            // btnQLDV
            // 
            this.btnQLDV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQLDV.FlatAppearance.BorderSize = 0;
            this.btnQLDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLDV.ForeColor = System.Drawing.Color.Red;
            this.btnQLDV.Image = ((System.Drawing.Image)(resources.GetObject("btnQLDV.Image")));
            this.btnQLDV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLDV.Location = new System.Drawing.Point(3, 119);
            this.btnQLDV.Name = "btnQLDV";
            this.btnQLDV.Size = new System.Drawing.Size(252, 52);
            this.btnQLDV.TabIndex = 3;
            this.btnQLDV.Text = "        Quản Lý Dịch Vụ";
            this.btnQLDV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLDV.UseVisualStyleBackColor = false;
            this.btnQLDV.Click += new System.EventHandler(this.btnQLDV_Click_1);
            // 
            // btnQLKH
            // 
            this.btnQLKH.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQLKH.FlatAppearance.BorderSize = 0;
            this.btnQLKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLKH.ForeColor = System.Drawing.Color.Black;
            this.btnQLKH.Image = ((System.Drawing.Image)(resources.GetObject("btnQLKH.Image")));
            this.btnQLKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLKH.Location = new System.Drawing.Point(3, 177);
            this.btnQLKH.Name = "btnQLKH";
            this.btnQLKH.Size = new System.Drawing.Size(252, 52);
            this.btnQLKH.TabIndex = 4;
            this.btnQLKH.Text = "         Quản Lý Khách Hàng";
            this.btnQLKH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLKH.UseVisualStyleBackColor = false;
            this.btnQLKH.Click += new System.EventHandler(this.btnQLKH_Click_1);
            // 
            // btnQLHD
            // 
            this.btnQLHD.BackColor = System.Drawing.Color.Transparent;
            this.btnQLHD.FlatAppearance.BorderSize = 0;
            this.btnQLHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLHD.ForeColor = System.Drawing.Color.Black;
            this.btnQLHD.Image = ((System.Drawing.Image)(resources.GetObject("btnQLHD.Image")));
            this.btnQLHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLHD.Location = new System.Drawing.Point(3, 235);
            this.btnQLHD.Name = "btnQLHD";
            this.btnQLHD.Size = new System.Drawing.Size(252, 52);
            this.btnQLHD.TabIndex = 1;
            this.btnQLHD.Text = "         Quản Lý Hợp Đồng";
            this.btnQLHD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLHD.UseVisualStyleBackColor = false;
            this.btnQLHD.Click += new System.EventHandler(this.btnQLHD_Click_1);
            // 
            // btnQLHDon
            // 
            this.btnQLHDon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQLHDon.FlatAppearance.BorderSize = 0;
            this.btnQLHDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLHDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLHDon.ForeColor = System.Drawing.Color.Black;
            this.btnQLHDon.Image = ((System.Drawing.Image)(resources.GetObject("btnQLHDon.Image")));
            this.btnQLHDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLHDon.Location = new System.Drawing.Point(3, 293);
            this.btnQLHDon.Name = "btnQLHDon";
            this.btnQLHDon.Size = new System.Drawing.Size(252, 52);
            this.btnQLHDon.TabIndex = 6;
            this.btnQLHDon.Text = "         Quản Lý Hóa Đơn";
            this.btnQLHDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLHDon.UseVisualStyleBackColor = false;
            this.btnQLHDon.Click += new System.EventHandler(this.btnQLHDon_Click_1);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.Black;
            this.btnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Image")));
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(3, 351);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(252, 52);
            this.btnDangXuat.TabIndex = 7;
            this.btnDangXuat.Text = "         Đăng Xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click_1);
            // 
            // picIcon
            // 
            this.picIcon.Image = ((System.Drawing.Image)(resources.GetObject("picIcon.Image")));
            this.picIcon.Location = new System.Drawing.Point(58, 20);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(171, 154);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 2;
            this.picIcon.TabStop = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel1.Controls.Add(this.dgvDichVu);
            this.splitContainer2.Panel1.Controls.Add(this.grpDichVu);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer2.Panel2.Controls.Add(this.lblTextRun);
            this.splitContainer2.Size = new System.Drawing.Size(928, 651);
            this.splitContainer2.SplitterDistance = 594;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer2_SplitterMoved);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.txtDichVu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(16, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 323);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Red;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(11, 117);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(109, 35);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "    Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.Red;
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.Location = new System.Drawing.Point(145, 117);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(95, 35);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "    Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtDichVu
            // 
            this.txtDichVu.Location = new System.Drawing.Point(11, 75);
            this.txtDichVu.Name = "txtDichVu";
            this.txtDichVu.Size = new System.Drawing.Size(229, 30);
            this.txtDichVu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dịch vụ:";
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDichVu.BackgroundColor = System.Drawing.Color.White;
            this.dgvDichVu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDichVu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDichVu.Location = new System.Drawing.Point(0, 0);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvDichVu.RowHeadersWidth = 51;
            this.dgvDichVu.RowTemplate.Height = 24;
            this.dgvDichVu.Size = new System.Drawing.Size(928, 237);
            this.dgvDichVu.TabIndex = 2;
            this.dgvDichVu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDichVu_CellContentClick);
            // 
            // grpDichVu
            // 
            this.grpDichVu.BackColor = System.Drawing.Color.White;
            this.grpDichVu.Controls.Add(this.btnReset2);
            this.grpDichVu.Controls.Add(this.richTextboxMota);
            this.grpDichVu.Controls.Add(this.txtTenDV);
            this.grpDichVu.Controls.Add(this.btnLuu);
            this.grpDichVu.Controls.Add(this.btnSua);
            this.grpDichVu.Controls.Add(this.btnXoa);
            this.grpDichVu.Controls.Add(this.btnThem);
            this.grpDichVu.Controls.Add(this.txtGiaDV);
            this.grpDichVu.Controls.Add(this.txtMaDV);
            this.grpDichVu.Controls.Add(this.lblMoTa);
            this.grpDichVu.Controls.Add(this.lblGiaDV);
            this.grpDichVu.Controls.Add(this.lblMaDv);
            this.grpDichVu.Controls.Add(this.lblTenDV);
            this.grpDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDichVu.ForeColor = System.Drawing.Color.Red;
            this.grpDichVu.Location = new System.Drawing.Point(323, 243);
            this.grpDichVu.Name = "grpDichVu";
            this.grpDichVu.Size = new System.Drawing.Size(602, 323);
            this.grpDichVu.TabIndex = 0;
            this.grpDichVu.TabStop = false;
            this.grpDichVu.Text = "Dịch vụ ";
            this.grpDichVu.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnReset2
            // 
            this.btnReset2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReset2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset2.Location = new System.Drawing.Point(484, 263);
            this.btnReset2.Name = "btnReset2";
            this.btnReset2.Size = new System.Drawing.Size(101, 35);
            this.btnReset2.TabIndex = 14;
            this.btnReset2.Text = "Reset";
            this.btnReset2.UseVisualStyleBackColor = false;
            this.btnReset2.Click += new System.EventHandler(this.btnReset2_Click);
            // 
            // richTextboxMota
            // 
            this.richTextboxMota.Location = new System.Drawing.Point(172, 166);
            this.richTextboxMota.Name = "richTextboxMota";
            this.richTextboxMota.Size = new System.Drawing.Size(404, 81);
            this.richTextboxMota.TabIndex = 13;
            this.richTextboxMota.Text = "";
            // 
            // txtTenDV
            // 
            this.txtTenDV.Location = new System.Drawing.Point(172, 77);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(404, 30);
            this.txtTenDV.TabIndex = 12;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(368, 263);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(101, 35);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(252, 263);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(101, 35);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(136, 263);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(101, 35);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(20, 263);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(101, 35);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtGiaDV
            // 
            this.txtGiaDV.Location = new System.Drawing.Point(172, 122);
            this.txtGiaDV.Name = "txtGiaDV";
            this.txtGiaDV.Size = new System.Drawing.Size(404, 30);
            this.txtGiaDV.TabIndex = 9;
            this.txtGiaDV.TextChanged += new System.EventHandler(this.txtSoNguoi_TextChanged);
            // 
            // txtMaDV
            // 
            this.txtMaDV.Location = new System.Drawing.Point(172, 29);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Size = new System.Drawing.Size(404, 30);
            this.txtMaDV.TabIndex = 9;
            this.txtMaDV.TextChanged += new System.EventHandler(this.txtSoNguoi_TextChanged);
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMoTa.Location = new System.Drawing.Point(25, 166);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(73, 25);
            this.lblMoTa.TabIndex = 0;
            this.lblMoTa.Text = "Mô tả:";
            // 
            // lblGiaDV
            // 
            this.lblGiaDV.AutoSize = true;
            this.lblGiaDV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGiaDV.Location = new System.Drawing.Point(25, 123);
            this.lblGiaDV.Name = "lblGiaDV";
            this.lblGiaDV.Size = new System.Drawing.Size(127, 25);
            this.lblGiaDV.TabIndex = 0;
            this.lblGiaDV.Text = "Giá dịch vụ:";
            // 
            // lblMaDv
            // 
            this.lblMaDv.AutoSize = true;
            this.lblMaDv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMaDv.Location = new System.Drawing.Point(25, 37);
            this.lblMaDv.Name = "lblMaDv";
            this.lblMaDv.Size = new System.Drawing.Size(124, 25);
            this.lblMaDv.TabIndex = 0;
            this.lblMaDv.Text = "Mã dịch vụ:";
            this.lblMaDv.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTenDV
            // 
            this.lblTenDV.AutoSize = true;
            this.lblTenDV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTenDV.Location = new System.Drawing.Point(25, 80);
            this.lblTenDV.Name = "lblTenDV";
            this.lblTenDV.Size = new System.Drawing.Size(132, 25);
            this.lblTenDV.TabIndex = 0;
            this.lblTenDV.Text = "Tên dịch vụ:";
            this.lblTenDV.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTextRun
            // 
            this.lblTextRun.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTextRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextRun.Location = new System.Drawing.Point(0, 18);
            this.lblTextRun.Name = "lblTextRun";
            this.lblTextRun.Size = new System.Drawing.Size(928, 35);
            this.lblTextRun.TabIndex = 0;
            this.lblTextRun.Text = "   Liên hệ: 0974739146";
            this.lblTextRun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblQuanLyDichVu
            // 
            this.lblQuanLyDichVu.BackColor = System.Drawing.Color.White;
            this.lblQuanLyDichVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblQuanLyDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLyDichVu.ForeColor = System.Drawing.Color.White;
            this.lblQuanLyDichVu.Image = ((System.Drawing.Image)(resources.GetObject("lblQuanLyDichVu.Image")));
            this.lblQuanLyDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblQuanLyDichVu.Location = new System.Drawing.Point(0, 0);
            this.lblQuanLyDichVu.Name = "lblQuanLyDichVu";
            this.lblQuanLyDichVu.Size = new System.Drawing.Size(1193, 69);
            this.lblQuanLyDichVu.TabIndex = 1;
            this.lblQuanLyDichVu.Text = "QUẢN LÝ DỊCH VỤ";
            this.lblQuanLyDichVu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmQuanLyDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1193, 720);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lblQuanLyDichVu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmQuanLyDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Dịch Vụ";
            this.Load += new System.EventHandler(this.frmQuanLyDichVu_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            this.grpDichVu.ResumeLayout(false);
            this.grpDichVu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblQuanLyDichVu;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox grpDichVu;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblGiaDV;
        private System.Windows.Forms.Label lblTenDV;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.Label lblMaDv;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label lblTextRun;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.TextBox txtGiaDV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.TextBox txtDichVu;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.RichTextBox richTextboxMota;
        private System.Windows.Forms.Button btnReset2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.Button btnQLP;
        private System.Windows.Forms.Button btnQLDV;
        private System.Windows.Forms.Button btnQLKH;
        private System.Windows.Forms.Button btnQLHD;
        private System.Windows.Forms.Button btnQLHDon;
        private System.Windows.Forms.Button btnDangXuat;
    }
}