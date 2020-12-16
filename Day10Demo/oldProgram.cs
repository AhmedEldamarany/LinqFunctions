using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Demo
{
    class Program2
    {
        static void Main2(string[] args)
        {
            #region Features to support linq

            #region Var
            //feature no 1 to support linq
            //var
            //first use for var in linq 
            // that we have multiple return data types
            //second use for var in linq
            //anonymous object
            //var p = new { Email = "ALi@gmail.com", Password = "ali123" };
            //var p2 = new {  Password = "ola123", Email = "ola@gmail.com" };

            //Console.WriteLine(p.Email);
            //Console.WriteLine(p.Password);
            //Console.WriteLine(p.ToString());
            //Console.WriteLine(p2.GetType()); 
            #endregion

            #region Extension Methods
            //int x = 7;
            //IntFunctions.Print(x);
            //x.Print();
            //List<int> lst = new List<int>();
            //lst.Print();
            //Dictionary<string, int> pairs = new Dictionary<string, int>();
            //pairs.Print();
            //Enumerable  -> static class elly mwgood gwah el linq functions
            //IEnumerable -> interface elly bn-Append 3leeh el linq functions
            #endregion

            #endregion

            #region Filtering/Restriction
            //ana 3ayz a3mel filter lel rows
            //List<int> lst = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Enumerable.Where(lst, i => i > 3);
            //var res= lst.Where(i => i > 3);
            //fluent expression
            // by default linq is working as differed execution
            //if we want to make it an immediate execution : ya ema casting operators, single element operator
            //var res = ListGenerators.ProductList.Where(p => p.ProductID > 70).ToList();
            //ListGenerators.ProductList.Add(new Product() { ProductID = 78, ProductName = "Shai" });
            ////query expression // syntax sugar
            //res = from p in ListGenerators.ProductList
            //      where p.ProductID > 75
            //      select p;
            //indexed where
            //var res = ListGenerators.ProductList.Where((p, index) => p.UnitPrice > 10 && index % 2 == 1);
            //foreach (var item in res)
            //{
            //    Console.WriteLine($"{item} ");
            //}
            //Console.WriteLine();
            #endregion

            #region Projection
            // select, indexed select, selectMany
            //var res = ListGenerators.ProductList.Select(p => p.ProductName);
            //var res = ListGenerators.ProductList.Select(p => new { p.ProductID, PrdName=p.ProductName});
            //res = from p in ListGenerators.ProductList
            //      select new { p.ProductID, PrdName =p.ProductName};

            //var res = ListGenerators.ProductList.Select((p, index) => new { index, p.ProductID, p.ProductName });
            //List<string> Names = new List<string>() { "ALi Wael Abdo", "Lara Wael", "Ola Abdo" };
            //ana da5elly list and i want to generate a new list tkon el length bta3ha akbr mn el old
            //{"Ali","Wael","Lara" }
            //var res = Names.SelectMany(p => p.Split(' '));
            //mix between where and select
            //var res = ListGenerators.ProductList.Where(p => p.UnitPrice > 10).Select(prd=>new { prd.ProductID , prd.ProductName});
            //res = from p in ListGenerators.ProductList
            //      where p.UnitPrice > 20
            //      select new { p.ProductID, p.ProductName };
            #endregion
            #region Single operator (Immediate execution)
            //first, single, last :: or defualt
            //var res = ListGenerators.ProductList.First();          
            //var res = ListGenerators.ProductList.First(p=>p.ProductID>70);
            //var res = ListGenerators.ProductList.FirstOrDefault(p=>p.UnitsInStock==0);
            // res = ListGenerators.ProductList.LastOrDefault(p=>p.UnitsInStock==0);
            //ListGenerators.ProductList.Add(new Product() { ProductID = 77, ProductName = "Coffee" });
            //var res = ListGenerators.ProductList.SingleOrDefault(p=>p.ProductID==77);

            #endregion
            #region Aggregate
            //max, min, sum, count
            //List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var res = nums.Count();
            //var res = ListGenerators.ProductList.Max();
            #endregion

            #region Ordering operators
            //orderby, orderbydescending, thenby, thenbydescending
            //var res = ListGenerators.ProductList.Where(pp=>pp.UnitsInStock!=0).OrderBy(p => p.UnitPrice).ThenByDescending(p=>p.UnitsInStock);
            //res = from p in ListGenerators.ProductList
            //      where p.UnitsInStock != 0
            //      orderby p.UnitPrice ascending, p.UnitsInStock descending
            //      select p;

            #endregion

            #region Partitioning
            //take, skip, takewhile, skipwhile
            // List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ,2,1};
            //var res = nums.Where(p => p % 2 == 0).Take(3);
            //var res = nums.Where(p => p % 2 == 0).Skip(3);
            //var res = nums.TakeWhile(i => i < 4);
            //var res = nums.SkipWhile(i => i < 4);
            #endregion

            #region Grouping
            //group by
            //var res = ListGenerators.ProductList.GroupBy(p => p.Category);
            //res = from p in ListGenerators.ProductList
            //      group p by p.Category;
            //foreach (var Category in res)
            //{
            //    Console.WriteLine($"{Category.Key}:::");
            //    foreach (var product in Category)
            //    {
            //        Console.WriteLine(product);
            //    }
            //    Console.WriteLine("------------------");
            //}
            #endregion
            #region Quantifiers
            //any, all
            //List<int> lst = new List<int>();
            //at least one satisfies the condition
            //var res = ListGenerators.ProductList.Any(p=>p.ProductID>77);
            //var res = ListGenerators.ProductList.All(p => p.ProductID > 1);
            #endregion
            #region Set Operators
            //intersect, union, except, zip
            //List<int> lst1 = new List<int>() { 2, 1, 3, 7, 4, 9 }; 
            //List<int> lst2 = new List<int>() { 3,5, 7, 3, 9, 8, 10,23 };
            //var res = lst1.Intersect(lst2);
            //res = lst1.Except(lst2);
            //res = lst1.Union(lst2);
            //res = lst1.Concat(lst2);
            //var res = lst1.Zip(lst2, (i1, i2) => $"({i1},{i2})");
            //var res = lst1.Zip(lst2, (i1, i2) => i1+i2);
            #endregion
            // query into , let
            //List<string> name = new List<string>() { "Ahmed", "Ola", "Lara", "Abdulrahman" };
            //var res1 = name.Where(n => n.Length > 4);
            //var res2 = res1.Select(i => new { oldValue = i, newValue = i.ToUpper() });
            ////Console.WriteLine(res);

            //foreach (var item in res2)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadLine();
            //wessam.abdelkhalek@gmail.com





        }
    }
}
