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
using RetailStore.BLL;
using RetailStore.DTO;
namespace RetailStore.GUI
{
    public partial class frmNhaCungCap : Form
    {
        BindingSource supplierList = new BindingSource();
        public frmNhaCungCap()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            dGVSupplier.DataSource = supplierList;
            cbSapxepNCC.SelectedIndex = 0;
            DisableControls();
            LoadDSSupplier();
            AddSupplierBinding();
        }
        private void LoadDSSupplier()
        {
            supplierList.DataSource = BLL_NhaCungCap.Instance.GetListSuppliers_BLL();
            SortListSupplier();
        }
        private void SortListSupplier()
        {
            switch (cbSapxepNCC.SelectedIndex)
            {
                case 1:
                    supplierList.DataSource = BLL_NhaCungCap.Instance.SortListSupplier_BLL(NhaCungCap.Compare_NameAZ);
                    break;
                case 2:
                    supplierList.DataSource = BLL_NhaCungCap.Instance.SortListSupplier_BLL(NhaCungCap.Compare_NameZA);
                    break;
                default:
                    supplierList.DataSource = BLL_NhaCungCap.Instance.GetListSuppliers_BLL();
                    break;
            }
        }
        private void DisableControls()
        {
            txtMaNCC.ReadOnly = true;
            txtDcNCC.ReadOnly = true;
            txtSdtNCC.ReadOnly = true;
            txtTenNCC.ReadOnly = true;
            txtEmailNCC.ReadOnly = true;
            btnLuuNCC.Enabled = false;
            btnThemNCC.Enabled = true;
            btnCapnhatNCC.Enabled = true;
        }
        private void EnableControls()
        {
            txtDcNCC.ReadOnly = false;
            txtSdtNCC.ReadOnly = false;
            txtTenNCC.ReadOnly = false;
            txtEmailNCC.ReadOnly = false;
            btnLuuNCC.Enabled = true;
        }
        private void GetRowValue()
        {
            int index = dGVSupplier.SelectedCells[0].RowIndex;
            DataGridViewRow row = dGVSupplier.Rows[index];
            txtMaNCC.Text = Convert.ToString(row.Cells[0].Value);
            txtTenNCC.Text = Convert.ToString(row.Cells[1].Value);
            txtDcNCC.Text = Convert.ToString(row.Cells[2].Value);
            txtSdtNCC.Text = Convert.ToString(row.Cells[3].Value);
            txtEmailNCC.Text = Convert.ToString(row.Cells[4].Value);
        }
        private void AddSupplierBinding()
        {
            txtMaNCC.DataBindings.Add(new Binding("Text", dGVSupplier.DataSource, "Mã_NCC", true, DataSourceUpdateMode.Never));
            txtTenNCC.DataBindings.Add(new Binding("Text", dGVSupplier.DataSource, "Tên_NCC", true, DataSourceUpdateMode.Never));
            txtSdtNCC.DataBindings.Add(new Binding("Text", dGVSupplier.DataSource, "Sdt_NCC", true, DataSourceUpdateMode.Never));
            txtEmailNCC.DataBindings.Add(new Binding("Text", dGVSupplier.DataSource, "Email_NCC", true, DataSourceUpdateMode.Never));
            txtDcNCC.DataBindings.Add(new Binding("Text", dGVSupplier.DataSource, "Đc_NCC", true, DataSourceUpdateMode.Never));
        }
        private void TangKeySupplier()
        {
            string maSupmax = BLL_NhaCungCap.Instance.FindSupplierMaxKey_BLL();
            var maSUP = Regex.Match(maSupmax, @"\d+").Value;
            var intmaSUP = Int32.Parse(maSUP);
            intmaSUP++;
            maSupmax = "NCC" + intmaSUP.ToString("D3");
            maSupmax = maSupmax.Replace(" ", string.Empty);
            txtMaNCC.Text = maSupmax;
        }
        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            EnableControls();
            btnCapnhatNCC.Enabled = false;
            TangKeySupplier();
            txtTenNCC.Text = "";
            txtDcNCC.Text = "";
            txtSdtNCC.Text = "";
            txtEmailNCC.Text = "";
        }
        private void btnCapnhatNCC_Click(object sender, EventArgs e)
        {
            EnableControls();
            btnThemNCC.Enabled = false;
        }
        private void btnLuuNCC_Click(object sender, EventArgs e)
        {
            string idNCC = txtMaNCC.Text;
            string name = txtTenNCC.Text;
            string sdt = txtSdtNCC.Text;
            string dc = txtDcNCC.Text;
            string email = txtEmailNCC.Text;
            NhaCungCap sup = new NhaCungCap(idNCC, name, dc, sdt, email);
            if (idNCC != "" && name != "" && sdt != "" && dc != "" && email != "")
            {
                // IF Trùng idSupplier -> Update, ELSE Insert
                if (BLL_NhaCungCap.Instance.InsertSupplier_BLL(sup))
                {
                    MessageBox.Show("Thêm nhà cung cấp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (BLL_NhaCungCap.Instance.UpdateSupplier_BLL(sup))
                    {
                        MessageBox.Show("Cập nhật nhà cung cấp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Có dữ liệu không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                LoadDSSupplier();
            }
            else
            {
                MessageBox.Show("Nhập thiếu dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection data = dGVSupplier.SelectedRows;
            if (data.Count >= 1)
            {
                DialogResult q = MessageBox.Show("Xác nhận xóa nhà cung cấp", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (q == DialogResult.Yes)
                {
                    List<string> listID = new List<string>();
                    foreach (DataGridViewRow i in data)
                    {
                        listID.Add(i.Cells[0].Value.ToString());
                    }
                    foreach (string i in listID)
                    {
                        if (!BLL_NhaCungCap.Instance.DeleteSupplier_BLL(i))
                        {
                            MessageBox.Show("Lỗi khi xóa nhà cung cấp mã " + i, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    MessageBox.Show("Hoàn tất xóa nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSSupplier();
                }
            }
        }
        private void btnHuyNCC_Click(object sender, EventArgs e)
        {
            DisableControls();
            dGVSupplier.CurrentCell = dGVSupplier.Rows[0].Cells[0];
            GetRowValue();
        }
        private void dGVSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DisableControls();
            GetRowValue();
        }

        private void cbSapxepNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortListSupplier();
        }
        private void txtTimNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)13))
            {
                if (txtTimNCC.Text != "")
                {
                    supplierList.DataSource = BLL_NhaCungCap.Instance.GetSupplierByName_BLL(txtTimNCC.Text);
                    if(txtMaNCC.Text == "")
                    {
                        MessageBox.Show("Tìm kiếm của bạn không có kết quả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDSSupplier();
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
