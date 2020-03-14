using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    class Program
    {
        public static void swap<T>(ref T a, ref T b)
        {
            T c = a;
            a = b;
            b = c;
        }
        static void Main(string[] args)
        {
            int a = 5, b = 7;
            double c = 15.5, d = 4.4;
            swap<int>(ref a, ref b);
            swap<double>(ref c, ref d);
            Console.WriteLine(a + "|" + b);
            Console.WriteLine(c + "|" + d);
        }
    }
}
