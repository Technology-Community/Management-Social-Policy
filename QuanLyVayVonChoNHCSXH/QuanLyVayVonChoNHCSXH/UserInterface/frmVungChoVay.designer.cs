namespace QuanLyVayVonChoNHCSXH.UserInterface
{
    partial class frmVungChoVay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVungChoVay));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.toolThem = new System.Windows.Forms.ToolStripButton();
            this.toolXoa = new System.Windows.Forms.ToolStripButton();
            this.toolLuu = new System.Windows.Forms.ToolStripButton();
            this.toolTim = new System.Windows.Forms.ToolStripDropDownButton();
            this.tooltimtheoma = new System.Windows.Forms.ToolStripMenuItem();
            this.tooltimtheoten = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolTimVungChoVay = new System.Windows.Forms.ToolStripComboBox();
            this.toolThoat = new System.Windows.Forms.ToolStripButton();
            this.MaVung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenVung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolXemlai = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            this.bindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 77);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView);
            this.groupBox1.Controls.Add(this.bindingNavigator);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 238);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách vùng ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(186, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vùng Cho  Vay";
            // 
            // bindingNavigator
            // 
            this.bindingNavigator.AddNewItem = null;
            this.bindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator.DeleteItem = null;
            this.bindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolThem,
            this.toolXoa,
            this.toolLuu,
            this.toolTim,
            this.ToolTimVungChoVay,
            this.toolThoat,
            this.toolXemlai});
            this.bindingNavigator.Location = new System.Drawing.Point(3, 16);
            this.bindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator.Name = "bindingNavigator";
            this.bindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator.Size = new System.Drawing.Size(604, 36);
            this.bindingNavigator.TabIndex = 0;
            this.bindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 33);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 36);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 36);
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
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaVung,
            this.TenVung});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 52);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(604, 183);
            this.dataGridView.TabIndex = 1;
            // 
            // toolThem
            // 
            this.toolThem.Image = global::QuanLyVayVonChoNHCSXH.Properties.Resources.add;
            this.toolThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolThem.Name = "toolThem";
            this.toolThem.Size = new System.Drawing.Size(56, 33);
            this.toolThem.Text = "Thêm mới";
            this.toolThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolThem.Click += new System.EventHandler(this.toolThem_Click);
            // 
            // toolXoa
            // 
            this.toolXoa.Image = global::QuanLyVayVonChoNHCSXH.Properties.Resources.remove;
            this.toolXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolXoa.Name = "toolXoa";
            this.toolXoa.Size = new System.Drawing.Size(29, 33);
            this.toolXoa.Text = "Xóa";
            this.toolXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolXoa.Click += new System.EventHandler(this.toolXoa_Click);
            // 
            // toolLuu
            // 
            this.toolLuu.Image = global::QuanLyVayVonChoNHCSXH.Properties.Resources.save;
            this.toolLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolLuu.Name = "toolLuu";
            this.toolLuu.Size = new System.Drawing.Size(29, 33);
            this.toolLuu.Text = "Lưu";
            this.toolLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolLuu.Click += new System.EventHandler(this.toolLuu_Click);
            // 
            // toolTim
            // 
            this.toolTim.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolTim.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tooltimtheoma,
            this.tooltimtheoten});
            this.toolTim.Image = global::QuanLyVayVonChoNHCSXH.Properties.Resources.find;
            this.toolTim.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolTim.Name = "toolTim";
            this.toolTim.Size = new System.Drawing.Size(29, 33);
            this.toolTim.Text = "Tra cứu";
            // 
            // tooltimtheoma
            // 
            this.tooltimtheoma.Name = "tooltimtheoma";
            this.tooltimtheoma.Size = new System.Drawing.Size(152, 22);
            this.tooltimtheoma.Text = "Tìm theo mã";
            this.tooltimtheoma.Click += new System.EventHandler(this.tooltimtheoma_Click);
            // 
            // tooltimtheoten
            // 
            this.tooltimtheoten.Name = "tooltimtheoten";
            this.tooltimtheoten.Size = new System.Drawing.Size(152, 22);
            this.tooltimtheoten.Text = "Tìm theo tên";
            this.tooltimtheoten.Click += new System.EventHandler(this.tooltimtheoten_Click);
            // 
            // ToolTimVungChoVay
            // 
            this.ToolTimVungChoVay.Name = "ToolTimVungChoVay";
            this.ToolTimVungChoVay.Size = new System.Drawing.Size(121, 36);
            this.ToolTimVungChoVay.Leave += new System.EventHandler(this.ToolTimVungChoVay_Leave);
            this.ToolTimVungChoVay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ToolTimVungChoVay_KeyPress);
            this.ToolTimVungChoVay.Enter += new System.EventHandler(this.ToolTimVungChoVay_Enter);
            // 
            // toolThoat
            // 
            this.toolThoat.Image = global::QuanLyVayVonChoNHCSXH.Properties.Resources.stop;
            this.toolThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolThoat.Name = "toolThoat";
            this.toolThoat.Size = new System.Drawing.Size(39, 33);
            this.toolThoat.Text = "Thoát";
            this.toolThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolThoat.Click += new System.EventHandler(this.toolThoat_Click);
            // 
            // MaVung
            // 
            this.MaVung.DataPropertyName = "MaVung";
            this.MaVung.HeaderText = "Mã Vùng";
            this.MaVung.Name = "MaVung";
            // 
            // TenVung
            // 
            this.TenVung.DataPropertyName = "TenVung";
            this.TenVung.HeaderText = "Tên vùng";
            this.TenVung.Name = "TenVung";
            this.TenVung.Width = 200;
            // 
            // toolXemlai
            // 
            this.toolXemlai.Image = global::QuanLyVayVonChoNHCSXH.Properties.Resources.reload_24;
            this.toolXemlai.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolXemlai.Name = "toolXemlai";
            this.toolXemlai.Size = new System.Drawing.Size(44, 33);
            this.toolXemlai.Text = "Xem lại";
            this.toolXemlai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolXemlai.Click += new System.EventHandler(this.toolXemlai_Click);
            // 
            // frmVungChoVay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 315);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frmVungChoVay";
            this.Text = "frmVungChoVay";
            this.Load += new System.EventHandler(this.frmVungChoVay_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            this.bindingNavigator.ResumeLayout(false);
            this.bindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingNavigator bindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripButton toolThem;
        private System.Windows.Forms.ToolStripButton toolXoa;
        private System.Windows.Forms.ToolStripButton toolLuu;
        private System.Windows.Forms.ToolStripDropDownButton toolTim;
        private System.Windows.Forms.ToolStripMenuItem tooltimtheoma;
        private System.Windows.Forms.ToolStripMenuItem tooltimtheoten;
        private System.Windows.Forms.ToolStripComboBox ToolTimVungChoVay;
        private System.Windows.Forms.ToolStripButton toolThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaVung;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenVung;
        private System.Windows.Forms.ToolStripButton toolXemlai;
    }
}