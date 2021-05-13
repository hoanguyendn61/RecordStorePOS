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
    public partial class frmMenu : Form
    {
        
        Boolean eeStatus = true;
        public frmMenu()
        {
            InitializeComponent();
            LoadData();
            lblName.Text = frmDangnhap.nv.Tên;
            frmThanhtoan frmTT = new frmThanhtoan(frmDangnhap.nv.Tên);
            addform(frmTT);
            if (frmDangnhap.nv.Loại_tài_khoản != true)
            {
                btnEmployees.Enabled = false;
                btnInventory.Enabled = false;
                btnDashboard.Enabled = false;
            }
        }
        private void LoadData()
        {
            lblTitle.Text = "THANH TOÁN";
            if (eeStatus) lblStatus.Text = "Chưa bấm giờ vào làm";
            pnlNav.Top = btnTerminal.Top;
            pnlNav.Height = btnTerminal.Height;
            pnlNav.Left = btnTerminal.Left;
            this.pnlfrmLoader.Controls.Clear();
        }
        private void addform(Form f)
        {
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            f.TopMost = true;
            this.pnlfrmLoader.Controls.Clear();
            this.pnlfrmLoader.Controls.Add(f);
            f.Show();
        }
        // Chấm công
        private void ClockInnOut()
        {
            string time;
            if (eeStatus)
            {
                time = DateTime.Now.TimeOfDay.ToString("hh\\:mm");
                from = TimeSpan.Parse(time);
                lblStatus.Text = "Bấm giờ vào làm việc lúc " + time;
                eeStatus = false;
            }
            else
            {
                DialogResult q = MessageBox.Show("Xác nhận bấm giờ ra", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (q == DialogResult.Yes)
                {

                    time = DateTime.Now.TimeOfDay.ToString("hh\\:mm");
                    to = TimeSpan.Parse(time);
                    GioCong gc = new GioCong(frmDangnhap.nv, from, to, DateTime.Now.Date);
                    lblStatus.Text = "Bấm giờ ra lúc " + time;
                    BLL_GioCong.Instance.InsertTime_BLL(gc);
                    eeStatus = true;
                }
            }
        }
        // Form QUẢN LÝ BÁO CÁO
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmThongKe fDB = new frmThongKe();
            lblTitle.Text = "BIỂU ĐỒ DOANH THU";
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Left = btnDashboard.Left;
            addform(fDB);
        }
        // Form QUẢN LÝ BÁN HÀNG
        private void btnTerminal_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "THANH TOÁN";
            pnlNav.Top = btnTerminal.Top;
            pnlNav.Height = btnTerminal.Height;
            pnlNav.Left = btnTerminal.Left;
            frmThanhtoan frmTT = new frmThanhtoan(frmDangnhap.nv.Tên);
            addform(frmTT);
        }
        // Form QUẢN LÝ KHO HÀNG
        private void btnInventory_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "QUẢN LÝ KHO HÀNG";
            pnlNav.Top = btnInventory.Top;
            pnlNav.Height = btnInventory.Height;
            pnlNav.Left = btnInventory.Left;
            frmKhohang frmKho = new frmKhohang();
            addform(frmKho);
        }
        // Form QUẢN LÝ KHÁCH HÀNG
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "QUẢN LÝ KHÁCH HÀNG";
            pnlNav.Top = btnCustomers.Top;
            pnlNav.Height = btnCustomers.Height;
            pnlNav.Left = btnCustomers.Left;
            frmKhachhang f = new frmKhachhang();
            addform(f);
        }
        // Form QUẢN LÝ NHÂN VIÊN
        private void btnEmployees_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "QUẢN LÝ NHÂN VIÊN";
            pnlNav.Top = btnEmployees.Top;
            pnlNav.Height = btnEmployees.Height;
            pnlNav.Left = btnEmployees.Left;
            frmNhanvien f = new frmNhanvien();
            addform(f);
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDate.Text = DateTime.Now.ToString("ddd, dd/MM/yyyy");
          //  cmbTheo.SelectedItem = "Tháng";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            timer1.Start();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (MessageBox.Show("Xác nhận đăng xuất chương trình", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            } else if(!eeStatus)
            {
                ClockInnOut();
            }
        }
        // Đăng xuất 
        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Mở form đổi mật khẩu
        private void btnDoiPass_Click(object sender, EventArgs e)
        {
            //frmDoimatkhau f = new frmDoimatkhau(this);
            frmDoimatkhau f = new frmDoimatkhau();
            f.txtTK.Text = frmDangnhap.nv.Tên_tài_khoản;
            f.ShowDialog();
        }
        TimeSpan from;
        TimeSpan to;
        private void btnClock_Click(object sender, EventArgs e)
        {
            ClockInnOut();
        }
    }
 }

