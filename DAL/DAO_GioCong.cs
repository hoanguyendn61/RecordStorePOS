using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RetailStore.DTO;
namespace RetailStore.DAL
{
    public class DAO_GioCong
    {
        private static DAO_GioCong _Instance;
        public static DAO_GioCong Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAO_GioCong();
                }
                return _Instance;
            }
            private set { }
        }
        private DAO_GioCong()
        {
        }
        string formatNgay = "yyyy-MM-dd";
        string formatGio = "hh\\:mm";

        public List<GioCong> GetListGioCong_DAL(DateTime from, DateTime to)
        {
            List<GioCong> list = new List<GioCong>();
            string query = "EXEC dbo.PROC_GetListGioCong @date1 = '"+from.ToString(formatNgay) +"' , @date2 = '"+to.ToString(formatNgay) +"' ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                GioCong time = new GioCong(item);
                list.Add(time);
            }
            return list;
        }
        public bool InsertTime_DAL(GioCong t)
        {
            int kq = 0;
            string query = "INSERT dbo.GIOCONG (MaNV, GioVao, GioRa, NgayLamViec) VALUES ( @manv , @in , @out , @date )";
            kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { t.Mã_NV, t.Giờ_Vào.ToString(formatGio), t.Giờ_Ra.ToString(formatGio), t.Ngày_Làm_Việc.ToString(formatNgay) });
            return kq > 0;
        }
    }
}
