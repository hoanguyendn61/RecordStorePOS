using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RetailStore.DTO;
namespace RetailStore.DAL
{
    public class DAO_DangNhap
    {
        private static DAO_DangNhap instance;

        public static DAO_DangNhap Instance
        {
            get { if (instance == null) instance = new DAO_DangNhap(); return DAO_DangNhap.instance; }
            private set { DAO_DangNhap.instance = value; }
        }
        private DAO_DangNhap() { }
        public DangNhap Login_DAL(string username, string password)
        {
            string query = "SELECT * FROM dbo.DANGNHAP WHERE TaiKhoan = @username AND MatKhau = @password ";
            DataTable kq = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });
            try
            {
                if (kq.Rows[0] == null)
                {
                    return null;
                }
                else
                {
                    return new DangNhap(kq.Rows[0]);
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<DangNhap> GetListAccount_DAL()
        {
            List<DangNhap> list = new List<DangNhap>();
            string query = "SELECT * FROM DANGNHAP";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DangNhap account = new DangNhap(item);
                list.Add(account);
            }
            return list;
        }
        public bool InsertAccount_DAL(DangNhap tk)
        {
            string query = "INSERT dbo.DANGNHAP (TaiKhoan, MatKhau, TkType) VALUES ( @tk , @mk , @type )";
            int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tk.Tên_tài_khoản, tk.Mật_khẩu, tk.Loại_tài_khoản.ToString()});
            return kq > 0;
        }
        public bool DeleteAccount_DAL(string tentk)
        {
            // Xóa tài khoản nhưng không xóa lịch sử giao dịch của nhân viên
            string query;
            int kq = 0;
            query = "alter table dbo.NHANVIEN nocheck constraint ALL " +
                    "DELETE dbo.DANGNHAP WHERE TaiKhoan = '"+tentk+"' " +
                    "alter table dbo.NHANVIEN check constraint ALL ";
            kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }
        public bool UpdateAccount_DAL(DangNhap tk)
        {
            string query = "UPDATE dbo.DANGNHAP SET MatKhau = @mk , TkType = @type WHERE TaiKhoan =  @tk ";
            int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tk.Mật_khẩu, tk.Loại_tài_khoản.ToString(), tk.Tên_tài_khoản});
            return kq > 0;
        }
    }
}
