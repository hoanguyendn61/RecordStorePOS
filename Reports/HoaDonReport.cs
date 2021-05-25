using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
namespace RetailStore
{
    public partial class HoaDonReport : DevExpress.XtraReports.UI.XtraReport
    {
        double TienKhach;
        public HoaDonReport()
        {
            InitializeComponent();
        }
        public HoaDonReport(double tienKhach)
        {
            InitializeComponent();
            TienKhach = tienKhach;
            Khachdua.Text = String.Format("{0:#,##0}₫", TienKhach);
        }
        private void Tralai_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            double tralai = TienKhach - Convert.ToDouble(TongCong.Value);
            Tralai.Text = String.Format("{0:#,##0}₫", tralai);
        }
    }
}
