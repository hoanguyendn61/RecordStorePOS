using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RetailStore.DAL;
using RetailStore.DTO;
namespace RetailStore.BLL
{
    public class BLL_ThongKe
    {
        private static BLL_ThongKe _Instance;
        public static BLL_ThongKe Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_ThongKe();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_ThongKe()
        {
        }
        public List<BieuDo> ListDoanhThuTheoNgay_BLL()
        {
            return DAO_ThongKe.Instance.ListDoanhThuTheoNgay_DAL();
        }
        public List<BieuDo> ListDoanhThuTheoThang_BLL()
        {
            return DAO_ThongKe.Instance.ListDoanhThuTheoThang_DAL();
        }
        public List<BieuDo> ListDoanhThuTheoNam_BLL()
        {
            return DAO_ThongKe.Instance.ListDoanhThuTheoNam_DAL();
        }
        public List<BieuDoTop> ListTop5Products_BLL()
        {
            return DAO_ThongKe.Instance.ListTop5Products_DAL();
        }
        public List<BieuDoTop> ListTopNVCuaThang_BLL()
        {
            return DAO_ThongKe.Instance.ListTopNVCuaThang_DAL();
        }
        public List<BieuDoTop> ListTopCategory_BLL()
        {
            return DAO_ThongKe.Instance.ListTopCategory_DAL();
        }
        public DataTable BHCuoiNgay_DAL(DateTime date)
        {
            return DAO_ThongKe.Instance.BHCuoiNgay_DAL(date);
        }
        public DataTable HHCuoiNgay_DAL(DateTime date)
        {
            return DAO_ThongKe.Instance.HHCuoiNgay_DAL(date);
        }
        public DataTable NVBanHang_DAL(DateTime from, DateTime to)
        {
            return DAO_ThongKe.Instance.NVBanHang_DAL(from, to);
        }
        public DataTable LNBanHang_BLL(DateTime from, DateTime to)
        {
            return DAO_ThongKe.Instance.LNBanHang_DAL(from, to);
        }
        public DataTable BHHangHoa_BLL(DateTime from, DateTime to)
        {
            return DAO_ThongKe.Instance.BHHangHoa_DAL(from, to);
        }
        public DataTable LNHangHoa_BLL(DateTime from, DateTime to)
        {
            return DAO_ThongKe.Instance.LNHangHoa_DAL(from, to);
        }
    }
}
