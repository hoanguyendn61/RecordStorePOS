using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStore.DTO
{
    public class DangNhap
    {
        public DangNhap()
        {
        }
        public DangNhap(string taiKHOAN, string matKHAU, Boolean tkType)
        {
            this.Tên_tài_khoản = taiKHOAN;
            this.Mật_khẩu = matKHAU;
            this.Loại_tài_khoản = tkType;
        }
        public DangNhap(DataRow row)
        {
            this.Tên_tài_khoản = (string)row["TaiKhoan"];
            this.Mật_khẩu = (string)row["MatKhau"];
            this.Loại_tài_khoản = Convert.ToBoolean(row["TkType"]);
        }
        private string taikhoan;
        public string Tên_tài_khoản
        {
            get { return taikhoan; }
            set { taikhoan = value; }
        }
        private string matkhau;
        public string Mật_khẩu
        {
            get { return matkhau; }
            set { matkhau = value; }
        }
        private Boolean tktype;
        public Boolean Loại_tài_khoản
        {
            get { return tktype; }
            set { tktype = value; }
        }
    }
}
