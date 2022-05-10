using System;
using System.Collections;
using System.Collections.Generic;

namespace lab_9
{


    class HashTable:IEnumerable<int>
    {
        List<int>[] arr = new List<int>[101];

        public bool Add(int value)
        {
            //arr[HashCode(value)] = value;
            //return true;
            int hashCode = HashCode(value);
            if(arr[hashCode] == null)
            {
                arr[hashCode] = new List<int>();
            }
            if (arr[hashCode].Contains(value))
            {
                return false;
            }
            arr[hashCode].Add(value);
            return true;
        }
        public bool Remove(int value)
        {
            int hashCode = HashCode(value);
            if(arr[hashCode] == null || !arr[hashCode].Contains(value))
            {
                return false;
            }
            return arr[hashCode].Remove(value);
            //arr[HashCode(value)] = null;
            //return true;
        }
        public bool Contains(int value)
        {
            int hashCode = HashCode(value);
            if (arr[hashCode] != null && arr[hashCode].Contains(value))
            {
                return true;
            }
            return false;
        }

        private int HashCode(int value)
        {
            return value.GetHashCode() % arr.Length;
        }

        public IEnumerator<int> GetEnumerator()
        {
            foreach (List<int> list in arr)
            {
                if(list != null)
                {
                    foreach (int val in list)
                    {
                        yield return val;
                    }
                    //yield return (int)item;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!".GetHashCode());
            HashTable table = new HashTable();
            table.Add(6);
            table.Add(12);
            table.Add(7);
            table.Add(104);
            Console.WriteLine(table.Add(3));
            foreach (int item in table)
            {
                Console.WriteLine(item);
            }
        }
    }
}
