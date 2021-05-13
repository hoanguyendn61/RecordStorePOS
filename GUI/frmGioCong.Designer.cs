
namespace RetailStore.GUI
{
    partial class frmGioCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGioCong));
            this.dGVGioCong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnXem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCapnhatGC = new System.Windows.Forms.Button();
            this.btnXoaGC = new System.Windows.Forms.Button();
            this.btnThemGC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVGioCong)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGVGioCong
            // 
            this.dGVGioCong.AllowUserToAddRows = false;
            this.dGVGioCong.AllowUserToDeleteRows = false;
            this.dGVGioCong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVGioCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVGioCong.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVGioCong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVGioCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVGioCong.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGVGioCong.Location = new System.Drawing.Point(15, 54);
            this.dGVGioCong.Name = "dGVGioCong";
            this.dGVGioCong.ReadOnly = true;
            this.dGVGioCong.RowHeadersWidth = 51;
            this.dGVGioCong.RowTemplate.Height = 24;
            this.dGVGioCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVGioCong.Size = new System.Drawing.Size(1206, 395);
            this.dGVGioCong.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Josefin Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Josefin Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến ngày:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpFrom.CalendarTitleForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dtpFrom.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(143, 13);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(147, 34);
            this.dtpFrom.TabIndex = 2;
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(143, 57);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(147, 34);
            this.dtpTo.TabIndex = 2;
            // 
            // btnXem
            // 
            this.btnXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXem.Font = new System.Drawing.Font("Josefin Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnXem.Location = new System.Drawing.Point(296, 13);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(164, 78);
            this.btnXem.TabIndex = 3;
            this.btnXem.Text = "Xem công";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Josefin Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(349, 44);
            this.label3.TabIndex = 4;
            this.label3.Text = "DANH SÁCH GIỜ CÔNG";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnCapnhatGC);
            this.panel1.Controls.Add(this.btnXoaGC);
            this.panel1.Controls.Add(this.btnThemGC);
            this.panel1.Controls.Add(this.dGVGioCong);
            this.panel1.Location = new System.Drawing.Point(-3, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1232, 552);
            this.panel1.TabIndex = 5;
            // 
            // btnCapnhatGC
            // 
            this.btnCapnhatGC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCapnhatGC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapnhatGC.Font = new System.Drawing.Font("Josefin Sans", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhatGC.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCapnhatGC.Image = ((System.Drawing.Image)(resources.GetObject("btnCapnhatGC.Image")));
            this.btnCapnhatGC.Location = new System.Drawing.Point(231, 455);
            this.btnCapnhatGC.Name = "btnCapnhatGC";
            this.btnCapnhatGC.Size = new System.Drawing.Size(157, 87);
            this.btnCapnhatGC.TabIndex = 11;
            this.btnCapnhatGC.Text = "Cập nhật";
            this.btnCapnhatGC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCapnhatGC.UseVisualStyleBackColor = true;
            // 
            // btnXoaGC
            // 
            this.btnXoaGC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoaGC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaGC.Font = new System.Drawing.Font("Josefin Sans", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaGC.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnXoaGC.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaGC.Image")));
            this.btnXoaGC.Location = new System.Drawing.Point(445, 455);
            this.btnXoaGC.Name = "btnXoaGC";
            this.btnXoaGC.Size = new System.Drawing.Size(147, 87);
            this.btnXoaGC.TabIndex = 13;
            this.btnXoaGC.Text = "Xóa";
            this.btnXoaGC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaGC.UseVisualStyleBackColor = true;
            // 
            // btnThemGC
            // 
            this.btnThemGC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThemGC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemGC.Font = new System.Drawing.Font("Josefin Sans", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemGC.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnThemGC.Image = ((System.Drawing.Image)(resources.GetObject("btnThemGC.Image")));
            this.btnThemGC.Location = new System.Drawing.Point(15, 455);
            this.btnThemGC.Name = "btnThemGC";
            this.btnThemGC.Size = new System.Drawing.Size(165, 87);
            this.btnThemGC.TabIndex = 10;
            this.btnThemGC.Text = "Thêm";
            this.btnThemGC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemGC.UseVisualStyleBackColor = true;
            // 
            // frmGioCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1230, 651);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "frmGioCong";
            this.Text = "Quản lý Giờ Công";
            ((System.ComponentModel.ISupportInitialize)(this.dGVGioCong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVGioCong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCapnhatGC;
        private System.Windows.Forms.Button btnXoaGC;
        private System.Windows.Forms.Button btnThemGC;
    }
}