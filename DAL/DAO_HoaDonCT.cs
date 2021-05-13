using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RetailStore.DTO;
namespace RetailStore.DAL
{
    public class DAO_HoaDonCT
    {
        private static DAO_HoaDonCT instance;

        public static DAO_HoaDonCT Instance
        {
            get { if (instance == null) instance = new DAO_HoaDonCT(); return DAO_HoaDonCT.instance; }
            private set { DAO_HoaDonCT.instance = value; }
        }
        private DAO_HoaDonCT() { }
        public bool InsertHoaDonCT(HoaDonCT hoaDonCT)
        {
            string query = "INSERT dbo.CHITIETHOADON ( MaHD, MaHH, SalesDc, QtyHD) VALUES ('" + hoaDonCT.Mã_HĐơn + "', '" + hoaDonCT.Mã_Hàng + "', '" + hoaDonCT.Giảm_giá + "', '" + hoaDonCT.SL + "')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
      
    }
}
