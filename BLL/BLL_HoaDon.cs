﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RetailStore.DAL;
namespace RetailStore.BLL
{
    public class BLL_HoaDon
    {
        private static BLL_HoaDon _Instance;
        public static BLL_HoaDon Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_HoaDon();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_HoaDon()
        {
        }
        public string FindReceiptKeyMax_BLL()
        {
            return DAO_HoaDon.Instance.FindReceiptKeyMax_DAL();
        }
    }
}
