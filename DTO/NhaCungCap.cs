using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStore.DTO
{
    public class NhaCungCap
    {
        public NhaCungCap(string id, string name, string dc, string sdt, string email)
        {
            this.Mã_NCC = id;
            this.Tên_NCC = name;
            this.Đc_NCC = dc;
            this.Sdt_NCC = sdt;
            this.Email_NCC = email;
        }
        public NhaCungCap(DataRow row)
        {
            this.Mã_NCC = (string)row["MaNCC"];
            this.Tên_NCC = (string)row["TenNCC"];
            this.Đc_NCC = (string)row["DcNCC"];
            this.Sdt_NCC = (string)row["SdtNCC"];
            this.Email_NCC = (string)row["EmailNCC"];
        }
        public NhaCungCap() { }
        public string Mã_NCC { get; set; }
        public string Tên_NCC { get; set; }
        public string Đc_NCC { get; set; }
        public string Sdt_NCC { get; set; }
        public string Email_NCC { get; set; }
        public static int Compare_NameAZ(NhaCungCap p1, NhaCungCap p2)
        {
            return p1.Tên_NCC.CompareTo(p2.Tên_NCC);
        }
        public static int Compare_NameZA(NhaCungCap p1, NhaCungCap p2)
        {
            return p2.Tên_NCC.CompareTo(p1.Tên_NCC);
        }
    }
}
