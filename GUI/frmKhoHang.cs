using RetailStore.BLL;
using RetailStore.DTO;
using RetailStore.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace RetailStore
{
    public partial class frmKhohang : Form
    {
        BindingSource productList = new BindingSource();
        public frmKhohang()
        {
            InitializeComponent();
            LoadData();
            DisableControls();
        }
        private void LoadData()
        {
            cmbSapxep.SelectedItem = "Mặc định";
            dtgvKHOHANG.DataSource = productList;
            LoadDSHangHoa();
            AddProductBinding();
            LoadCategoriesIntoCB(cmbLoai);
            LoadCategoriesIntoCB(cmbMaLoai);
            LoadSuppliersIntoCB();
        }
        private void DisableControls()
        {
            txtTenhang.ReadOnly = true;
            nmGiaban.Enabled = false;
            nmGiaVon.Enabled = false;
            nmQtyHH.Enabled = false;
            rtxtGhichu.ReadOnly = true;
            btnLuuHH.Enabled = false;
            cmbMaLoai.Enabled = false;
            cbSupplier.Enabled = false;
            dtpNgayHH.Enabled = false;
            btnThemHH.Enabled = true;
            btnCapnhatHH.Enabled = true;
        }
        private void EnableControls()
        {
            btnLuuHH.Enabled = true;
            rtxtGhichu.ReadOnly = false;
            txtTenhang.ReadOnly = false;
            nmGiaVon.Enabled = true;
            nmGiaban.Enabled = true;
            nmQtyHH.Enabled = true;
            dtpNgayHH.Enabled = true;
            cbSupplier.Enabled = true;
            cmbMaLoai.Enabled = true;
        }
        private void LoadCategoriesIntoCB(ComboBox cmb)
        {
            if(cmb.Name == "cmbLoai")
            {
                cmb.Items.Add(new CBBItem { ID = "XX", Text = "Tất cả" });
            }
            foreach (LoaiHang i in BLL_LoaiHang.Instance.GetListCategory_BLL())
            {
                cmb.Items.Add(new CBBItem
                {
                    ID = i.Mã_Loại,
                    Text = i.Tên_Loại
                });;
            }
            cmb.SelectedIndex = 0;
        }
        private void LoadSuppliersIntoCB()
        {
            cbSupplier.Items.Clear();
            foreach (NhaCungCap i in BLL_NhaCungCap.Instance.GetListSuppliers_BLL())
            {
                cbSupplier.Items.Add(new CBBItem
                {
                    ID = i.Mã_NCC,
                    Text = i.Tên_NCC
                });
            }
            cbSupplier.SelectedIndex = 0;
        }
        private void LoadDSHangHoa()
        {
            productList.DataSource = BLL_HangHoa.Instance.GetListProducts_BLL();
            SortListProduct();
        }
        // Load DANH SACH HANG HOA BY CATEGORY
        private void LoadDSHangHoa(string categoryName)
        {
            productList.DataSource = BLL_HangHoa.Instance.GetListProducts_BLL(categoryName);
        }
        // DATABINDING
        private void AddProductBinding()
        {
            txtMahang.DataBindings.Add(new Binding("Text", dtgvKHOHANG.DataSource, "Mã_Hàng", true, DataSourceUpdateMode.Never));
            txtTenhang.DataBindings.Add(new Binding("Text", dtgvKHOHANG.DataSource, "Tên", true, DataSourceUpdateMode.Never));
            nmGiaban.DataBindings.Add(new Binding("Value", dtgvKHOHANG.DataSource, "Đơn_Giá", true, DataSourceUpdateMode.Never));
            nmGiaVon.DataBindings.Add(new Binding("Value", dtgvKHOHANG.DataSource, "Giá_Vốn", true, DataSourceUpdateMode.Never));
            nmQtyHH.DataBindings.Add(new Binding("Value", dtgvKHOHANG.DataSource, "Số_Lượng", true, DataSourceUpdateMode.Never));
            dtpNgayHH.DataBindings.Add(new Binding("Value", dtgvKHOHANG.DataSource, "Cập_Nhật", true, DataSourceUpdateMode.Never));
            cbSupplier.DataBindings.Add(new Binding("Text", dtgvKHOHANG.DataSource, "Nhà_Cung_Cấp", true, DataSourceUpdateMode.Never));
            rtxtGhichu.DataBindings.Add(new Binding("Text", dtgvKHOHANG.DataSource, "Ghi_Chú", true, DataSourceUpdateMode.Never));
            cmbMaLoai.DataBindings.Add(new Binding("Text", dtgvKHOHANG.DataSource, "Loại", true, DataSourceUpdateMode.Never));
        }
        // Hàm tăng giá trị thuộc tính mã hàng hóa
        private void TangKeyValueHH(LoaiHang cat)
        {
            string maHHmax = BLL_HangHoa.Instance.FindProductMaxKey_BLL(cat);
            var maHH = Regex.Match(maHHmax, @"\d+").Value;
            var intmaHH = Int32.Parse(maHH);
            intmaHH++;
            maHHmax = cat.Mã_Loại + intmaHH.ToString("D4");
            maHHmax = maHHmax.Replace(" ", string.Empty);
            txtMahang.Text = maHHmax;
        }
        private List<string> GetListID_GUI()
        {
            List<string> LMHH = new List<string>();
            try
            {
                foreach (DataGridViewRow i in dtgvKHOHANG.Rows)
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
        private void GetRowValue()
        {
            int index = dtgvKHOHANG.SelectedCells[0].RowIndex;
            DataGridViewRow row = dtgvKHOHANG.Rows[index];
            txtMahang.Text = Convert.ToString(row.Cells[0].Value);
            txtTenhang.Text = Convert.ToString(row.Cells[1].Value);
            cmbMaLoai.Text = Convert.ToString(row.Cells[2].Value);
            nmQtyHH.Value = Convert.ToInt32(row.Cells[3].Value);
            nmGiaVon.Value = Convert.ToInt32(row.Cells[4].Value);
            nmGiaban.Value = Convert.ToInt32(row.Cells[5].Value);
            dtpNgayHH.Value = Convert.ToDateTime(row.Cells[6].Value);
            rtxtGhichu.Text = Convert.ToString(row.Cells[7].Value);
            cbSupplier.Text = Convert.ToString(row.Cells[8].Value);
        }
        private void SortListProduct()
        {
            List<HangHoa> listP = BLL_HangHoa.Instance.GetListProductDGV(GetListID_GUI());
            switch (cmbSapxep.SelectedIndex)
            {
                case 0:
                    productList.DataSource = BLL_HangHoa.Instance.SortListProduct_BLL(listP, HangHoa.Compare_IDAscending);
                    break;
                case 1:
                    productList.DataSource = BLL_HangHoa.Instance.SortListProduct_BLL(listP, HangHoa.Compare_NameAZ);
                    break;
                case 2:
                    productList.DataSource = BLL_HangHoa.Instance.SortListProduct_BLL(listP, HangHoa.Compare_NameZA);
                    break;
                case 3:
                    productList.DataSource = BLL_HangHoa.Instance.SortListProduct_BLL(listP, HangHoa.Compare_PriceAscending);
                    break;
                case 4:
                    productList.DataSource = BLL_HangHoa.Instance.SortListProduct_BLL(listP, HangHoa.Compare_PriceDescending);
                    break;
                case 5:
                    productList.DataSource = BLL_HangHoa.Instance.SortListProduct_BLL(listP, HangHoa.Compare_DateLE);
                    break;
                case 6:
                    productList.DataSource = BLL_HangHoa.Instance.SortListProduct_BLL(listP, HangHoa.Compare_DateEL);
                    break;
                default:
                    break;
            }
        }
        #region events
        // Clear toàn bộ textbox, numericupdown... Thêm Hàng hóa
        private void btnThemHH_Click(object sender, EventArgs e)
        {
            EnableControls();
            btnCapnhatHH.Enabled = false;
            LoaiHang cat = new LoaiHang((cmbMaLoai.SelectedItem as CBBItem).ID, (cmbMaLoai.SelectedItem as CBBItem).Text);
            TangKeyValueHH(cat);
            txtTenhang.Text = null;
            cmbMaLoai.SelectedItem = "CD/DVD";
            nmGiaban.Value = 0;
            nmGiaVon.Value = 0;
            nmQtyHH.Value = 0;
            rtxtGhichu.Text = "";
            dtpNgayHH.Value = DateTime.Now;
        }
        // Thoát khỏi chế độ thêm, cập nhật
        private void btnHuyHH_Click(object sender, EventArgs e)
        {
            DisableControls();
            dtgvKHOHANG.CurrentCell = dtgvKHOHANG.Rows[0].Cells[0];
            GetRowValue();
        }
        // CẬP NHẬT THÔNG TIN HÀNG HÓA
        private void btnCapnhatHH_Click(object sender, EventArgs e)
        {
            EnableControls();
            btnThemHH.Enabled = false;
        }
        // LƯU SẢN PHẨM
        private void btnLuuHH_Click(object sender, EventArgs e)
        {
            string idHH = txtMahang.Text;
            string name = txtTenhang.Text;
            string idLoai = (cmbMaLoai.SelectedItem as CBBItem).ID;
            string idNCC = (cbSupplier.SelectedItem as CBBItem).ID;
            int Qty = (int)nmQtyHH.Value;
            float cost = (float)nmGiaVon.Value;
            float price = (float)nmGiaban.Value;
            DateTime updateAt = DateTime.Now;
            string Ghichu = rtxtGhichu.Text;
            HangHoa hangHoa = new HangHoa(idHH, name, idLoai, Qty, cost, price, updateAt, Ghichu, idNCC);
            if (idHH != "" && name != "" && Qty != 0 && price != 0 && cost != 0)
            {
                // IF Trùng idHH -> Update, ELSE Insert
                if (BLL_HangHoa.Instance.InsertProduct_BLL(hangHoa))
                {
                    MessageBox.Show("Thêm hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    if (BLL_HangHoa.Instance.UpdateProduct_BLL(hangHoa))
                    {
                        MessageBox.Show("Cập nhật hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } else
                    {
                        MessageBox.Show("Có lỗi khi thực thi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                LoadDSHangHoa();
            }
            else
            {
                MessageBox.Show("Nhập thiếu dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        // XÓA SẢN PHẨM 
        private void btnXoaHH_Click(object sender, EventArgs e)
        {
            // XÓA NHIỀU HÀNG CÙNG LÚC
            DataGridViewSelectedRowCollection data = dtgvKHOHANG.SelectedRows;
            if (data.Count >= 1)
            {
                DialogResult q = MessageBox.Show("Xác nhận xóa hàng", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(q == DialogResult.Yes)
                {
                    List<string> listID = new List<string>();
                    foreach (DataGridViewRow i in data)
                    {
                        listID.Add(i.Cells[0].Value.ToString());
                    }
                    foreach (string i in listID)
                    {
                        if (!BLL_HangHoa.Instance.DeleteProduct_BLL(i)){
                            MessageBox.Show("Lỗi khi xóa hàng mã " + i, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    MessageBox.Show("Hoàn tất xóa hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSHangHoa();
                }
            }
        }
        
        private void cmbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDSHangHoa(cmbLoai.Text);
        }
        private void cmbSapxep_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortListProduct();
        }
        private void cmbMaLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaLoai.SelectedItem != null)
            {
                LoaiHang cat = new LoaiHang((cmbMaLoai.SelectedItem as CBBItem).ID, (cmbMaLoai.SelectedItem as CBBItem).Text);
                TangKeyValueHH(cat);
            } else
            {
                LoadDSHangHoa(cmbLoai.Text);
                MessageBox.Show("Tìm kiếm của bạn không có kết quả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txtTimHH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)13))
            {
                if(txtTimHH.Text != "")
                {
                    productList.DataSource = BLL_HangHoa.Instance.GetProductByName_BLL(cmbLoai.Text, txtTimHH.Text);
                } else
                {
                    MessageBox.Show("Chưa nhập dữ liệu vào ô tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                e.Handled = true;
            }
        }
        private void btnSupplier_Click(object sender, EventArgs e)
        {
            frmNhaCungCap f = new frmNhaCungCap();
            f.ShowDialog();
            LoadSuppliersIntoCB();
        }

        private void dtgvKHOHANG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DisableControls();
            GetRowValue();
        }

        
    }
    #endregion
}
