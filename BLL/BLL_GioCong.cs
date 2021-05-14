using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RetailStore.DAL;
using RetailStore.DTO;
namespace RetailStore.BLL
{
    public class BLL_GioCong
    {
        private static BLL_GioCong _Instance;
        public static BLL_GioCong Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_GioCong();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_GioCong()
        {
        }
        public List<GioCong> GetListGioCong_BLL(DateTime f, DateTime t)
        {
            return DAO_GioCong.Instance.GetListGioCong_DAL(f, t);
        }
        public List<GioCong> GetListGioCong_BLL(DateTime f, DateTime t, string id)
        {
            return DAO_GioCong.Instance.GetListGioCong_DAL(f, t, id);
        }
        public bool InsertTime_BLL(GioCong t)
        {
            return DAO_GioCong.Instance.InsertTime_DAL(t);
        }
        public bool UpdateTime_BLL(GioCong t, int id)
        {
            return DAO_GioCong.Instance.UpdateTime_DAL(t, id);
        }
        public bool DeleteTime_BLL(int id)
        {
            return DAO_GioCong.Instance.DeleteTime_DAL(id);
        }
    }
}
