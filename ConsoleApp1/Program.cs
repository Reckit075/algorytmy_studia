using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 234, 1, 2, 5, 1234, 676 };
            int[] numbers2 = { 1,234,2345,2 };

           int result = findSmallestNumber(numbers);
            int ext2Result = exercise2(numbers2, 3);
           Console.WriteLine(result);
            Console.WriteLine(ext2Result);
        }
        static int findSmallestNumber(int[] numbers)
        {
            int smallestNumber = numbers[0];
            int index = -1;
            if (numbers.Length > 0)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (smallestNumber > numbers[i] && ( (numbers[i] > 9 && numbers[i] <= 99) || (numbers[i]<-9 && numbers[i] >=-99)))
                    {
                        smallestNumber = numbers[i];
                        index = i;
                        numbers[i] = smallestNumber;
                    }
                }
                return index;
            }
            return -1;
        }
        static int exercise2(int[] numbers, int k)
        {
            int sum = 0;
            int average;
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            average = sum / numbers.Length;
            for (int i = 0; i < numbers.Length; i++)
            {
                int oneNumber = numbers[i];
                int numberOfDigits = Math.Abs(oneNumber).ToString().Length;
                if (oneNumber < average && numberOfDigits == k)
                {
                    result += oneNumber;
                }
            }
            return result;
        }
    }
}
