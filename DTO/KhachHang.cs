using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace RetailStore.DTO
{
    public class KhachHang
    {
        public KhachHang(string id, string name, string sdtKH)
        {
            this.Mã_KHàng = id;
            this.Tên = name;
            this.SĐT = sdtKH;
        }
        public KhachHang(DataRow row)
        {
            this.Mã_KHàng = (string)row["MaKH"];
            this.Tên = row["TenKH"].ToString();
            this.SĐT = (string)row["SdtKH"];
            this.Tổng_GD = Convert.ToDouble(row["TongGiaoDich"].ToString());
        }
        public KhachHang() { }
        private string id;
        public string Mã_KHàng
        {
            get { return id; }
            set { id = value; }
        }
        private string name;
        public string Tên
        {
            get { return name; }
            set { name = value; }
        }
        private string sdt;
        public string SĐT
        {
            get { return sdt; }
            set { sdt = value; }
        }
        private double _tongGD;
        public double Tổng_GD { get => _tongGD; set => _tongGD = value; }

        

        public static int Compare_NameAZ(KhachHang p1, KhachHang p2)
        {
            return p1.Tên.CompareTo(p2.Tên);
        }
        public static int Compare_NameZA(KhachHang p1, KhachHang p2)
        {
            return p2.Tên.CompareTo(p1.Tên);
        }
        public static int Compare_AmountSpentASC(KhachHang p1, KhachHang p2)
        {
            return p1.Tổng_GD.CompareTo(p2.Tổng_GD);
        }
        public static int Compare_AmountSpentDESC(KhachHang p1, KhachHang p2)
        {
            return p2.Tổng_GD.CompareTo(p1.Tổng_GD);
        }
    }
}
