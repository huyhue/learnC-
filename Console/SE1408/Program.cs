using System;

namespace SE1408
{
    class Program
    {
        
        static void A(out int x)
        {
            x = 5;
        }
        static void HV(ref int a, ref int b)
        {
            int temp = a; a = b; b = temp;
        }
        static void Main(string[] args)
        {
            
            //Output //Input ep kieu
            // int x = 1, y = 2, z;
            // string s = "";
            // Console.WriteLine("Hello World! Gia Huy " + 'H');
            // Console.WriteLine("Nhap s, x, y, z: ");
            // s = Console.ReadLine();
            // x = int.Parse(Console.ReadLine());
            // int.TryParse(Console.ReadLine(), out y);
            // z = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("so x = {0}, y = {1}, s = {2}, z = {3}", x, y, s, z);

            // int m=1,n=2,l;
            // HV(ref m,ref n);
            // A(out l);
            // Console.WriteLine("m = {0}, n = {1}, l = {2}", m,n,l);

            //mang 1 chieu
            // string[] arr = {"A", "B", "C", "D"};
            // for (int i = 0; i < arr.Length; i++)
            // {
            //     Console.Write(arr[i] + " ");
            // }
            // Console.WriteLine("========================");
            // foreach (string i in arr)
            // {
            //     Console.Write(i + " ");
            // }
            // //mang 2 chieu
            // Console.WriteLine("========================");
            // string[,] arr1 = {
            //     {"A1", "B1", "C1", "D1"},
            //     {"A2", "B2", "C2", "D2"} };
            // foreach (string i in arr1)
            // {
            //     Console.Write(i + " ");
            // }

            // //mang thanh phan
            // string[][] softs = new string[3][];
            // softs[0] = new string[]{
            //     "A3", "B3", "C3" };
            // softs[1] = new string[]{
            //     "A4", "B4", "C4", "D4" };
            // softs[2] = new string[]{
            //     "A5", "B5", "C5" };
            // for (int i = 0; i < softs.GetLength(0); i++)
            // {`          
            //     for (int j = 0; j < softs[i].GetLength(0); j++)
            //     {
            //         Console.WriteLine(softs[i][j]);
            //     }
            // }
            // Console.WriteLine("========================");
            // foreach (string[] srr in softs)
            // {
            //     foreach (string s in srr)
            //     {
            //         Console.WriteLine(s);
            //     }
            // }





        }
    }
}
