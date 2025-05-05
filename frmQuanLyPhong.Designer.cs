namespace Đồ_Án
{
    partial class frmQuanLyPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyPhong));
            this.lblTheLoaiPhong = new System.Windows.Forms.Label();
            this.grpTimPhong = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.radDaThue = new System.Windows.Forms.RadioButton();
            this.radTrong = new System.Windows.Forms.RadioButton();
            this.lblTinhTrangPhong = new System.Windows.Forms.Label();
            this.cboLoaiPhong = new System.Windows.Forms.ComboBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblThongTinPhong = new System.Windows.Forms.Label();
            this.dgvTTP = new System.Windows.Forms.DataGridView();
            this.grpTTP = new System.Windows.Forms.GroupBox();
            this.btnXemPhong = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.txtLoaiPhong = new System.Windows.Forms.TextBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.lblLoaiPhong = new System.Windows.Forms.Label();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.btnQLP = new System.Windows.Forms.Button();
            this.btnQLDV = new System.Windows.Forms.Button();
            this.btnQLKH = new System.Windows.Forms.Button();
            this.btnQLHD = new System.Windows.Forms.Button();
            this.btnQLHDon = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.dgvLoaiPhong = new System.Windows.Forms.DataGridView();
            this.grpLoaiPhong = new System.Windows.Forms.GroupBox();
            this.txtSoNguoi = new System.Windows.Forms.TextBox();
            this.btnXoaLP = new System.Windows.Forms.Button();
            this.btnCapNhatLP = new System.Windows.Forms.Button();
            this.btnThemLP = new System.Windows.Forms.Button();
            this.txtGiaThueLP = new System.Windows.Forms.TextBox();
            this.txtMaLP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpTimPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTP)).BeginInit();
            this.grpTTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).BeginInit();
            this.grpLoaiPhong.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTheLoaiPhong
            // 
            this.lblTheLoaiPhong.AutoSize = true;
            this.lblTheLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheLoaiPhong.ForeColor = System.Drawing.Color.Black;
            this.lblTheLoaiPhong.Location = new System.Drawing.Point(11, 32);
            this.lblTheLoaiPhong.Name = "lblTheLoaiPhong";
            this.lblTheLoaiPhong.Size = new System.Drawing.Size(169, 25);
            this.lblTheLoaiPhong.TabIndex = 6;
            this.lblTheLoaiPhong.Text = "Thể loại phòng: ";
            // 
            // grpTimPhong
            // 
            this.grpTimPhong.BackColor = System.Drawing.Color.Transparent;
            this.grpTimPhong.Controls.Add(this.btnReset);
            this.grpTimPhong.Controls.Add(this.radDaThue);
            this.grpTimPhong.Controls.Add(this.radTrong);
            this.grpTimPhong.Controls.Add(this.lblTinhTrangPhong);
            this.grpTimPhong.Controls.Add(this.cboLoaiPhong);
            this.grpTimPhong.Controls.Add(this.btnTim);
            this.grpTimPhong.Controls.Add(this.lblTheLoaiPhong);
            this.grpTimPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpTimPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTimPhong.ForeColor = System.Drawing.Color.Red;
            this.grpTimPhong.Location = new System.Drawing.Point(305, 427);
            this.grpTimPhong.Name = "grpTimPhong";
            this.grpTimPhong.Size = new System.Drawing.Size(262, 248);
            this.grpTimPhong.TabIndex = 10;
            this.grpTimPhong.TabStop = false;
            this.grpTimPhong.Text = "Tìm Phòng";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(15, 201);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(91, 36);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // radDaThue
            // 
            this.radDaThue.AutoSize = true;
            this.radDaThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDaThue.ForeColor = System.Drawing.Color.Black;
            this.radDaThue.Location = new System.Drawing.Point(122, 155);
            this.radDaThue.Name = "radDaThue";
            this.radDaThue.Size = new System.Drawing.Size(108, 29);
            this.radDaThue.TabIndex = 17;
            this.radDaThue.TabStop = true;
            this.radDaThue.Text = "Đã thuê";
            this.radDaThue.UseVisualStyleBackColor = true;
            // 
            // radTrong
            // 
            this.radTrong.AutoSize = true;
            this.radTrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTrong.ForeColor = System.Drawing.Color.Black;
            this.radTrong.Location = new System.Drawing.Point(15, 155);
            this.radTrong.Name = "radTrong";
            this.radTrong.Size = new System.Drawing.Size(90, 29);
            this.radTrong.TabIndex = 16;
            this.radTrong.TabStop = true;
            this.radTrong.Text = "Trống";
            this.radTrong.UseVisualStyleBackColor = true;
            // 
            // lblTinhTrangPhong
            // 
            this.lblTinhTrangPhong.AutoSize = true;
            this.lblTinhTrangPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinhTrangPhong.ForeColor = System.Drawing.Color.Black;
            this.lblTinhTrangPhong.Location = new System.Drawing.Point(11, 127);
            this.lblTinhTrangPhong.Name = "lblTinhTrangPhong";
            this.lblTinhTrangPhong.Size = new System.Drawing.Size(183, 25);
            this.lblTinhTrangPhong.TabIndex = 15;
            this.lblTinhTrangPhong.Text = "Tình trạng phòng:";
            // 
            // cboLoaiPhong
            // 
            this.cboLoaiPhong.FormattingEnabled = true;
            this.cboLoaiPhong.Items.AddRange(new object[] {
            "Phòng Đơn",
            "Phòng Đôi ",
            "Phòng Tập Thể 3",
            "Phòng Tập Thể 4 "});
            this.cboLoaiPhong.Location = new System.Drawing.Point(16, 60);
            this.cboLoaiPhong.Name = "cboLoaiPhong";
            this.cboLoaiPhong.Size = new System.Drawing.Size(214, 33);
            this.cboLoaiPhong.TabIndex = 14;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTim.BackgroundImage")));
            this.btnTim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.ForeColor = System.Drawing.Color.Red;
            this.btnTim.Location = new System.Drawing.Point(139, 201);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(91, 36);
            this.btnTim.TabIndex = 10;
            this.btnTim.Text = "   Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblThongTinPhong
            // 
            this.lblThongTinPhong.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblThongTinPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblThongTinPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinPhong.ForeColor = System.Drawing.Color.White;
            this.lblThongTinPhong.Image = ((System.Drawing.Image)(resources.GetObject("lblThongTinPhong.Image")));
            this.lblThongTinPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblThongTinPhong.Location = new System.Drawing.Point(0, 0);
            this.lblThongTinPhong.Name = "lblThongTinPhong";
            this.lblThongTinPhong.Size = new System.Drawing.Size(1193, 77);
            this.lblThongTinPhong.TabIndex = 0;
            this.lblThongTinPhong.Text = "THÔNG TIN PHÒNG";
            this.lblThongTinPhong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblThongTinPhong.Click += new System.EventHandler(this.lblThongTinPhong_Click);
            // 
            // dgvTTP
            // 
            this.dgvTTP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTTP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTTP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTTP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvTTP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTTP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTP.GridColor = System.Drawing.Color.White;
            this.dgvTTP.Location = new System.Drawing.Point(713, 77);
            this.dgvTTP.Name = "dgvTTP";
            this.dgvTTP.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTTP.RowHeadersWidth = 51;
            this.dgvTTP.RowTemplate.Height = 24;
            this.dgvTTP.Size = new System.Drawing.Size(480, 321);
            this.dgvTTP.TabIndex = 11;
            this.dgvTTP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTTP_CellContentClick);
            // 
            // grpTTP
            // 
            this.grpTTP.BackColor = System.Drawing.Color.Transparent;
            this.grpTTP.Controls.Add(this.btnXemPhong);
            this.grpTTP.Controls.Add(this.btnSua);
            this.grpTTP.Controls.Add(this.btnXoa);
            this.grpTTP.Controls.Add(this.btnThem);
            this.grpTTP.Controls.Add(this.txtTinhTrang);
            this.grpTTP.Controls.Add(this.txtLoaiPhong);
            this.grpTTP.Controls.Add(this.txtMaPhong);
            this.grpTTP.Controls.Add(this.lblTinhTrang);
            this.grpTTP.Controls.Add(this.lblLoaiPhong);
            this.grpTTP.Controls.Add(this.lblMaPhong);
            this.grpTTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTTP.ForeColor = System.Drawing.Color.Red;
            this.grpTTP.Location = new System.Drawing.Point(573, 427);
            this.grpTTP.Name = "grpTTP";
            this.grpTTP.Size = new System.Drawing.Size(608, 248);
            this.grpTTP.TabIndex = 0;
            this.grpTTP.TabStop = false;
            this.grpTTP.Text = "Thông tin phòng";
            this.grpTTP.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnXemPhong
            // 
            this.btnXemPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnXemPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemPhong.ForeColor = System.Drawing.Color.Red;
            this.btnXemPhong.Location = new System.Drawing.Point(426, 195);
            this.btnXemPhong.Name = "btnXemPhong";
            this.btnXemPhong.Size = new System.Drawing.Size(146, 42);
            this.btnXemPhong.TabIndex = 5;
            this.btnXemPhong.Text = "Xem phòng";
            this.btnXemPhong.UseVisualStyleBackColor = false;
            this.btnXemPhong.Click += new System.EventHandler(this.btnXemPhong_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.Red;
            this.btnSua.Location = new System.Drawing.Point(218, 195);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(129, 42);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Cập nhật";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.Location = new System.Drawing.Point(126, 195);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(77, 42);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.Red;
            this.btnThem.Location = new System.Drawing.Point(23, 196);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 42);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(157, 143);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(415, 30);
            this.txtTinhTrang.TabIndex = 4;
            this.txtTinhTrang.TextChanged += new System.EventHandler(this.txtGiaThue_TextChanged);
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.Location = new System.Drawing.Point(157, 95);
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.Size = new System.Drawing.Size(415, 30);
            this.txtLoaiPhong.TabIndex = 4;
            this.txtLoaiPhong.TextChanged += new System.EventHandler(this.txtLoaiPhong_TextChanged);
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(157, 45);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(415, 30);
            this.txtMaPhong.TabIndex = 4;
            this.txtMaPhong.TextChanged += new System.EventHandler(this.txtMaPhong_TextChanged);
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.ForeColor = System.Drawing.Color.Black;
            this.lblTinhTrang.Location = new System.Drawing.Point(17, 148);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(125, 25);
            this.lblTinhTrang.TabIndex = 3;
            this.lblTinhTrang.Text = "Tình Trạng:";
            this.lblTinhTrang.Click += new System.EventHandler(this.lblGiaThue_Click);
            // 
            // lblLoaiPhong
            // 
            this.lblLoaiPhong.AutoSize = true;
            this.lblLoaiPhong.ForeColor = System.Drawing.Color.Black;
            this.lblLoaiPhong.Location = new System.Drawing.Point(17, 98);
            this.lblLoaiPhong.Name = "lblLoaiPhong";
            this.lblLoaiPhong.Size = new System.Drawing.Size(126, 25);
            this.lblLoaiPhong.TabIndex = 3;
            this.lblLoaiPhong.Text = "Loại phòng:";
            this.lblLoaiPhong.Click += new System.EventHandler(this.lblLoaiPhong_Click);
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.AutoSize = true;
            this.lblMaPhong.ForeColor = System.Drawing.Color.Black;
            this.lblMaPhong.Location = new System.Drawing.Point(17, 48);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(117, 25);
            this.lblMaPhong.TabIndex = 3;
            this.lblMaPhong.Text = "Mã Phòng:";
            this.lblMaPhong.Click += new System.EventHandler(this.lblMaPhong_Click);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitter1.Location = new System.Drawing.Point(0, 77);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(299, 610);
            this.splitter1.TabIndex = 12;
            this.splitter1.TabStop = false;
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picIcon.Image = ((System.Drawing.Image)(resources.GetObject("picIcon.Image")));
            this.picIcon.Location = new System.Drawing.Point(58, 96);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(161, 151);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 14;
            this.picIcon.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel1.Controls.Add(this.btnTrangChu);
            this.flowLayoutPanel1.Controls.Add(this.btnQLP);
            this.flowLayoutPanel1.Controls.Add(this.btnQLDV);
            this.flowLayoutPanel1.Controls.Add(this.btnQLKH);
            this.flowLayoutPanel1.Controls.Add(this.btnQLHD);
            this.flowLayoutPanel1.Controls.Add(this.btnQLHDon);
            this.flowLayoutPanel1.Controls.Add(this.btnDangXuat);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 253);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(292, 422);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTrangChu.FlatAppearance.BorderSize = 0;
            this.btnTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChu.ForeColor = System.Drawing.Color.Black;
            this.btnTrangChu.Image = ((System.Drawing.Image)(resources.GetObject("btnTrangChu.Image")));
            this.btnTrangChu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangChu.Location = new System.Drawing.Point(3, 3);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(281, 52);
            this.btnTrangChu.TabIndex = 5;
            this.btnTrangChu.Text = "         Trang Chủ";
            this.btnTrangChu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangChu.UseVisualStyleBackColor = false;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click_1);
            // 
            // btnQLP
            // 
            this.btnQLP.BackColor = System.Drawing.Color.Transparent;
            this.btnQLP.FlatAppearance.BorderSize = 0;
            this.btnQLP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLP.ForeColor = System.Drawing.Color.Red;
            this.btnQLP.Image = ((System.Drawing.Image)(resources.GetObject("btnQLP.Image")));
            this.btnQLP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLP.Location = new System.Drawing.Point(3, 61);
            this.btnQLP.Name = "btnQLP";
            this.btnQLP.Size = new System.Drawing.Size(281, 52);
            this.btnQLP.TabIndex = 2;
            this.btnQLP.Text = "        Quản Lý Phòng";
            this.btnQLP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLP.UseVisualStyleBackColor = false;
            this.btnQLP.Click += new System.EventHandler(this.btnQLP_Click_1);
            // 
            // btnQLDV
            // 
            this.btnQLDV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQLDV.FlatAppearance.BorderSize = 0;
            this.btnQLDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLDV.ForeColor = System.Drawing.Color.Black;
            this.btnQLDV.Image = ((System.Drawing.Image)(resources.GetObject("btnQLDV.Image")));
            this.btnQLDV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLDV.Location = new System.Drawing.Point(3, 119);
            this.btnQLDV.Name = "btnQLDV";
            this.btnQLDV.Size = new System.Drawing.Size(281, 52);
            this.btnQLDV.TabIndex = 3;
            this.btnQLDV.Text = "         Quản Lý Dịch Vụ";
            this.btnQLDV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLDV.UseVisualStyleBackColor = false;
            this.btnQLDV.Click += new System.EventHandler(this.btnQLDV_Click_1);
            // 
            // btnQLKH
            // 
            this.btnQLKH.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQLKH.FlatAppearance.BorderSize = 0;
            this.btnQLKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLKH.ForeColor = System.Drawing.Color.Black;
            this.btnQLKH.Image = ((System.Drawing.Image)(resources.GetObject("btnQLKH.Image")));
            this.btnQLKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLKH.Location = new System.Drawing.Point(3, 177);
            this.btnQLKH.Name = "btnQLKH";
            this.btnQLKH.Size = new System.Drawing.Size(281, 52);
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
            this.btnQLHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLHD.ForeColor = System.Drawing.Color.Black;
            this.btnQLHD.Image = ((System.Drawing.Image)(resources.GetObject("btnQLHD.Image")));
            this.btnQLHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLHD.Location = new System.Drawing.Point(3, 235);
            this.btnQLHD.Name = "btnQLHD";
            this.btnQLHD.Size = new System.Drawing.Size(281, 52);
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
            this.btnQLHDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLHDon.ForeColor = System.Drawing.Color.Black;
            this.btnQLHDon.Image = ((System.Drawing.Image)(resources.GetObject("btnQLHDon.Image")));
            this.btnQLHDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLHDon.Location = new System.Drawing.Point(3, 293);
            this.btnQLHDon.Name = "btnQLHDon";
            this.btnQLHDon.Size = new System.Drawing.Size(281, 52);
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
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.Black;
            this.btnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Image")));
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(3, 351);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(281, 52);
            this.btnDangXuat.TabIndex = 7;
            this.btnDangXuat.Text = "         Đăng Xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click_1);
            // 
            // dgvLoaiPhong
            // 
            this.dgvLoaiPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiPhong.BackgroundColor = System.Drawing.Color.White;
            this.dgvLoaiPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLoaiPhong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvLoaiPhong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLoaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiPhong.GridColor = System.Drawing.Color.White;
            this.dgvLoaiPhong.Location = new System.Drawing.Point(298, 77);
            this.dgvLoaiPhong.Name = "dgvLoaiPhong";
            this.dgvLoaiPhong.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLoaiPhong.RowHeadersWidth = 51;
            this.dgvLoaiPhong.RowTemplate.Height = 24;
            this.dgvLoaiPhong.Size = new System.Drawing.Size(418, 177);
            this.dgvLoaiPhong.TabIndex = 16;
            this.dgvLoaiPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiPhong_CellContentClick);
            // 
            // grpLoaiPhong
            // 
            this.grpLoaiPhong.BackColor = System.Drawing.Color.Transparent;
            this.grpLoaiPhong.Controls.Add(this.txtSoNguoi);
            this.grpLoaiPhong.Controls.Add(this.btnXoaLP);
            this.grpLoaiPhong.Controls.Add(this.btnCapNhatLP);
            this.grpLoaiPhong.Controls.Add(this.btnThemLP);
            this.grpLoaiPhong.Controls.Add(this.txtGiaThueLP);
            this.grpLoaiPhong.Controls.Add(this.txtMaLP);
            this.grpLoaiPhong.Controls.Add(this.label3);
            this.grpLoaiPhong.Controls.Add(this.label1);
            this.grpLoaiPhong.Controls.Add(this.label2);
            this.grpLoaiPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLoaiPhong.ForeColor = System.Drawing.Color.Red;
            this.grpLoaiPhong.Location = new System.Drawing.Point(305, 240);
            this.grpLoaiPhong.Name = "grpLoaiPhong";
            this.grpLoaiPhong.Size = new System.Drawing.Size(402, 169);
            this.grpLoaiPhong.TabIndex = 17;
            this.grpLoaiPhong.TabStop = false;
            this.grpLoaiPhong.Text = "Loại phòng";
            // 
            // txtSoNguoi
            // 
            this.txtSoNguoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoNguoi.Location = new System.Drawing.Point(112, 117);
            this.txtSoNguoi.Name = "txtSoNguoi";
            this.txtSoNguoi.Size = new System.Drawing.Size(196, 27);
            this.txtSoNguoi.TabIndex = 19;
            // 
            // btnXoaLP
            // 
            this.btnXoaLP.BackColor = System.Drawing.Color.White;
            this.btnXoaLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLP.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaLP.Image")));
            this.btnXoaLP.Location = new System.Drawing.Point(329, 117);
            this.btnXoaLP.Name = "btnXoaLP";
            this.btnXoaLP.Size = new System.Drawing.Size(67, 46);
            this.btnXoaLP.TabIndex = 18;
            this.btnXoaLP.UseVisualStyleBackColor = false;
            this.btnXoaLP.Click += new System.EventHandler(this.btnXoaLP_Click);
            // 
            // btnCapNhatLP
            // 
            this.btnCapNhatLP.BackColor = System.Drawing.Color.White;
            this.btnCapNhatLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatLP.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhatLP.Image")));
            this.btnCapNhatLP.Location = new System.Drawing.Point(329, 66);
            this.btnCapNhatLP.Name = "btnCapNhatLP";
            this.btnCapNhatLP.Size = new System.Drawing.Size(67, 45);
            this.btnCapNhatLP.TabIndex = 18;
            this.btnCapNhatLP.UseVisualStyleBackColor = false;
            this.btnCapNhatLP.Click += new System.EventHandler(this.btnCapNhatLP_Click);
            // 
            // btnThemLP
            // 
            this.btnThemLP.BackColor = System.Drawing.Color.White;
            this.btnThemLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLP.Image = ((System.Drawing.Image)(resources.GetObject("btnThemLP.Image")));
            this.btnThemLP.Location = new System.Drawing.Point(329, 16);
            this.btnThemLP.Name = "btnThemLP";
            this.btnThemLP.Size = new System.Drawing.Size(67, 44);
            this.btnThemLP.TabIndex = 18;
            this.btnThemLP.UseVisualStyleBackColor = false;
            this.btnThemLP.Click += new System.EventHandler(this.btnThemLP_Click);
            // 
            // txtGiaThueLP
            // 
            this.txtGiaThueLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaThueLP.Location = new System.Drawing.Point(112, 72);
            this.txtGiaThueLP.Name = "txtGiaThueLP";
            this.txtGiaThueLP.Size = new System.Drawing.Size(196, 27);
            this.txtGiaThueLP.TabIndex = 19;
            // 
            // txtMaLP
            // 
            this.txtMaLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLP.Location = new System.Drawing.Point(112, 29);
            this.txtMaLP.Name = "txtMaLP";
            this.txtMaLP.Size = new System.Drawing.Size(196, 27);
            this.txtMaLP.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số người:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Giá thuê:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã LP: ";
            // 
            // frmQuanLyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1193, 687);
            this.Controls.Add(this.grpLoaiPhong);
            this.Controls.Add(this.dgvLoaiPhong);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.grpTTP);
            this.Controls.Add(this.dgvTTP);
            this.Controls.Add(this.grpTimPhong);
            this.Controls.Add(this.lblThongTinPhong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmQuanLyPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Phòng";
            this.Load += new System.EventHandler(this.frmThongTinPhong_Load);
            this.grpTimPhong.ResumeLayout(false);
            this.grpTimPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTP)).EndInit();
            this.grpTTP.ResumeLayout(false);
            this.grpTTP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).EndInit();
            this.grpLoaiPhong.ResumeLayout(false);
            this.grpLoaiPhong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblThongTinPhong;
        private System.Windows.Forms.Label lblTheLoaiPhong;
        private System.Windows.Forms.GroupBox grpTimPhong;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dgvTTP;
        private System.Windows.Forms.GroupBox grpTTP;
        private System.Windows.Forms.Button btnXemPhong;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.TextBox txtLoaiPhong;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.Label lblLoaiPhong;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.ComboBox cboLoaiPhong;
        private System.Windows.Forms.RadioButton radDaThue;
        private System.Windows.Forms.RadioButton radTrong;
        private System.Windows.Forms.Label lblTinhTrangPhong;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.Button btnQLP;
        private System.Windows.Forms.Button btnQLDV;
        private System.Windows.Forms.Button btnQLKH;
        private System.Windows.Forms.Button btnQLHD;
        private System.Windows.Forms.Button btnQLHDon;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.DataGridView dgvLoaiPhong;
        private System.Windows.Forms.GroupBox grpLoaiPhong;
        private System.Windows.Forms.TextBox txtSoNguoi;
        private System.Windows.Forms.Button btnThemLP;
        private System.Windows.Forms.TextBox txtGiaThueLP;
        private System.Windows.Forms.TextBox txtMaLP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXoaLP;
        private System.Windows.Forms.Button btnCapNhatLP;
    }
}