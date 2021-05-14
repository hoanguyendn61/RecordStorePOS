
namespace RetailStore.GUI
{
    partial class frmGioCongCT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGioCongCT));
            this.btnLuuGC = new System.Windows.Forms.Button();
            this.btnHuyGC = new System.Windows.Forms.Button();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTenNV = new System.Windows.Forms.ComboBox();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpClockIn = new System.Windows.Forms.DateTimePicker();
            this.dtpClockOut = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnLuuGC
            // 
            this.btnLuuGC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuGC.Font = new System.Drawing.Font("Josefin Sans", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuGC.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLuuGC.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuGC.Image")));
            this.btnLuuGC.Location = new System.Drawing.Point(82, 259);
            this.btnLuuGC.Name = "btnLuuGC";
            this.btnLuuGC.Size = new System.Drawing.Size(151, 87);
            this.btnLuuGC.TabIndex = 9;
            this.btnLuuGC.Text = "Lưu";
            this.btnLuuGC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuuGC.UseVisualStyleBackColor = true;
            this.btnLuuGC.Click += new System.EventHandler(this.btnLuuGC_Click);
            // 
            // btnHuyGC
            // 
            this.btnHuyGC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyGC.Font = new System.Drawing.Font("Josefin Sans", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyGC.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnHuyGC.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyGC.Image")));
            this.btnHuyGC.Location = new System.Drawing.Point(276, 259);
            this.btnHuyGC.Name = "btnHuyGC";
            this.btnHuyGC.Size = new System.Drawing.Size(146, 87);
            this.btnHuyGC.TabIndex = 10;
            this.btnHuyGC.Text = "Hủy";
            this.btnHuyGC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuyGC.UseVisualStyleBackColor = true;
            this.btnHuyGC.Click += new System.EventHandler(this.btnHuyGC_Click);
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNV.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTenNV.Location = new System.Drawing.Point(48, 27);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(142, 31);
            this.lblTenNV.TabIndex = 11;
            this.lblTenNV.Text = "Tên nhân viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(48, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ngày làm việc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(48, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "Giờ vào:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(48, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "Giờ ra:";
            // 
            // cbTenNV
            // 
            this.cbTenNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenNV.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTenNV.FormattingEnabled = true;
            this.cbTenNV.Location = new System.Drawing.Point(216, 19);
            this.cbTenNV.Name = "cbTenNV";
            this.cbTenNV.Size = new System.Drawing.Size(240, 39);
            this.cbTenNV.TabIndex = 12;
            // 
            // dtpNgay
            // 
            this.dtpNgay.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay.Location = new System.Drawing.Point(216, 80);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(240, 34);
            this.dtpNgay.TabIndex = 13;
            // 
            // dtpClockIn
            // 
            this.dtpClockIn.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpClockIn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpClockIn.Location = new System.Drawing.Point(216, 134);
            this.dtpClockIn.Name = "dtpClockIn";
            this.dtpClockIn.ShowUpDown = true;
            this.dtpClockIn.Size = new System.Drawing.Size(240, 34);
            this.dtpClockIn.TabIndex = 13;
            // 
            // dtpClockOut
            // 
            this.dtpClockOut.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpClockOut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpClockOut.Location = new System.Drawing.Point(216, 188);
            this.dtpClockOut.Name = "dtpClockOut";
            this.dtpClockOut.ShowUpDown = true;
            this.dtpClockOut.Size = new System.Drawing.Size(240, 34);
            this.dtpClockOut.TabIndex = 13;
            // 
            // frmGioCongCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(517, 382);
            this.Controls.Add(this.dtpClockOut);
            this.Controls.Add(this.dtpClockIn);
            this.Controls.Add(this.dtpNgay);
            this.Controls.Add(this.cbTenNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTenNV);
            this.Controls.Add(this.btnLuuGC);
            this.Controls.Add(this.btnHuyGC);
            this.Name = "frmGioCongCT";
            this.Text = "Thiết lập giờ công";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLuuGC;
        private System.Windows.Forms.Button btnHuyGC;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTenNV;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.DateTimePicker dtpClockIn;
        private System.Windows.Forms.DateTimePicker dtpClockOut;
    }
}