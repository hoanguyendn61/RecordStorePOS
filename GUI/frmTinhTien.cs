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
using RetailStore.DTO;
namespace RetailStore
{
    public partial class frmTinhtien : Form
    {
        HoaDon hdon = null;
        public frmTinhtien(HoaDon hd)
        {
            InitializeComponent();
            hdon = hd;
            txtTong.Text = String.Format("{0:#,##0}", hdon.Tổng_cộng);
            TinhTienTraLai();
            nmKhachdua.Select();
        }
        double Tralai;
        private void TinhTienTraLai()
        {
            double TongC = hdon.Tổng_cộng;
            Tralai = Convert.ToDouble(nmKhachdua.Value) - TongC;
            txtTralai.Text = String.Format("{0:#,##0}", Tralai);
        }
        private void nmKhachdua_ValueChanged(object sender, EventArgs e)
        {
            TinhTienTraLai();
        }
        private void nmKhachdua_KeyUp(object sender, KeyEventArgs e)
        {
            TinhTienTraLai();
        }
        private void btnInHD_Click(object sender, EventArgs e)
        {
            if (Tralai >= 0)
            {
                HoaDonReport hoaDonIn = new HoaDonReport(Convert.ToDouble(nmKhachdua.Value));
                hoaDonIn.DataSource = BLL_HoaDon.Instance.PrintHoaDon_BLL(hdon.Mã_HĐơn);
                hoaDonIn.ShowPreviewDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Khách đưa chưa đủ tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            if (Tralai >= 0)
            {
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Khách đưa chưa đủ tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if(Tralai < 0)
            {
                MessageBox.Show("Khách đưa chưa đủ tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
        }
    }
}
