using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using RetailStore.BLL;
using RetailStore.DTO;

namespace RetailStore
{
    public partial class frmThanhtoan : Form
    {

        public frmThanhtoan(string name)
        {
            InitializeComponent();
            LoadData(name);
        }

        #region method
        void LoadData(string tenNV)
        {
           LoadListProductsTT();
            LayDSKH();
            // Hide Column Mã_Hàng
            dtgvTTHang.Columns[0].Visible = false;
            // Hide Column Giá_Vốn
            dtgvTTHang.Columns[4].Visible = false;
            // Hide Column Nhà_Cung_Cấp
            dtgvTTHang.Columns[8].Visible = false;
            lblCashier.Text = tenNV;
            TangKeyValueHD();
            btnXoaSP.Enabled = false;
            btnSuaSP.Enabled = false;
            btnTT.Enabled = false;
            cmbSapxep.SelectedItem = "Mặc định";
            TinhTien();
        }
        void LayDSKH()
        {
            cmbTenKH.DataSource = BLL_KhachHang.Instance.GetListCustomers_BLL();
            cmbTenKH.DisplayMember = "Tên";
        }
        void LoadListProductsTT()
        {
            dtgvTTHang.DataSource = BLL_HangHoa.Instance.GetListProducts_BLL();
        }
        void LoadListProductsTT(string catName)
        {
            dtgvTTHang.DataSource = BLL_HangHoa.Instance.GetListProducts_BLL(catName);
        }
        private List<string> GetListID_GUI()
        {
            List<string> LMHH = new List<string>();
            try
            {
                foreach (DataGridViewRow i in dtgvTTHang.Rows)
                {
                    LMHH.Add(i.Cells[0].Value.ToString());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Danh sách không tồn tại dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return LMHH;
        }
        public void TangKeyValueHD()
        {
            string maHDmax = BLL_HoaDon.Instance.FindReceiptKeyMax_BLL();
            var maHD = Regex.Match(maHDmax, @"\d+").Value;
            var intmaHD = Int32.Parse(maHD);
            intmaHD++;
            maHDmax = "HD" + intmaHD.ToString("D6");
            maHDmax = maHDmax.Replace(" ", string.Empty);
            txtMaHD.Text = maHDmax;
        }
        // Tính tiền
        public double TOTAL = 0;
        public void TinhTien()
        {
            double total = 0;
            double giamGia = (double)Convert.ToDouble(nmDiscount.Value);
            foreach (ListViewItem item in lsvHHThanhToan.Items)
            {
                total += double.Parse(item.SubItems[4].Text, System.Globalization.NumberStyles.Currency);
            }
            TOTAL = total - (total * giamGia / 100);
            txtTienH.Text = String.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", total);
            txtTongC.Text = String.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", TOTAL);
        }
        // Xóa item ra khỏi danh sách hóa đơn
        public void XoaSP()
        {
            if (lsvHHThanhToan.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("BẠN MUỐN XÓA SẢN PHẨM KHỎI DANH SÁCH MUA HÀNG", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    lsvHHThanhToan.Items.RemoveAt(lsvHHThanhToan.SelectedItems[0].Index);
                }
            }
            if (lsvHHThanhToan.Items.Count == 0)
            {
                btnTT.Enabled = false;
                btnThemSP.Enabled = true;
            }
            TinhTien();
            btnXoaSP.Enabled = false;
            btnSuaSP.Enabled = false;
        }
        #endregion
        #region events
        private void frmThanhtoan_Load(object sender, EventArgs e)
        {
            txtNgayGD.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        string catName = "Tất cả";
        private void btnCategory_Click(object sender, EventArgs e)
        {
            catName = ((Button)sender).Text;
            LoadListProductsTT(catName);
        }
        // Sắp xếp danh sách hàng hóa
        private void cmbSapxep_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<HangHoa> listP = BLL_HangHoa.Instance.GetListProductDGV(GetListID_GUI());
            switch (cmbSapxep.SelectedIndex)
            {
                case 0:
                    dtgvTTHang.DataSource = BLL_HangHoa.Instance.SortListProduct_BLL(listP, HangHoa.Compare_IDAscending);
                    break;
                case 1:
                    dtgvTTHang.DataSource = BLL_HangHoa.Instance.SortListProduct_BLL(listP, HangHoa.Compare_NameAZ);
                    break;
                case 2:
                    dtgvTTHang.DataSource = BLL_HangHoa.Instance.SortListProduct_BLL(listP, HangHoa.Compare_NameZA);
                    break;
                case 3:
                    dtgvTTHang.DataSource = BLL_HangHoa.Instance.SortListProduct_BLL(listP, HangHoa.Compare_PriceAscending);
                    break;
                case 4:
                    dtgvTTHang.DataSource = BLL_HangHoa.Instance.SortListProduct_BLL(listP, HangHoa.Compare_PriceDescending);
                    break;
                case 5:
                    dtgvTTHang.DataSource = BLL_HangHoa.Instance.SortListProduct_BLL(listP, HangHoa.Compare_DateLE);
                    break;
                case 6:
                    dtgvTTHang.DataSource = BLL_HangHoa.Instance.SortListProduct_BLL(listP, HangHoa.Compare_DateEL);
                    break;
                default:
                    break;
            }
        }
        // Tìm kiếm hàng hóa theo tên
        private void txtTimkiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)13))
            {
                if (txtTimkiem.Text != "")
                {
                    dtgvTTHang.DataSource = BLL_HangHoa.Instance.GetProductByName_BLL(catName, txtTimkiem.Text);
                    if (dtgvTTHang.Rows.Count == 0)
                    {
                        MessageBox.Show("Tìm kiếm của bạn không có kết quả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        catName = "Tất cả"; 
                        LoadListProductsTT(catName);
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập dữ liệu vào ô tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                e.Handled = true;
            }
        }
        // Button tạo hóa đơn mới
        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            TangKeyValueHD();
            lsvHHThanhToan.Items.Clear();
            TinhTien();
            btnTT.Enabled = false;
        }
        // Button thêm item vào danh sách hóa đơn
        private void btnThemHD_Click(object sender, EventArgs e)
        {
            int id = dtgvTTHang.SelectedRows[0].Index;
            string maHang = dtgvTTHang.Rows[id].Cells[0].Value.ToString();
            int slH = (int)Convert.ToInt32(dtgvTTHang.Rows[id].Cells[3].Value.ToString());
            if (slH == 0)
            {
                MessageBox.Show("SẢN PHẨM ĐÃ HẾT", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ListViewItem item = lsvHHThanhToan.FindItemWithText(maHang);
                double thanhTien;
                if (item == null)
                {
                    frmThemVaoHD f = new frmThemVaoHD(this);
                    f.txtMahang.Text = maHang;
                    f.txtTenhang.Text = dtgvTTHang.Rows[id].Cells[1].Value.ToString();
                    f.txtDongia.Text = dtgvTTHang.Rows[id].Cells[4].Value.ToString();
                    ListViewItem lvi = new ListViewItem(f.txtMahang.Text);
                    lvi.SubItems.Add(f.txtTenhang.Text);
                    lvi.SubItems.Add(f.nmSLSP.Value.ToString());
                    lvi.SubItems.Add(f.txtDongia.Text);
                    thanhTien = (double)Convert.ToDouble(f.txtDongia.Text) * (double)Convert.ToDouble(f.nmSLSP.Value);
                    lvi.SubItems.Add(thanhTien.ToString());
                    lsvHHThanhToan.Items.Add(lvi);
                    this.lsvHHThanhToan.Items[0].Selected = true;
                }
                else
                {
                    this.lsvHHThanhToan.Items[item.Index].Selected = true;
                    ListViewItem lvi = lsvHHThanhToan.SelectedItems[0];
                    int sl;
                    sl = (int)Convert.ToDouble(lvi.SubItems[2].Text) + 1;
                    thanhTien = (double)Convert.ToDouble(lvi.SubItems[3].Text) * (double)Convert.ToDouble(sl);
                    if (sl <= slH)
                    {
                        lvi.SubItems[2].Text = sl.ToString();
                        lvi.SubItems[4].Text = thanhTien.ToString();
                    }
                    else
                    {
                        MessageBox.Show("NHẬP QUÁ SỐ LƯỢNG CÒN LẠI CỦA SẢN PHẨM", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                btnTT.Enabled = true;
            }
            TinhTien();
        }
        private void dtgvTTHang_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            btnThemSP.Enabled = true;
        }
        // Button xóa item khỏi danh sách hóa đơn
        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            XoaSP();
        }

        private void dtgvTTHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoaSP.Enabled = false;
            btnSuaSP.Enabled = false;
        }
        // button mở form Nhập SL sản phẩm
        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            if (lsvHHThanhToan.SelectedItems.Count > 0)
            {
                frmThemVaoHD f = new frmThemVaoHD(this);
                ListViewItem lvi = lsvHHThanhToan.SelectedItems[0];
                f.txtMahang.Text = lvi.SubItems[0].Text;
                f.txtTenhang.Text = lvi.SubItems[1].Text;
                f.nmSLSP.Value = (int)Convert.ToDouble(lvi.SubItems[2].Text);
                f.txtDongia.Text = lvi.SubItems[3].Text;
                f.ShowDialog();
            }
        }
        private void lsvHHThanhToan_MouseClick(object sender, MouseEventArgs e)
        {
            btnThemSP.Enabled = false;
            btnXoaSP.Enabled = true;
            btnSuaSP.Enabled = true;
        }
        private void nmDiscount_ValueChanged(object sender, EventArgs e)
        {
            TinhTien();
        }
        // Button thanh toán hóa đơn
        private void btnTT_Click(object sender, EventArgs e)
        {
            //string maHD = txtMaHD.Text;
            //string maKH = (cmbTenKH.SelectedItem as KhachHang).Mã_KHàng;
            //DateTime ngayGD = DateTime.Now;
            //string maNV = (cmbTenNV.SelectedItem as NhanVien).Mã_NViên;
            //int giamGia = (int)Convert.ToInt32(nmDiscount.Value);
            //HoaDon hoadon = new HoaDon(maHD, ngayGD, maNV, maKH);
            //if (HoaDonDAO.Instance.InsertHoaDon(hoadon))
            //{
            //    for (int i = 0; i < lsvHHThanhToan.Items.Count; i++)
            //    {
            //        string maHH = lsvHHThanhToan.Items[i].SubItems[0].Text;
            //        int slHH = (int)Convert.ToInt32(lsvHHThanhToan.Items[i].SubItems[2].Text);
            //        HoaDonCT hoaDonCT = new HoaDonCT(maHD, maHH, giamGia, slHH);
            //        HoaDonCTDAO.Instance.InsertHoaDonCT(hoaDonCT);
            //    }
            //    lsvHHThanhToan.Items.Clear();
            //    LoadListProductsTT();
            //    frmTinhtien f = new frmTinhtien(this);
            //    f.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("CÓ LỖI KHI THANH TOÁN", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //btnTT.Enabled = false;
        }
        // Tạo chức năng các phím tắt cho danh sách hóa đơn
        private void lsvHHThanhToan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                XoaSP();
            }
            int sl;
            double thanhTien;
            ListViewItem lvi;
            if (lsvHHThanhToan.Items.Count > 0)
            {
                if (e.KeyCode == Keys.Subtract)
                {
                    lvi = lsvHHThanhToan.SelectedItems[0];
                    sl = (int)Convert.ToDouble(lvi.SubItems[2].Text) - 1;
                    if (sl == 0)
                    {
                        XoaSP();
                    }
                    else
                    {
                        thanhTien = sl * (double)Convert.ToDouble(lvi.SubItems[3].Text);
                        lvi.SubItems[2].Text = sl.ToString();
                        lvi.SubItems[4].Text = thanhTien.ToString();
                    }
                }
                //if (e.KeyCode == Keys.Add)
                //{
                //    lvi = lsvHHThanhToan.SelectedItems[0];
                //    sl = (int)Convert.ToDouble(lvi.SubItems[2].Text) + 1;
                //    thanhTien = sl * (double)Convert.ToDouble(lvi.SubItems[3].Text);
                //    lvi.SubItems[2].Text = sl.ToString();
                //    lvi.SubItems[4].Text = thanhTien.ToString();
                //}
                TinhTien();
            }
        }
        // Tạo chức năng các phím tắt cho danh sách sản phẩm
        private void dtgvTTHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Add)
            {
                btnThemHD_Click(sender, e);
            }
        }
        private void nmDiscount_KeyUp(object sender, KeyEventArgs e)
        {
            TinhTien();
        }
    }
    #endregion
}

