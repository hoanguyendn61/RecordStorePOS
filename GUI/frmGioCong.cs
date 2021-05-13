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
            
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            DateTime from = dtpFrom.Value;
            DateTime to = dtpTo.Value;
            dGVGioCong.DataSource = BLL_GioCong.Instance.GetListGioCong_BLL(from, to);
            dGVGioCong.Columns[0].Visible = false;
            if (dGVGioCong.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
