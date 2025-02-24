using System.Collections;
using static Linq.ListGenerator;
namespace Linq
{
    internal class Program
    {
        //public static void Print (object X)
        //{
        //    Console.WriteLine (X);
        //}
        //public static void Print(dynamic X)
        //{
        //    Console.WriteLine(X);
        //}
        static void Main(string[] args)
        {
            #region Var vs Dynamic
            // Var Implicitly typed variable
            // Type will be determined at compilation time based on the assigned value (strong typing)
            // Cannot change the data type once the type is declaration at the compilation time
            // Variable must be intialized at the time of it's decleration
            // static type best at performance than dynamic type

            //var x = 10;

            // Dynamic
            // Dynammic Dynamically typed variable
            // Type will be determined at run time based on the assigned value 
            // Can change the data type once the type
            // Variable not have to be intialized at the time of it's decleration

            //dynamic x ;


            #endregion

            #region Anonymous Type
            //var employee01 = new { Name = "Ahmed", Id = 10 };
            //var employee02 = new { Id = 10, Name = "mohamed" };
            //Console.WriteLine(employee01.GetType().Name);
            //Console.WriteLine(employee02.GetType().Name);

            //var UpdatedEmployee01 = employee01 with { Id = 50 };
            //Console.WriteLine(UpdatedEmployee01.GetType().Name);
            //Console.WriteLine(employee01.GetType().Name);
            //Console.WriteLine(employee02.GetType().Name);
            #endregion

            #region Extension Method
            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //numbers.Shuffle();
            //Console.WriteLine(string.Join(", ",numbers));

            //List<string> names = ["Mohamed", "Ahmed", "Aya", "ossama"];
            //names.Shuffle();
            //Console.WriteLine(string.Join(", ",names));
            #endregion

            #region Linq
            #region What is Linq ?
            // Language integrated query 
            // +40 Extension Methods inside bulit-in interface ( IEnumerable <> )
            // Linq Operators Exists inside Enumerable class
            // Categorized into 13 category
            // Use Linq operators against any Data (stored in Sequence) , Regardless DataBase Provider (Sql , Mysql , postgres,oracle)
            // Sequence => Object from class implementing (IEnumerable<>) (collections => List , Array , Dictionary ..)
            // 1.Local Sequence => L2O , L2XML
            // 2.Remote Sequence => L2EF  

            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<int> OddNumbers = numbers.Where(x => x % 2 == 1).ToList();
            //Console.WriteLine(string.Join(", " , OddNumbers));
            #endregion


            #region Linq Syntax
            // 1-Fluent Syntax 
            // 1.1 Call Linq operator as a static method throw Enumerable class
            // List<int> oddNumbers = Enumerable.Where(numbers, x => x % 2 == 1).ToList();
            // 1.2 Call Linq operator as a Extension Method 
            // List<int> OddNumbers = numbers.Where(X => X % 2 == 1 ).ToList(); => Recommended

            // 2-Query Syntax (Query Expression)
            // Like SQL Query style
            // Starting with Keyword "from"
            // Range Variable Represent each element in input sequence
            // Ending With Select or Groub BY Keyword
            //var OddNumbers = from x in numbers
            //                 where x % 2 == 1
            //                 select x;
            //Console.WriteLine(String.Join(", ", OddNumbers));
            #endregion

            #region Execution Ways
            #region Deffered Execution
            // Deffered Excution => Works on (Latest Version of Data)
            //List<int> numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

            //var OddNumbers = numbers.Where(X => X % 2 == 1);

            //numbers.AddRange([11, 12, 13, 14, 15, 16, 17, 18, 19, 20]);

            //Console.WriteLine(String.Join(", ", OddNumbers)); 
            #endregion

            #region Immediate Execution
            // Immediate Execution (Element Operators , Casting operators , Aggregate Operators )
            //List<int> numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

            //var OddNumbers = numbers.Where(X => X % 2 == 1).ToList();

            //numbers.AddRange([11, 12, 13, 14, 15, 16, 17, 18, 19, 20]);

            //Console.WriteLine(String.Join(", ", OddNumbers));
            #endregion
            #endregion
            #endregion

            #region Filteration (Restriction Oberators) => Where , OfType
            //Fluent Syntax
            //var products = ProductList.Where((product, index) => product.UnitsInStock == 0 && index < 10);
            //Console.WriteLine("Products are out of stock :");
            //foreach (var unit in products)
            //{
            //    Console.WriteLine(unit);
            //}
            //indexed Where Valid only in fluent Syntax

            //Query Syntax
            //var OutOfStockProducts = from product in ProductList
            //                         where product.UnitsInStock == 0 && product.Category == "Meat/Poultry"
            //                         select product;
            //foreach (var item in OutOfStockProducts)
            //{
            //    Console.WriteLine(item);
            //}

            // TypeOf
            //ArrayList list = ["Ahmed", 1, true, "Ali"];
            //var StringList = list.OfType<string>();
            //Console.WriteLine(string.Join(", ", StringList));
            #endregion

            #region Transformation (Projection) Operators - Select , SelectMany
            #region Select
            //var ProductNames = ProductList.Select(product => product.ProductName);

            //var ProductsNames = from product in ProductList
            //                    select product.ProductName;
            //var products = ProductList.Where(product => product.UnitsInStock == 0)
            //                                .Select((product, index) => $"{index + 1} : {product.ProductName}");
            //                                
            //var products = ProductList.Where(product => product.UnitsInStock != 0)
            //                           .Select(product => new
            //                           {
            //                               Id = product.ProductID,
            //                               Name = product.ProductName,
            //                               OldPrice = product.UnitPrice,
            //                               NewPrice = product.UnitPrice - (product.UnitPrice * 0.1m)
            //                           });

            //var products = from product in ProductList
            //               where product.UnitPrice > 1
            //               select new
            //               {
            //                   Id = product.ProductID,
            //                   Name = product.ProductName,
            //                   OldPrice = product.UnitPrice,
            //                   NewPrice = product.UnitPrice - (product.UnitPrice * 0.1m)
            //               };

            //var products = from product in ProductList
            //               select new { Id = product.ProductID, Name = product.ProductName };
            //foreach (var Product in products)
            //    Console.WriteLine(Product); 
            #endregion

            #region SelectMany
            // var orders = CustomerList.SelectMany(customer => customer.Orders , (customer,order)=> new {customer,order} );
            //var orders = from customer in CustomerList
            //             from order in customer.Orders
            //             select new { customer, order };
            //foreach (var order in orders)
            //    Console.WriteLine(order);
            #endregion
            #endregion

            #region Ordering Operators
            //var result = ProductList.OrderByDescending(product => product.ProductName)
            //                        .OrderByDescending(product => product.UnitsInStock)
            //                        .Select(product => new {Name = product.ProductName , UnitsAvailable=product.UnitsInStock})    ;

           //var result = from product in ProductList
           //          orderby product.ProductName descending, product.UnitsInStock descending
           //             select new { Name = product.ProductName, UnitsAvailable = product.UnitsInStock };

           // foreach (var Product in result)
           //     Console.WriteLine(Product);
            #endregion
        }
    }
}
