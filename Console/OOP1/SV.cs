using System;

namespace OOP1
{
public class SV
{
    public int MSSV { get; set; }
        public string nameSV { get; set; }
        public double DTB { get; set; }
        public SV(int m, string n, double d) 
        {
            MSSV = m;
            nameSV = n;
            DTB = d;
        }
        public void show() 
        {
            Console.WriteLine("Ma so sv: " + MSSV + ", Ten: " +nameSV + ", Diem TB: " + DTB);
        }

        public override string ToString(){
            return "Sinh vien Ma so: " + MSSV + ", Ten: " + nameSV + ", Diem TB: " + DTB;
        }
        public static bool Compare_MSSV(object s1,object s2){
            if (((SV)s1).MSSV > ((SV)s2).MSSV){
                return true;
            }else{
                return false;
            }
        }
}
}