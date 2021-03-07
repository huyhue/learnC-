using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien
{
    class SVComparer : IComparer<SV>
    {
        public enum sortBy
        {
            MSSV,
            NameSV,
            lop,
            ngaysinh,
            gender
        }

        //Sort two employee Ages  
        public sortBy compareByFields = sortBy.MSSV;
        public int Compare(SV x, SV y)
        {
            switch (compareByFields)
            {
                case sortBy.MSSV:
                    return x.MSSV.CompareTo(y.MSSV);
                case sortBy.NameSV:
                    return x.NameSV.CompareTo(y.NameSV);
                case sortBy.lop:
                    return x.lop.CompareTo(y.lop);
                case sortBy.ngaysinh:
                    return x.ngaysinh.CompareTo(y.ngaysinh);
                case sortBy.gender:
                    return x.gender.CompareTo(y.gender);
                default: break;

            }
            return x.MSSV.CompareTo(y.MSSV);

        }
    }
}
