using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RetailStore.DAL;
using RetailStore.DTO;
namespace RetailStore.BLL
{
    public class BLL_KhachHang
    {
        public delegate int MyCompare(KhachHang p1, KhachHang p2);
        private static BLL_KhachHang _Instance;
        public static BLL_KhachHang Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_KhachHang();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_KhachHang()
        {
        }
        public List<KhachHang> GetListCustomers_BLL()
        {
            return DAO_KhachHang.Instance.GetListCustomers_DAL();
        }
        public bool InsertCustomer_BLL(KhachHang khachHang)
        {
            return DAO_KhachHang.Instance.InsertCustomer_DAL(khachHang);
        }
        public bool UpdateCustomer_BLL(KhachHang khachHang)
        {
            return DAO_KhachHang.Instance.UpdateCustomer_DAL(khachHang);
        }
        public bool DeleteCustomer_BLL(string maKH)
        {
            return DAO_KhachHang.Instance.DeleteCustomer_DAL(maKH);
        }
        public string FindCustomerMaxKey_BLL()
        {
            string maKHmax = "KH0001";
            foreach(KhachHang i in GetListCustomers_BLL())
            {
                if(String.Compare(maKHmax, i.Mã_KHàng) < 0)
                {
                    maKHmax = i.Mã_KHàng;
                }
            }
            return maKHmax;
        }
        public List<KhachHang> GetCustomerByName(string Name)
        {
            List<KhachHang> data = new List<KhachHang>();
            foreach (KhachHang i in GetListCustomers_BLL())
            {
                if (Name != "")
                {
                    if (i.Tên.IndexOf(Name, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        data.Add(new KhachHang
                        {
                           Mã_KHàng = i.Mã_KHàng,
                           Tên = i.Tên,
                           SĐT = i.SĐT,
                        });
                    }
                }
            }
            return data;
        }
        public List<KhachHang> SortListCustomer_BLL(MyCompare cmp)
        {
            List<KhachHang> LKH = GetListCustomers_BLL();
            LKH.Sort(new Comparison<KhachHang>(cmp));
            return LKH;
        }
        public int SLKhachHang_BLL()
        {
             return GetListCustomers_BLL().Count - 1;
        }
    }
}
