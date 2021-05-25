using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using DevExpress.XtraReports.UI;
using RetailStore.BLL;
using RetailStore.DTO;
using RetailStore.Reports;
namespace RetailStore
{
    
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }
        #region method
        void LoadChartSalesnProfit(string title, List<BieuDo> data)
        {
            chartTitle.Text = title;
            chartDevDoanhThu.Titles.Clear();
            chartDevDoanhThu.Titles.Add(chartTitle);
            bieuDoBindingSource.DataSource = data;
        }
        void LoadChartTop(ChartControl chart, ChartTitle t, List<BieuDoTop> data)
        {
            chart.Series[0].DataSource = data;
            chart.Series[0].ArgumentDataMember = "Name";
            chart.Series[0].ValueDataMembers.AddRange("Value");
            chart.Titles.Add(t);
        }
        void LoadChartDoanhThuNgay()
        {
            List<BieuDo> data = BLL_ThongKe.Instance.ListDoanhThuTheoNgay_BLL();
            LoadChartSalesnProfit("Doanh thu và lợi nhuận theo ngày trong tháng " + DateTime.Now.Month, data);
            chartDevDoanhThu.CrosshairOptions.GroupHeaderPattern = "{A:dd/MM/yyy}";
            XYDiagram diagram = chartDevDoanhThu.Diagram as XYDiagram;
            diagram.AxisX.Label.TextPattern = "{A:dd}";
            diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Day;
            diagram.AxisX.DateTimeScaleOptions.GridAlignment = DateTimeGridAlignment.Day;
        }
        ChartTitle chartTitle = new ChartTitle();
        void LoadChartDoanhThuThang()
        {
            List<BieuDo> data = BLL_ThongKe.Instance.ListDoanhThuTheoThang_BLL();
            // DEVExpress Chart
            LoadChartSalesnProfit("Doanh thu và lợi nhuận theo tháng trong năm " + DateTime.Now.Year, data);
            chartDevDoanhThu.CrosshairOptions.GroupHeaderPattern = "{A:MM/yyy}";
            XYDiagram diagram = chartDevDoanhThu.Diagram as XYDiagram;
            diagram.AxisX.Label.TextPattern = "{A:MMM}"; 
            diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Month;
        }
        void LoadChartDoanhThuNam()
        {
            List<BieuDo> data = BLL_ThongKe.Instance.ListDoanhThuTheoNam_BLL();
            LoadChartSalesnProfit("Doanh thu và lợi nhuận theo từng năm (VNĐ)", data);
            chartDevDoanhThu.CrosshairOptions.GroupHeaderPattern = "{A:yyy}";
            XYDiagram diagram = chartDevDoanhThu.Diagram as XYDiagram;
            diagram.AxisX.Label.TextPattern = "{A:yyyy}";
            diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Year;
        }
        void LoadChartTopNV()
        {
            List<BieuDoTop> data = BLL_ThongKe.Instance.ListTopNVCuaThang_BLL();
            ChartTitle t = new ChartTitle();
            t.Text = "TOP nhân viên của tháng " + DateTime.Now.Month;
            LoadChartTop(chartDevTopNV, t, data);
        }
        void LoadChartTopSP()
        {
            List<BieuDoTop> data = BLL_ThongKe.Instance.ListTop5Products_BLL();
            ChartTitle t = new ChartTitle();
            t.Text = "TOP 5 mặt hàng bán chạy nhất";
            LoadChartTop(chartTopProducts, t, data);
        }
        void LoadChartTopLoaiHH()
        {
            List<BieuDoTop> data = BLL_ThongKe.Instance.ListTopCategory_BLL();
            ChartTitle t = new ChartTitle();
            t.Text = "TOP 4 loại hàng bán chạy nhất";
            LoadChartTop(chartTopCategory, t, data);
        }
        #endregion
        #region events
        private void frmDashboard_Load(object sender, EventArgs e)
        {
            lbldthuNgay.Text = String.Format("{0:#,##0}", BLL_HoaDon.Instance.DoanhThuTheoNgay_BLL());
            lblTongHD.Text = BLL_HoaDon.Instance.SoHDTrongNgay_BLL().ToString();
            lblSLkhach.Text = BLL_KhachHang.Instance.SLKhachHang_BLL().ToString();
            lblSLsanpham.Text = BLL_HangHoa.Instance.TongSLTonKho_BLL().ToString();
            cmbDthu.SelectedIndex = 0;
            LoadChartTopLoaiHH();
            LoadChartTopSP();
            LoadChartTopNV();
        }
        private void cmbDthu_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbDthu.SelectedIndex)
            {
                case 0:
                    LoadChartDoanhThuNgay();
                    break;
                case 1:
                    LoadChartDoanhThuThang();
                    break;
                case 2:
                    LoadChartDoanhThuNam();
                    break;
                default:
                    break;
            }
        }
        // In báo cáo cuối ngày
        private void btnInCN_Click(object sender, EventArgs e)
        {
            if (rBBHCuoiNgay.Checked)
            {
                BHCuoiNgayRpt rp = new BHCuoiNgayRpt(dtpCuoiNgay.Value);
                rp.DataSource = BLL_ThongKe.Instance.BHCuoiNgay_DAL(dtpCuoiNgay.Value);
                rp.ShowPreviewDialog();
            }
            else
            {
                HHCuoiNgayRpt rp = new HHCuoiNgayRpt(dtpCuoiNgay.Value);
                rp.DataSource = BLL_ThongKe.Instance.HHCuoiNgay_DAL(dtpCuoiNgay.Value);
                rp.ShowPreviewDialog();
            }
        }
        // In báo cáo bán hàng
        private void btnInBH_Click(object sender, EventArgs e)
        {
            if (rBLNBanHang.Checked)
            {
                LNBanHangRpt rp = new LNBanHangRpt(dtpFromBH.Value, dtpToBH.Value);
                rp.DataSource = BLL_ThongKe.Instance.LNBanHang_BLL(dtpFromBH.Value, dtpToBH.Value);
                rp.ShowPreviewDialog();
            } else
            {
                NVBanHangRpt rp = new NVBanHangRpt(dtpFromBH.Value, dtpToBH.Value);
                rp.DataSource = BLL_ThongKe.Instance.NVBanHang_DAL(dtpFromBH.Value, dtpToBH.Value);
                rp.ShowPreviewDialog();
            }
        }
        // In báo cáo hàng hóa
        private void btnInHH_Click(object sender, EventArgs e)
        {
            if (rBBHHangHoa.Checked)
            {
                BHHangHoaRpt rp = new BHHangHoaRpt(dtpFromHH.Value, dtpToBH.Value);
                rp.DataSource = BLL_ThongKe.Instance.BHHangHoa_BLL(dtpFromHH.Value, dtpToBH.Value);
                rp.ShowPreviewDialog();
            }
            else
            {
                LNHangHoaRpt rp = new LNHangHoaRpt(dtpFromHH.Value, dtpToBH.Value);
                rp.DataSource = BLL_ThongKe.Instance.LNHangHoa_BLL(dtpFromHH.Value, dtpToBH.Value);
                rp.ShowPreviewDialog();
            }
        }
        #endregion
    }
}
