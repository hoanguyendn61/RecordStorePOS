using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using RetailStore.BLL;
using DevExpress.XtraReports.UI;
namespace RetailStore
{
    public partial class frmTinhtien : Form
    {
        public frmTinhtien()
        {
            InitializeComponent();
        }
        private frmThanhtoan frmthanhToan = null;
        private frmThanhtoan FrmThanhToan
        {
            get { return frmthanhToan; }
            set { frmthanhToan = value; }
        }
        public frmTinhtien(frmThanhtoan parentForm) : this()
        {
            this.FrmThanhToan = parentForm;
        }
        private void frmTinhtien_Load(object sender, EventArgs e)
        {
            txtTong.Text = frmthanhToan.txtTongC.Text;
            nmKhachdua.Select();
        }
        private void nmKhachdua_ValueChanged(object sender, EventArgs e)
        {
            double TongC = frmthanhToan.TOTAL;
            double Tralai = (double)Convert.ToDouble(nmKhachdua.Value) - TongC;
            txtTralai.Text = String.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", Tralai);
        }
        double Tralai;
        private void nmKhachdua_KeyDown(object sender, KeyEventArgs e)
        {
            double TongC = frmthanhToan.TOTAL;
            Tralai = (double)Convert.ToDouble(nmKhachdua.Value) - TongC;
            txtTralai.Text = String.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", Tralai);
        }
        private void btnInHD_Click(object sender, EventArgs e)
        {
            if (Tralai >= 0)
            {
                HoaDonReport hoaDonIn = new HoaDonReport(nmKhachdua.Value.ToString(), txtTralai.Text);
                hoaDonIn.DataSource = BLL_HoaDon.Instance.PrintHoaDon_BLL(frmthanhToan.txtMaHD.Text);
                hoaDonIn.ShowPreviewDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Khách đưa chưa đủ tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnKoInHD_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
