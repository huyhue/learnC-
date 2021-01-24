using System;

namespace lab1
{
    class Program
    {
        static void Input(int[] A)
        {
            for (int i = 0; i < getLength(A); i++)
            {
                Console.Write("A[" + i + "]=");
                A[i] = int.Parse(Console.ReadLine());
            }
        }

        static void Output(int[] A)
        {
            Console.Write("List Arrays is: ");
            for (int i = 0; i < getLength(A); i++)
                Console.Write(A[i] + " ");
        }

        static int getLength(int[] A)
        {
            int n = 0;
            foreach (int i in A)
            {
                n++;
            }
            return n;
        }

        static void Insert(int x, int index, ref int[] A)
        {
            int[] B = new int[getLength(A) + 1];
            for (int i = 0; i < getLength(B) - 1; i++)
            {
                B[i] = A[i];
            }

            for (int i = getLength(B) - 1; i > index; i--)
            {
                B[i] = B[i - 1];
            }

            B[index] = x;
            A = new int[getLength(B)];

            for (int i = 0; i < getLength(A); i++)
            {
                A[i] = B[i];
            }
        }
        static int IndexOf(int[] A, int x)
        {
            for (int i = 0; i < getLength(A); i++)
                if (A[i] == x)
                    return i;

            return -1;
        }
        static void Remove(int x, ref int[] A)
        {

            if (IndexOf(A, x) < 0)
            {
                Console.WriteLine("x isn't exist");
            }
            else
            {
                while (IndexOf(A, x) > 0)
                {
                    RemoveAt(IndexOf(A, x), ref A);
                }
            }
        }
        //xoa phan tu tai vi tri
        static void RemoveAt(int index, ref int[] A)
        {
            int[] B = new int[getLength(A)];
            for (int i = 0; i < getLength(B); i++)
            {
                B[i] = A[i];
            }

            for (int i = index; i < getLength(B) - 1; i++)
            {
                B[i] = B[i + 1];
            }

            A = new int[getLength(B) - 1];
            for (int i = 0; i < getLength(A); i++)
            {
                A[i] = B[i];
            }
        }
        static void Update(int index, int[] A)
        {
            for (int i = 0; i < getLength(A); i++)
            {
                if (i == index)
                {
                    Console.Write("Enter to update: ");
                    A[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        static void SX(int[] A)
        {
            int size = getLength(A) - 1;
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = size - 1; j > i; j--)
                {
                    if (A[j] < A[j - 1])
                    {
                        int t = A[j];
                        A[j] = A[j - 1];
                        A[j - 1] = t;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int n;
            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[n];
            Input(A);
            Output(A);
            Console.WriteLine();
            Console.Write("Moi ban chen them gia tri: ");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.Write("Moi ban nhap vi tri can chen: ");
            int index = Convert.ToInt32(Console.ReadLine());
            // Insert(value, index, ref A);
            // Output(A);
            // Remove(value, ref A);
            // Output(A);
            Update(index, A);
            Output(A);
            Console.WriteLine();
            Console.Write("Sorting: ");
            SX(A);
            Output(A);
        }
    }
}
