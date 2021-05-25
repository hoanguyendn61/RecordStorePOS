using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RetailStore.DTO;
namespace RetailStore.DAL
{
    public class DAO_NhaCungCap
    {
        private static DAO_NhaCungCap _Instance;
        public static DAO_NhaCungCap Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAO_NhaCungCap();
                }
                return _Instance;
            }
            private set { }
        }
        private DAO_NhaCungCap()
        {
        }
        public List<NhaCungCap> GetListSuppliers_DAL()
        {
            List<NhaCungCap> list = new List<NhaCungCap>();

            string query = "select * from NHACUNGCAP";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                NhaCungCap supplier = new NhaCungCap(item);
                list.Add(supplier);
            }
            return list;
        }
        public bool InsertSupplier_DAL(NhaCungCap sup)
        {
            string query = "INSERT dbo.NHACUNGCAP (MaNCC, TenNCC, DcNCC, SdtNCC, EmailNCC)" +
                "VALUES ( @ma , @ten , @dc , @sdt , @email )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { sup.Mã_NCC, sup.Tên, sup.Địa_chỉ, sup.SĐT, sup.Email});
            return result > 0;
        }
        public bool UpdateSupplier_DAL(NhaCungCap sup)
        {
            string query = string.Format("UPDATE dbo.NHACUNGCAP SET TenNCC = @ten , DcNCC = @dc , SdtNCC = @sdt , EmailNCC = @email WHERE MaNCC = @ma ");
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { sup.Tên, sup.Địa_chỉ, sup.SĐT, sup.Email, sup.Mã_NCC});
            return result > 0;
        }
        public bool DeleteSupplier_DAL(string idSup)
        {
            string query = string.Format("Delete FROM dbo.NHACUNGCAP WHERE MaNCC = '{0}'", idSup);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public NhaCungCap GetSupplierByID_DAL(string id)
        {
            string query = "SELECT * FROM NHACUNGCAP WHERE MaNCC = '" + id + "'";
            return new NhaCungCap(DataProvider.Instance.ExecuteQuery(query).Rows[0]);
        }
    }
}
