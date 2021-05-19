using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RetailStore.DTO;
using RetailStore.DAL;
namespace RetailStore.BLL
{
    public class BLL_HangHoa 
    {
        public delegate int MyCompare(HangHoa p1, HangHoa p2);
        private static BLL_HangHoa _Instance;
        public static BLL_HangHoa Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_HangHoa();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_HangHoa()
        {
        }
        public List<HangHoa> GetListProducts_BLL()
        {
            return DAO_HangHoa.Instance.GetListProducts_DAL();
        }
        public List<HangHoa> GetListProducts_BLL(string categoryName)
        {
            return DAO_HangHoa.Instance.GetListProducts_DAL(categoryName);
        }
        public HangHoa GetProductByID_BLL(string id)
        {
            return DAO_HangHoa.Instance.GetProductByID_DAL(id);
        }
        public int GetProductQuanityByID_BLL(string id)
        {
            int slHH = 0;
            foreach (HangHoa i in GetListProducts_BLL())
            {
                if(i.Mã_hàng == id)
                {
                    slHH = i.SL;
                }
            }
            return slHH;
        }
        public List<HangHoa> GetListProductDGV(List<string> LID)
        {
            List<HangHoa> data = new List<HangHoa>();
            foreach (string i in LID)
            {
                data.Add(BLL_HangHoa.Instance.GetProductByID_BLL(i));
            }
            return data;
        }
        public List<HangHoa> GetProductByName_BLL(string catName, string pName)
        {
            List<HangHoa> data = new List<HangHoa>();
            foreach (HangHoa i in GetListProducts_BLL(catName))
            {
                if (pName != "")
                {
                    if (i.Tên.IndexOf(pName, StringComparison.OrdinalIgnoreCase) >=0)
                    {
                        data.Add(new HangHoa
                        {
                            Mã_hàng = i.Mã_hàng,
                            Tên = i.Tên,
                            Loại = i.Loại,
                            SL = i.SL,
                            Giá_vốn = i.Giá_vốn,
                            Đơn_giá = i.Đơn_giá,
                            Cập_nhật = i.Cập_nhật,
                            Ghi_chú = i.Ghi_chú,
                            Nhà_cung_cấp = i.Nhà_cung_cấp
                        });
                    }
                }
            }
            return data;
        }
        public bool InsertProduct_BLL(HangHoa hangHoa)
        {
            return DAO_HangHoa.Instance.InsertProduct_DAL(hangHoa);
        }
        public bool UpdateProduct_BLL(HangHoa hangHoa)
        {
            return DAO_HangHoa.Instance.UpdateProduct_DAL(hangHoa);   
        }
        public bool DeleteProduct_BLL(string idHH)
        {
            return DAO_HangHoa.Instance.DeleteProduct_DAL(idHH);
        }
        public string FindProductMaxKey_BLL(LoaiHang cat)
        {
                string maHHMax = cat.Mã_Loại + "0001";
                foreach (HangHoa i in GetListProducts_BLL(cat.Tên_Loại))
                {
                    if (String.Compare(maHHMax, i.Mã_hàng) < 0)
                    {
                        maHHMax = i.Mã_hàng;
                    }
                }
            return maHHMax;
        }
        // Sorting using List<T>.Sort(Comparison<T>(T x, T y)))
        public List<HangHoa> SortListProduct_BLL(List<HangHoa> LHH, MyCompare cmp)
        {
            LHH.Sort(new Comparison<HangHoa>(cmp));
            return LHH;
        }
    }
}
