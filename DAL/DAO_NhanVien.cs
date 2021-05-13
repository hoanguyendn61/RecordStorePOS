using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RetailStore.DTO;
namespace RetailStore.DAL
{
    public class DAO_NhanVien
    {
        private static DAO_NhanVien instance;

        public static DAO_NhanVien Instance
        {
            get { if (instance == null) instance = new DAO_NhanVien(); return DAO_NhanVien.instance; }
            private set { DAO_NhanVien.instance = value; }
        }
        private DAO_NhanVien() { }
        public List<NhanVien> GetListEmployees_DAL()
        {
            List<NhanVien> list = new List<NhanVien>();
            string query = "SELECT * FROM NHANVIEN INNER JOIN DANGNHAP ON NHANVIEN.TaiKhoan = DANGNHAP.TaiKhoan";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                NhanVien employee = new NhanVien(item);
                list.Add(employee);
            }
            return list;
        }
        public NhanVien GetEmployeeByUsername_DAL(string username)
        {
            string query = "SELECT * FROM dbo.NHANVIEN INNER JOIN dbo.DANGNHAP ON DANGNHAP.TaiKhoan = NHANVIEN.TaiKhoan WHERE NHANVIEN.TaiKhoan = '" + username + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return new NhanVien(data.Rows[0]);
        }
        private string format = "yyyy-MM-dd";
        public bool InsertEmployee_DAL(NhanVien nv, DangNhap tk)
        {
            int kq = 0;
            string date = nv.Ngày_bắt_đầu.ToString(format);
            if (DAO_DangNhap.Instance.InsertAccount_DAL(tk))
            {
                string query = "INSERT dbo.NHANVIEN (MaNV, TenNV, DcNV, SdtNV, CmndNV, LuongNV, NgayBDNV, Taikhoan)" +
                           "VALUES  ( @maNV , @teNV , @dcNV , @sdt , @cmnd , @luong , @ngay , @tk )";
                kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { nv.Mã_NViên, nv.Tên, nv.Địa_chỉ, nv.SĐT, nv.CMND, nv.Lương_NV, date, nv.Tên_tài_khoản});
            }
            return kq > 0;
        }
        public bool UpdateEmployee_DAL(NhanVien nv, DangNhap dn)
        {
            int kq = 0;
            string query;
            string date = nv.Ngày_bắt_đầu.ToString(format);
            query = "UPDATE dbo.NHANVIEN SET TenNV = @tenNV , DcNV = @dcNV , SdtNV = @sdt , CmndNV = @cmnd , LuongNV = @luongNV , NgayBDNV = @ngay WHERE MaNV = @maNV "
                    + " UPDATE dbo.DANGNHAP SET TkType = @type WHERE TaiKhoan = @tk ";
            kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { nv.Tên, nv.Địa_chỉ, nv.SĐT, nv.CMND, nv.Lương_NV, date, nv.Mã_NViên, dn.Loại_tài_khoản.ToString(), dn.Tên_tài_khoản});
            return kq > 0;
        }
        public bool DeleteEmployee_DAL(string maNV)
        {
            string query = "alter table dbo.HOADON nocheck constraint ALL " +
                        "DELETE FROM dbo.NHANVIEN WHERE MaNV = '" + maNV + "'" +
                        "alter table dbo.HOADON check constraint ALL";
            int kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }
        public bool ResetEmployeePassword_DAL(string taiK)
        {
            string query = "UPDATE dbo.DANGNHAP SET MatKhau = @mk WHERE TaiKhoan = @tk ";
            int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { taiK, taiK });
            return kq > 0;
        }
    }
}
