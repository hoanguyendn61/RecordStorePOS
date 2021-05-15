using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStore.DTO
{
    public class HoaDon
    {
        private NhanVien nv = new NhanVien();
        private KhachHang kh = new KhachHang();
        public HoaDon() { }
        public HoaDon(string maHD, DateTime ngayGD, string maNV, string maKH, double total) 
        {
            this.Mã_HĐơn = maHD;
            this.Nv.Mã_NViên = maNV;
            this.Kh.Mã_KHàng = maKH;
            this.Ngày_GD = ngayGD;
            this.Tổng_cộng = total;
        }
        public HoaDon(DataRow row)
        {
            this.Mã_HĐơn = (string)row["MaHD"];
            this.Tên_người_bán = (string)row["TenNV"];
            this.Ngày_GD = Convert.ToDateTime(row["NgayGD"]);
            this.Tổng_cộng = (float)Convert.ToDouble(row["TongCong"]);
        }
        private string MaHD;
        public string Mã_HĐơn { get => MaHD; set => MaHD = value; }
        public string Tên_người_bán { get => Nv.Tên; set => Nv.Tên = value; }
        private DateTime NgayGD;
        public DateTime Ngày_GD
        {
            get { return NgayGD; }
            set { NgayGD = value; }
        }
        private double _tongCong;
        public double Tổng_cộng
        {
            get { return _tongCong; }
            set { _tongCong = value; }
        }
        public NhanVien Nv { get => nv; set => nv = value; }
        public KhachHang Kh { get => kh; set => kh = value; }
    }
}
