using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RetailStore.DTO;
namespace RetailStore.DAL
{
    public class DAO_LoaiHang
    {
        private static DAO_LoaiHang instance;

        public static DAO_LoaiHang Instance
        {
            get { if (instance == null) instance = new DAO_LoaiHang(); return DAO_LoaiHang.instance; }
            private set { DAO_LoaiHang.instance = value; }
        }

        private DAO_LoaiHang() { }

        public List<LoaiHang> GetListCategory_DAL()
        {
            List<LoaiHang> list = new List<LoaiHang>();

            string query = "SELECT * FROM LOAIHANG";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                LoaiHang category = new LoaiHang(item);
                list.Add(category);
            }
            return list;
        }
        public LoaiHang GetCategoryByID_DAL(string id)
        {
            LoaiHang category = null;
            string query = "select * from LOAIHANG where MaL = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                category = new LoaiHang(item);
                return category;
            }
            return category;
        }
    }
}
