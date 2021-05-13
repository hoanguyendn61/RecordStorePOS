using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
namespace RetailStore
{
    public partial class HoaDonReport : DevExpress.XtraReports.UI.XtraReport
    {
        public HoaDonReport()
        {
            InitializeComponent();
        }
        public HoaDonReport(string tienKhach, string tienTra)
        {
            InitializeComponent();
            Khachdua.Text = tienKhach;
            Tralai.Text = tienTra;
        }
        private frmTinhtien frmtinhTien = null;
        private frmTinhtien FrmTinhtien
        {
            get { return frmtinhTien; }
            set { frmtinhTien = value; }
        }
        public HoaDonReport(frmTinhtien parentForm) : this()
        {
            this.FrmTinhtien = parentForm;
        }
    }
}
