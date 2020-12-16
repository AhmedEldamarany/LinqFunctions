using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Day10Demo
{
    class Program :IComparer
    {
        int IComparer.Compare(Object x, Object y)
        {
            return ((new CaseInsensitiveComparer()).Compare(x, y));
        }
        public static void Main(string[] args)
        {
            #region  Restericition Operators
            //var lst = from p in ListGenerators.ProductList where p.UnitsInStock == 0 select p;
            //Console.WriteLine("These products are out of stock");
            //foreach(var item in lst)
            //    Console.WriteLine(item);
            //Console.WriteLine("\n These products cost less than 3 and are avaialbe in stock");
            //lst = from p in ListGenerators.ProductList where p.UnitsInStock != 0 where p.UnitPrice > (decimal)3.00 select p;
            //foreach (var item in lst)
            //    Console.WriteLine(item);
            //Console.WriteLine("these digits have lesser names than values");
            string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var res = Arr.Where((p, index) => p.Length <index);
            //foreach (var item in res)
            //    Console.WriteLine(item);
            #endregion

            #region Element Operators
            //var item = ListGenerators.ProductList.First(p => p.UnitsInStock == 0);
            //Console.WriteLine("this is the first item occured out of stock");
            //Console.WriteLine(item);
            //Console.WriteLine("\nwe have this number of products with price more than 1000");
            //item = ListGenerators.ProductList.FirstOrDefault(p => p.UnitPrice > 1000);
            //if (item == null)
            //    Console.WriteLine("zero");
            //Console.WriteLine("second element greater than 5 is");
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //Console.WriteLine(Arr.Where(p => p > 5).ElementAt(1));
            //Todo idk any better way

            #endregion
            #region Set Operators
            // Console.WriteLine("\n these are the unique categories we have" );
            //var lst= from p in ListGenerators.ProductList group p by p.Category ;
            // foreach(var c in lst)
            //     Console.WriteLine(c.Key);
            // string[] lst1 = { "Ahmed", "ebrahim", "karim" };
            // string[] lst2 = { "Ahmed", "ali", "Alaa" };
            //Console.WriteLine("unique characters in product names and company names");
            // var res = ListGenerators.CustomerList.Select(prop=>prop.CompanyName[0]).
            //    Union(ListGenerators.ProductList.Select(prop => prop.ProductName[0]));
            //foreach(var i in res)
            //    Console.WriteLine(i);

            //Console.WriteLine("\nCommon first letters ");
            //res = ListGenerators.CustomerList.Select(prop => prop.CompanyName[0]).
            //    Intersect(ListGenerators.ProductList.Select(prop => prop.ProductName[0]));
            //foreach (var i in res)
            //    Console.WriteLine(i);

            //Console.WriteLine("Intersect");
            //res = ListGenerators.CustomerList.Select(prop => prop.CompanyName[0]).
            //   Except(ListGenerators.ProductList.Select(prop => prop.ProductName[0]));
            //foreach (var i in res)
            //    Console.WriteLine(i);

            // res = ListGenerators.CustomerList.Select(prop =>   prop.CompanyName.Substring(prop.CompanyName.Count()-3) ).
            //        Concat(ListGenerators.ProductList.Select(prop =>  prop.ProductName.Substring(prop.ProductName.Count()-3 )));
            //foreach (var i in res)
            //    Console.WriteLine(i);
            #endregion
            #region Aggregate Operators
            //int[] arr = { 5,4,1,3,9,8,6,7,2,0};
            //int count = arr.Where(p => p % 2 != 0).Count();
            //Console.WriteLine(count);
            //Console.WriteLine("How many order has every customer make");
            //int orders=ListGenerators.CustomerList.Select(predicate => predicate.Orders).Count();
            //Console.WriteLine(orders);

            //var categories = ListGenerators.ProductList.GroupBy(p => p.Category);
            //foreach (var cat in categories)
            //    Console.WriteLine($"{cat.Key} \t{cat.Count()}");

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //Console.WriteLine(   Arr.Sum());
            //string[] lines = System.IO.File.ReadAllLines("dictionary_english.txt");
            //int count = lines.Select(p => p.Length).Sum();
            //Console.WriteLine(count);
            //cheepest product in every category
            //var categories = ListGenerators.ProductList.GroupBy(p => p.Category);
            //foreach (var cat in categories)
            //       Console.WriteLine($"{cat.Key} \t{cat.Min(prop=>prop.UnitPrice)}");

            //int max = lines.Select(p => p.Count()).Max();
            //Console.WriteLine($"elgnth of longest word in the dictionary {max}");

            //Console.WriteLine("The Most expensive product in all the  categories ");
            //Console.WriteLine(categories.Max(prop => prop.Max(p=>p.UnitPrice)));

            //Console.WriteLine("list of most expensive product under each cateogry");
            //foreach (var cat in categories)
            //    Console.WriteLine($"{cat.Key} \t{cat.Max(prop => prop.UnitPrice)}");

            //double avgLegnth = lines.Select(p => p.Length).Average();
            //Console.WriteLine(avgLegnth);

            //Q14
            //foreach (var cat in categories)
            //     Console.WriteLine($"{cat.Key} \t{cat.Average(prop=>prop.UnitPrice)}");

            #endregion

            #region Ordering Operators
            //var res = ListGenerators.ProductList.OrderBy(p => p.ProductName);
            //foreach(var item in res)
            //    Console.WriteLine(item.ProductName); // .ProductName isn't required
            string[] arr = { "aPPLE", "AbAcUs","bRaNcH","BlUeBeRrY","ClovEr","cHeRry"};
            //Array.Sort(arr, new Program());
            //    foreach(var item in arr)
            //    Console.WriteLine(item);

            //var res = from p in ListGenerators.ProductList
            //          orderby p.UnitsInStock descending
            //          select p;
            //foreach(var item in res)
            //    Console.WriteLine(item.UnitsInStock); //.UnitesInStock isn't required
            //var ordered= Arr.OrderBy(p => p.Length).ThenBy(p => p);
            //    foreach(string item in ordered)
            //    Console.WriteLine(item);
            //string[] sortedArr = arr.OrderBy(p => p.Length).ToArray();
            // Array.Sort(sortedArr, new Program());
            //foreach (var item in sortedArr)
            //    Console.WriteLine(item);
            //6
            //var lst = ListGenerators.ProductList.OrderBy(p => p.Category).ThenBy(p => p.UnitPrice);

            //foreach (var c in lst)
            //    Console.WriteLine(c);
            //7
            //string[] sortedarr = arr;
            //Array.Sort(sortedarr, new Program());
            // sortedarr= arr.OrderBy(w => w.Length).ToArray();
            //foreach(var item in sortedarr)
            //Console.WriteLine(item);

            //8
            //var digits= Arr.Where(d => d[1] == 'i');
            // foreach(var d in digits)
            //     Console.WriteLine(d);

            #endregion

            #region Partitioning Operators
            //Washinton returns null so I used London instead
            //var lst = ListGenerators.CustomerList.Where(c => c.City == "London").Take(3).Select(c => c.Orders); //1
            //  lst = ListGenerators.CustomerList.Where(c => c.City == "London").Skip(2).Select(c => c.Orders); //2
            //foreach (var orders in lst)
            //    foreach(var order in orders)
            //        Console.WriteLine(order);

            // int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            // //var result = numbers.TakeWhile((n, index) => n > index); //3
            ////var result = numbers.SkipWhile(n => (n % 3) != 0); //4
            // var result = numbers.SkipWhile((n,i) => (n>=i ) ); //5

            // foreach (var r in result)
            //     Console.WriteLine(r);
            #endregion
            #region Projection Operators
            //1
            //var res = ListGenerators.ProductList.Select(p => p.ProductName);
            //foreach(var item in res)
            //Console.WriteLine(item);
            //2
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var res = words.Select(w=> new { upper= w.ToUpper(), lower=w.ToLower()});
            //foreach(var word in res)
            //    Console.WriteLine($"upper is {word.upper} , lower is {word.lower}");

            #endregion
            Console.ReadLine();
        }
    }
}
