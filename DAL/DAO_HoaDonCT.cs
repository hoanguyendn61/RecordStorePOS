using System;
using System.Collections.Generic;
using System.Data;
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
        public List<HoaDonCT> GetListHDCT_DAL(string idHD)
        {
            List<HoaDonCT> list = new List<HoaDonCT>();
            string query = "EXEC dbo.PROC_GetListCTHDByID @idhd = '"+idHD+"' ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                HoaDonCT hdct = new HoaDonCT(item);
                list.Add(hdct);
            }
            return list;
        }
        public bool InsertHoaDonCT_DAL(HoaDonCT hoaDonCT)
        {
            string query = "INSERT dbo.CHITIETHOADON ( MaHD, MaHH, SalesDc, QtyHD) VALUES ( @maHD , @maHH , @giam , @qty )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { hoaDonCT.Mã_HĐ, hoaDonCT.Mã_HH, hoaDonCT.Giảm_giá, hoaDonCT.SL});
            return result > 0;
        }
    }
}
