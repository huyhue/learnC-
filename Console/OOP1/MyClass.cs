using System;

namespace OOP1
{
    public class MyClass : IFile2, IFile1
    {
        // public void A()
        // {
        //     Console.WriteLine("A");
        // }

        // public void B()
        // {
        //     Console.WriteLine("B");
        // }

        // public void D()
        // {
        //     Console.WriteLine("D");
        // }
        void IFile2.A()
        {
            Console.WriteLine("A2");
        }

        void IFile1.A()
        {
            Console.WriteLine("A1");
        }

        void IFile1.B()
        {
            throw new NotImplementedException();
        }

        void IFile2.D()
        {
            throw new NotImplementedException();
        }
    }
}