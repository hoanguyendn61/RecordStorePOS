namespace RetailStore
{
    partial class frmTinhtien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTinhtien));
            this.txtTong = new System.Windows.Forms.TextBox();
            this.txtTralai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInHD = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.nmKhachdua = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmKhachdua)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTong
            // 
            this.txtTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTong.Location = new System.Drawing.Point(231, 73);
            this.txtTong.Name = "txtTong";
            this.txtTong.ReadOnly = true;
            this.txtTong.Size = new System.Drawing.Size(279, 34);
            this.txtTong.TabIndex = 0;
            this.txtTong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTralai
            // 
            this.txtTralai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTralai.Location = new System.Drawing.Point(231, 191);
            this.txtTralai.Name = "txtTralai";
            this.txtTralai.ReadOnly = true;
            this.txtTralai.Size = new System.Drawing.Size(279, 34);
            this.txtTralai.TabIndex = 2;
            this.txtTralai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Josefin Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(46, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "TỔNG CỘNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Josefin Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(46, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "KHÁCH ĐƯA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Josefin Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(46, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "TRẢ LẠI";
            // 
            // btnInHD
            // 
            this.btnInHD.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnInHD.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnInHD.FlatAppearance.BorderSize = 3;
            this.btnInHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInHD.Font = new System.Drawing.Font("Josefin Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInHD.Image = ((System.Drawing.Image)(resources.GetObject("btnInHD.Image")));
            this.btnInHD.Location = new System.Drawing.Point(53, 250);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(268, 94);
            this.btnInHD.TabIndex = 7;
            this.btnInHD.Text = "IN HÓA ĐƠN";
            this.btnInHD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInHD.UseVisualStyleBackColor = false;
            this.btnInHD.Click += new System.EventHandler(this.btnInHD_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Josefin Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(327, 250);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(183, 94);
            this.btnDong.TabIndex = 8;
            this.btnDong.Text = "ĐÓNG";
            this.btnDong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // nmKhachdua
            // 
            this.nmKhachdua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmKhachdua.Increment = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmKhachdua.Location = new System.Drawing.Point(231, 136);
            this.nmKhachdua.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nmKhachdua.Name = "nmKhachdua";
            this.nmKhachdua.Size = new System.Drawing.Size(279, 34);
            this.nmKhachdua.TabIndex = 10;
            this.nmKhachdua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmKhachdua.ValueChanged += new System.EventHandler(this.nmKhachdua_ValueChanged);
            this.nmKhachdua.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nmKhachdua_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Josefin Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(92, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(341, 52);
            this.label4.TabIndex = 11;
            this.label4.Text = "TÍNH TIỀN TRẢ LẠI";
            // 
            // frmTinhtien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(569, 355);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nmKhachdua);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnInHD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTralai);
            this.Controls.Add(this.txtTong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTinhtien";
            this.Text = "Tính tiền trả lại";
            ((System.ComponentModel.ISupportInitialize)(this.nmKhachdua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInHD;
        private System.Windows.Forms.Button btnDong;
        public System.Windows.Forms.TextBox txtTralai;
        public System.Windows.Forms.NumericUpDown nmKhachdua;
        private System.Windows.Forms.Label label4;
    }
}