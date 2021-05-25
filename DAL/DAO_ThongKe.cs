using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RetailStore.DTO;
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
        public List<BieuDo> ListDoanhThuTheoNgay_DAL()
        {
            List<BieuDo> list = new List<BieuDo>();
            string query = "EXEC PROC_DTvaLNTheoNgay";
            DataTable dthu = DataProvider.Instance.ExecuteQuery(query);
            if (dthu != null)
            {
                for (int i = 0; i < dthu.Rows.Count; i++)
                {
                    list.Add(new BieuDo()
                    {
                        Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, Convert.ToInt32(dthu.Rows[i]["NGAY"])),
                        GrossSales = Convert.ToDouble(dthu.Rows[i]["DoanhThu"]),
                        GrossProfit = Convert.ToDouble(dthu.Rows[i]["LoiNhuanGop"])
                    });
                }
            }
            return list;
        }
        public List<BieuDo> ListDoanhThuTheoThang_DAL()
        {
            List<BieuDo> list = new List<BieuDo>();
            string query = "EXEC dbo.PROC_DTvaLNTheoThang";
            DataTable dthu = DataProvider.Instance.ExecuteQuery(query);
            if (dthu != null)
            {
                for (int i = 0; i < dthu.Rows.Count; i++)
                {
                    list.Add(new BieuDo()
                    {
                        Date = new DateTime(DateTime.Now.Year, Convert.ToInt32(dthu.Rows[i]["THANG"]), 1),
                        GrossSales = Convert.ToDouble(dthu.Rows[i]["DoanhThu"]),
                        GrossProfit = Convert.ToDouble(dthu.Rows[i]["LoiNhuanGop"])
                    });
                }
            }
            return list;
        }
        public List<BieuDo> ListDoanhThuTheoNam_DAL()
        {
            List<BieuDo> list = new List<BieuDo>();
            string query = "EXEC PROC_DTvaLNTheoNam";
            DataTable dthu = DataProvider.Instance.ExecuteQuery(query);
            if (dthu != null)
            {
                for (int i = 0; i < dthu.Rows.Count; i++)
                {
                    list.Add(new BieuDo() 
                    {
                        Date = new DateTime(Convert.ToInt32(dthu.Rows[i]["NAM"]), 1, 1),
                        GrossSales = Convert.ToDouble(dthu.Rows[i]["DoanhThu"]),
                        GrossProfit = Convert.ToDouble(dthu.Rows[i]["LoiNhuanGop"])
                    });
                }
            }
            return list;
        }
        public DataTable TOP5SanPham_DAL()
        {
            DataTable top;
            string query = "EXEC TOP5BestSelling";
            top = DataProvider.Instance.ExecuteQuery(query);
            return top;
        }
       
        public List<BieuDoTop> ListTopNVCuaThang_DAL()
        {
            List<BieuDoTop> list = new List<BieuDoTop>();
            string query = "EXEC dbo.TOPNVCUATHANG";
            DataTable dthu = DataProvider.Instance.ExecuteQuery(query);
            if (dthu != null)
            {
                for (int i = 0; i < dthu.Rows.Count; i++)
                {
                    list.Add(new BieuDoTop()
                    {
                        Name = Convert.ToString(dthu.Rows[i]["TenNV"]),
                        Value = Convert.ToInt32(dthu.Rows[i]["SHD"])
                    }) ;
                }
            }
            return list;
        }
        public List<BieuDoTop> ListTopCategory_DAL()
        {
            List<BieuDoTop> list = new List<BieuDoTop>();
            string query = "EXEC dbo.TOP4LoaiHH";
            DataTable dthu = DataProvider.Instance.ExecuteQuery(query);
            if (dthu != null)
            {
                for (int i = 0; i < dthu.Rows.Count; i++)
                {
                    list.Add(new BieuDoTop()
                    {
                        Name = Convert.ToString(dthu.Rows[i]["LoaiHH"]),
                        Value = Convert.ToInt32(dthu.Rows[i]["SL"])
                    });
                }
            }
            return list;
        }
        public List<BieuDoTop> ListTop5Products_DAL()
        {
            List<BieuDoTop> list = new List<BieuDoTop>();
            string query = "EXEC dbo.PROC_TOP5Products";
            DataTable dthu = DataProvider.Instance.ExecuteQuery(query);
            if (dthu != null)
            {
                for (int i = 0; i < dthu.Rows.Count; i++)
                {
                    list.Add(new BieuDoTop()
                    {
                        Name = Convert.ToString(dthu.Rows[i]["TenHH"]),
                        Value = Convert.ToInt32(dthu.Rows[i]["SL"])
                    });
                }
            }
            return list;
        }
        // Báo cáo
        string dateformat = "yyyy-MM-dd";
        public DataTable BHCuoiNgay_DAL(DateTime date)
        {
            string query = "SELECT * FROM View_BHCuoiNgay WHERE NgayGD = '" + date.ToString(dateformat)+"'";
            DataTable rp = DataProvider.Instance.ExecuteQuery(query);
            return rp;
        }
        public DataTable HHCuoiNgay_DAL(DateTime date)
        {
            string query = "EXEC PROC_HHCuoiNgay @date = '" + date.ToString(dateformat) + "'";
            DataTable rp = DataProvider.Instance.ExecuteQuery(query);
            return rp;
        }
        public DataTable NVBanHang_DAL(DateTime from, DateTime to)
        {
            string query = "EXEC PROC_NVBanHang @date1 = '"+from.ToString(dateformat)+ "', @date2 = '" + to.ToString(dateformat) + "'";
            DataTable rp = DataProvider.Instance.ExecuteQuery(query);
            return rp;
        }
        public DataTable LNBanHang_DAL(DateTime from, DateTime to)
        {
            string query = "EXEC PROC_LNBanHang @date1 = '" + from.ToString(dateformat) + "', @date2 = '" + to.ToString(dateformat) + "'";
            DataTable rp = DataProvider.Instance.ExecuteQuery(query);
            return rp;
        }
        public DataTable BHHangHoa_DAL(DateTime from, DateTime to)
        {
            string query = "EXEC PROC_BHHangHoa @date1 = '" + from.ToString(dateformat) + "', @date2 = '" + to.ToString(dateformat) + "'";
            DataTable rp = DataProvider.Instance.ExecuteQuery(query);
            return rp;
        }
        public DataTable LNHangHoa_DAL(DateTime from, DateTime to)
        {
            string query = "EXEC PROC_LNHangHoa @date1 = '" + from.ToString(dateformat) + "', @date2 = '" + to.ToString(dateformat) + "'";
            DataTable rp = DataProvider.Instance.ExecuteQuery(query);
            return rp;
        }
    }
}
