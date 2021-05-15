using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RetailStore.BLL;
namespace RetailStore.DTO
{
    public class HoaDonCT //: HoaDon
    {
        public HoaDonCT(HoaDon hd, string maHH, int salesdc, int qtyHD)
        {
            this.Mã_HĐ = hd.Mã_HĐơn;
            this.Mã_HH = maHH;
            this.Giảm_giá = salesdc;
            this.SL = qtyHD;
        }
        public HoaDonCT(DataRow row)
        {
            this.Mã_HH = (string)row["MaHH"];
            this.Tên_HH = (string)row["TenHH"];
            this.SL = Convert.ToInt32(row["QtyHD"].ToString());
            this.Đơn_giá = (float)Convert.ToDouble(row["DonGiaHH"]);
            this.Giảm_giá = Convert.ToInt32(row["SalesDc"]);
            this.Thành_tiền = Convert.ToDouble(row["ThanhTien"]);
        }
        private HoaDon hoaDon = new HoaDon();
        public string Mã_HĐ { get => hoaDon.Mã_HĐơn; set => hoaDon.Mã_HĐơn = value; }
        private HangHoa p = new HangHoa();
        public string Mã_HH { get => p.Mã_Hàng; set => p.Mã_Hàng = value; }
        public string Tên_HH { get => p.Tên; set => p.Tên = value; }
        public float Đơn_giá { get => p.Đơn_Giá; set => p.Đơn_Giá = value; }
        private int Qty;
        public int SL
        {
            get { return Qty; }
            set { Qty = value; }
        }
        private int Discount;
        public int Giảm_giá
        {
            get { return Discount; }
            set { Discount = value; }
        }
        private double thanhTien;
        public double Thành_tiền { get => thanhTien; set => thanhTien = value; }
    }
}
