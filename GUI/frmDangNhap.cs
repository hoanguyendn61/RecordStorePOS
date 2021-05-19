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
using RetailStore.DTO;
namespace RetailStore
{
    public partial class frmDangnhap : Form
    {
        static public NhanVien nv = null;
        static public DangNhap dn = null;
        public frmDangnhap()
        {
            InitializeComponent();
            
        }
        string username;
        string password;
        private void Login()
        {
            username = txtTaikhoan.Text;
            password = txtMatkhau.Text;
            dn = BLL_DangNhap.Instance.Login_BLL(username, password);
            if (dn != null)
            {
                nv = BLL_NhanVien.Instance.GetEmployeeByUsername_BLL(dn);
                frmMenu f;
                f = new frmMenu();
                txtTaikhoan.Clear();
                txtMatkhau.Clear();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Nhập sai tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if(txtMatkhau.Text == "" || txtTaikhoan.Text == "")
            {
                MessageBox.Show("Chưa nhập tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Login();
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (MessageBox.Show("Xác nhận thoát chương trình", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void btnDangnhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
        private void frmDangnhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
        private void txtMatkhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

    }
}
