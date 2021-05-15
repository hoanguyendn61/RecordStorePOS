using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RetailStore.DTO;
using System.Data;
namespace RetailStore.DAL
{
    public class DAO_KhachHang
    {
        private static DAO_KhachHang instance;
        public static DAO_KhachHang Instance
        {
            get { if (instance == null) instance = new DAO_KhachHang(); return DAO_KhachHang.instance; }
            private set { DAO_KhachHang.instance = value; }
        }
        private DAO_KhachHang() { }
        public List<KhachHang> GetListCustomers_DAL()
        {
            List<KhachHang> list = new List<KhachHang>();
            //string query = "SELECT * FROM KHACHHANG";
            string query = "EXEC dbo.PROC_GetListKH";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                KhachHang customer = new KhachHang(item);
                list.Add(customer);
            }
            return list;
        }
        public bool InsertCustomer_DAL(KhachHang khachHang)
        {
            string query = "INSERT dbo.KHACHHANG (MaKH, TenKH, SdtKH) VALUES  ( @maKH , @tenKH , @sdtKH )";
            int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] {khachHang.Mã_KHàng, khachHang.Tên, khachHang.SĐT });
            return kq > 0;
        }
        public bool UpdateCustomer_DAL(KhachHang khachHang)
        {
            string query = "UPDATE dbo.KHACHHANG SET TenKH = @tenKH , SdtKH = @sdtKH WHERE MaKH = @maKH ";
            int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { khachHang.Tên, khachHang.SĐT, khachHang.Mã_KHàng });
            return kq > 0;
        }
        public bool DeleteCustomer_DAL(string maKH)
        {
            string query = string.Format("alter table dbo.HOADON nocheck constraint ALL " +
                                          "Delete FROM dbo.KHACHHANG WHERE MaKH = '{0}'" +
                                          "alter table dbo.HOADON check constraint ALL ", maKH);
            int kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }
        //public List<KhachHang> TimKiemKhachHangByName_DAL(string TenKH)
        //{
        //    List<KhachHang> list = new List<KhachHang>();
        //    string query;
        //    query = "SELECT * FROM dbo.KHACHHANG WHERE dbo.fuConvertToUnsign1(TenKH) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + TenKH + "') + '%'";
        //    DataTable data = DataProvider.Instance.ExecuteQuery(query);
        //    foreach (DataRow item in data.Rows)
        //    {
        //        KhachHang customer = new KhachHang(item);
        //        list.Add(customer);
        //    }
        //    return list;
        //}
        //public int TongSoKhachHang_DAL()
        //{
        //    return Convert.ToInt32(DataProvider.Instance.ExecuteScalar("SELECT COUNT(*) MaKH FROM dbo.KHACHHANG"));
        //}
    }
}
