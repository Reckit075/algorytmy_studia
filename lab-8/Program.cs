using System;

namespace lab_8
{
    class Program
    {
        record Student { string Name, int Ects };
        static void Main(string[] args)
        {
            int[] arr = { 5, 6, 2, 6, 9, 87 };
            Array.Sort(arr);
            int index = Array.BinarySearch(arr, 6);
            Console.WriteLine(index);

            Student[] students =
            {
                new Student("Ewa", 86);
                new Student("Tomasz", 45);
                new Student("Jan", 55);
            };
        Array.Sort(students,(a, b)=>{
            a.Ects.CompareTo(b.Ects);
        });
        Array.BinarySearch(students, new Student("Ewa",86),(a,b);
    }
    }
}
