
namespace RetailStore.GUI
{
    partial class frmLichSuBH
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLichSuBH));
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbKH = new System.Windows.Forms.ComboBox();
            this.cbNV = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnCTHD = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvLichSuBH = new System.Windows.Forms.DataGridView();
            this.btnXem = new System.Windows.Forms.Button();
            this.txtTimHD = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuBH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(137, 72);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(147, 34);
            this.dtpTo.TabIndex = 5;
            // 
            // dtpFrom
            // 
            this.dtpFrom.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpFrom.CalendarTitleForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dtpFrom.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(137, 28);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(147, 34);
            this.dtpFrom.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Josefin Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Josefin Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Từ ngày:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbKH);
            this.groupBox1.Controls.Add(this.cbNV);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Josefin Sans", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(290, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(819, 102);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bộ lọc";
            // 
            // cbKH
            // 
            this.cbKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKH.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKH.FormattingEnabled = true;
            this.cbKH.Location = new System.Drawing.Point(587, 35);
            this.cbKH.Name = "cbKH";
            this.cbKH.Size = new System.Drawing.Size(217, 39);
            this.cbKH.TabIndex = 1;
            // 
            // cbNV
            // 
            this.cbNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNV.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNV.FormattingEnabled = true;
            this.cbNV.Location = new System.Drawing.Point(171, 35);
            this.cbNV.Name = "cbNV";
            this.cbNV.Size = new System.Drawing.Size(217, 39);
            this.cbNV.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(408, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "Theo khách hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Theo người bán:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtTimHD);
            this.panel1.Controls.Add(this.lblMaHD);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnHuyBo);
            this.panel1.Controls.Add(this.btnCTHD);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dgvLichSuBH);
            this.panel1.Location = new System.Drawing.Point(4, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1224, 527);
            this.panel1.TabIndex = 8;
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Font = new System.Drawing.Font("Josefin Sans", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHD.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMaHD.Location = new System.Drawing.Point(831, 10);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(0, 34);
            this.lblMaHD.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Josefin Sans", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(685, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 34);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mã hóa đơn:";
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyBo.Font = new System.Drawing.Font("Josefin Sans", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyBo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnHuyBo.Location = new System.Drawing.Point(1096, 7);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(118, 44);
            this.btnHuyBo.TabIndex = 9;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnCTHD
            // 
            this.btnCTHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCTHD.Font = new System.Drawing.Font("Josefin Sans", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCTHD.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCTHD.Location = new System.Drawing.Point(982, 7);
            this.btnCTHD.Name = "btnCTHD";
            this.btnCTHD.Size = new System.Drawing.Size(108, 44);
            this.btnCTHD.TabIndex = 9;
            this.btnCTHD.Text = "Chi tiết";
            this.btnCTHD.UseVisualStyleBackColor = true;
            this.btnCTHD.Click += new System.EventHandler(this.btnCTHD_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Josefin Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(8, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 44);
            this.label3.TabIndex = 5;
            this.label3.Text = "DACH SÁCH HÓA ĐƠN";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvLichSuBH
            // 
            this.dgvLichSuBH.AllowUserToAddRows = false;
            this.dgvLichSuBH.AllowUserToDeleteRows = false;
            this.dgvLichSuBH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLichSuBH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichSuBH.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLichSuBH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvLichSuBH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLichSuBH.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvLichSuBH.Location = new System.Drawing.Point(9, 56);
            this.dgvLichSuBH.MultiSelect = false;
            this.dgvLichSuBH.Name = "dgvLichSuBH";
            this.dgvLichSuBH.ReadOnly = true;
            this.dgvLichSuBH.RowHeadersWidth = 51;
            this.dgvLichSuBH.RowTemplate.Height = 24;
            this.dgvLichSuBH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichSuBH.Size = new System.Drawing.Size(1206, 463);
            this.dgvLichSuBH.TabIndex = 1;
            this.dgvLichSuBH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichSuBH_CellClick);
            // 
            // btnXem
            // 
            this.btnXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXem.Font = new System.Drawing.Font("Josefin Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnXem.Location = new System.Drawing.Point(1114, 28);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(104, 78);
            this.btnXem.TabIndex = 9;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // txtTimHD
            // 
            this.txtTimHD.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimHD.Location = new System.Drawing.Point(414, 14);
            this.txtTimHD.Name = "txtTimHD";
            this.txtTimHD.Size = new System.Drawing.Size(228, 30);
            this.txtTimHD.TabIndex = 12;
            this.txtTimHD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimHD_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(366, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // frmLichSuBH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1230, 651);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLichSuBH";
            this.Text = "Lịch sử bán hàng";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuBH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.DataGridView dgvLichSuBH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCTHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.TextBox txtTimHD;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}