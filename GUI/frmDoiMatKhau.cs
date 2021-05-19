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
    public partial class frmDoimatkhau : Form
    {
        public frmDoimatkhau()
        {
            InitializeComponent();
        }
        private void btnHuyDoiMK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LuuMK()
        {
            if (frmDangnhap.dn.Mật_khẩu != txtMKC.Text )
            {
                MessageBox.Show("Nhập sai mật khẩu cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMKC.Clear();
                txtMKM.Clear();
                txtXacNMKM.Clear();
            }
            else if (txtMKM.Text != txtXacNMKM.Text)
            {
                MessageBox.Show("Nhập sai mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMKM.Clear();
                txtXacNMKM.Clear();
            }
            else
            {
                if (txtMKM.Text != "" && txtMKC.Text != "" && txtMKM.Text != "")
                {
                    frmDangnhap.dn.Mật_khẩu = txtXacNMKM.Text;
                    if (BLL_DangNhap.Instance.UpdateAccount_BLL(frmDangnhap.dn))
                    {
                        MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Hãy nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnLuuMK_Click(object sender, EventArgs e)
        {
            LuuMK();
        }
        private void txtXacNMKM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LuuMK();
            }
        }
    }
}
