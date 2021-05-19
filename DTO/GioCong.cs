using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStore.DTO
{
    public class GioCong 
    {
        private NhanVien nv = new NhanVien();
        public GioCong(NhanVien nv, TimeSpan gioVao, TimeSpan gioRa, DateTime ngayLam)
        {
            this.nv.Mã_NViên = nv.Mã_NViên;
            this.Giờ_vào = gioVao;
            this.Giờ_ra = gioRa;
            this.Ngày_làm_việc = ngayLam;
        }
        public GioCong(DataRow row)
        {
            this.TimeID = Convert.ToInt32(row["TimeID"]);
            this.Tên_NV = row["TenNV"].ToString();
            this.Ngày_làm_việc = (DateTime)row["NgayLamViec"];
            this.Giờ_vào = (TimeSpan)row["GioVao"];
            this.Giờ_ra = (TimeSpan)row["GioRa"];
            this.Tổng_giờ = (float)Convert.ToDouble(row["TongGio"]);
        }
        public GioCong() { }
        private int _timeID;
        public int TimeID { get => _timeID; set => _timeID = value; }
        public string Tên_NV { get => nv.Tên; set => nv.Tên = value; }
        private DateTime _ngayLam; 
        public DateTime Ngày_làm_việc { get => _ngayLam; set => _ngayLam = value; }
        private TimeSpan _gioVao;
        public TimeSpan Giờ_vào { get => _gioVao; set => _gioVao = value; }
        private TimeSpan _gioRa; 
        public TimeSpan Giờ_ra { get => _gioRa; set => _gioRa = value; }
        private float _tongGio;
        public float Tổng_giờ { get => _tongGio; set => _tongGio = value; }
        internal NhanVien Nv { get => nv; set => nv = value; }
    }
}
