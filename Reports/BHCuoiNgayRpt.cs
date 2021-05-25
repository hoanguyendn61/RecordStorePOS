using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace RetailStore.Reports
{
    public partial class BHCuoiNgayRpt : DevExpress.XtraReports.UI.XtraReport
    {
        public BHCuoiNgayRpt()
        {
            InitializeComponent();
        }
        public BHCuoiNgayRpt(DateTime NgayBan)
        {
            InitializeComponent();
            ngayBan.Text = NgayBan.ToString("dd/MM/yyyy");
            ngayLap.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            nguoiLap.Text = frmDangnhap.nv.Tên;
        }
    }
}
