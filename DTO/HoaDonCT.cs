using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStore.DTO
{
    public class HoaDonCT : HoaDon
    {
        public HoaDonCT(HoaDon hd, string maHH, int salesdc, int qtyHD)
        {
            this.Mã_HĐơn = hd.Mã_HĐơn;
            this.Mã_KHàng = hd.Mã_KHàng;
            this.Mã_NViên = hd.Mã_NViên;
            this.Ngày_GD = hd.Ngày_GD;
            this.Mã_Hàng = maHH;
            this.Giảm_giá = salesdc;
            this.SL = qtyHD;
        }
        private string MaHH;
        public string Mã_Hàng
        {
            get { return MaHH; }
            set { MaHH = value; }
        }
        private int Discount;
        public int Giảm_giá
        {
            get { return Discount; }
            set { Discount = value; }
        }
        private int Qty;
        public int SL
        {
            get {return Qty ;}
            set { Qty = value ;}
        }
    }
}
