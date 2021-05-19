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
        private LoaiHang cat = new LoaiHang();
        private NhaCungCap sup = new NhaCungCap();
        public HangHoa(string id, string name, string categoryID, int qty, float cost, float price, DateTime updateAt, string ghichu, string idncc)
        {
            this.Mã_hàng = id;
            this.Tên = name;
            this.Cat.Mã_Loại = categoryID;
            this.SL = qty;
            this.Giá_vốn = cost;
            this.Đơn_giá = price;
            this.Cập_nhật = updateAt;
            this.Ghi_chú = ghichu;
            this.Sup.Mã_NCC = idncc;
        }
        public HangHoa() { }
        public HangHoa(DataRow row)
        {
            this.Mã_hàng = (string)row["MaHH"];
            this.Tên = row["TenHH"].ToString();
            this.Loại = (string)row["LoaiHH"];
            this.SL = (int)Convert.ToDouble(row["QtyHH"].ToString());
            this.Giá_vốn = (float)Convert.ToDouble(row["GiaVonHH"].ToString());
            this.Đơn_giá = (float)Convert.ToDouble(row["DonGiaHH"].ToString());
            this.Nhà_cung_cấp = (string)row["TenNCC"];
            this.Cập_nhật = (DateTime)row["UpdateAt"];
            this.Ghi_chú = (string)row["GhiChuHH"];
        }
        private string iD;
        public string Mã_hàng
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
        public string Loại
        {
            get { return cat.Tên_Loại; }
            set { cat.Tên_Loại = value; }
        }
        private int qty;
        public int SL
        {
            get { return qty; }
            set { qty = value; }
        }
        private float cost;
        public float Giá_vốn
        {
            get { return cost; }
            set { cost = value; }
        }
        private float price;
        public float Đơn_giá
        {
            get { return price; }
            set { price = value; }
        }
        private DateTime updateDate;
        public DateTime Cập_nhật
        {
            get { return updateDate; }
            set { updateDate = value; }
        }
        private string ghichu;
        public string Ghi_chú
        {
            get { return ghichu; }
            set { ghichu = value; }
        }
        public string Nhà_cung_cấp { get => sup.Tên; set => sup.Tên = value; }
        internal LoaiHang Cat { get => cat; set => cat = value; }
        internal NhaCungCap Sup { get => sup; set => sup = value; }

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

