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
        public GioCong(NhanVien nv, TimeSpan gioVao, TimeSpan gioRa, DateTime ngayLam)
        {
            this.Mã_NV = nv.Mã_NViên;
            this.Tên_NV = nv.Tên;
            this.Giờ_Vào = gioVao;
            this.Giờ_Ra = gioRa;
            this.Ngày_Làm_Việc = ngayLam;
        }
        public GioCong(DataRow row)
        {
            this.TimeID = Convert.ToInt32(row["TimeID"]);
            this.Tên_NV = row["TenNV"].ToString();
            this.Ngày_Làm_Việc = (DateTime)row["NgayLamViec"];
            this.Giờ_Vào = (TimeSpan)row["GioVao"];
            this.Giờ_Ra = (TimeSpan)row["GioRa"];
            this.Tổng_Giờ = (float)Convert.ToDouble(row["TongGio"]);
        }
        public GioCong() { }
        private int _timeID;
        public int TimeID { get => _timeID; set => _timeID = value; }
        private string _maNV;
        public string Mã_NV { get => _maNV; set => _maNV = value; }
        private string _tenNV;
        public string Tên_NV { get => _tenNV; set => _tenNV = value; }
        private DateTime _ngayLam; 
        public DateTime Ngày_Làm_Việc { get => _ngayLam; set => _ngayLam = value; }
        private TimeSpan _gioVao;
        public TimeSpan Giờ_Vào { get => _gioVao; set => _gioVao = value; }
        private TimeSpan _gioRa; 
        public TimeSpan Giờ_Ra { get => _gioRa; set => _gioRa = value; }
        private float _tongGio;
        public float Tổng_Giờ { get => _tongGio; set => _tongGio = value; }
    }
}
