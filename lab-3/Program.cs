using System;

namespace lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(42));
            SinTable sinObject = new SinTable();
            Console.WriteLine(sinObject.Sin(90));
        }

        public static long Fibonacci(int n)
        {
            long[] length = new long[n];
            Array.Fill<long>(length, -1);
            return Fib(n, length);
        }
        static private long Fib(int n, long[] mem)
        {
            if (n < 0)
            {
                throw new ArgumentException();
            }
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }

            if (mem[n-1] == -1)
            {
                mem[n - 1] = Fib(n - 1, mem);
            }
            if (mem[n-2] == -1)
            {
                mem[n - 2] = Fib(n - 2, mem);
            }
            return mem[n-1] + mem[n-2];
            //return fib(n - 1) + fib(n - 2);
        }

        class SinTable
        {
            //static private double[] sinTable;
            //static SinTable()
            //{
            //    Sin(90);
            //}
            public double Sin(int degree)
            {
                double result = Math.PI * degree / 180;
                return result;
            }
        }
        public class cacheRegister
        {
            static readonly int one = 0;
            static readonly int two = 1;
            static readonly int three = 2;
            private readonly int[] _coins = new int[3];

            public cacheRegister(int[] coins)
            {
               this._coins = coins;
            }

            int[] Payment(int[] income, int amount)
            {
                throw new NotFiniteNumberException();
            }
        }
    }
}
