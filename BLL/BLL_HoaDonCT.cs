using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RetailStore.DAL;
using RetailStore.DTO;
namespace RetailStore.BLL
{
    public class BLL_HoaDonCT
    {
        private static BLL_HoaDonCT _Instance;
        public static BLL_HoaDonCT Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_HoaDonCT();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_HoaDonCT()
        {
        }
        public List<HoaDonCT> GetListHDCT_BLL(string idHD)
        {
            return DAO_HoaDonCT.Instance.GetListHDCT_DAL(idHD);
        }
        public bool InsertHoaDonCT_BLL(HoaDonCT hoaDonCT)
        {
            return DAO_HoaDonCT.Instance.InsertHoaDonCT_DAL(hoaDonCT);
        }
    }
}
