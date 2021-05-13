using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace RetailStore.DTO
{
    public class NhanVien : DangNhap
    {
        public NhanVien(string maNV, string name, string dcNV, string SdtNV, string CmndNV, float LuongNV, DateTime ngayBD, DangNhap tkdn)
        {
            this.Mã_NViên = maNV;
            this.Tên = name;
            this.Địa_chỉ = dcNV;
            this.SĐT = SdtNV;
            this.CMND = CmndNV;
            this.Ngày_bắt_đầu = ngayBD;
            this.Lương_NV = LuongNV;
            this.Tên_tài_khoản = tkdn.Tên_tài_khoản;
            this.Mật_khẩu = tkdn.Mật_khẩu;
            this.Loại_tài_khoản = tkdn.Loại_tài_khoản;
        }
        public NhanVien(DataRow row)
        {
            this.Mã_NViên = (string)row["MaNV"];
            this.Tên = row["TenNV"].ToString();
            this.Địa_chỉ = (string)row["DcNV"];
            this.SĐT = (string)row["SdtNV"];
            this.CMND = (string)row["CmndNV"].ToString();
            this.Lương_NV = (float)Convert.ToDouble(row["LuongNV"].ToString());
            this.Ngày_bắt_đầu = (DateTime)row["NgayBDNV"];
            this.Tên_tài_khoản = (string)row["TaiKhoan"];
            this.Mật_khẩu = (string)row["MatKhau"];
            this.Loại_tài_khoản = Convert.ToBoolean(row["TkType"]);
        }
        public NhanVien() { }
        
        private string maNV;
        public string Mã_NViên
        {
            get { return maNV; }
            set { maNV = value; }
        }
        private string name;
        public string Tên
        {
            get { return name; }
            set { name = value; }
        }
        private string DcNV;
        public string Địa_chỉ
        {
            get { return DcNV; }
            set { DcNV = value; }
        }
        private string sdtNV;
        public string SĐT
        {
            get { return sdtNV; }
            set { sdtNV = value; }
        }
        private string cmndNV;
        public string CMND
        {
            get { return cmndNV; }
            set { cmndNV = value; }
        }
        private float luongNV;
        public float Lương_NV
        {
            get { return luongNV; }
            set { luongNV = value; }
        }
        private DateTime ngaybd;
        public DateTime Ngày_bắt_đầu
        {
            get { return ngaybd; }
            set { ngaybd = value; }
        }
        public static int Compare_NameAZ(NhanVien p1, NhanVien p2)
        {
            return p1.name.CompareTo(p2.name);
        }
        public static int Compare_NameZA(NhanVien p1, NhanVien p2)
        {
            return p2.name.CompareTo(p1.name);
        }
        public static int Compare_DateEL(NhanVien p1, NhanVien p2)
        {
            return p1.ngaybd.CompareTo(p2.ngaybd);
        }
        public static int Compare_DateLE(NhanVien p1, NhanVien p2)
        {
            return p2.ngaybd.CompareTo(p1.ngaybd);
        }
    }
}
