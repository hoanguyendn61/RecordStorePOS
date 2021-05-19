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
        public frmLichSuBH()
        {
            InitializeComponent();
            LoadDataIntoCB(cbKH);
            LoadDataIntoCB(cbNV);
        }

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
            DateTime from = dtpFrom.Value;
            DateTime to = dtpTo.Value;
            string idNV = (cbNV.SelectedItem as CBBItem).ID;
            string idKH = (cbKH.SelectedItem as CBBItem).ID;
            if (idNV == "XX" && idKH == "XX")
            {
                // All nhân viên + khách hàng
                dgvLichSuBH.DataSource = BLL_HoaDon.Instance.GetListHD_BLL(from, to);
            }
            else
            {
                dgvLichSuBH.DataSource = BLL_HoaDon.Instance.GetListHD_BLL(from, to, idNV, idKH);
            }
            if (dgvLichSuBH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadDSHoaDon();
        }
        // Xem hóa đơn chi tiết ứng với mã hóa đơn
        private void btnCTHD_Click(object sender, EventArgs e)
        {
            int index = dgvLichSuBH.SelectedCells[0].RowIndex;
            DataGridViewRow row = dgvLichSuBH.Rows[index];
            if (row != null)
            {
                string idHD = row.Cells[0].Value.ToString();
                lblMaHD.Text = idHD;
                dgvLichSuBH.DataSource = BLL_HoaDonCT.Instance.GetListHDCT_BLL(idHD);
            }
        }
        // Hủy bỏ hóa đơn ứng với mã hóa đơn
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            int index = dgvLichSuBH.SelectedCells[0].RowIndex;
            DataGridViewRow row = dgvLichSuBH.Rows[index];
            if (row != null)
            {
                string idHD = row.Cells[0].Value.ToString();
                DialogResult q = MessageBox.Show("Xác nhận hủy bỏ hóa đơn " + idHD, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (q == DialogResult.Yes)
                {
                    if (BLL_HoaDon.Instance.DeleteHD_BLL(idHD))
                    {
                        MessageBox.Show("Hủy bỏ hóa đơn " + idHD + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } else
                    {
                        MessageBox.Show("Hủy bỏ hóa đơn " + idHD + " không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    LoadDSHoaDon();
                }
            }
        }
    }
}
