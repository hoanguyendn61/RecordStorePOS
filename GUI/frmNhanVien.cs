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
using RetailStore.GUI;
namespace RetailStore
{
    public partial class frmNhanvien : Form
    {
        BindingSource dsnv = new BindingSource();
        public frmNhanvien()
        {
            InitializeComponent();
            LoadData();
        }
        #region method
        private void LoadData()
        {
            dtgvNhanvien.DataSource = dsnv;
            cmbSapxepNV.SelectedIndex = 0;
            LoadDSNhanVien();
            AddEmployeeBinding();
            DisableControls();
        }
        private void LoadDSNhanVien()
        {
            dsnv.DataSource = BLL_NhanVien.Instance.GetListEmployees_BLL();
            SortListEmployee();
        }
        private List<string> ListUsernamesDGV()
        {
            List<string> l = new List<string>();
            foreach (DataGridViewRow i in dtgvNhanvien.Rows)
            {
                l.Add(i.Cells[7].Value.ToString());
            }
            return l;
        }
        private void GetRowValue()
        {
            int index = dtgvNhanvien.SelectedCells[0].RowIndex;
            DataGridViewRow row = dtgvNhanvien.Rows[index];
            Boolean i = Convert.ToBoolean(row.Cells[8].Value);
            if (i == false)
            {
                rBNV.Checked = true;
            }
            else
            {
                rBQL.Checked = true;
            }
            // Không cập nhật quyền của admin, chỉ admin được phép phân quyền
            if (frmDangnhap.nv.Tên_tài_khoản == "admin")
            {
                if (txtTenTK.Text == "admin")
                {
                    rBNV.Enabled = false;
                    rBQL.Enabled = false;
                }
            } else
            {
                rBNV.Enabled = false;
                rBQL.Enabled = false;
            }
            txtMaNV.Text = row.Cells[0].Value.ToString();
            txtTenNV.Text = row.Cells[1].Value.ToString();
            txtDCNV.Text = row.Cells[2].Value.ToString();
            txtSDT.Text = row.Cells[3].Value.ToString();
            txtCMND.Text = row.Cells[4].Value.ToString();
            nmLuongNV.Value = Convert.ToInt32(row.Cells[5].Value);
            dtpNgayBD.Value = Convert.ToDateTime(row.Cells[6].Value);
            txtTenTK.Text = row.Cells[7].Value.ToString();
        }
        private void SortListEmployee()
        {
            switch (cmbSapxepNV.SelectedIndex)
            {
                case 1:
                    dsnv.DataSource = BLL_NhanVien.Instance.SortListSupplier_BLL(NhanVien.Compare_NameAZ);
                    break;
                case 2:
                    dsnv.DataSource = BLL_NhanVien.Instance.SortListSupplier_BLL(NhanVien.Compare_NameZA);
                    break;
                case 3:
                    dsnv.DataSource = BLL_NhanVien.Instance.SortListSupplier_BLL(NhanVien.Compare_DateLE);
                    break;
                case 4:
                    dsnv.DataSource = BLL_NhanVien.Instance.SortListSupplier_BLL(NhanVien.Compare_DateEL);
                    break;
                default:
                    dsnv.DataSource = BLL_NhanVien.Instance.GetListEmployees_BLL();
                    break;
            }
        }
        private void AddEmployeeBinding()
        {
            txtMaNV.DataBindings.Add(new Binding("Text", dtgvNhanvien.DataSource, "Mã_NViên", true, DataSourceUpdateMode.Never));
            txtTenNV.DataBindings.Add(new Binding("Text", dtgvNhanvien.DataSource, "Tên", true, DataSourceUpdateMode.Never));
            txtSDT.DataBindings.Add(new Binding("Text", dtgvNhanvien.DataSource, "SĐT", true, DataSourceUpdateMode.Never));
            txtCMND.DataBindings.Add(new Binding("Text", dtgvNhanvien.DataSource, "CMND", true, DataSourceUpdateMode.Never));
            nmLuongNV.DataBindings.Add(new Binding("Value", dtgvNhanvien.DataSource, "Lương_NV", true, DataSourceUpdateMode.Never));
            txtDCNV.DataBindings.Add(new Binding("Text", dtgvNhanvien.DataSource, "Địa_chỉ", true, DataSourceUpdateMode.Never));
            dtpNgayBD.DataBindings.Add(new Binding("Value", dtgvNhanvien.DataSource, "Ngày_bắt_đầu", true, DataSourceUpdateMode.Never));
            txtTenTK.DataBindings.Add(new Binding("Text", dtgvNhanvien.DataSource, "Tên_tài_khoản", true, DataSourceUpdateMode.Never));
            rBQL.DataBindings.Add(new Binding("Checked", dtgvNhanvien.DataSource, "Loại_tài_khoản", true, DataSourceUpdateMode.Never));
        }
        private void EnableControls()
        {
            btnLuuNV.Enabled = true;
            txtTenNV.ReadOnly = false;
            txtSDT.ReadOnly = false;
            txtDCNV.ReadOnly = false;
            txtCMND.ReadOnly = false;
            txtPassNV.ReadOnly = false;
            dtpNgayBD.Enabled = true;
            nmLuongNV.ReadOnly = false;
            rBQL.Enabled = true;
            rBNV.Enabled = true;
        }
        private void DisableControls()
        {
            btnLuuNV.Enabled = false;
            txtTenNV.ReadOnly = true;
            txtSDT.ReadOnly = true;
            txtDCNV.ReadOnly = true;
            txtCMND.ReadOnly = true;
            txtTenTK.ReadOnly = true;
            txtPassNV.ReadOnly = true;
            nmLuongNV.ReadOnly = true;
            dtpNgayBD.Enabled = false;
            rBQL.Enabled = false;
            rBNV.Enabled = false;
            label5.Visible = false;
            txtPassNV.Visible = false;
            btnThemNV.Enabled = true;
            btnCapnhatNV.Enabled = true;
        }
        // Hàm tăng giá trị thuộc tính mã nhân viên
        private void TangKeyValueNV()
        {
            string maNVmax = BLL_NhanVien.Instance.FindEmployeeMaxKey_BLL();
            var maNV = Regex.Match(maNVmax, @"\d+").Value;
            var intmaNV = Int32.Parse(maNV);
            intmaNV++;
            maNVmax = "NV" + intmaNV.ToString("D3");
            maNVmax = maNVmax.Replace(" ", string.Empty);
            txtMaNV.Text = maNVmax;
        }
        // Finish Insert or Update
        private void OutInsertorUpdate()
        {
            DisableControls();
            dtgvNhanvien.CurrentCell = dtgvNhanvien.Rows[0].Cells[0];
            GetRowValue();
        }
        #endregion
        #region events
        // THÊM NHÂN VIÊN
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            EnableControls();
            label5.Visible = true;
            txtPassNV.Visible = true;
            txtTenTK.ReadOnly = false;
            btnCapnhatNV.Enabled = false;
            TangKeyValueNV();
            txtTenNV.Text = "";
            txtSDT.Text = "0";
            txtCMND.Text = "";
            txtDCNV.Text = "";
            nmLuongNV.Value = 0;
            dtpNgayBD.Value = DateTime.Now;
            txtTenTK.Text = "";
            txtPassNV.Text = "";
        }
        // LƯU NHÂN VIÊN
        private void btnLuuNV_Click(object sender, EventArgs e)
        {
            string tenNV = txtTenNV.Text;
            string maNV = txtMaNV.Text;
            string sdtNV = txtSDT.Text;
            string dcNV = txtDCNV.Text;
            string cmndNV = txtCMND.Text;
            float luongNV = (float)nmLuongNV.Value;
            string tkNV = txtTenTK.Text.Trim();
            string mkNV = txtPassNV.Text;
            Boolean tktype = rBQL.Checked;
            DateTime ngayBDNV = dtpNgayBD.Value;
            DangNhap dn = new DangNhap(tkNV, mkNV, tktype);
            NhanVien nv = new NhanVien(maNV, tenNV, dcNV, sdtNV, cmndNV, luongNV, ngayBDNV, dn);
            if (txtPassNV.Visible == true)
            {
                if (tenNV != "" && sdtNV != "" && cmndNV != "" && mkNV != "")
                {
                    if (!BLL_NhanVien.Instance.CheckUsername_BLL(ListUsernamesDGV(), tkNV))
                    {
                        if (BLL_NhanVien.Instance.InsertEmployee_BLL(nv, dn))
                        {
                            MessageBox.Show("Thêm nhân viên " + nv.Tên + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDSNhanVien();
                            OutInsertorUpdate();
                        }
                        else
                        {
                            MessageBox.Show("Có dữ liệu không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tên tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTenTK.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Nhập thiếu dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                if (tenNV != "" && sdtNV != "" && cmndNV != "")
                {
                    if (BLL_NhanVien.Instance.UpdateEmployee_BLL(nv, dn))
                    {
                        MessageBox.Show("Cập nhật nhân viên " + nv.Tên + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDSNhanVien();
                        OutInsertorUpdate();
                    }
                    else
                    {
                        MessageBox.Show("Có dữ liệu không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Nhập thiếu dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // CẬP NHẬT NHÂN VIÊN
        private void btnCapnhatNV_Click(object sender, EventArgs e)
        {
            EnableControls();
            GetRowValue();
            btnThemNV.Enabled = false;
        }
        // XÓA NHÂN VIÊN
        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            int k = 0;
            DataGridViewSelectedRowCollection data = dtgvNhanvien.SelectedRows;
            if (data.Count >= 1)
            {
                DialogResult q = MessageBox.Show("Xác nhận xóa nhân viên", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (q == DialogResult.Yes)
                {
                    List<string> listTK = new List<string>();
                    foreach (DataGridViewRow i in data)
                    {
                            listTK.Add(i.Cells[7].Value.ToString());
                    }
                    foreach (string i in listTK)
                    {
                        if (!BLL_NhanVien.Instance.DeleteEmployee_BLL(i))
                        {
                            MessageBox.Show("Không thể xóa nhân viên " + i, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            k = 1;
                        }
                    }
                    if(k!=1)
                    MessageBox.Show("Hoàn tất xóa nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSNhanVien();
                }
            }
        }
        // Thoát chế độ thêm, cập nhật
        private void btnHuyNV_Click(object sender, EventArgs e)
        {
            OutInsertorUpdate();
        }
        // Sắp xếp danh sách nhân viên
        private void cmbSapxepNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortListEmployee();
        }
        private void dtgvNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DisableControls();
            GetRowValue();
        }
        // RESET MẬT KHẨU CỦA NHÂN VIÊN
        private void btnRsMK_Click(object sender, EventArgs e)
        {
            int index = dtgvNhanvien.SelectedCells[0].RowIndex;
            DataGridViewRow row = dtgvNhanvien.Rows[index];
            string tknv = row.Cells[7].Value.ToString();
            string tenNV = row.Cells[1].Value.ToString();
            if (BLL_NhanVien.Instance.ResetEmployeePassword_BLL(tknv))
            {
                MessageBox.Show("Reset mật khẩu nhân viên " + tenNV + " thành công " +"\n"+ "Tài khoản: "+tknv +"\n" + "Mật khẩu: " + tknv, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Reset mật khẩu nhân viên " + tenNV + " không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // TÌM KIẾM NHÂN VIÊN
        private void txtTimNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)13))
            {
                if (txtTimNV.Text != "")
                {
                    dsnv.DataSource = BLL_NhanVien.Instance.GetEmployeeByName_BLL(txtTimNV.Text);
                    if (txtMaNV.Text == "")
                    {
                        MessageBox.Show("Tìm kiếm của bạn không có kết quả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDSNhanVien();
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập dữ liệu vào ô tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                e.Handled = true;
            }
        }

        private void btnQlGC_Click(object sender, EventArgs e)
        {
            frmGioCong f = new frmGioCong();
            f.ShowDialog();
        }
        private void txtTenTK_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }
        #endregion
    }
}
