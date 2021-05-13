using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RetailStore.DTO;
using RetailStore.DAL;
namespace RetailStore.BLL
{
    public class BLL_LoaiHang
    {
        private static BLL_LoaiHang _Instance;
        public static BLL_LoaiHang Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_LoaiHang();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_LoaiHang()
        {
        }
        public List<LoaiHang> GetListCategory_BLL()
        {
            return DAO_LoaiHang.Instance.GetListCategory_DAL();
        }
        public LoaiHang GetCategoryByID_BLL(string id)
        {
            return DAO_LoaiHang.Instance.GetCategoryByID_DAL(id);
        }
    }
}
