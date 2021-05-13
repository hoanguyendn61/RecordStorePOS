﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RetailStore.DAL;
using RetailStore.DTO;
namespace RetailStore.BLL
{
    public class BLL_NhanVien
    {
        public delegate int MyCompare(NhanVien p1, NhanVien p2);
        private static BLL_NhanVien _Instance;
        public static BLL_NhanVien Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_NhanVien();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_NhanVien()
        {
        }
        public NhanVien GetEmployeeByUsername_BLL(string username)
        {
            return DAO_NhanVien.Instance.GetEmployeeByUsername_DAL(username);
        }
        public List<NhanVien> GetListEmployees_BLL()
        {
            return DAO_NhanVien.Instance.GetListEmployees_DAL();
        }
        public bool InsertEmployee_BLL(NhanVien nv, DangNhap tk)
        {
            return DAO_NhanVien.Instance.InsertEmployee_DAL(nv, tk);
        }
        public bool UpdateEmployee_BLL(NhanVien nv, DangNhap dn)
        {
            return DAO_NhanVien.Instance.UpdateEmployee_DAL(nv, dn);
        }
        public bool DeleteEmployee_BLL(string tentk)
        {
            if (tentk != "admin" && tentk != frmDangnhap.nv.Tên_tài_khoản)
            {
                return BLL_DangNhap.Instance.DeleteAccount_BLL(GetEmployeeByUsername_BLL(tentk));
            } 
            else 
            {
                return false;
            }
        }
        public bool CheckUsername_BLL(List<string> Usernames, string username)
        {
            foreach(string i in Usernames)
            {
                if(i == username)
                {
                    return true;
                }
            }
            return false;
        }
        public string FindEmployeeMaxKey_BLL()
        {
            string maNVmax = "NV000";
            foreach (NhanVien i in GetListEmployees_BLL())
            {
                if (String.Compare(maNVmax, i.Mã_NViên) < 0)
                {
                    maNVmax = i.Mã_NViên;
                }
            }
            return maNVmax;
        }
        public bool ResetEmployeePassword_BLL(string tkNV)
        {
            return DAO_NhanVien.Instance.ResetEmployeePassword_DAL(tkNV);
        }
        public List<NhanVien> GetEmployeeByName_BLL(string Name)
        {
            List<NhanVien> data = new List<NhanVien>();
            foreach (NhanVien i in GetListEmployees_BLL())
            {
                if (Name != "")
                {
                    if (i.Tên.IndexOf(Name, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        data.Add(new NhanVien
                        {
                            Mã_NViên = i.Mã_NViên,
                            Tên = i.Tên,
                            Địa_chỉ = i.Địa_chỉ,
                            SĐT = i.SĐT,
                            CMND = i.CMND,
                            Ngày_bắt_đầu = i.Ngày_bắt_đầu,
                            Tên_tài_khoản = i.Tên_tài_khoản,
                            Loại_tài_khoản = i.Loại_tài_khoản
                        });
                    }
                }
            }
            return data;
        }
        public List<NhanVien> SortListSupplier_BLL(MyCompare cmp)
        {
            List<NhanVien> LNV = GetListEmployees_BLL();
            LNV.Sort(new Comparison<NhanVien>(cmp));
            return LNV;
        }
    }
}
