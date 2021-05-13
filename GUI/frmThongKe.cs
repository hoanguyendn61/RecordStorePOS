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
using RetailStore.BLL;
namespace RetailStore
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();

        }
       
        void LoadChartDoanhThuNgay()
        {
            chartDoanhThu.DataSource = BLL_ThongKe.Instance.DoanhThuTheoNgay_BLL();
            chartDoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";
            chartDoanhThu.ChartAreas["ChartArea1"].AxisY.Title = "VNĐ";
            chartDoanhThu.Series["Doanh thu"].XValueMember = "NGAY";
            chartDoanhThu.Series["Doanh thu"].YValueMembers = "TongTien";
        }
        void LoadChartDoanhThuThang()
        {
            chartDoanhThu.DataSource = BLL_ThongKe.Instance.DoanhThuTheoThang_BLL();
            chartDoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
            chartDoanhThu.ChartAreas["ChartArea1"].AxisY.Title = "VNĐ";
            chartDoanhThu.Series["Doanh thu"].XValueMember = "THANG";
            chartDoanhThu.Series["Doanh thu"].YValueMembers = "TongTien";
            
        }
        void LoadChartDoanhThuNam()
        {
            chartDoanhThu.DataSource = BLL_ThongKe.Instance.DoanhThuTheoNam_BLL();
            chartDoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Năm";
            chartDoanhThu.ChartAreas["ChartArea1"].AxisY.Title = "VNĐ";
            chartDoanhThu.Series["Doanh thu"].XValueMember = "NAM";
            chartDoanhThu.Series["Doanh thu"].YValueMembers = "TongTien";
        }
        void LoadChartTopNV()
        {
            chartTopNV.DataSource = BLL_ThongKe.Instance.TopNVCuaThang_BLL();
            chartTopNV.Series["Số hóa đơn bán"].XValueMember = "TenNV";
            chartTopNV.Series["Số hóa đơn bán"].YValueMembers = "SHD";
            chartTopNV.Series["Số hóa đơn bán"].IsValueShownAsLabel = true;
        }
        void LoadChartTopSP()
        {
            chartTopSP.DataSource = BLL_ThongKe.Instance.TOP5SanPham_BLL();
            chartTopSP.Series["Số lượng bán ra"].XValueMember = "TenHH";
            chartTopSP.Series["Số lượng bán ra"].YValueMembers = "SL";
            chartTopSP.Series["Số lượng bán ra"].IsValueShownAsLabel = true;
        }
        void LoadChartTopLoaiHH()
        {
            chartTopLoaiHH.DataSource = BLL_ThongKe.Instance.TopLoaiHH_BLL();
            chartTopLoaiHH.Series["Số lượng bán ra"].XValueMember = "LoaiHH";
            chartTopLoaiHH.Series["Số lượng bán ra"].YValueMembers = "SL";
            chartTopLoaiHH.Series["Số lượng bán ra"].IsValueShownAsLabel = true;
        }
        private void frmDashboard_Load(object sender, EventArgs e)
        {
            //lbldthuNgay.Text = String.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", HoaDonDAO.Instance.TongTienTheoNgay());
            //lblTongHD.Text = HoaDonDAO.Instance.TongSoHoaDon().ToString();
            //lblSLkhach.Text = KhachHangDAO.Instance.TongSoKhachHang().ToString();
            //lblSLsanpham.Text = HangHoaDAO.Instance.TongSLSanPham().ToString();
            //cmbDthu.SelectedItem = "ngày";
            //chartDoanhThu.Series["Doanh thu"].IsValueShownAsLabel = true;
            //LoadChartTopLoaiHH();
            //LoadChartTopSP();
            //LoadChartTopNV();
        }

        private void cmbDthu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //switch (cmbDthu.Text)
            //{
            //    case "tháng":
            //        LoadChartDoanhThuThang();
            //        break;
            //    case "ngày":
            //        LoadChartDoanhThuNgay();
            //        break;
            //    case "năm":
            //        LoadChartDoanhThuNam();
            //        break;
            //    default:
            //        break;
            //}
        }
    }
}
