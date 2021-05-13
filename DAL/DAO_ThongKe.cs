using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStore.DAL
{
    public class DAO_ThongKe
    {
        private static DAO_ThongKe instance;
        public static DAO_ThongKe Instance
        {
            get { if (instance == null) instance = new DAO_ThongKe(); return DAO_ThongKe.instance; }
            private set { DAO_ThongKe.instance = value; }
        }
        private DAO_ThongKe() { }
        public DataTable DoanhThuTheoNgay_DAL()
        {
            DataTable dthu;
            string query = "EXEC DoanhThuTheoNgay";
            dthu = DataProvider.Instance.ExecuteQuery(query);
            return dthu;
        }
        public DataTable DoanhThuTheoThang_DAL()
        {
            DataTable dthu;
            string query = "EXEC DoanhThuTheoThang";
            dthu = DataProvider.Instance.ExecuteQuery(query);
            return dthu;
        }
        public DataTable DoanhThuTheoNam_DAL()
        {
            DataTable dthu;
            string query = "EXEC DoanhThuTheoNam";
            dthu = DataProvider.Instance.ExecuteQuery(query);
            return dthu;
        }
        public DataTable TOP5SanPham_DAL()
        {
            DataTable top;
            string query = "EXEC TOP5BestSelling";
            top = DataProvider.Instance.ExecuteQuery(query);
            return top;
        }
        public DataTable TopNVCuaThang_DAL()
        {
            DataTable top;
            string query = "EXEC dbo.TOPNVCUATHANG";
            top = DataProvider.Instance.ExecuteQuery(query);
            return top; 
        }
        public DataTable TopLoaiHH_DAL()
        {
            DataTable top;
            string query = "EXEC TOP4LoaiHH";
            top = DataProvider.Instance.ExecuteQuery(query);
            return top;
        }
    }
}
