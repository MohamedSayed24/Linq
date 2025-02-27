using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using static AssignmentLinq03.ListGenerator;
using static System.Net.Mime.MediaTypeNames;
namespace AssignmentLinq03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "dictionary_english.txt";
            string[] dictionary = File.ReadAllLines(filePath);

            #region LINQ - Partitioning Operators
            #region 1. Get the first 3 orders from customers in Washington
            //var result = CustomerList.Where(customer => customer.Region=="WA")
            //                         .SelectMany(o => o.Orders).Take(3);
            //foreach (var customer in result)
            //{
            //    Console.WriteLine(customer);
            //}
            #endregion

            #region 2. Get all but the first 2 orders from customers in Washington.
            //var result = CustomerList.Where(customer => customer.Region == "WA")
            //                         .SelectMany(o => o.Orders).Skip(2);
            //foreach (var customer in result)
            //{
            //    Console.WriteLine(customer);
            //}

            #endregion

            #region 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.TakeWhile((number, index) => number > index);
            //foreach (var number in result)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion

            #region 4.Get the elements of the array starting from the first element divisible by 3.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.SkipWhile(number => number % 3 != 0);
            //Console.WriteLine(string.Join(", ", result));

            #endregion

            #region 5. Get the elements of the array starting from the first element less than its position.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.SkipWhile((number, index) => number > index);
            //foreach (var number in result)
            //{
            //    Console.WriteLine(number);
            //}

            #endregion
            #endregion

            #region LINQ – Grouping Operators
            #region Use group by to partition a list of numbers by their remainder when divided by 5
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var result = numbers.GroupBy(n => n % 5);
            //foreach (var group in result)
            //{
            //    Console.WriteLine("\n");
            //    Console.WriteLine($"Numbers with remainder {group.Key} when divided by 5: {string.Join(", ", group)}");
            //}

            #endregion

            #region Uses group by to partition a list of words by their first letter. Use dictionary_english.txt for Input
            //var result = dictionary.GroupBy(word => word[0]);
            //foreach (var group in result)
            //{
            //    Console.WriteLine(group.Key);
            //    //foreach (var word in group)
            //    //{
            //    //    Console.WriteLine(word);
            //    //}
            //    Console.WriteLine("====================================================");
            //}
            #endregion

            #region Use Group By with a custom comparer that matches words that are consists of the same Characters Together
            //String[] Arr = { "from", "salt", "earn", " last", "near", "form" };
            //var result = Arr.GroupBy(word => String.Concat(word.OrderBy(c => c)));
            //foreach (var group in result)
            //{
                
            //    foreach (var word in group)
            //    {
            //        Console.WriteLine(word);
            //    }
            //    Console.WriteLine("====================================================");
            //}
            #endregion
            #endregion
        }
    }
}
