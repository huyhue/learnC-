using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien
{
    
    class DB
    {
        public List<SV> li { get; set; }
        public DB()
        {
            li = new List<SV>();
            li.AddRange(new SV[]
            {
                new SV(106,"NVZ","SE1408",DateTime.Now,true),
                new SV(102,"NVB","SE1404",DateTime.Now,false),
                new SV(109,"NVA","SE1408",DateTime.Now,false),
                new SV(104,"NVD","SE1408",DateTime.Now,true),
                new SV(105,"NVE","SE1404",DateTime.Now,false),
            });
        }
        
    }
}
