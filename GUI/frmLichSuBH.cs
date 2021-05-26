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
namespace RetailStore.GUI
{
    public partial class frmLichSuBH : Form
    {
        public delegate void MydelBH();
        public MydelBH dHH { get; set; }
        public frmLichSuBH()
        {
            InitializeComponent();
            LoadDataIntoCB(cbKH);
            LoadDataIntoCB(cbNV);
            LoadDSHoaDon();
        }
        string maHD = "";
        DateTime from = new DateTime();
        DateTime to = new DateTime();
        string idNV = "";
        string idKH = ""; 
        private void LoadDataIntoCB(ComboBox cmb)
        {
            cmb.Items.Add(new CBBItem { ID = "XX", Text = "Tất cả" });
            switch (cmb.Name)
            {
                case "cbKH":
                    foreach (KhachHang i in BLL_KhachHang.Instance.GetListCustomers_BLL())
                    {
                        cmb.Items.Add(new CBBItem
                        {
                            ID = i.Mã_KHàng,
                            Text = i.Tên
                        }); ;
                    }
                    break;
                case "cbNV":
                    foreach (NhanVien i in BLL_NhanVien.Instance.GetListEmployees_BLL())
                    {
                        cmb.Items.Add(new CBBItem
                        {
                            ID = i.Mã_NViên,
                            Text = i.Tên
                        }); ;
                    }
                    break;
                default:
                    break;
            }
            cmb.SelectedIndex = 0;
        }
        private void LoadDSHoaDon()
        {
            lblMaHD.Text = "";
            maHD = "";
            from = dtpFrom.Value;
            to = dtpTo.Value;
            idNV = (cbNV.SelectedItem as CBBItem).ID;
            idKH = (cbKH.SelectedItem as CBBItem).ID;
            if (idNV == "XX" && idKH == "XX")
            {
                // All nhân viên + khách hàng
                dgvLichSuBH.DataSource = BLL_HoaDon.Instance.GetListHD_BLL(from, to);
            }
            else
            {
                dgvLichSuBH.DataSource = BLL_HoaDon.Instance.GetListHD_BLL(from, to, idNV, idKH);
            }
            btnCTHD.Enabled = true;
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadDSHoaDon();
            txtTimHD.Clear();
        }
        // Xem hóa đơn chi tiết ứng với mã hóa đơn
        private void btnCTHD_Click(object sender, EventArgs e)
        {
            int index = dgvLichSuBH.SelectedCells[0].RowIndex;
            DataGridViewRow row = dgvLichSuBH.Rows[index];
            if (row != null)
            {
                maHD = row.Cells[0].Value.ToString();
                lblMaHD.Text = maHD;
                dgvLichSuBH.DataSource = BLL_HoaDonCT.Instance.GetListHDCT_BLL(maHD);
            }
            btnCTHD.Enabled = false;
        }
        // Hủy bỏ hóa đơn ứng với mã hóa đơn
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            if(maHD != "")
            {
                DialogResult q = MessageBox.Show("Xác nhận hủy bỏ hóa đơn " + maHD, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (q == DialogResult.Yes)
                {
                    if (BLL_HoaDon.Instance.DeleteHD_BLL(maHD))
                    {
                        MessageBox.Show("Hủy bỏ hóa đơn " + maHD + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dHH();
                    }
                    else
                    {
                        MessageBox.Show("Hủy bỏ hóa đơn " + maHD + " không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    LoadDSHoaDon();
                }
            }
        }
        // Bấm enter để tìm hóa đơn
        private void txtTimHD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)13))
            {
                if (txtTimHD.Text != "")
                {
                    dgvLichSuBH.DataSource = BLL_HoaDon.Instance.GetHDByMaHD(txtTimHD.Text, from, to, idNV, idKH);
                    if (dgvLichSuBH.Rows.Count < 1)
                    {
                        MessageBox.Show("Tìm kiếm của bạn không có kết quả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDSHoaDon();
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập dữ liệu vào ô tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                e.Handled = true;
            }
        }
    }
}
