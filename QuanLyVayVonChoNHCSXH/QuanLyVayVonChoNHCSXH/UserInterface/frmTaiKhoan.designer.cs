namespace QuanLyVayVonChoNHCSXH.UserInterface
{
    partial class frmTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaiKhoan));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThemMaCap = new System.Windows.Forms.Button();
            this.cmbMaCap = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThemNhanVien = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMaNV = new System.Windows.Forms.ComboBox();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMaTaiKhoan = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewTK = new System.Windows.Forms.DataGridView();
            this.MaTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorTK = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.Xoá = new System.Windows.Forms.ToolStripButton();
            this.Lưu = new System.Windows.Forms.ToolStripButton();
            this.toolStripTim = new System.Windows.Forms.ToolStripSplitButton();
            this.ToolTimMaTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolTimTenTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTimTaiKhoan = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTimKiem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolSua = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorTK)).BeginInit();
            this.bindingNavigatorTK.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 452);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(735, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(735, 452);
            this.splitContainer1.SplitterDistance = 216;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThemMaCap);
            this.groupBox1.Controls.Add(this.cmbMaCap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnThemNhanVien);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbMaNV);
            this.groupBox1.Controls.Add(this.txtTenTaiKhoan);
            this.groupBox1.Controls.Add(this.txtMaTaiKhoan);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 167);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // btnThemMaCap
            // 
            this.btnThemMaCap.Image = global::QuanLyVayVonChoNHCSXH.Properties.Resources.add;
            this.btnThemMaCap.Location = new System.Drawing.Point(585, 81);
            this.btnThemMaCap.Name = "btnThemMaCap";
            this.btnThemMaCap.Size = new System.Drawing.Size(36, 23);
            this.btnThemMaCap.TabIndex = 11;
            this.btnThemMaCap.UseVisualStyleBackColor = true;
            this.btnThemMaCap.Click += new System.EventHandler(this.btnThemMaCap_Click);
            // 
            // cmbMaCap
            // 
            this.cmbMaCap.FormattingEnabled = true;
            this.cmbMaCap.Location = new System.Drawing.Point(388, 78);
            this.cmbMaCap.Name = "cmbMaCap";
            this.cmbMaCap.Size = new System.Drawing.Size(177, 21);
            this.cmbMaCap.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(295, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã cấp";
            // 
            // btnThemNhanVien
            // 
            this.btnThemNhanVien.Image = global::QuanLyVayVonChoNHCSXH.Properties.Resources.add;
            this.btnThemNhanVien.Location = new System.Drawing.Point(585, 33);
            this.btnThemNhanVien.Name = "btnThemNhanVien";
            this.btnThemNhanVien.Size = new System.Drawing.Size(36, 21);
            this.btnThemNhanVien.TabIndex = 8;
            this.btnThemNhanVien.UseVisualStyleBackColor = true;
            this.btnThemNhanVien.Click += new System.EventHandler(this.btnThemNhanVien_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(290, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tên nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(22, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(22, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã tài khoản";
            // 
            // cmbMaNV
            // 
            this.cmbMaNV.FormattingEnabled = true;
            this.cmbMaNV.Location = new System.Drawing.Point(389, 33);
            this.cmbMaNV.Name = "cmbMaNV";
            this.cmbMaNV.Size = new System.Drawing.Size(176, 21);
            this.cmbMaNV.TabIndex = 3;
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(115, 73);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(153, 20);
            this.txtTenTaiKhoan.TabIndex = 1;
            // 
            // txtMaTaiKhoan
            // 
            this.txtMaTaiKhoan.Location = new System.Drawing.Point(115, 33);
            this.txtMaTaiKhoan.Name = "txtMaTaiKhoan";
            this.txtMaTaiKhoan.Size = new System.Drawing.Size(153, 20);
            this.txtMaTaiKhoan.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 49);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(218, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài Khoản";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewTK);
            this.groupBox2.Controls.Add(this.bindingNavigatorTK);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(735, 232);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách tài khoản";
            // 
            // dataGridViewTK
            // 
            this.dataGridViewTK.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dataGridViewTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTaiKhoan,
            this.TenTaiKhoan,
            this.MaNV,
            this.MaCap});
            this.dataGridViewTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTK.Location = new System.Drawing.Point(3, 52);
            this.dataGridViewTK.Name = "dataGridViewTK";
            this.dataGridViewTK.Size = new System.Drawing.Size(729, 177);
            this.dataGridViewTK.TabIndex = 1;
            // 
            // MaTaiKhoan
            // 
            this.MaTaiKhoan.DataPropertyName = "MaTaiKhoan";
            this.MaTaiKhoan.HeaderText = "Mã tài khoản";
            this.MaTaiKhoan.Name = "MaTaiKhoan";
            this.MaTaiKhoan.Width = 150;
            // 
            // TenTaiKhoan
            // 
            this.TenTaiKhoan.DataPropertyName = "TenTaiKhoan";
            this.TenTaiKhoan.HeaderText = "Tên tài khoản";
            this.TenTaiKhoan.Name = "TenTaiKhoan";
            this.TenTaiKhoan.Width = 200;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 200;
            // 
            // MaCap
            // 
            this.MaCap.DataPropertyName = "MaCap";
            this.MaCap.HeaderText = "Mã cấp";
            this.MaCap.Name = "MaCap";
            // 
            // bindingNavigatorTK
            // 
            this.bindingNavigatorTK.AddNewItem = null;
            this.bindingNavigatorTK.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorTK.DeleteItem = null;
            this.bindingNavigatorTK.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.Xoá,
            this.Lưu,
            this.toolStripTim,
            this.toolTimTaiKhoan,
            this.toolStripTimKiem,
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolSua});
            this.bindingNavigatorTK.Location = new System.Drawing.Point(3, 16);
            this.bindingNavigatorTK.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorTK.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorTK.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorTK.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorTK.Name = "bindingNavigatorTK";
            this.bindingNavigatorTK.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorTK.Size = new System.Drawing.Size(729, 36);
            this.bindingNavigatorTK.TabIndex = 0;
            this.bindingNavigatorTK.Text = "bindingNavigator1";
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
            // Xoá
            // 
            this.Xoá.Image = global::QuanLyVayVonChoNHCSXH.Properties.Resources.remove;
            this.Xoá.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Xoá.Name = "Xoá";
            this.Xoá.Size = new System.Drawing.Size(29, 33);
            this.Xoá.Text = "Xoá";
            this.Xoá.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Xoá.Click += new System.EventHandler(this.Xoá_Click);
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
            // toolStripTim
            // 
            this.toolStripTim.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolTimMaTaiKhoan,
            this.ToolTimTenTaiKhoan});
            this.toolStripTim.Image = global::QuanLyVayVonChoNHCSXH.Properties.Resources.find;
            this.toolStripTim.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripTim.Name = "toolStripTim";
            this.toolStripTim.Size = new System.Drawing.Size(79, 33);
            this.toolStripTim.Text = "Tìm kiếm";
            // 
            // ToolTimMaTaiKhoan
            // 
            this.ToolTimMaTaiKhoan.Name = "ToolTimMaTaiKhoan";
            this.ToolTimMaTaiKhoan.Size = new System.Drawing.Size(150, 22);
            this.ToolTimMaTaiKhoan.Text = "Mã tài khoản";
            this.ToolTimMaTaiKhoan.Click += new System.EventHandler(this.ToolTimMaTaiKhoan_Click);
            // 
            // ToolTimTenTaiKhoan
            // 
            this.ToolTimTenTaiKhoan.Name = "ToolTimTenTaiKhoan";
            this.ToolTimTenTaiKhoan.Size = new System.Drawing.Size(150, 22);
            this.ToolTimTenTaiKhoan.Text = "Tên tài khoản";
            this.ToolTimTenTaiKhoan.Click += new System.EventHandler(this.ToolTimTenTaiKhoan_Click);
            // 
            // toolTimTaiKhoan
            // 
            this.toolTimTaiKhoan.Name = "toolTimTaiKhoan";
            this.toolTimTaiKhoan.Size = new System.Drawing.Size(100, 36);
            this.toolTimTaiKhoan.Enter += new System.EventHandler(this.toolTimTaiKhoan_Enter);
            this.toolTimTaiKhoan.Leave += new System.EventHandler(this.toolTimTaiKhoan_Leave);
            this.toolTimTaiKhoan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolTimTaiKhoan_KeyPress);
            // 
            // toolStripTimKiem
            // 
            this.toolStripTimKiem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripTimKiem.Image = global::QuanLyVayVonChoNHCSXH.Properties.Resources.forward;
            this.toolStripTimKiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripTimKiem.Name = "toolStripTimKiem";
            this.toolStripTimKiem.Size = new System.Drawing.Size(23, 33);
            this.toolStripTimKiem.Text = "Tìm kiếm";
            this.toolStripTimKiem.Click += new System.EventHandler(this.toolStripTimKiem_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = global::QuanLyVayVonChoNHCSXH.Properties.Resources.reload_24;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(47, 33);
            this.toolStripButton6.Text = "Xem Lại";
            this.toolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Image = global::QuanLyVayVonChoNHCSXH.Properties.Resources.stop;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(39, 33);
            this.toolStripButton7.Text = "Thoát";
            this.toolStripButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // toolSua
            // 
            this.toolSua.Image = global::QuanLyVayVonChoNHCSXH.Properties.Resources.edit;
            this.toolSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSua.Name = "toolSua";
            this.toolSua.Size = new System.Drawing.Size(30, 33);
            this.toolSua.Text = "Sửa";
            this.toolSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolSua.Click += new System.EventHandler(this.toolSua_Click);
            // 
            // frmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(735, 474);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTaiKhoan";
            this.Text = "Tai Khoan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTaiKhoan_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorTK)).EndInit();
            this.bindingNavigatorTK.ResumeLayout(false);
            this.bindingNavigatorTK.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewTK;
        private System.Windows.Forms.BindingNavigator bindingNavigatorTK;
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
        private System.Windows.Forms.ToolStripButton Xoá;
        private System.Windows.Forms.ToolStripButton Lưu;
        private System.Windows.Forms.ToolStripTextBox toolTimTaiKhoan;
        private System.Windows.Forms.ToolStripButton toolStripTimKiem;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripSplitButton toolStripTim;
        private System.Windows.Forms.ToolStripMenuItem ToolTimMaTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem ToolTimTenTaiKhoan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMaNV;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.TextBox txtMaTaiKhoan;
        private System.Windows.Forms.Button btnThemNhanVien;
        private System.Windows.Forms.Button btnThemMaCap;
        private System.Windows.Forms.ComboBox cmbMaCap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCap;
        private System.Windows.Forms.ToolStripButton toolSua;
    }
}