namespace QuanLyVayVonChoNHCSXH.UserInterface
{
    partial class frmDanhSachKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhSachKhachHang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDSKH = new System.Windows.Forms.DataGridView();
            this.MaDoiTac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiHinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiDoiTac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDanToc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaXa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorDSKH = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Thêm = new System.Windows.Forms.ToolStripButton();
            this.Xóa = new System.Windows.Forms.ToolStripButton();
            this.Lưu = new System.Windows.Forms.ToolStripButton();
            this.TimKiem = new System.Windows.Forms.ToolStripSplitButton();
            this.ToolTimMaDoiTac = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolTimTenDoiTac = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolTimMaLoaiDoiTac = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTimDanhSachKhachHang = new System.Windows.Forms.ToolStripTextBox();
            this.Tim = new System.Windows.Forms.ToolStripButton();
            this.XemLai = new System.Windows.Forms.ToolStripButton();
            this.Thoat = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorDSKH)).BeginInit();
            this.bindingNavigatorDSKH.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 61);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(177, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Khách Hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewDSKH);
            this.groupBox1.Controls.Add(this.bindingNavigatorDSKH);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 205);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách khách hàng";
            // 
            // dataGridViewDSKH
            // 
            this.dataGridViewDSKH.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dataGridViewDSKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDoiTac,
            this.HoTenDT,
            this.GioiTinh,
            this.DiaChi,
            this.NgaySinh,
            this.CMND,
            this.NgayCap,
            this.MaTinh,
            this.MaLoaiHinh,
            this.MaLoaiDoiTac,
            this.MaDanToc,
            this.MaHuyen,
            this.MaXa});
            this.dataGridViewDSKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDSKH.Location = new System.Drawing.Point(3, 52);
            this.dataGridViewDSKH.Name = "dataGridViewDSKH";
            this.dataGridViewDSKH.Size = new System.Drawing.Size(772, 150);
            this.dataGridViewDSKH.TabIndex = 1;
            // 
            // MaDoiTac
            // 
            this.MaDoiTac.DataPropertyName = "MaDoiTac";
            this.MaDoiTac.HeaderText = "Mã đối tác";
            this.MaDoiTac.Name = "MaDoiTac";
            // 
            // HoTenDT
            // 
            this.HoTenDT.DataPropertyName = "HoTenDT";
            this.HoTenDT.HeaderText = "Họ tên đối tác";
            this.HoTenDT.Name = "HoTenDT";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // CMND
            // 
            this.CMND.DataPropertyName = "CMND";
            this.CMND.HeaderText = "CMND";
            this.CMND.Name = "CMND";
            // 
            // NgayCap
            // 
            this.NgayCap.DataPropertyName = "NgayCap";
            this.NgayCap.HeaderText = "Ngày cấp";
            this.NgayCap.Name = "NgayCap";
            // 
            // MaTinh
            // 
            this.MaTinh.DataPropertyName = "MaTinh";
            this.MaTinh.HeaderText = "Mã tỉnh";
            this.MaTinh.Name = "MaTinh";
            // 
            // MaLoaiHinh
            // 
            this.MaLoaiHinh.DataPropertyName = "MaLoaiHinh";
            this.MaLoaiHinh.HeaderText = "Mã loại hình";
            this.MaLoaiHinh.Name = "MaLoaiHinh";
            // 
            // MaLoaiDoiTac
            // 
            this.MaLoaiDoiTac.DataPropertyName = "MaLoaiDoiTac";
            this.MaLoaiDoiTac.HeaderText = "Mã loại đối tác";
            this.MaLoaiDoiTac.Name = "MaLoaiDoiTac";
            // 
            // MaDanToc
            // 
            this.MaDanToc.DataPropertyName = "MaDanToc";
            this.MaDanToc.HeaderText = "Mã dân tộc";
            this.MaDanToc.Name = "MaDanToc";
            // 
            // MaHuyen
            // 
            this.MaHuyen.DataPropertyName = "MaHuyen";
            this.MaHuyen.HeaderText = "Mã huyện";
            this.MaHuyen.Name = "MaHuyen";
            // 
            // MaXa
            // 
            this.MaXa.DataPropertyName = "MaXa";
            this.MaXa.HeaderText = "Mã xã";
            this.MaXa.Name = "MaXa";
            // 
            // bindingNavigatorDSKH
            // 
            this.bindingNavigatorDSKH.AddNewItem = null;
            this.bindingNavigatorDSKH.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorDSKH.DeleteItem = null;
            this.bindingNavigatorDSKH.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.Thêm,
            this.Xóa,
            this.Lưu,
            this.TimKiem,
            this.toolTimDanhSachKhachHang,
            this.Tim,
            this.XemLai,
            this.Thoat});
            this.bindingNavigatorDSKH.Location = new System.Drawing.Point(3, 16);
            this.bindingNavigatorDSKH.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorDSKH.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorDSKH.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorDSKH.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorDSKH.Name = "bindingNavigatorDSKH";
            this.bindingNavigatorDSKH.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorDSKH.Size = new System.Drawing.Size(772, 36);
            this.bindingNavigatorDSKH.TabIndex = 0;
            this.bindingNavigatorDSKH.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 33);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 33);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 33);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 36);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 36);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 33);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 33);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 36);
            // 
            // Thêm
            // 
            this.Thêm.Image = global::QuanLyVayVonChoNHCSXH.Properties.Resources.add;
            this.Thêm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Thêm.Name = "Thêm";
            this.Thêm.Size = new System.Drawing.Size(37, 33);
            this.Thêm.Text = "Thêm";
            this.Thêm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Thêm.Click += new System.EventHandler(this.Thêm_Click);
            // 
            // Xóa
            // 
            this.Xóa.Image = global::QuanLyVayVonChoNHCSXH.Properties.Resources.remove;
            this.Xóa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Xóa.Name = "Xóa";
            this.Xóa.Size = new System.Drawing.Size(29, 33);
            this.Xóa.Text = "Xóa";
            this.Xóa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Xóa.Click += new System.EventHandler(this.Xóa_Click);
            // 
            // Lưu
            // 
            this.Lưu.Image = global::QuanLyVayVonChoNHCSXH.Properties.Resources.save;
            this.Lưu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Lưu.Name = "Lưu";
            this.Lưu.Size = new System.Drawing.Size(29, 33);
            this.Lưu.Text = "Lưu";
            this.Lưu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Lưu.Click += new System.EventHandler(this.Lưu_Click);
            // 
            // TimKiem
            // 
            this.TimKiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolTimMaDoiTac,
            this.ToolTimTenDoiTac,
            this.ToolTimMaLoaiDoiTac});
            this.TimKiem.Image = global::QuanLyVayVonChoNHCSXH.Properties.Resources.find;
            this.TimKiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TimKiem.Name = "TimKiem";
            this.TimKiem.Size = new System.Drawing.Size(79, 33);
            this.TimKiem.Text = "Tìm kiếm";
            // 
            // ToolTimMaDoiTac
            // 
            this.ToolTimMaDoiTac.Name = "ToolTimMaDoiTac";
            this.ToolTimMaDoiTac.Size = new System.Drawing.Size(161, 22);
            this.ToolTimMaDoiTac.Text = "Mã khách hàng";
            this.ToolTimMaDoiTac.Click += new System.EventHandler(this.ToolTimMaDoiTac_Click);
            // 
            // ToolTimTenDoiTac
            // 
            this.ToolTimTenDoiTac.Name = "ToolTimTenDoiTac";
            this.ToolTimTenDoiTac.Size = new System.Drawing.Size(161, 22);
            this.ToolTimTenDoiTac.Text = "Tên khách hàng";
            this.ToolTimTenDoiTac.Click += new System.EventHandler(this.ToolStripTimTenDoiTac_Click);
            // 
            // ToolTimMaLoaiDoiTac
            // 
            this.ToolTimMaLoaiDoiTac.Name = "ToolTimMaLoaiDoiTac";
            this.ToolTimMaLoaiDoiTac.Size = new System.Drawing.Size(176, 22);
            this.ToolTimMaLoaiDoiTac.Text = "Mã loại khách hàng";
            this.ToolTimMaLoaiDoiTac.Click += new System.EventHandler(this.ToolTimMaLoaiDoiTac_Click);
            // 
            // toolTimDanhSachKhachHang
            // 
            this.toolTimDanhSachKhachHang.Name = "toolTimDanhSachKhachHang";
            this.toolTimDanhSachKhachHang.Size = new System.Drawing.Size(100, 36);
            this.toolTimDanhSachKhachHang.Enter += new System.EventHandler(this.toolTimDanhSachKhachHang_Enter);
            this.toolTimDanhSachKhachHang.Leave += new System.EventHandler(this.toolTimDanhSachKhachHang_Leave);
            this.toolTimDanhSachKhachHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolTimDanhSachKhachHang_KeyPress);
            // 
            // Tim
            // 
            this.Tim.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tim.Image = global::QuanLyVayVonChoNHCSXH.Properties.Resources.forward;
            this.Tim.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tim.Name = "Tim";
            this.Tim.Size = new System.Drawing.Size(23, 33);
            this.Tim.Text = "toolStripButton5";
            this.Tim.Click += new System.EventHandler(this.Tim_Click);
            // 
            // XemLai
            // 
            this.XemLai.Image = global::QuanLyVayVonChoNHCSXH.Properties.Resources.reload_24;
            this.XemLai.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.XemLai.Name = "XemLai";
            this.XemLai.Size = new System.Drawing.Size(44, 33);
            this.XemLai.Text = "Xem lại";
            this.XemLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.XemLai.Click += new System.EventHandler(this.XemLai_Click);
            // 
            // Thoat
            // 
            this.Thoat.Image = global::QuanLyVayVonChoNHCSXH.Properties.Resources.stop;
            this.Thoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(39, 33);
            this.Thoat.Text = "Thoát";
            this.Thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // frmDanhSachKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(778, 266);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDanhSachKhachHang";
            this.Text = "Danh Sach Khach Hang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDanhSachKhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorDSKH)).EndInit();
            this.bindingNavigatorDSKH.ResumeLayout(false);
            this.bindingNavigatorDSKH.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewDSKH;
        private System.Windows.Forms.BindingNavigator bindingNavigatorDSKH;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton Thêm;
        private System.Windows.Forms.ToolStripButton Xóa;
        private System.Windows.Forms.ToolStripButton Lưu;
        private System.Windows.Forms.ToolStripTextBox toolTimDanhSachKhachHang;
        private System.Windows.Forms.ToolStripButton Tim;
        private System.Windows.Forms.ToolStripButton XemLai;
        private System.Windows.Forms.ToolStripButton Thoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDoiTac;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiHinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiDoiTac;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDanToc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaXa;
        private System.Windows.Forms.ToolStripSplitButton TimKiem;
        private System.Windows.Forms.ToolStripMenuItem ToolTimMaDoiTac;
        private System.Windows.Forms.ToolStripMenuItem ToolTimTenDoiTac;
        private System.Windows.Forms.ToolStripMenuItem ToolTimMaLoaiDoiTac;
    }
}