using System;

namespace OOP
{
    public class SV
    {
        public int _MSSV { get; set; }
        public string _nameSV { get; set; }
        public double _dtb { get; set; }
        // private int _MSSV;
        // private string _nameSV;
        // private double _dtb;
        
        // public string NameSV{
        //     get{
        //         return _nameSV;
        //     }
        //     set{
        //         _nameSV = value;
        //     }
        // }
        // public int Get_MSSV(){
        //     return _MSSV;
        // }
        // public void Set_MSSV(int new_value){
        //     _MSSV = new_value;
        // }
        // public SV(SV s) 
        // {
        //     _MSSV = s._MSSV;
        //     _nameSV = s._nameSV;
        //     _dtb = s._dtb;
        // }
        // public int MyProperty { get; set; }
        // public SV(int m, string n, double d) 
        // {
        //     _MSSV = m;
        //     _nameSV = n;
        //     _dtb = d;
        // }

        // public SV() 
        // {
        //     _MSSV = 1;
        //     _nameSV = "NVA";
        //     _dtb = 1.1;
        // }

        public void show() 
        {
            Console.WriteLine("Ma so sv: " + _MSSV + ", Ten: " + _nameSV + ", Diem TB: " + _dtb);
        }

        public override string ToString(){
            return "Sinh vien Ma so: "+_MSSV+", Ten: "+_nameSV+", Diem TB: "+_dtb;
        }
    }
}