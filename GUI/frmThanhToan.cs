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
using RetailStore.GUI;
namespace RetailStore
{
    public partial class frmThanhtoan : Form
    {

        public frmThanhtoan()
        {
            InitializeComponent();
            LoadData();
        }

        #region method
        private void LoadData()
        {
            // no one but the manager can see the sales history
            if (frmDangnhap.nv.Loại_tài_khoản != true)
            {
                btnHistory.Enabled = false;
            }
            LoadListProductsTT();
            LayDSKH();
            lblNgayGD.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            // Hide Column Mã_Hàng
            dtgvTTHang.Columns[0].Visible = false;
            // Hide Column Giá_Vốn
            dtgvTTHang.Columns[4].Visible = false;
            // Hide Column Nhà_Cung_Cấp
            dtgvTTHang.Columns[8].Visible = false;
            lblCashier.Text = frmDangnhap.nv.Tên;
            TangKeyValueHD();
            cmbSapxep.SelectedItem = "Mặc định";
            TinhTien();
        }
        private void LayDSKH()
        {
            cmbTenKH.DataSource = BLL_KhachHang.Instance.GetListCustomers_BLL();
            cmbTenKH.DisplayMember = "Tên";
        }
        private void LoadListProductsTT()
        {
            dtgvTTHang.DataSource = BLL_HangHoa.Instance.GetListProducts_BLL();
        }
        private void LoadListProductsTT(string catName)
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
            lblMaHD.Text = maHDmax;
        }
        // Tính tiền
        private double TOTAL = 0;
        public void TinhTien()
        {
            double total = 0;
            double giamGia = Convert.ToDouble(nmDiscount.Value);
            foreach (ListViewItem item in lsvHHThanhToan.Items)
            {
                total += double.Parse(item.SubItems[4].Text, System.Globalization.NumberStyles.Currency);
            }
            TOTAL = total - (total * giamGia / 100);
            txtTienH.Text = String.Format("{0:#,##0}", total);
            txtTongC.Text = String.Format("{0:#,##0}", TOTAL);
        }
        ListViewItem slvi = null;
        // Hàm kiểm tra item đã chọn trong datagridview tồn tại trong listviewitem hay không
        private Boolean CheckItemExistsInLVI(int _sl = 1)
        {
            string maHang = "";
            int id = 0;
            ListViewItem item = null;
            Boolean itemExists = false;
            try
            {
                id = dtgvTTHang.SelectedRows[0].Index;
                maHang = dtgvTTHang.Rows[id].Cells[0].Value.ToString();
                item = lsvHHThanhToan.FindItemWithText(maHang);
                if (item != null)
                {
                    this.lsvHHThanhToan.Items[item.Index].Selected = true;
                    // Nếu tồn tại item trong danh sách HĐ -> itemExists = true
                    itemExists = true;
                    slvi = lsvHHThanhToan.SelectedItems[0];
                }
                else
                {
                    // Nếu chưa -> khởi tạo slvi với mã hàng của item đã chọn
                    slvi = new ListViewItem(maHang);
                    string tenHH = dtgvTTHang.Rows[id].Cells[1].Value.ToString();
                    string donGia = String.Format("{0:#,##0}", dtgvTTHang.Rows[id].Cells[5].Value);
                    string thanhTien = String.Format("{0:#,##0}", Convert.ToDouble(dtgvTTHang.Rows[id].Cells[5].Value) * _sl);
                    slvi.SubItems.AddRange(new[] { tenHH, _sl.ToString(), donGia, thanhTien });
                }
            }
            catch (Exception)
            {
                itemExists = true;
                slvi = lsvHHThanhToan.SelectedItems[0];
            }
            return itemExists;
        }
        // Thêm item vào danh sách hóa đơn
        private void ThemSP()
        {
            if(dtgvTTHang.SelectedRows.Count > 0 || lsvHHThanhToan.SelectedItems.Count > 0)
            {
                if (!CheckItemExistsInLVI())
                {
                    lsvHHThanhToan.Items.Add(slvi);
                }
                else
                {
                    int slMax = BLL_HangHoa.Instance.GetProductQuanityByID_BLL(slvi.SubItems[0].Text);
                    int sl = Convert.ToInt32(slvi.SubItems[2].Text) + 1;
                    double thanhTien = Convert.ToDouble(slvi.SubItems[3].Text) * Convert.ToDouble(sl);
                    if (sl <= slMax)
                    {
                        slvi.SubItems[2].Text = sl.ToString();
                        slvi.SubItems[4].Text = String.Format("{0:#,##0}", thanhTien);
                    }
                    else
                    {
                        MessageBox.Show("Nhập quá số lượng tồn kho của sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                TinhTien();
            }
            else
            {
                MessageBox.Show("Chưa chọn sản phẩm cần thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // Giảm số lượng item trong danh sách hóa đơn
        private void GiamSP()
        {
            if (dtgvTTHang.SelectedRows.Count > 0 || lsvHHThanhToan.SelectedItems.Count > 0)
            {
                if (CheckItemExistsInLVI())
                {
                    int sl = Convert.ToInt32(slvi.SubItems[2].Text) - 1;
                    if (sl == 0)
                    {
                        XoaSP();
                    }
                    else
                    {
                        double thanhTien = sl * Convert.ToDouble(slvi.SubItems[3].Text);
                        slvi.SubItems[2].Text = sl.ToString();
                        slvi.SubItems[4].Text = String.Format("{0:#,##0}", thanhTien);
                    }
                    TinhTien();
                }
                else
                {
                    MessageBox.Show("Sản phẩm cần giảm SL không có trong danh sách mua hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn sản phẩm cần giảm SL", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // Mở from Nhập SL sản phẩm
        private void NhapSLSP()
        {
            if(dtgvTTHang.SelectedRows.Count > 0 || lsvHHThanhToan.SelectedItems.Count > 0)
            {
                CheckItemExistsInLVI();
                frmThemVaoHD f = new frmThemVaoHD(slvi);
                //DialogResult result = f.ShowDialog();
                if (DialogResult.Cancel != f.ShowDialog())
                {
                    if (!CheckItemExistsInLVI(Convert.ToInt32(slvi.SubItems[2].Text)))
                    {
                        lsvHHThanhToan.Items.Add(slvi);
                    }
                }
                TinhTien();
            }
            else
            {
                MessageBox.Show("Chưa chọn sản phẩm cần nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // Xóa item ra khỏi danh sách hóa đơn
        private void XoaSP()
        {
            if (dtgvTTHang.SelectedRows.Count > 0 || lsvHHThanhToan.SelectedItems.Count > 0)
            {
                if (CheckItemExistsInLVI())
                {
                    if (MessageBox.Show("Xác nhận xóa sản phẩm khỏi danh sách mua hàng", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        lsvHHThanhToan.Items.RemoveAt(lsvHHThanhToan.SelectedItems[0].Index);
                    }
                    TinhTien();
                }
                else
                {
                    MessageBox.Show("Sản phẩm cần xóa không có trong danh sách mua hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn sản phẩm cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ThanhToan()
        {
            if (lsvHHThanhToan.Items.Count > 0)
            {
                string maHD = lblMaHD.Text;
                string maKH = (cmbTenKH.SelectedItem as KhachHang).Mã_KHàng;
                DateTime ngayGD = DateTime.Now;
                string maNV = frmDangnhap.nv.Mã_NViên;
                int giamGia = Convert.ToInt32(nmDiscount.Value);
                HoaDon hoadon = new HoaDon(maHD, ngayGD, maNV, maKH, TOTAL);
                if (BLL_HoaDon.Instance.InsertHoaDon_BLL(hoadon))
                {
                    for (int i = 0; i < lsvHHThanhToan.Items.Count; i++)
                    {
                        string maHH = lsvHHThanhToan.Items[i].SubItems[0].Text;
                        int slHH = Convert.ToInt32(lsvHHThanhToan.Items[i].SubItems[2].Text);
                        HoaDonCT hoaDonCT = new HoaDonCT(hoadon, maHH, giamGia, slHH);
                        BLL_HoaDonCT.Instance.InsertHoaDonCT_BLL(hoaDonCT);
                    }
                    frmTinhtien f = new frmTinhtien(hoadon);
                    f.ShowDialog();
                    TangKeyValueHD();
                    HuyHD();
                }
                else
                {
                    MessageBox.Show("Lỗi khi thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Danh sách mua hàng trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void HuyHD()
        {
            lsvHHThanhToan.Items.Clear();
            cmbTenKH.SelectedIndex = 0;
            TinhTien();
        }
        #endregion
        #region events
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
        // Button hủy HĐ
        private void btnHuyHD_Click(object sender, EventArgs e)
        {
            HuyHD();
        }
        // Button thêm item vào danh sách hóa đơn
        private void btnThemHD_Click(object sender, EventArgs e)
        {
            ThemSP();
        }
        // Button giảm số lượng item trong danh sách hóa đơn
        private void btnGiam_Click(object sender, EventArgs e)
        {
            GiamSP();
        }
        // Button xóa item khỏi danh sách hóa đơn
        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            XoaSP();
        }
        // button mở form Nhập SL sản phẩm
        private void btnNhapSL_Click(object sender, EventArgs e)
        {
            NhapSLSP();
        }
        private void lsvHHThanhToan_MouseClick(object sender, MouseEventArgs e)
        {
            btnXoaSP.Enabled = true;
            btnNhapSL.Enabled = true;
            dtgvTTHang.ClearSelection();
        }
        private void nmDiscount_ValueChanged(object sender, EventArgs e)
        {
            TinhTien();
        }
        // Button thanh toán hóa đơn
        private void btnTT_Click(object sender, EventArgs e)
        {
            ThanhToan();
        }
        private void nmDiscount_KeyUp(object sender, KeyEventArgs e)
        {
            TinhTien();
        }
        private void btnHistory_Click(object sender, EventArgs e)
        {
            frmLichSuBH frm = new frmLichSuBH();
            frm.dHH = new frmLichSuBH.MydelBH(LoadListProductsTT);
            frm.ShowDialog();
            TangKeyValueHD();
        }
        // Tạo các phím tắt cho form Thanh Toán
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Add:
                    ThemSP();
                    break;
                case Keys.Subtract:
                    GiamSP();
                    break;
                case Keys.Delete:
                    XoaSP();
                    break;
                case Keys.F1:
                    ThanhToan();
                    break;
                case Keys.F2:
                    HuyHD();
                    break;
                case Keys.F3:
                    NhapSLSP();
                    break;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
            return true;
        }
    }
    #endregion
}

