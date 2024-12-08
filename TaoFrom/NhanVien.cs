using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaoFrom
{
    internal class NhanVien
    {
        public string MSNV { get; set; }
        public string TenNV { get; set; }
        public decimal LuongCB { get; set; }

        public NhanVien(string msnv, string tenNv, decimal luongCb)
        {
            MSNV = msnv;
            TenNV = tenNv;
            LuongCB = luongCb;
        }
    }
}
