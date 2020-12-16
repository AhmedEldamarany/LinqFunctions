using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Demo
{
    static class IntFunctions
    {
        public static void Print(this int x)
        {
            Console.WriteLine($"My value is {x}");
        } 
        public static void Print<T>(this IEnumerable<T> x)
        {
            Console.WriteLine($"My value is {x}");
        }
    }
}
