using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace RetailStore.DTO
{
    public class LoaiHang
    {
        public LoaiHang(string id, string name)
        {
            this.Mã_Loại = id;
            this.Tên_Loại = name;
        }
        public LoaiHang(DataRow row)
        {
            this.Mã_Loại = (string)row["MaL"];
            this.Tên_Loại = (string)row["LoaiHH"];
        }
        public LoaiHang() { }
        private string iD;
        public string Mã_Loại
        {
            get { return iD; }
            set { iD = value; }
        }
        private string name;
        public string Tên_Loại
        {
            get { return name; }
            set { name = value; }
        }
        
    }
}
