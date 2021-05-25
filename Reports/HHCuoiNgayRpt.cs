using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace RetailStore.Reports
{
    public partial class HHCuoiNgayRpt : DevExpress.XtraReports.UI.XtraReport
    {
        public HHCuoiNgayRpt()
        {
            InitializeComponent();
        }
        public HHCuoiNgayRpt(DateTime NgayBan)
        {
            InitializeComponent();
            ngayBan.Text = NgayBan.ToString("dd/MM/yyyy");
            ngayLap.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            nguoiLap.Text = nguoiLap.Text = frmDangnhap.nv.Tên;
        }
    }
}
