using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RetailStore.BLL;
namespace RetailStore
{
    public partial class frmThemVaoHD : Form
    {
        ListViewItem lvi = null;
        public frmThemVaoHD(ListViewItem i)
        {
            InitializeComponent();
            btnHuySL.DialogResult = DialogResult.Cancel;
            lvi = i;
            SetGUI(lvi);
        }
        private void SetGUI(ListViewItem i)
        {
            txtMahang.Text = i.SubItems[0].Text;
            txtTenhang.Text = i.SubItems[1].Text;
            nmSLSP.Value = Convert.ToInt32(i.SubItems[2].Text);
            txtDongia.Text = i.SubItems[3].Text;
        }
        private void btnXacnhanSL_Click(object sender, EventArgs e)
        {
            // gán mã hàng hóa cho string idHH
            string idHH = lvi.SubItems[0].Text;
            // gán số lượng hàng hóa tương ứng với idHH
            int slH = BLL_HangHoa.Instance.GetProductQuanityByID_BLL(idHH);
            if (nmSLSP.Value <= slH)
            {
                lvi.SubItems[2].Text = nmSLSP.Value.ToString();
                double thanhtien = Convert.ToDouble(txtDongia.Text) * Convert.ToDouble(nmSLSP.Value);
                lvi.SubItems[4].Text = String.Format("{0:#,##0}", thanhtien);
            }
            else
            {
                MessageBox.Show("Nhập quá số lượng còn lại của sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nmSLSP.Focus();
            }
        }
        private void nmSLSP_ValueChanged(object sender, EventArgs e)
        {
            // gán mã hàng hóa cho string idHH
            string idHH = lvi.SubItems[0].Text;
            // gán số lượng hàng hóa tương ứng với idHH
            int slH = BLL_HangHoa.Instance.GetProductQuanityByID_BLL(idHH);
            if (nmSLSP.Value <= slH)
            {
                btnXacnhanSL.DialogResult = DialogResult.OK;
            }
            else
            {
                btnXacnhanSL.DialogResult = DialogResult.None;
            }
        }
    }
}
