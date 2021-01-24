using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // SV s1 = new SV();
            // SV s2 = new SV(1,"huy", 5.1);   
            //  SV s3 = new SV(s2);
            // s3.NameSV = s1.NameSV;
            // s1.show();
            // s2.show();
            // s3.show();

            // SV s1 = new SV{
            //     _MSSV = 1,
            //     _nameSV="huy",
            //     _dtb = 5
            // };
            // // Console.WriteLine(s1);

            // SV s2 = new SV{
            //     _MSSV = 2,
            //     _nameSV="hien",
            //     _dtb = 10
            // };
            // QLSV.Instance.Add(s1);
            // QLSV.Instance.Add(s2);
            // Console.WriteLine(QLSV.Instance.ToString());


            int a = 5;
            int b;

            do {
                Console.Write("Enter b : ");
                b = int.Parse(Console.ReadLine());
                try  {
                    int c = a / b;
                    Console.WriteLine("Value c = " + c);
                }  catch (System.DivideByZeroException dex) {
                    Console.WriteLine("Error: " + dex.Message);
                } catch (System.Exception dex) {
                    Console.WriteLine("Generator Error: " + dex.Message);
                } finally {
                    Console.WriteLine("This is finally");
                }
            } while (b != 0);
        }
    }
}

