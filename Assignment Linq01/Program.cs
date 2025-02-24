using System.Threading;
using static Assignment_Linq01.ListGenerator;
namespace Assignment_Linq01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators

            #region 1. Find all products that are out of stock.
            //Console.WriteLine("products that are out of stock");
            //var products = ProductList.Where(product => product.UnitsInStock == 0);

            //Query Syntax
            //var products = from product in ProductList
            //               where product.UnitsInStock == 0
            //               select product;
            //foreach (var Product in products)
            //    Console.WriteLine(Product);
            #endregion

            #region 2. Find all products that are in stock and cost more than 3.00 per unit.
            //var products = ProductList.Where(product => product.UnitsInStock > 0)
            //                          .Where(product => product.UnitPrice > 3.00m);

            //Query Syntax
            //var products = from product in ProductList
            //               where product.UnitsInStock > 0 && product.UnitPrice > 3.00m
            //               select product;
            //foreach (var Product in products)
            //    Console.WriteLine(Product);
            #endregion

            #region 3. Returns digits whose name is shorter than their value.
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.Where((digit, index) => digit.Length < index);

            //Query Syntax
            //var result = from i in Enumerable.Range(0, Arr.Length)
            //             where Arr[i].Length < i
            //             select Arr[i];
            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion
            #endregion
             
            #region LINQ - Ordering Operators
            #region 1. Sort a list of products by name 
            //var products = ProductList.OrderBy(product => product.ProductName);

            //Query SyntaX
            //  var products = from product in ProductList
            //           orderby product.ProductName
            //           select product;
            //foreach (var Product in products)
            //    Console.WriteLine(Product);
            #endregion

            #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(word => word.ToLower());
            //Console.WriteLine(string.Join(",  ",result));
            #endregion

            #region 3. Sort a list of products by units in stock from highest to lowest.
            //var products = ProductList.OrderByDescending(product => product.UnitsInStock);

            //Query Syntax
            //var products = from product in ProductList
            //               orderby product.UnitsInStock descending
            //               select product;
            //foreach (var Product in products)
            //    Console.WriteLine(Product);
            #endregion

            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven, eight, nine"};
            //var result = Arr.OrderBy(digit => digit.Length).ThenBy(digit => digit);
            //Query Syntax
            //var result = from digit in Arr
            //             orderby digit.Length, digit
            //             select digit;
            //Console.WriteLine(string.Join(", ", result));
            #endregion

            #region 5. Sort first by-word length and then by a case-insensitive sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(word => word.Length).ThenBy(word => word.ToLower());
            //Console.WriteLine(string.Join(", ",Arr));
            #endregion

            #region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var  products = ProductList.OrderByDescending(product => product.Category)
            //                            .ThenByDescending(product => product.UnitPrice);
            //foreach (var Product in products)
            //    Console.WriteLine(Product);
            #endregion

            #region 7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result =Arr.OrderByDescending(x => x.Length).ThenByDescending(x => x);
            //Console.WriteLine(string.Join(", ", result));

            #endregion

            #region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var result = Arr.Where(digit => digit[1] == 'i').Reverse();
            //Console.WriteLine(string.Join(", ", result));
            #endregion


            #endregion

            #region LINQ – Transformation Operators
            #region 1. Return a sequence of just the names of a list of products.
            //var ProductNames = ProductList.Select(product => product.ProductName);

            //Query Syntax
            //var ProductNames = from product in ProductList
            //                   select product.ProductName;
            //foreach (var Product in ProductNames)
            //    Console.WriteLine(Product);
            #endregion

            #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var result = words.Select(word => new { Upper = word.ToUpper(), Lower = word.ToLower() });
            //Console.WriteLine(string.Join(", ",result));                  
            #endregion

            #region 4. Determine if the value of int in an array match their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Select((number, index) => number == index);
            //Console.WriteLine(string.Join(", ", result));
            #endregion

            #region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var result = numbersA.SelectMany(a => numbersB, (a, b) => new { a, b })
            //                     .Where(pair => pair.a < pair.b);
            //foreach (var pair in result)
            //    Console.WriteLine($"{pair.a} is less than {pair.b}");
            #endregion

            #region 6. Select all orders where the order total is less than 500.00.
            //var orders = CustomerList.SelectMany(customer => customer.Orders)
            //                         .Where(order => order.Total < 500.00m);

            //Query Syntax
            //var orders = from customer in CustomerList
            //             from order in customer.Orders
            //             where order.Total < 500.00m
            //             select order;
            //foreach (var order in orders)
            //    Console.WriteLine(order);
            #endregion

            #region 7. Select all orders where the order was made in 1998 or later.
            //var orders = CustomerList.SelectMany(customer => customer.Orders)
            //    .Where(order => order.OrderDate.Year >= 1998);

            //Query Syntax
            //var orders = from customer in CustomerList
            //             from order in customer.Orders
            //             where order.OrderDate.Year >= 1998
            //             select order;
            //foreach (var order in orders)
            //    Console.WriteLine(order);


            #endregion
            #endregion
        }
    }
}
