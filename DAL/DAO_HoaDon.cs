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
        // Get list hóa đơn
        public List<HoaDon> GetListHD_DAL()
        {
            List<HoaDon> list = new List<HoaDon>();
            string query = "EXEC dbo.PROC_GetListHD";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                HoaDon hd = new HoaDon(item);
                list.Add(hd);
            }
            return list;
        }
        // Get list hoa don id Khach hang
        public List<HoaDon> GetListHD_DAL(string idkh)
        {
            List<HoaDon> list = new List<HoaDon>();
            string query = "EXEC dbo.PROC_GetListHDByIdKH @makh = '"+idkh+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                HoaDon hd = new HoaDon(item);
                list.Add(hd);
            }
            return list;
        }
        // Get list HĐ between dates, employee, customer
        string formatFrom = "yyyy-MM-dd 00:00:00.000";
        string formatTo = "yyyy-MM-dd 23:59:59.000";
        public List<HoaDon> GetListHD_DAL(DateTime from, DateTime to)
        {
            List<HoaDon> list = new List<HoaDon>();
            string query = "EXEC dbo.PROC_GetListHDByDates @date1 = '"+from.ToString(formatFrom) +"', @date2 = '"+to.ToString(formatTo) +"' ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                HoaDon hd = new HoaDon(item);
                list.Add(hd);
            }
            return list;
        }


        private string format = "yyyy-MM-dd HH:mm:ss";
        public bool InsertHoaDon_DAL(HoaDon hoaDon)
        {
            string query = "INSERT dbo.HOADON ( MaHD, NgayGD, MaNV, MaKH) VALUES ( @maHD , @ngay , @maNV , @maKH )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { hoaDon.Mã_HĐơn, hoaDon.Ngày_GD.ToString(format), hoaDon.Nv.Mã_NViên, hoaDon.Kh.Mã_KHàng});
            return result > 0;
        }
        public DataTable PrintHoaDon_DAL(string maHD)
        {
            string query = "SELECT * FROM dbo.HoaDonView WHERE MaHD = '" +maHD+ "'";
            HoaDonReport hoaDonIn = new HoaDonReport();
            hoaDonIn.DataSource = DataProvider.Instance.ExecuteQuery(query);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool DeleteHD_DAL(string maHD )
        {
            string query = "DELETE dbo.HOADON WHERE MaHD = '" + maHD + "'";
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
