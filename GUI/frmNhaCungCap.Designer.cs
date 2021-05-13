
namespace RetailStore.GUI
{
    partial class frmNhaCungCap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhaCungCap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbSapxepNCC = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTimNCC = new System.Windows.Forms.TextBox();
            this.lblTimkiem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dGVSupplier = new System.Windows.Forms.DataGridView();
            this.grpbNhapKH = new System.Windows.Forms.GroupBox();
            this.txtDcNCC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSdtNCC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLuuNCC = new System.Windows.Forms.Button();
            this.txtEmailNCC = new System.Windows.Forms.TextBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.btnHuyNCC = new System.Windows.Forms.Button();
            this.btnCapnhatNCC = new System.Windows.Forms.Button();
            this.btnXoaNCC = new System.Windows.Forms.Button();
            this.btnThemNCC = new System.Windows.Forms.Button();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.lblMKH = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSupplier)).BeginInit();
            this.grpbNhapKH.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cbSapxepNCC);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTimNCC);
            this.panel1.Controls.Add(this.lblTimkiem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dGVSupplier);
            this.panel1.Location = new System.Drawing.Point(3, 316);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1224, 335);
            this.panel1.TabIndex = 1;
            // 
            // cbSapxepNCC
            // 
            this.cbSapxepNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSapxepNCC.Font = new System.Drawing.Font("Josefin Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSapxepNCC.FormattingEnabled = true;
            this.cbSapxepNCC.Items.AddRange(new object[] {
            "Mặc định",
            "Tên, A->Z",
            "Tên, Z->A"});
            this.cbSapxepNCC.Location = new System.Drawing.Point(1060, 12);
            this.cbSapxepNCC.Name = "cbSapxepNCC";
            this.cbSapxepNCC.Size = new System.Drawing.Size(161, 35);
            this.cbSapxepNCC.TabIndex = 12;
            this.cbSapxepNCC.SelectedIndexChanged += new System.EventHandler(this.cbSapxepNCC_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Josefin Sans SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(945, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 38);
            this.label4.TabIndex = 34;
            this.label4.Text = "Sắp xếp:";
            // 
            // txtTimNCC
            // 
            this.txtTimNCC.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimNCC.Location = new System.Drawing.Point(570, 14);
            this.txtTimNCC.Name = "txtTimNCC";
            this.txtTimNCC.Size = new System.Drawing.Size(358, 33);
            this.txtTimNCC.TabIndex = 11;
            this.txtTimNCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimNCC_KeyPress);
            // 
            // lblTimkiem
            // 
            this.lblTimkiem.AutoSize = true;
            this.lblTimkiem.Font = new System.Drawing.Font("Josefin Sans SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimkiem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTimkiem.Location = new System.Drawing.Point(436, 9);
            this.lblTimkiem.Name = "lblTimkiem";
            this.lblTimkiem.Size = new System.Drawing.Size(128, 38);
            this.lblTimkiem.TabIndex = 32;
            this.lblTimkiem.Text = "Tìm kiếm: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Josefin Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "DANH SÁCH NHÀ CUNG CẤP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dGVSupplier
            // 
            this.dGVSupplier.AllowUserToAddRows = false;
            this.dGVSupplier.AllowUserToDeleteRows = false;
            this.dGVSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVSupplier.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVSupplier.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGVSupplier.Location = new System.Drawing.Point(3, 54);
            this.dGVSupplier.Name = "dGVSupplier";
            this.dGVSupplier.ReadOnly = true;
            this.dGVSupplier.RowHeadersWidth = 51;
            this.dGVSupplier.RowTemplate.Height = 24;
            this.dGVSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVSupplier.Size = new System.Drawing.Size(1218, 273);
            this.dGVSupplier.TabIndex = 13;
            this.dGVSupplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVSupplier_CellClick);
            // 
            // grpbNhapKH
            // 
            this.grpbNhapKH.Controls.Add(this.txtDcNCC);
            this.grpbNhapKH.Controls.Add(this.label3);
            this.grpbNhapKH.Controls.Add(this.txtSdtNCC);
            this.grpbNhapKH.Controls.Add(this.label2);
            this.grpbNhapKH.Controls.Add(this.btnLuuNCC);
            this.grpbNhapKH.Controls.Add(this.txtEmailNCC);
            this.grpbNhapKH.Controls.Add(this.txtTenNCC);
            this.grpbNhapKH.Controls.Add(this.btnHuyNCC);
            this.grpbNhapKH.Controls.Add(this.btnCapnhatNCC);
            this.grpbNhapKH.Controls.Add(this.btnXoaNCC);
            this.grpbNhapKH.Controls.Add(this.btnThemNCC);
            this.grpbNhapKH.Controls.Add(this.lblSDT);
            this.grpbNhapKH.Controls.Add(this.lblTenKH);
            this.grpbNhapKH.Controls.Add(this.txtMaNCC);
            this.grpbNhapKH.Controls.Add(this.lblMKH);
            this.grpbNhapKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbNhapKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpbNhapKH.Font = new System.Drawing.Font("Josefin Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbNhapKH.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grpbNhapKH.Location = new System.Drawing.Point(0, 0);
            this.grpbNhapKH.Name = "grpbNhapKH";
            this.grpbNhapKH.Size = new System.Drawing.Size(1230, 320);
            this.grpbNhapKH.TabIndex = 3;
            this.grpbNhapKH.TabStop = false;
            this.grpbNhapKH.Text = "Khung nhập liệu";
            // 
            // txtDcNCC
            // 
            this.txtDcNCC.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDcNCC.Location = new System.Drawing.Point(201, 165);
            this.txtDcNCC.Name = "txtDcNCC";
            this.txtDcNCC.Size = new System.Drawing.Size(366, 34);
            this.txtDcNCC.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(21, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 31);
            this.label3.TabIndex = 30;
            this.label3.Text = "Địa chỉ:";
            // 
            // txtSdtNCC
            // 
            this.txtSdtNCC.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSdtNCC.Location = new System.Drawing.Point(772, 112);
            this.txtSdtNCC.MaxLength = 10;
            this.txtSdtNCC.Name = "txtSdtNCC";
            this.txtSdtNCC.Size = new System.Drawing.Size(315, 34);
            this.txtSdtNCC.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(614, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 31);
            this.label2.TabIndex = 28;
            this.label2.Text = "Email:";
            // 
            // btnLuuNCC
            // 
            this.btnLuuNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuNCC.Font = new System.Drawing.Font("Josefin Sans", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuNCC.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLuuNCC.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuNCC.Image")));
            this.btnLuuNCC.Location = new System.Drawing.Point(420, 223);
            this.btnLuuNCC.Name = "btnLuuNCC";
            this.btnLuuNCC.Size = new System.Drawing.Size(144, 87);
            this.btnLuuNCC.TabIndex = 8;
            this.btnLuuNCC.Text = "Lưu";
            this.btnLuuNCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuuNCC.UseVisualStyleBackColor = true;
            this.btnLuuNCC.Click += new System.EventHandler(this.btnLuuNCC_Click);
            // 
            // txtEmailNCC
            // 
            this.txtEmailNCC.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailNCC.Location = new System.Drawing.Point(772, 59);
            this.txtEmailNCC.MaxLength = 100;
            this.txtEmailNCC.Name = "txtEmailNCC";
            this.txtEmailNCC.Size = new System.Drawing.Size(315, 34);
            this.txtEmailNCC.TabIndex = 4;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNCC.Location = new System.Drawing.Point(201, 112);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(366, 34);
            this.txtTenNCC.TabIndex = 2;
            // 
            // btnHuyNCC
            // 
            this.btnHuyNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyNCC.Font = new System.Drawing.Font("Josefin Sans", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyNCC.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnHuyNCC.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyNCC.Image")));
            this.btnHuyNCC.Location = new System.Drawing.Point(792, 223);
            this.btnHuyNCC.Name = "btnHuyNCC";
            this.btnHuyNCC.Size = new System.Drawing.Size(146, 87);
            this.btnHuyNCC.TabIndex = 10;
            this.btnHuyNCC.Text = "Hủy";
            this.btnHuyNCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuyNCC.UseVisualStyleBackColor = true;
            this.btnHuyNCC.Click += new System.EventHandler(this.btnHuyNCC_Click);
            // 
            // btnCapnhatNCC
            // 
            this.btnCapnhatNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapnhatNCC.Font = new System.Drawing.Font("Josefin Sans", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhatNCC.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCapnhatNCC.Image = ((System.Drawing.Image)(resources.GetObject("btnCapnhatNCC.Image")));
            this.btnCapnhatNCC.Location = new System.Drawing.Point(223, 223);
            this.btnCapnhatNCC.Name = "btnCapnhatNCC";
            this.btnCapnhatNCC.Size = new System.Drawing.Size(157, 87);
            this.btnCapnhatNCC.TabIndex = 7;
            this.btnCapnhatNCC.Text = "Cập nhật";
            this.btnCapnhatNCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCapnhatNCC.UseVisualStyleBackColor = true;
            this.btnCapnhatNCC.Click += new System.EventHandler(this.btnCapnhatNCC_Click);
            // 
            // btnXoaNCC
            // 
            this.btnXoaNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaNCC.Font = new System.Drawing.Font("Josefin Sans", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNCC.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnXoaNCC.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaNCC.Image")));
            this.btnXoaNCC.Location = new System.Drawing.Point(604, 223);
            this.btnXoaNCC.Name = "btnXoaNCC";
            this.btnXoaNCC.Size = new System.Drawing.Size(147, 87);
            this.btnXoaNCC.TabIndex = 9;
            this.btnXoaNCC.Text = "Xóa";
            this.btnXoaNCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaNCC.UseVisualStyleBackColor = true;
            this.btnXoaNCC.Click += new System.EventHandler(this.btnXoaNCC_Click);
            // 
            // btnThemNCC
            // 
            this.btnThemNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNCC.Font = new System.Drawing.Font("Josefin Sans", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNCC.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnThemNCC.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNCC.Image")));
            this.btnThemNCC.Location = new System.Drawing.Point(20, 223);
            this.btnThemNCC.Name = "btnThemNCC";
            this.btnThemNCC.Size = new System.Drawing.Size(165, 87);
            this.btnThemNCC.TabIndex = 6;
            this.btnThemNCC.Text = "Thêm";
            this.btnThemNCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemNCC.UseVisualStyleBackColor = true;
            this.btnThemNCC.Click += new System.EventHandler(this.btnThemNCC_Click);
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSDT.Location = new System.Drawing.Point(614, 115);
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
            this.lblTenKH.Size = new System.Drawing.Size(177, 31);
            this.lblTenKH.TabIndex = 2;
            this.lblTenKH.Text = "Tên nhà cung cấp:";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNCC.Location = new System.Drawing.Point(201, 59);
            this.txtMaNCC.MaxLength = 6;
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.ReadOnly = true;
            this.txtMaNCC.Size = new System.Drawing.Size(366, 34);
            this.txtMaNCC.TabIndex = 1;
            // 
            // lblMKH
            // 
            this.lblMKH.AutoSize = true;
            this.lblMKH.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMKH.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMKH.Location = new System.Drawing.Point(18, 62);
            this.lblMKH.Name = "lblMKH";
            this.lblMKH.Size = new System.Drawing.Size(177, 31);
            this.lblMKH.TabIndex = 0;
            this.lblMKH.Text = "Mã nhà cung cấp:";
            // 
            // frmNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1230, 651);
            this.Controls.Add(this.grpbNhapKH);
            this.Controls.Add(this.panel1);
            this.Name = "frmNhaCungCap";
            this.Text = "Quản lý Nhà Cung Cấp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSupplier)).EndInit();
            this.grpbNhapKH.ResumeLayout(false);
            this.grpbNhapKH.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dGVSupplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpbNhapKH;
        private System.Windows.Forms.Button btnLuuNCC;
        private System.Windows.Forms.TextBox txtEmailNCC;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.Button btnHuyNCC;
        private System.Windows.Forms.Button btnCapnhatNCC;
        private System.Windows.Forms.Button btnXoaNCC;
        private System.Windows.Forms.Button btnThemNCC;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label lblMKH;
        private System.Windows.Forms.TextBox txtSdtNCC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDcNCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTimNCC;
        private System.Windows.Forms.Label lblTimkiem;
        private System.Windows.Forms.ComboBox cbSapxepNCC;
        private System.Windows.Forms.Label label4;
    }
}