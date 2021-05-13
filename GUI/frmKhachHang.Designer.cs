namespace RetailStore
{
    partial class frmKhachhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachhang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.btnHuyKH = new System.Windows.Forms.Button();
            this.btnCapnhatKH = new System.Windows.Forms.Button();
            this.btnXoaKH = new System.Windows.Forms.Button();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.lblMKH = new System.Windows.Forms.Label();
            this.pnlDSKH = new System.Windows.Forms.Panel();
            this.cmbSapxepKH = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvDSKHACH = new System.Windows.Forms.DataGridView();
            this.txtTimKH = new System.Windows.Forms.TextBox();
            this.lblTimkiem = new System.Windows.Forms.Label();
            this.grpbNhapKH = new System.Windows.Forms.GroupBox();
            this.btnLuuKH = new System.Windows.Forms.Button();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.pnlDSKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSKHACH)).BeginInit();
            this.grpbNhapKH.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Josefin Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH KHÁCH HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(194, 112);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(315, 34);
            this.txtTenKH.TabIndex = 2;
            // 
            // btnHuyKH
            // 
            this.btnHuyKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyKH.Font = new System.Drawing.Font("Josefin Sans", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyKH.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnHuyKH.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyKH.Image")));
            this.btnHuyKH.Location = new System.Drawing.Point(797, 237);
            this.btnHuyKH.Name = "btnHuyKH";
            this.btnHuyKH.Size = new System.Drawing.Size(146, 87);
            this.btnHuyKH.TabIndex = 8;
            this.btnHuyKH.Text = "Hủy";
            this.btnHuyKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuyKH.UseVisualStyleBackColor = true;
            this.btnHuyKH.Click += new System.EventHandler(this.btnHuyKH_Click);
            // 
            // btnCapnhatKH
            // 
            this.btnCapnhatKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapnhatKH.Font = new System.Drawing.Font("Josefin Sans", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhatKH.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCapnhatKH.Image = ((System.Drawing.Image)(resources.GetObject("btnCapnhatKH.Image")));
            this.btnCapnhatKH.Location = new System.Drawing.Point(222, 237);
            this.btnCapnhatKH.Name = "btnCapnhatKH";
            this.btnCapnhatKH.Size = new System.Drawing.Size(160, 87);
            this.btnCapnhatKH.TabIndex = 5;
            this.btnCapnhatKH.Text = "Cập nhật";
            this.btnCapnhatKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCapnhatKH.UseVisualStyleBackColor = true;
            this.btnCapnhatKH.Click += new System.EventHandler(this.btnCapnhatKH_Click);
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaKH.Font = new System.Drawing.Font("Josefin Sans", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaKH.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnXoaKH.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaKH.Image")));
            this.btnXoaKH.Location = new System.Drawing.Point(609, 237);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.Size = new System.Drawing.Size(150, 87);
            this.btnXoaKH.TabIndex = 7;
            this.btnXoaKH.Text = "Xóa";
            this.btnXoaKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaKH.UseVisualStyleBackColor = true;
            this.btnXoaKH.Click += new System.EventHandler(this.btnXoaKH_Click);
            // 
            // btnThemKH
            // 
            this.btnThemKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemKH.Font = new System.Drawing.Font("Josefin Sans", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKH.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnThemKH.Image = ((System.Drawing.Image)(resources.GetObject("btnThemKH.Image")));
            this.btnThemKH.Location = new System.Drawing.Point(23, 237);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(165, 87);
            this.btnThemKH.TabIndex = 4;
            this.btnThemKH.Text = "Thêm";
            this.btnThemKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemKH.UseVisualStyleBackColor = true;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSDT.Location = new System.Drawing.Point(18, 173);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(137, 31);
            this.lblSDT.TabIndex = 6;
            this.lblSDT.Text = "Số điện thoại:";
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKH.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTenKH.Location = new System.Drawing.Point(17, 115);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(160, 31);
            this.lblTenKH.TabIndex = 2;
            this.lblTenKH.Text = "Tên khách hàng:";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(194, 59);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.ReadOnly = true;
            this.txtMaKH.Size = new System.Drawing.Size(315, 34);
            this.txtMaKH.TabIndex = 1;
            // 
            // lblMKH
            // 
            this.lblMKH.AutoSize = true;
            this.lblMKH.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMKH.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMKH.Location = new System.Drawing.Point(18, 62);
            this.lblMKH.Name = "lblMKH";
            this.lblMKH.Size = new System.Drawing.Size(160, 31);
            this.lblMKH.TabIndex = 0;
            this.lblMKH.Text = "Mã khách hàng:";
            // 
            // pnlDSKH
            // 
            this.pnlDSKH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDSKH.Controls.Add(this.cmbSapxepKH);
            this.pnlDSKH.Controls.Add(this.label2);
            this.pnlDSKH.Controls.Add(this.dtgvDSKHACH);
            this.pnlDSKH.Controls.Add(this.txtTimKH);
            this.pnlDSKH.Controls.Add(this.lblTimkiem);
            this.pnlDSKH.Controls.Add(this.label1);
            this.pnlDSKH.Location = new System.Drawing.Point(0, 330);
            this.pnlDSKH.Name = "pnlDSKH";
            this.pnlDSKH.Size = new System.Drawing.Size(1282, 429);
            this.pnlDSKH.TabIndex = 3;
            // 
            // cmbSapxepKH
            // 
            this.cmbSapxepKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSapxepKH.Font = new System.Drawing.Font("Josefin Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSapxepKH.FormattingEnabled = true;
            this.cmbSapxepKH.Items.AddRange(new object[] {
            "Mặc định",
            "Tên, A->Z",
            "Tên, Z->A"});
            this.cmbSapxepKH.Location = new System.Drawing.Point(1118, 16);
            this.cmbSapxepKH.Name = "cmbSapxepKH";
            this.cmbSapxepKH.Size = new System.Drawing.Size(152, 35);
            this.cmbSapxepKH.TabIndex = 10;
            this.cmbSapxepKH.SelectedIndexChanged += new System.EventHandler(this.cmbSapxepKH_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Josefin Sans SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(1000, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sắp xếp:";
            // 
            // dtgvDSKHACH
            // 
            this.dtgvDSKHACH.AllowUserToAddRows = false;
            this.dtgvDSKHACH.AllowUserToDeleteRows = false;
            this.dtgvDSKHACH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvDSKHACH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDSKHACH.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDSKHACH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvDSKHACH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvDSKHACH.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvDSKHACH.Location = new System.Drawing.Point(12, 57);
            this.dtgvDSKHACH.Name = "dtgvDSKHACH";
            this.dtgvDSKHACH.ReadOnly = true;
            this.dtgvDSKHACH.RowHeadersWidth = 51;
            this.dtgvDSKHACH.RowTemplate.Height = 24;
            this.dtgvDSKHACH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDSKHACH.Size = new System.Drawing.Size(1258, 359);
            this.dtgvDSKHACH.TabIndex = 11;
            this.dtgvDSKHACH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDSKHACH_CellClick);
            // 
            // txtTimKH
            // 
            this.txtTimKH.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKH.Location = new System.Drawing.Point(623, 18);
            this.txtTimKH.Name = "txtTimKH";
            this.txtTimKH.Size = new System.Drawing.Size(358, 33);
            this.txtTimKH.TabIndex = 9;
            this.txtTimKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimKH_KeyPress);
            // 
            // lblTimkiem
            // 
            this.lblTimkiem.AutoSize = true;
            this.lblTimkiem.Font = new System.Drawing.Font("Josefin Sans SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimkiem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTimkiem.Location = new System.Drawing.Point(489, 16);
            this.lblTimkiem.Name = "lblTimkiem";
            this.lblTimkiem.Size = new System.Drawing.Size(128, 38);
            this.lblTimkiem.TabIndex = 2;
            this.lblTimkiem.Text = "Tìm kiếm: ";
            // 
            // grpbNhapKH
            // 
            this.grpbNhapKH.Controls.Add(this.btnLuuKH);
            this.grpbNhapKH.Controls.Add(this.txtSDT);
            this.grpbNhapKH.Controls.Add(this.txtTenKH);
            this.grpbNhapKH.Controls.Add(this.btnHuyKH);
            this.grpbNhapKH.Controls.Add(this.btnCapnhatKH);
            this.grpbNhapKH.Controls.Add(this.btnXoaKH);
            this.grpbNhapKH.Controls.Add(this.btnThemKH);
            this.grpbNhapKH.Controls.Add(this.lblSDT);
            this.grpbNhapKH.Controls.Add(this.lblTenKH);
            this.grpbNhapKH.Controls.Add(this.txtMaKH);
            this.grpbNhapKH.Controls.Add(this.lblMKH);
            this.grpbNhapKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbNhapKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpbNhapKH.Font = new System.Drawing.Font("Josefin Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbNhapKH.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grpbNhapKH.Location = new System.Drawing.Point(0, 0);
            this.grpbNhapKH.Name = "grpbNhapKH";
            this.grpbNhapKH.Size = new System.Drawing.Size(1282, 760);
            this.grpbNhapKH.TabIndex = 2;
            this.grpbNhapKH.TabStop = false;
            this.grpbNhapKH.Text = "Khung nhập liệu";
            // 
            // btnLuuKH
            // 
            this.btnLuuKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuKH.Font = new System.Drawing.Font("Josefin Sans", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuKH.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLuuKH.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuKH.Image")));
            this.btnLuuKH.Location = new System.Drawing.Point(420, 237);
            this.btnLuuKH.Name = "btnLuuKH";
            this.btnLuuKH.Size = new System.Drawing.Size(151, 87);
            this.btnLuuKH.TabIndex = 6;
            this.btnLuuKH.Text = "Lưu";
            this.btnLuuKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuuKH.UseVisualStyleBackColor = true;
            this.btnLuuKH.Click += new System.EventHandler(this.btnLuuKH_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(194, 170);
            this.txtSDT.MaxLength = 10;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(315, 34);
            this.txtSDT.TabIndex = 3;
            // 
            // frmKhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1282, 758);
            this.Controls.Add(this.pnlDSKH);
            this.Controls.Add(this.grpbNhapKH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKhachhang";
            this.Text = "frmKhachhang";
            this.pnlDSKH.ResumeLayout(false);
            this.pnlDSKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSKHACH)).EndInit();
            this.grpbNhapKH.ResumeLayout(false);
            this.grpbNhapKH.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Button btnHuyKH;
        private System.Windows.Forms.Button btnCapnhatKH;
        private System.Windows.Forms.Button btnXoaKH;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label lblMKH;
        private System.Windows.Forms.Panel pnlDSKH;
        private System.Windows.Forms.GroupBox grpbNhapKH;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTimKH;
        private System.Windows.Forms.Label lblTimkiem;
        private System.Windows.Forms.DataGridView dtgvDSKHACH;
        private System.Windows.Forms.Button btnLuuKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSapxepKH;
    }
}