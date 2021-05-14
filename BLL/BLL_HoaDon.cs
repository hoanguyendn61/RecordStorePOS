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
        public string FindReceiptKeyMax_BLL()
        {
            return DAO_HoaDon.Instance.FindReceiptKeyMax_DAL();
        }
        public bool InsertHoaDon_BLL(HoaDon hoaDon)
        {
            return DAO_HoaDon.Instance.InsertHoaDon_DAL(hoaDon);
        }
        public DataTable PrintHoaDon_BLL(string maHD)
        {
            return DAO_HoaDon.Instance.PrintHoaDon_DAL(maHD);
        }
    }
}
