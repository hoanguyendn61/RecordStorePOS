using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RetailStore.DTO;
using RetailStore.DAL;
using System.Data;

namespace RetailStore.BLL
{
    public class BLL_DangNhap
    {
        public static Boolean type;
        private static BLL_DangNhap _Instance;
        public static BLL_DangNhap Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_DangNhap();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_DangNhap()
        {
        }

        public DangNhap Login_BLL(string username, string password)
        {
            return DAO_DangNhap.Instance.Login_DAL(username, password);
        }
        public List<DangNhap> GetListAccounts_BLL()
        {
            return DAO_DangNhap.Instance.GetListAccounts_DAL();
        }
        //public bool InsertAccount_BLL(string tenTK, string mkNV)
        //{
        //    return DAO_DangNhap.Instance.InsertAccount_DAL(tenTK, mkNV);
        //}
        public bool DeleteAccount_BLL(string tentk)
        {
            return DAO_DangNhap.Instance.DeleteAccount_DAL(tentk);
        }
        public bool UpdateAccount_BLL(DangNhap tk)
        {
            return DAO_DangNhap.Instance.UpdateAccount_DAL(tk);
        }
    }
}
