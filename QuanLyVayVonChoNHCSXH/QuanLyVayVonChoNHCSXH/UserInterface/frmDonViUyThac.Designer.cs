namespace QuanLyVayVonChoNHCSXH.UserInterface
{
    partial class frmDonViUyThac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDonViUyThac));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDVUT = new System.Windows.Forms.DataGridView();
            this.MaDVUyThac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDVUyThac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorDVUT = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripSplitButton();
            this.ToolTimMaDonViUyThac = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolTimTenDonViUyThac = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTimDonViUyThac = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDVUT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorDVUT)).BeginInit();
            this.bindingNavigatorDVUT.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 358);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(598, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 56);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(168, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đơn Vị Uỷ Thác";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewDVUT);
            this.groupBox1.Controls.Add(this.bindingNavigatorDVUT);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 302);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách đơn vị uỷ thác";
            // 
            // dataGridViewDVUT
            // 
            this.dataGridViewDVUT.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridViewDVUT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDVUT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDVUyThac,
            this.TenDVUyThac});
            this.dataGridViewDVUT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDVUT.Location = new System.Drawing.Point(3, 52);
            this.dataGridViewDVUT.Name = "dataGridViewDVUT";
            this.dataGridViewDVUT.Size = new System.Drawing.Size(592, 247);
            this.dataGridViewDVUT.TabIndex = 1;
            // 
            // MaDVUyThac
            // 
            this.MaDVUyThac.DataPropertyName = "MaDVUyThac";
            this.MaDVUyThac.HeaderText = "Mã đơn vị ủy thác";
            this.MaDVUyThac.Name = "MaDVUyThac";
            this.MaDVUyThac.Width = 150;
            // 
            // TenDVUyThac
            // 
            this.TenDVUyThac.DataPropertyName = "TenDVUyThac";
            this.TenDVUyThac.HeaderText = "Tên đơn vị ủy thác";
            this.TenDVUyThac.Name = "TenDVUyThac";
            this.TenDVUyThac.Width = 300;
            // 
            // bindingNavigatorDVUT
            // 
            this.bindingNavigatorDVUT.AddNewItem = null;
            this.bindingNavigatorDVUT.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorDVUT.DeleteItem = null;
            this.bindingNavigatorDVUT.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolTimDonViUyThac,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton7});
            this.bindingNavigatorDVUT.Location = new System.Drawing.Point(3, 16);
            this.bindingNavigatorDVUT.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorDVUT.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorDVUT.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorDVUT.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorDVUT.Name = "bindingNavigatorDVUT";
            this.bindingNavigatorDVUT.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorDVUT.Size = new System.Drawing.Size(592, 36);
            this.bindingNavigatorDVUT.TabIndex = 0;
            this.bindingNavigatorDVUT.Text = "bindingNavigator1";
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
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::QuanLyVayVonChoNHCSXH.Properties.Resources.add;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(37, 33);
            this.toolStripButton1.Text = "Thêm";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::QuanLyVayVonChoNHCSXH.Properties.Resources.remove;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 33);
            this.toolStripButton2.Text = "Xoá";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::QuanLyVayVonChoNHCSXH.Properties.Resources.save;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 33);
            this.toolStripButton3.Text = "Lưu";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolTimMaDonViUyThac,
            this.ToolTimTenDonViUyThac});
            this.toolStripButton4.Image = global::QuanLyVayVonChoNHCSXH.Properties.Resources.find;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(79, 33);
            this.toolStripButton4.Text = "Tìm kiếm";
            // 
            // ToolTimMaDonViUyThac
            // 
            this.ToolTimMaDonViUyThac.Name = "ToolTimMaDonViUyThac";
            this.ToolTimMaDonViUyThac.Size = new System.Drawing.Size(174, 22);
            this.ToolTimMaDonViUyThac.Text = "Mã đơn vị uỷ thác";
            this.ToolTimMaDonViUyThac.Click += new System.EventHandler(this.ToolTimMaDonViUyThac_Click);
            // 
            // ToolTimTenDonViUyThac
            // 
            this.ToolTimTenDonViUyThac.Name = "ToolTimTenDonViUyThac";
            this.ToolTimTenDonViUyThac.Size = new System.Drawing.Size(174, 22);
            this.ToolTimTenDonViUyThac.Text = "Tên đơn vị uỷ thác";
            this.ToolTimTenDonViUyThac.Click += new System.EventHandler(this.ToolTimTenDonViUyThac_Click);
            // 
            // toolTimDonViUyThac
            // 
            this.toolTimDonViUyThac.Name = "toolTimDonViUyThac";
            this.toolTimDonViUyThac.Size = new System.Drawing.Size(100, 36);
            this.toolTimDonViUyThac.Enter += new System.EventHandler(this.toolTimDonViUyThac_Enter);
            this.toolTimDonViUyThac.Leave += new System.EventHandler(this.toolTimDonViUyThac_Leave);
            this.toolTimDonViUyThac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolTimDonViUyThac_KeyPress);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::QuanLyVayVonChoNHCSXH.Properties.Resources.forward;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 33);
            this.toolStripButton5.Text = "toolStripButton5";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = global::QuanLyVayVonChoNHCSXH.Properties.Resources.reload_24;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(44, 33);
            this.toolStripButton6.Text = "Xem lại";
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
            // frmDonViUyThac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(598, 380);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDonViUyThac";
            this.Text = "Don Vi Uy Thac";
            this.Load += new System.EventHandler(this.frmDonViUyThac_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDVUT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorDVUT)).EndInit();
            this.bindingNavigatorDVUT.ResumeLayout(false);
            this.bindingNavigatorDVUT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewDVUT;
        private System.Windows.Forms.BindingNavigator bindingNavigatorDVUT;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripTextBox toolTimDonViUyThac;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripSplitButton toolStripButton4;
        private System.Windows.Forms.ToolStripMenuItem ToolTimMaDonViUyThac;
        private System.Windows.Forms.ToolStripMenuItem ToolTimTenDonViUyThac;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDVUyThac;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDVUyThac;
    }
}