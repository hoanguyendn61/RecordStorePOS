using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RetailStore.DAL;
using RetailStore.DTO;
namespace RetailStore.BLL
{
    public class BLL_NhaCungCap
    {
        public delegate int MyCompare(NhaCungCap p1, NhaCungCap p2);
        private static BLL_NhaCungCap _Instance;
        public static BLL_NhaCungCap Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_NhaCungCap();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_NhaCungCap()
        {
        }
        public List<NhaCungCap> GetListSuppliers_BLL()
        {
            return DAO_NhaCungCap.Instance.GetListSuppliers_DAL(); 
        }
        public bool InsertSupplier_BLL(NhaCungCap sup)
        {
            return DAO_NhaCungCap.Instance.InsertSupplier_DAL(sup);
        }
        public bool UpdateSupplier_BLL(NhaCungCap sup)
        {
            return DAO_NhaCungCap.Instance.UpdateSupplier_DAL(sup);

        }
        public bool DeleteSupplier_BLL(string idSup)
        {
            return DAO_NhaCungCap.Instance.DeleteSupplier_DAL(idSup);

        }
        public string FindSupplierMaxKey_BLL()
        {
            string maSupMax = "NCC001";
            foreach(NhaCungCap i in GetListSuppliers_BLL())
            {
                if(String.Compare(maSupMax, i.Mã_NCC) < 0)
                {
                    maSupMax = i.Mã_NCC;
                }
            }
            return maSupMax;
        }
        public NhaCungCap GetSupplierByID_BLL(string id)
        {
            return DAO_NhaCungCap.Instance.GetSupplierByID_DAL(id);
        }
        public List<NhaCungCap> GetSupplierByName_BLL(string Name)
        {
            List<NhaCungCap> data = new List<NhaCungCap>();
            foreach (NhaCungCap i in GetListSuppliers_BLL())
            {
                if (Name != "")
                {
                    if (i.Tên.IndexOf(Name, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        data.Add(new NhaCungCap
                        {
                            Mã_NCC = i.Mã_NCC,
                            Tên = i.Tên,
                            Địa_chỉ = i.Địa_chỉ,
                            SĐT = i.SĐT,
                            Email = i.Email
                        });
                    }
                }
            }
            return data;
        }
        public List<NhaCungCap> SortListSupplier_BLL(MyCompare cmp)
        {
            List<NhaCungCap> LNCC = GetListSuppliers_BLL();
            LNCC.Sort(new Comparison<NhaCungCap>(cmp));
            return LNCC;
        }
    }
}
