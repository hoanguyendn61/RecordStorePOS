using RetailStore.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace RetailStore.DAL
{
    public class DAO_HangHoa
    {
        private static DAO_HangHoa instance;
        public static DAO_HangHoa Instance
        {
            get { if (instance == null) instance = new DAO_HangHoa(); return DAO_HangHoa.instance; }
            private set { DAO_HangHoa.instance = value; }
        }
        private DAO_HangHoa() { }
        public List<HangHoa> GetListProducts_DAL()
        {
            List<HangHoa> list = new List<HangHoa>();
            string query = "EXEC dbo.GetListProducts";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                HangHoa hangHoa = new HangHoa(item);
                list.Add(hangHoa);
            }
            return list;
        }
        public List<HangHoa> GetListProducts_DAL(string categoryName)
        {
            List<HangHoa> data = new List<HangHoa>();
            if (categoryName == "Tất cả")
            {
                data = GetListProducts_DAL();
            }
            else
            {
                foreach (HangHoa i in GetListProducts_DAL())
                {
                    if (i.Loại == categoryName)
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
        private string format = "yyyy-MM-dd HH:mm:ss";
        public bool InsertProduct_DAL(HangHoa hangHoa)
        {
            string updateAt = hangHoa.Cập_nhật.ToString(format);
            string query = "INSERT dbo.HANGHOA (MaHH, TenHH, MaL, QtyHH, GiaVonHH, DonGiaHH, UpdateAt, GhiChuHH, MaNCC)" +
                "VALUES ( @maHH , @tenHH , @maL , @qtyHH , @giaVon , @donGia , @updateAt , @ghiChuHH , @maNCC )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { hangHoa.Mã_hàng, hangHoa.Tên, hangHoa.Cat.Mã_Loại, hangHoa.SL, hangHoa.Giá_vốn, hangHoa.Đơn_giá, updateAt, hangHoa.Ghi_chú, hangHoa.Sup.Mã_NCC});
            return result > 0;
        }
        public bool UpdateProduct_DAL(HangHoa hangHoa)
        {
            string updateAt = hangHoa.Cập_nhật.ToString(format);
            string query = string.Format("UPDATE dbo.HANGHOA SET TenHH = @tenHH , MaL = @maL , QtyHH = @sl , GiaVonHH = @giaVon , DonGiaHH = @donGia ,  UpdateAt = @updateAt , GhiChuHH = @ghiChu , MaNCC = @maNCC WHERE MaHH = @maHH ");
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {hangHoa.Tên, hangHoa.Cat.Mã_Loại, hangHoa.SL, hangHoa.Giá_vốn, hangHoa.Đơn_giá, updateAt, hangHoa.Ghi_chú, hangHoa.Sup.Mã_NCC, hangHoa.Mã_hàng});
            return result > 0;
        }
        public bool DeleteProduct_DAL(string idProduct)
        {
            string query = string.Format("Delete FROM dbo.HANGHOA WHERE MaHH = '{0}'", idProduct);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public HangHoa GetProductByID_DAL(string id)
        {
            string query = "EXEC dbo.GetProduct @maHH = '" + id + "'";
            return new HangHoa(DataProvider.Instance.ExecuteQuery(query).Rows[0]);
        }
        
    }
}
