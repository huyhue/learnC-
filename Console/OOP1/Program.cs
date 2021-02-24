using System;

namespace OOP1
{
    class Program
    {
        //khuon mau hang
        static void HV<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        public delegate void MyDel(int x, int y);

        static void Sum(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        static void Sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        static void TT(int x, int y, MyDel d)
        {
            d(x, y);
        }
        public delegate bool CompareObj(object s1, object s2);
        //ham sap xep chung
        static void sort(object[] arr, CompareObj cmp)
        {
            //tang dan DTB MSSV
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (cmp(arr[i], arr[j]))
                    // if (arr[i].DTB > arr[j].DTB)
                    {
                        object temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            // MyClass obj = new MyClass();
            // IFile1 f1 = (IFile1)obj;
            // f1.A();
            // IFile2 f2 = (IFile2)obj;
            // f2.A();

            // double x = 1.1, y = 2.2;
            // HV<double>(ref x, ref y);
            // Console.WriteLine("x = {0}, y = {1}", x, y);

            // MyGenericClass<int> mgc = new MyGenericClass<int>(10);

            // MyDel d1 = new MyDel(Sum);
            // int m = Sum(1, 2);
            // int n = d1(2, 1);
            // int p = d1.Invoke(2, 1);
            // Console.WriteLine("m = {0}, n = {1}, p = {2}", m, n, p);
            // //tham so
            // MyDel d2 = new MyDel(Sum);
            // int q = TT(2,1,d2);
            // int q1 = TT(2,1,Sum);
            // Console.WriteLine("q = {0}, q1 = {1}", q, q1);

            // MyDel d3 = new MyDel(Sum);
            // d3 += new MyDel(Sub);
            // d3 += new MyDel(Sub);
            // d3 -= new MyDel(Sub);
            // d3(2, 1);

            // SV[] arr =
            // {
            //     new SV(5,"Huy",3.3),
            //     new SV(2,"Phan",3.4),
            //     new SV(3,"Nguyen",3.5)
            // };
            // CompareObj cmp = new CompareObj(SV.Compare_MSSV);
            // sort(arr, cmp);
            // foreach (SV i in arr)
            // {
            //     Console.WriteLine(i.ToString());
            // }

            Clock c = new Clock();
            AnalogClock ac = new AnalogClock();
            DigitalClock dc = new DigitalClock();
            c.OnSecondChange += new Clock.SecondHandle(ac.ShowAC);
            c.OnSecondChange += new Clock.SecondHandle(dc.ShowDC);

            c.Run();
        }
    }
}
