using RetailStore.BLL;
using RetailStore.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailStore
{
    public partial class frmKhachhang : Form
    {
        BindingSource dskh = new BindingSource();
        public frmKhachhang()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            dtgvDSKHACH.DataSource = dskh;
            cmbSapxepKH.SelectedIndex = 0;
            LoadDSKhachhang();
            AddCustomersBinding();
            DisableControls();
        }
        private void LoadDSKhachhang()
        {
            dskh.DataSource = BLL_KhachHang.Instance.GetListCustomers_BLL();
            SortListCustomer();
        }
        private void SortListCustomer()
        {
            switch (cmbSapxepKH.SelectedIndex)
            {
                case 1:
                    dskh.DataSource = BLL_KhachHang.Instance.SortListCustomer_BLL(KhachHang.Compare_NameAZ);
                    break;
                case 2:
                    dskh.DataSource = BLL_KhachHang.Instance.SortListCustomer_BLL(KhachHang.Compare_NameZA);
                    break;
                default:
                    dskh.DataSource = BLL_KhachHang.Instance.GetListCustomers_BLL();
                    break;
            }
        }
        private void DisableControls()
        {
            txtTenKH.ReadOnly = true;
            txtSDT.ReadOnly = true;
            btnLuuKH.Enabled = false;
            btnThemKH.Enabled = true;
            btnCapnhatKH.Enabled = true;
        }
        private void EnableControls()
        {
            txtTenKH.ReadOnly = false;
            txtSDT.ReadOnly = false;
            btnLuuKH.Enabled = true;
        }
        private void TangKeyValueKH()
        {
            string maKHmax = BLL_KhachHang.Instance.FindCustomerMaxKey_BLL();
            var maKH = Regex.Match(maKHmax, @"\d+").Value;
            var intmaKH = Int32.Parse(maKH);
            intmaKH++;
            maKHmax = "KH" + intmaKH.ToString("D4");
            maKHmax = maKHmax.Replace(" ", string.Empty);
            txtMaKH.Text = maKHmax;
        }
        private void GetRowValue()
        {
            int index = dtgvDSKHACH.SelectedCells[0].RowIndex;
            DataGridViewRow row = dtgvDSKHACH.Rows[index];
            txtMaKH.Text = row.Cells[0].Value.ToString();
            txtTenKH.Text = row.Cells[1].Value.ToString();
            txtSDT.Text = row.Cells[2].Value.ToString();

        }
        private void btnHuyKH_Click(object sender, EventArgs e)
        {
            DisableControls();
            dtgvDSKHACH.CurrentCell = dtgvDSKHACH.Rows[0].Cells[0];
            GetRowValue();
        }
        void AddCustomersBinding()
        {
            txtMaKH.DataBindings.Add(new Binding("Text", dtgvDSKHACH.DataSource, "Mã_KHàng", true, DataSourceUpdateMode.Never));
            txtTenKH.DataBindings.Add(new Binding("Text", dtgvDSKHACH.DataSource, "Tên", true, DataSourceUpdateMode.Never));
            txtSDT.DataBindings.Add(new Binding("Text", dtgvDSKHACH.DataSource, "SĐT", true, DataSourceUpdateMode.Never));
        }
        // THÊM KHÁCH HÀNG
        private void btnThemKH_Click(object sender, EventArgs e)
        {
            EnableControls();
            btnCapnhatKH.Enabled = false;
            TangKeyValueKH();
            txtSDT.Text = "0";
            txtTenKH.Text = "";
        }
        // XÓA KHÁCH HÀNG
        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            int k = 0;
            DataGridViewSelectedRowCollection data = dtgvDSKHACH.SelectedRows;
            if (data.Count >= 1)
            {
                DialogResult q = MessageBox.Show("Xác nhận xóa khách hàng", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (q == DialogResult.Yes)
                {
                    List<string> listID = new List<string>();
                    foreach (DataGridViewRow i in data)
                    {
                        if(i.Cells[0].Value.ToString()!="KH0000")
                        listID.Add(i.Cells[0].Value.ToString());
                    }
                    foreach (string i in listID)
                    {
                        if (!BLL_KhachHang.Instance.DeleteCustomer_BLL(i))
                        {
                            MessageBox.Show("Lỗi khi xóa khách hàng " + i, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            k = 1;
                        }
                    }
                    if(k!=1)
                    MessageBox.Show("Hoàn tất xóa khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSKhachhang();
                }
            }
        }
        // SỬA
        private void btnCapnhatKH_Click(object sender, EventArgs e)
        {
            EnableControls();
            btnThemKH.Enabled = false;
        }
        // LƯU KHÁCH HÀNG
        private void btnLuuKH_Click(object sender, EventArgs e)
        {
            string tenKH = txtTenKH.Text;
            string maKH = txtMaKH.Text;
            string sdtKH = txtSDT.Text;
            KhachHang khachHang = new KhachHang(maKH, tenKH, sdtKH);
            if (tenKH != "" && maKH != "" && sdtKH != "")
            {
                // IF Trùng idCustomer -> Update, ELSE Insert
                if (BLL_KhachHang.Instance.InsertCustomer_BLL(khachHang))
                {
                    MessageBox.Show("Thêm khách hàng " + tenKH + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (BLL_KhachHang.Instance.UpdateCustomer_BLL(khachHang))
                    {
                        MessageBox.Show("Cập nhật khách hàng " + tenKH + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Có dữ liệu không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                LoadDSKhachhang();
            }
            else
            {
                MessageBox.Show("Nhập thiếu dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dtgvDSKHACH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DisableControls();
            GetRowValue();
        }
        // SẮP XẾP KHÁCH HÀNG THEO TÊN
        private void cmbSapxepKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortListCustomer();
            
        }
        // TÌM KIẾM KHÁCH HÀNG THEO TÊN
        private void txtTimKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)13))
            {
                if (txtTimKH.Text != "")
                {
                    dskh.DataSource = BLL_KhachHang.Instance.GetCustomerByName(txtTimKH.Text);
                    if (txtMaKH.Text == "")
                    {
                        MessageBox.Show("Tìm kiếm của bạn không có kết quả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDSKhachhang();
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
