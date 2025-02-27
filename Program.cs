using System.Collections.Generic;
using static AssignmentLinq02.ListGenerator;
using static System.Net.Mime.MediaTypeNames;
namespace AssignmentLinq02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "dictionary_english.txt";
            string[] dictionary = File.ReadAllLines(filePath);
            #region LINQ - Element Operators
            #region 1-Get first Product out of Stock
            //var firstProductOutOfStock = ProductList.FirstOrDefault(product => product.UnitsInStock == 0);
            //Console.WriteLine(firstProductOutOfStock);
            #endregion

            #region 2- Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var result = ProductList.FirstOrDefault(product => product.UnitPrice > 1000);
            //Console.WriteLine(result);
            #endregion

            #region 3- Retrieve the second number greater than 5
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.Where(num => num > 5).OrderBy(num => num).ElementAt(1);
            //Console.WriteLine(result);

            #endregion


            #endregion

            #region LINQ - Aggregate Operators
            #region 1- Uses Count to get the number of odd numbers in the array
            //int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.Count(num => num % 2 ==1);
            //Console.WriteLine(result);
            #endregion

            #region 2- Return a list of customers and how many orders each has.

            //var customerOrders = CustomerList.Select(customer => new { customer.CustomerName, OrderCount = customer.Orders.Count() });


            //foreach (var customer in customerOrders)
            //{
            //    Console.WriteLine(customer);
            //}
            #endregion

            #region 3-Return a list of categories and how many products each has
            //var result = ProductList.GroupBy(product => product.Category)
            //                        .Select(product => new { Category = product.Key, ProductCount = product.Count() });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 4- Get the total of the numbers in an array.

            //int[] numbers= { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.Sum();
            //Console.WriteLine(result);
            #endregion

            #region Get the total number of characters of all words in dictionary_english.txt 
            //Read dictionary_english.txt into Array of String First

            //var result = dictionary.Sum(word => word.Length);
            //Console.WriteLine(result);

            #endregion

            #region Get the length of the shortest word in dictionary

            //var result = dictionary.Min(word => word.Length);
            //Console.WriteLine(result);

            #endregion

            #region Get the length of the longest word in dictionary_english.txt

            // var result = dictionary.Max(word => word.Length);
            //Console.WriteLine(result);

            #endregion

            #region Get the average length of the words in dictionary

            //var result = dictionary.Average(word => word.Length);
            //Console.WriteLine(result);

            #endregion

            #region Get the total units in stock for each product category.
            //var result = ProductList.GroupBy(p=>p.Category)
            //                        .Select(p => new { Category = p.Key, TotalUnitsInStock = p.Sum(p => p.UnitsInStock) });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Get the cheapest price among each category's products
            //var result = ProductList.GroupBy(product => product.Category)
            //                        .Select(product => new { Category = product.Key, ChepeastPrice = product.Min(product => product.UnitPrice) });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Get the products with the cheapest price in each category (Use Let)
            //var result = from product in ProductList
            //             group product by product.Category into pr
            //             let cheapestPrice = pr.Where( P => P.UnitPrice == pr.Min(p => p.UnitPrice))
            //             select cheapestPrice;
            //foreach (var item in result)
            //{
            //    foreach (var  i in item)
            //    {
            //        Console.WriteLine($"ProductName = {i.ProductName}, Category = {i.Category}, UnttPrice { i.UnitPrice} ");
            //    }
            //}
            #endregion

            #region Get the most expensive price among each category's products
            //var result = ProductList.GroupBy(product => product.Category)
            //                        .Select(product => new { Category = product.Key, MostExpensive = product.Max(product => product.UnitPrice) });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Get the average price of each category's products.
            //var result = ProductList.GroupBy(product => product.Category)
            //                        .Select(product => new { Category = product.Key, Average = product.Average(product => product.UnitPrice) });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #endregion

            #region LINQ - Set Operators
            #region Find the unique Category names from Product List
            //var result = ProductList.Select(product => product.Category).Distinct();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Produce a Sequence containing the unique first letter from both product and customer names.
            //var result = ProductList.Select(product => product.ProductName[0])
            //                        .Union(CustomerList.Select(customer => customer.CustomerName[0]));
            //foreach (var item in result)
            //{
            //    Console.Write(item+" ");
            //}
            #endregion

            #region Create one sequence that contains the common first letter from both product and customer names
            //var result = ProductList.Select(product => product.ProductName[0])
            //            .Intersect(CustomerList.Select(customer => customer.CustomerName[0]));
            //foreach (var item in result)
            //{
            //    Console.Write(item + " ");
            //}
            #endregion

            #region Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var result = ProductList.Select(product => product.ProductName[0])
            //            .Except(CustomerList.Select(customer => customer.CustomerName[0]));
            //foreach (var item in result)
            //{
            //    Console.Write(item + " ");
            //}

            #endregion

            #region Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
            //var result = ProductList.Select(product => product.ProductName.TakeLast(3).ToArray());
            //var result02 = CustomerList.Select(customer => customer.CustomerName.TakeLast(3).ToArray());
            //var result03 = result02.Concat(result);

            //foreach (var item in result03)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion

            #region LINQ - Quantifiers
            #region Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
            //var result = dictionary.Any(word => word.Contains("ei"));
            //Console.WriteLine(result);
            #endregion

            #region Return a grouped a list of products only for categories that have at least one product that is out of stock.
            //var result = ProductList.GroupBy(product => product.Category)
            //                        .Where(product => product.Any(p => p.UnitsInStock == 0));

            //foreach ( var product in result )
            //{
            //    Console.WriteLine(product.Key);

            //}
            #endregion

            #region Return a grouped a list of products only for categories that have all of their products in stock.
            var result = ProductList.GroupBy(product => product.Category)
                                    .Where(product => product.All(p => p.UnitsInStock > 0));

            foreach (var product in result)
            {
                Console.WriteLine(product.Key);

            }

            #endregion
            #endregion
        }


    }
}

