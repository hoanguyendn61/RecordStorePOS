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
            this.Tên = name;
            this.Địa_chỉ = dc;
            this.SĐT = sdt;
            this.Email = email;
        }
        public NhaCungCap(DataRow row)
        {
            this.Mã_NCC = (string)row["MaNCC"];
            this.Tên = (string)row["TenNCC"];
            this.Địa_chỉ = (string)row["DcNCC"];
            this.SĐT = (string)row["SdtNCC"];
            this.Email = (string)row["EmailNCC"];
        }
        public NhaCungCap() { }
        public string Mã_NCC { get; set; }
        public string Tên { get; set; }
        public string Địa_chỉ { get; set; }
        public string SĐT { get; set; }
        public string Email { get; set; }
        public static int Compare_NameAZ(NhaCungCap p1, NhaCungCap p2)
        {
            return p1.Tên.CompareTo(p2.Tên);
        }
        public static int Compare_NameZA(NhaCungCap p1, NhaCungCap p2)
        {
            return p2.Tên.CompareTo(p1.Tên);
        }
    }
}
