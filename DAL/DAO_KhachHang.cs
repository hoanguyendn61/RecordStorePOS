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
            string query = string.Format("Delete FROM dbo.KHACHHANG WHERE MaKH = '{0}'", maKH);
            int kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }
    }
}
