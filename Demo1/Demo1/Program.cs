using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Collections;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Regex regex = new Regex(@"\d");
            //string a = "sad 3121312";
            //foreach (Match item in regex.Matches(a))
            //{
            //    Console.WriteLine(item.ToString());
            //}

            //ArrayList list = new ArrayList();
            //list.Add(231);
            //list.Add(123);
            //list.Add(321);
            //list.Sort();
            //for(int i = 0; i < list.Count; i++)
            //{
            //    Console.Write(list[i] + " ");
            //}

            //Hashtable hashtable = new Hashtable();
            //hashtable.Add("F", "Chu F");
            //hashtable.Add("B", "Chu B");
            //hashtable.Add("C", "Chu C");
            //hashtable.Add("D", "Chu D");
            //hashtable.Add("E", "Chu E");
            //hashtable.Add("A", "Chu A");
            //foreach(DictionaryEntry item in hashtable)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}

            //Stack stack = new Stack();
            //stack.Push("Bui");
            //stack.Push("Tat");
            //stack.Push("Trung");
            //for(int i = 0; i < stack.Count; i++)
            //{
            //    Console.WriteLine(stack.Pop());
            //}
            //Console.WriteLine(stack.Pop());

            //Queue queue = new Queue();
            //queue.Enqueue("Bui");
            //queue.Enqueue("Tat");
            //queue.Enqueue("Trung");
            //for (int i = 0; i < queue.Count; i++)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}
            //Console.WriteLine(queue.Dequeue());

            //bool[] arr1 = { true, false, true, true, false };
            //bool[] arr2 = { false, false, false, true, false };
            //BitArray bitArray1 = new BitArray(arr1);
            //BitArray bitArray2 = new BitArray(arr2);
            //for (int i = 0; i < bitArray1.Count; i++)
            //{
            //    Console.Write(bitArray1.Get(i).GetHashCode());
            //}
            //Console.WriteLine();
            //for (int i = 0; i < bitArray2.Count; i++)
            //{
            //    Console.Write(bitArray2.Get(i).GetHashCode());
            //}
            //Console.WriteLine();
            //bitArray1.Xor(bitArray2);
            //Console.Write("Phep and" + ": ");
            //for (int i = 0; i < bitArray1.Count; i++)
            //{
            //    Console.Write(bitArray1.Get(i).GetHashCode());
            //}
            //Console.WriteLine();

            Tuple<int, string, bool> tuple = new Tuple<int, string, bool>(15, "Trung", true);
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2);
            Console.WriteLine(tuple.Item3);

            var dateTime = getDateTime();
            Console.WriteLine(dateTime.Item1 + "/" + dateTime.Item2 + "/" + dateTime.Item3);
        }

        static Tuple<int, int, int> getDateTime()
        {
            DateTime now = DateTime.Now;
            return new Tuple<int, int, int>(now.Day, now.Month, now.Year);
        }
    }
}
