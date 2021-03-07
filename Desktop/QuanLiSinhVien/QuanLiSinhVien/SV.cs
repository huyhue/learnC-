using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien
{
   public class SV 
    {
        public int MSSV { get; set; }
        public string NameSV { get; set; }
        public string lop { get; set; }
        public DateTime ngaysinh { get; set; }
        public bool gender { get; set; }

        public SV(int v1, string v2, string v3, DateTime now, bool v4)
        {
            MSSV = v1;
            NameSV = v2;
            lop = v3;
            ngaysinh = now;
            gender = v4;
        }

    }
}
