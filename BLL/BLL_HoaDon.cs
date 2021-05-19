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
    public class BLL_HoaDon
    {
        private static BLL_HoaDon _Instance;
        public static BLL_HoaDon Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_HoaDon();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_HoaDon()
        {
        }
        public List<HoaDon> GetListHD_BLL()
        {
            return DAO_HoaDon.Instance.GetListHD_DAL();
        }
        public List<HoaDon> GetListHD_BLL(string idkh)
        {
            return DAO_HoaDon.Instance.GetListHD_DAL(idkh);
        }
        // Get list Hóa đơn between 2 dates
        public List<HoaDon> GetListHD_BLL(DateTime from, DateTime to)
        {
            return DAO_HoaDon.Instance.GetListHD_DAL(from, to);
        }
        // Get list Hóa đơn between 2 dates, filter: mã nhân viên, mã khách hàng
        public List<HoaDon> GetListHD_BLL(DateTime from, DateTime to, string idnv, string idkh)
        {
            List<HoaDon> list = new List<HoaDon>();
            if (idkh != "XX" && idnv == "XX")
            {
                // tất cả nhân viên, lọc theo khách hàng
                foreach (HoaDon i in DAO_HoaDon.Instance.GetListHD_DAL(from, to))
                {
                    if (i.Kh.Mã_KHàng == idkh)
                    {
                        list.Add(i);
                    }
                }
            } 
            else if(idnv != "XX" && idkh == "XX")
            {
                // tất cả khách hàng, lọc theo nhân viên
                foreach (HoaDon i in DAO_HoaDon.Instance.GetListHD_DAL(from, to))
                {
                    if (i.Nv.Mã_NViên == idnv)
                    {
                        list.Add(i);
                    }
                }
            }
            else
            {
                // lọc theo nhân viên và khách hàng
                foreach (HoaDon i in DAO_HoaDon.Instance.GetListHD_DAL(from, to))
                {
                    if (i.Nv.Mã_NViên == idnv && i.Kh.Mã_KHàng == idkh)
                    {
                        list.Add(i);
                    }
                }
            }
            return list;
        }
        public string FindReceiptKeyMax_BLL()
        {
            string maHDmax = "HD000000";
                foreach (HoaDon i in GetListHD_BLL())
                {
                    if (String.Compare(maHDmax, i.Mã_HĐơn) < 0)
                    {
                    maHDmax = i.Mã_HĐơn;
                    }
                }
            return maHDmax;
        }
        public bool InsertHoaDon_BLL(HoaDon hoaDon)
        {
            return DAO_HoaDon.Instance.InsertHoaDon_DAL(hoaDon);
        }
        public bool DeleteHD_BLL(string maHD)
        {
            return DAO_HoaDon.Instance.DeleteHD_DAL(maHD);
        }
        public DataTable PrintHoaDon_BLL(string maHD)
        {
            return DAO_HoaDon.Instance.PrintHoaDon_DAL(maHD);
        }
    }
}
