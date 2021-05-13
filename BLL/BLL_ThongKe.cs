using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RetailStore.DAL;
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
        public DataTable DoanhThuTheoNgay_BLL()
        {
            return DAO_ThongKe.Instance.DoanhThuTheoNgay_DAL();
        }
        public DataTable DoanhThuTheoThang_BLL()
        {
            return DAO_ThongKe.Instance.DoanhThuTheoThang_DAL();
        }
        public DataTable DoanhThuTheoNam_BLL()
        {
            return DAO_ThongKe.Instance.DoanhThuTheoNam_DAL();
        }
        public DataTable TOP5SanPham_BLL()
        {
            return DAO_ThongKe.Instance.TOP5SanPham_DAL();
        }
        public DataTable TopNVCuaThang_BLL()
        {
            return DAO_ThongKe.Instance.TopNVCuaThang_DAL();
        }
        public DataTable TopLoaiHH_BLL()
        {
            return DAO_ThongKe.Instance.TopLoaiHH_DAL();
        }
    }
}
