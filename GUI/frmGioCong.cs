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
    public partial class frmGioCong : Form
    {
        public frmGioCong()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            cbNV.DataSource = BLL_NhanVien.Instance.GetListEmployees_BLL();
            cbNV.DisplayMember = "Tên";
        }
        DateTime from, to;
        private void LoadDSGioCong(string id = null)
        {
            from = dtpFrom.Value;
            to = dtpTo.Value;
            if (id != null)
            {
                dGVGioCong.DataSource = BLL_GioCong.Instance.GetListGioCong_BLL(from, to, id);
            } else
            {
                dGVGioCong.DataSource = BLL_GioCong.Instance.GetListGioCong_BLL(from, to);
            }
            dGVGioCong.Columns[0].Visible = false;
            if (dGVGioCong.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadDSGioCong();
        }
        private void btnLoc_Click(object sender, EventArgs e)
        {
            // Lọc theo tên nhân viên
            string idnv = (cbNV.SelectedItem as NhanVien).Mã_NViên;
            LoadDSGioCong(idnv);
        }
        private void btnThemGC_Click(object sender, EventArgs e)
        {
            frmGioCongCT f = new frmGioCongCT();
            f.dShow = new frmGioCongCT.MyDelShow(LoadDSGioCong);
            f.ShowDialog();
        }
        private void btnCapnhatGC_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection data = dGVGioCong.SelectedRows;
            if (data.Count == 1)
            {
                frmGioCongCT f = new frmGioCongCT(data);
                f.dShow = new frmGioCongCT.MyDelShow(LoadDSGioCong);
                f.ShowDialog();
            }
        }
        private void btnXoaGC_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection data = dGVGioCong.SelectedRows;
            if (data.Count >= 1)
            {
                DialogResult q = MessageBox.Show("Xác nhận xóa giờ công", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (q == DialogResult.Yes)
                {
                    List<int> listID = new List<int>();
                    foreach (DataGridViewRow i in data)
                    {
                        listID.Add((int)i.Cells[0].Value);
                    }
                    foreach (int i in listID)
                    {
                        if (!BLL_GioCong.Instance.DeleteTime_BLL(i))
                        {
                            MessageBox.Show("Lỗi khi xóa giờ công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    MessageBox.Show("Hoàn tất xóa giờ công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSGioCong();
                }
            }
        }

        
    }
}
