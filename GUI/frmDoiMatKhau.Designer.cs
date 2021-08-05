namespace RetailStore
{
    partial class frmDoimatkhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoimatkhau));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.txtMKC = new System.Windows.Forms.TextBox();
            this.txtXacNMKM = new System.Windows.Forms.TextBox();
            this.txtMKM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLuuMK = new System.Windows.Forms.Button();
            this.btnHuyDoiMK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Josefin Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐỔI MẬT KHẨU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Josefin Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(54, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài khoản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Josefin Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(54, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu cũ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Josefin Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(54, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật khẩu mới:";
            // 
            // txtTK
            // 
            this.txtTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTK.Location = new System.Drawing.Point(61, 112);
            this.txtTK.Name = "txtTK";
            this.txtTK.ReadOnly = true;
            this.txtTK.Size = new System.Drawing.Size(274, 34);
            this.txtTK.TabIndex = 1;
            // 
            // txtMKC
            // 
            this.txtMKC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKC.Location = new System.Drawing.Point(61, 214);
            this.txtMKC.Name = "txtMKC";
            this.txtMKC.PasswordChar = '●';
            this.txtMKC.Size = new System.Drawing.Size(274, 34);
            this.txtMKC.TabIndex = 2;
            // 
            // txtXacNMKM
            // 
            this.txtXacNMKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXacNMKM.Location = new System.Drawing.Point(61, 403);
            this.txtXacNMKM.Name = "txtXacNMKM";
            this.txtXacNMKM.PasswordChar = '●';
            this.txtXacNMKM.Size = new System.Drawing.Size(274, 34);
            this.txtXacNMKM.TabIndex = 4;
            this.txtXacNMKM.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtXacNMKM_KeyDown);
            // 
            // txtMKM
            // 
            this.txtMKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKM.Location = new System.Drawing.Point(63, 306);
            this.txtMKM.Name = "txtMKM";
            this.txtMKM.PasswordChar = '●';
            this.txtMKM.Size = new System.Drawing.Size(274, 34);
            this.txtMKM.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Josefin Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(54, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 38);
            this.label5.TabIndex = 7;
            this.label5.Text = "Xác nhận mật khẩu mới:";
            // 
            // btnLuuMK
            // 
            this.btnLuuMK.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLuuMK.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnLuuMK.FlatAppearance.BorderSize = 3;
            this.btnLuuMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuMK.Font = new System.Drawing.Font("Josefin Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuMK.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLuuMK.Location = new System.Drawing.Point(63, 458);
            this.btnLuuMK.Name = "btnLuuMK";
            this.btnLuuMK.Size = new System.Drawing.Size(149, 62);
            this.btnLuuMK.TabIndex = 5;
            this.btnLuuMK.Text = "LƯU";
            this.btnLuuMK.UseVisualStyleBackColor = false;
            this.btnLuuMK.Click += new System.EventHandler(this.btnLuuMK_Click);
            // 
            // btnHuyDoiMK
            // 
            this.btnHuyDoiMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyDoiMK.Font = new System.Drawing.Font("Josefin Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyDoiMK.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnHuyDoiMK.Location = new System.Drawing.Point(215, 458);
            this.btnHuyDoiMK.Name = "btnHuyDoiMK";
            this.btnHuyDoiMK.Size = new System.Drawing.Size(126, 62);
            this.btnHuyDoiMK.TabIndex = 6;
            this.btnHuyDoiMK.Text = "HỦY";
            this.btnHuyDoiMK.UseVisualStyleBackColor = true;
            this.btnHuyDoiMK.Click += new System.EventHandler(this.btnHuyDoiMK_Click);
            // 
            // frmDoimatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(403, 544);
            this.Controls.Add(this.btnHuyDoiMK);
            this.Controls.Add(this.btnLuuMK);
            this.Controls.Add(this.txtMKM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtXacNMKM);
            this.Controls.Add(this.txtMKC);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDoimatkhau";
            this.Text = "Đổi mật khẩu";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMKC;
        private System.Windows.Forms.TextBox txtXacNMKM;
        private System.Windows.Forms.TextBox txtMKM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLuuMK;
        private System.Windows.Forms.Button btnHuyDoiMK;
        public System.Windows.Forms.TextBox txtTK;
    }
}