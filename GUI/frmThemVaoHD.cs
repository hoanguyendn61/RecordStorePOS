using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailStore
{
    public partial class frmThemVaoHD : Form
    {
        public frmThemVaoHD()
        {
            InitializeComponent();
        }
        private frmThanhtoan _parentForm1 = null;
        private frmThanhtoan FrmThanhToan
        {
            get { return _parentForm1; }
            set { _parentForm1 = value; }
        }
        public frmThemVaoHD(frmThanhtoan parentForm) : this()
        {
            this.FrmThanhToan = parentForm;
        }

        private void frmThemVaoHD_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Parent = null;
            this.Hide();
        }
        private void btnHuySL_Click(object sender, EventArgs e)
        {
             this.Close();
        }
        private void btnXacnhanSL_Click(object sender, EventArgs e)
        {
            if (this.FrmThanhToan.lsvHHThanhToan.SelectedItems.Count > 0)
            {
                ListViewItem lvi = this.FrmThanhToan.lsvHHThanhToan.SelectedItems[0];
                int id = this.FrmThanhToan.dtgvTTHang.SelectedRows[0].Index;
                int slH = (int)Convert.ToInt32(this.FrmThanhToan.dtgvTTHang.Rows[id].Cells[3].Value.ToString());
                if (nmSLSP.Value <= slH)
                {
                    lvi.SubItems[2].Text = nmSLSP.Value.ToString();
                    double thanhtien = (double)Convert.ToDouble(txtDongia.Text) * (double)Convert.ToDouble(nmSLSP.Value);
                    lvi.SubItems[4].Text = thanhtien.ToString();
                }
                else
                {
                    MessageBox.Show("NHẬP QUÁ SỐ LƯỢNG CÒN LẠI CỦA SẢN PHẨM", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Hide();
            }
            this.FrmThanhToan.TinhTien();
        }
        
    }
}
