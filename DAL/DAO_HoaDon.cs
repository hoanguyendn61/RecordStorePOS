using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RetailStore.DTO;
using DevExpress.XtraReports.UI;
namespace RetailStore.DAL
{
    public class DAO_HoaDon
    {
        private static DAO_HoaDon instance;

        public static DAO_HoaDon Instance
        {
            get { if (instance == null) instance = new DAO_HoaDon(); return DAO_HoaDon.instance; }
            private set { DAO_HoaDon.instance = value; }
        }
        private DAO_HoaDon() { }
        private string format = "yyyy-MM-dd HH:mm:ss";
        public bool InsertHoaDon_DAL(HoaDon hoaDon)
        {
            string query = "INSERT dbo.HOADON ( MaHD, NgayGD, MaNV, MaKH) VALUES ('" + hoaDon.Mã_HĐơn + "', '" + hoaDon.Ngày_GD.ToString(format) + "', '" + hoaDon.Mã_NViên+ "', '"+ hoaDon.Mã_KHàng +"')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public string FindReceiptKeyMax_DAL()
        {
            string query = "SELECT MAX(MaHD) FROM dbo.HOADON";
            string kq = DataProvider.Instance.ExecuteScalar(query).ToString();
            return kq;
        }
        public DataTable PrintHoaDon_DAL(string maHD)
        {
            string query = "SELECT * FROM dbo.HoaDonView WHERE MaHD = '" +maHD+ "'";
            //HoaDonReport hoaDonIn = new HoaDonReport();
            //hoaDonIn.DataSource = DataProvider.Instance.ExecuteQuery(query);
            //hoaDonIn.ShowPreviewDialog();
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool DeleteHD_DAL(string maHD )
        {
            string query = "DELETE dbo.CHITIETHOADON WHERE MaHD = '" + maHD + "'" +
                           "DELETE dbo.HOADON WHERE MaHD = '" + maHD + "'";
            int kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }
        public double TongTienTheoNgay_DAL()
        {
            return Convert.ToDouble(DataProvider.Instance.ExecuteScalar("EXEC DoanhThuToday"));
        }
        public int TongSoHoaDon_DAL()
        {
            return Convert.ToInt32(DataProvider.Instance.ExecuteScalar("SELECT COUNT(*) MaHD FROM dbo.HOADON"));
        }
    }
}
