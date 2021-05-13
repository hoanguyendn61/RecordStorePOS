using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Policy;
using System.Windows.Forms;
namespace RetailStore.DTO
{
    public class HangHoa 
    {
        public HangHoa(string id, string name, string categoryID, int qty, float cost, float price, DateTime updateAt, string ghichu, string idncc)
        {
            this.Mã_Hàng = id;
            this.Tên = name;
            this.Loại = categoryID;
            this.Số_Lượng = qty;
            this.Giá_Vốn = cost;
            this.Đơn_Giá = price;
            this.Cập_Nhật = updateAt;
            this.Ghi_Chú = ghichu;
            this.Nhà_Cung_Cấp = idncc;
        }
        public HangHoa() { }
        public HangHoa(DataRow row)
        {
            this.Mã_Hàng = (string)row["MaHH"];
            this.Tên = row["TenHH"].ToString();
            this.Loại = (string)row["LoaiHH"];
            this.Số_Lượng = (int)Convert.ToDouble(row["QtyHH"].ToString());
            this.Giá_Vốn = (float)Convert.ToDouble(row["GiaVonHH"].ToString());
            this.Đơn_Giá = (float)Convert.ToDouble(row["DonGiaHH"].ToString());
            this.Nhà_Cung_Cấp = (string)row["TenNCC"];
            this.Cập_Nhật = (DateTime)row["UpdateAt"];
            this.Ghi_Chú = (string)row["GhiChuHH"];
        }
        private string iD;
        public string Mã_Hàng
        {
            get { return iD; }
            set { iD = value; }
        }
        private string name;
        public string Tên
        {
            get { return name; }
            set { name = value; }
        }
        private string categoryID;
        public string Loại
        {
            get { return categoryID; }
            set { categoryID = value; }
        }
        private int qty;
        public int Số_Lượng
        {
            get { return qty; }
            set { qty = value; }
        }
        private float cost;
        public float Giá_Vốn
        {
            get { return cost; }
            set { cost = value; }
        }
        private float price;
        public float Đơn_Giá
        {
            get { return price; }
            set { price = value; }
        }
       
        private DateTime updateDate;
        public DateTime Cập_Nhật
        {
            get { return updateDate; }
            set { updateDate = value; }
        }
        private string ghichu;
        public string Ghi_Chú
        {
            get { return ghichu; }
            set { ghichu = value; }
        }
        private string idncc;
        public string Nhà_Cung_Cấp { get => idncc; set => idncc = value; }
        public static int Compare_IDAscending(HangHoa p1, HangHoa p2)
        {
            return p1.iD.CompareTo(p2.iD);
        }
        public static int Compare_PriceAscending(HangHoa p1, HangHoa p2)
        {
            return p1.price.CompareTo(p2.price);
        }
        public static int Compare_PriceDescending(HangHoa p1, HangHoa p2)
        {
            return p2.price.CompareTo(p1.price);
        }
        public static int Compare_NameAZ(HangHoa p1, HangHoa p2)
        {
            return p1.name.CompareTo(p2.name);
        }
        public static int Compare_NameZA(HangHoa p1, HangHoa p2)
        {
            return p2.name.CompareTo(p1.name);
        }
        public static int Compare_DateEL(HangHoa p1, HangHoa p2)
        {
            return p1.updateDate.CompareTo(p2.updateDate);
        }
        public static int Compare_DateLE(HangHoa p1, HangHoa p2)
        {
            return p2.updateDate.CompareTo(p1.updateDate);
        }
    }
}

