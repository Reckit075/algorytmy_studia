using System;

namespace lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 2 };
            int result = Sum(numbers, numbers.Length);
            Console.WriteLine(result);
            int result2 = NumberOfAppearances(numbers, 2, numbers.Length);
            Console.WriteLine(result2);
        }
        static int Sum(int[] data, int n)
        {
            if (n <= 0 || n>data.Length)
            {
                return 0;
            }
            else
            {
                return Sum(data, n - 1) + data[n - 1];
            }
        }
        static int NumberOfAppearances(int[] data, int index, int n)
        {
            int selectedNumber = data[index];
            if (n <= 0 || n >= data.Length)
            {
                return 0;
            }
            else
            {
                if (data[n] == selectedNumber) return NumberOfAppearances(data, index, n + 1) + 1;
                else return NumberOfAppearances(data, index, n + 1);
            }

        }
    }
}
