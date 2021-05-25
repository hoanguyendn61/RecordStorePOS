using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace RetailStore.Reports
{
    public partial class LNBanHangRpt : DevExpress.XtraReports.UI.XtraReport
    {
        public LNBanHangRpt()
        {
            InitializeComponent();
        }
        public LNBanHangRpt(DateTime from, DateTime to)
        {
            InitializeComponent();
            lblFrom.Text = from.ToString("dd/MM/yyyy");
            lblTo.Text = to.ToString("dd/MM/yyyy");
            ngayLap.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            nguoiLap.Text = frmDangnhap.nv.Tên;
        }
    }
}
