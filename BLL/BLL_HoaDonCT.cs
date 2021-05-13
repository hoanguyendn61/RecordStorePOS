using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
