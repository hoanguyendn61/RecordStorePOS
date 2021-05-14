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
    public partial class frmGioCongCT : Form
    {
        public delegate void MyDelShow(string id);
        public MyDelShow dShow { get; set; }
        public frmGioCongCT(DataGridViewSelectedRowCollection data = null)
        {
            InitializeComponent();
            LoadDSNVtoCB(data);
        }
        int timeID;
        private void LoadDSNVtoCB(DataGridViewSelectedRowCollection data)
        {
            cbTenNV.DataSource = BLL_NhanVien.Instance.GetListEmployees_BLL();
            cbTenNV.DisplayMember = "Tên";
            if(data != null)
            {
                string nameNV = data[0].Cells[2].Value.ToString();
                cbTenNV.SelectedIndex = cbTenNV.FindStringExact(nameNV);
                cbTenNV.Enabled = false;
                dtpNgay.Value = Convert.ToDateTime(data[0].Cells[3].Value.ToString());
                dtpClockIn.Value = Convert.ToDateTime(data[0].Cells[4].Value.ToString());
                dtpClockOut.Value = Convert.ToDateTime(data[0].Cells[5].Value.ToString());
                timeID = Convert.ToInt32(data[0].Cells[0].Value.ToString());
            }
        }
        private void btnHuyGC_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btnLuuGC_Click(object sender, EventArgs e)
        {
            // IF combobox is enabled then it will add, otherwise it will update
            if (dtpClockOut.Value >= dtpClockIn.Value)
            {
                //Convert datetime to timespan
                string clockin = dtpClockIn.Value.ToString("HH\\:mm");
                TimeSpan clockIn = TimeSpan.Parse(clockin);
                string clockout = dtpClockOut.Value.ToString("HH\\:mm");
                TimeSpan clockOut = TimeSpan.Parse(clockout);
                //Create GioCong object
                GioCong gc = new GioCong(cbTenNV.SelectedItem as NhanVien, clockIn, clockOut, dtpNgay.Value);
                if (cbTenNV.Enabled)
                {
                    //Add
                    if (BLL_GioCong.Instance.InsertTime_BLL(gc))
                    {
                        MessageBox.Show("Thêm giờ công thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi thêm giờ công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //Update
                    if (BLL_GioCong.Instance.UpdateTime_BLL(gc, timeID))
                    {
                        MessageBox.Show("Cập nhật giờ công thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi cập nhật giờ công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                dShow(null);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Lỗi nhập giờ vào sớm hơn giờ ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
