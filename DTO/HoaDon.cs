using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStore.DTO
{
    public class HoaDon
    {
        public HoaDon() { }
        public HoaDon(string maHD, DateTime ngayGD, string maNV, string maKH) 
        {
            this.Mã_HĐơn = maHD;
            this.Ngày_GD = ngayGD;
            this.Mã_NViên = maNV;
            this.Mã_KHàng = maKH;
        }
        private string MaHD;
        public string Mã_HĐơn
        {
            get { return MaHD ;}
            set {MaHD = value ;}
        }
        private DateTime NgayGD;
        public DateTime Ngày_GD
        {
            get { return NgayGD; }
            set { NgayGD = value; }
        }
        private string MaNV;
        public string Mã_NViên
        {
            get { return MaNV; }
            set { MaNV = value; }
        }
        private string MaKH;
        public string Mã_KHàng
        {
            get { return MaKH; }
            set { MaKH = value; }
        }
        private int TongTien;
        public int Tổng_tiền
        {
            get { return TongTien; }
            set { TongTien = value; }
        }
    }
}
