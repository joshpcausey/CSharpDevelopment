using LINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main()
        {
            //PrintAllProducts();


            //PrintAllCustomers();

            //Exercise1();
            //Exercise2();
            //Exercise3();
            //Exercise4();
            //Exercise5();
            //Exercise6();
            //Exercise7();
            //Exercise8();
            //Exercise9(); 
            //Exercise10();
            //Exercise11();
            //Exercise12();
            //Exercise13();
            //Exercise14();
            //Exercise15();
            //Exercise16();
            //Exercise17();
            //Exercise18();
            //Exercise19();
            //Exercise20();
            //Exercise22();
            //Exercise23();
            //Exercise24();
            //Exercise25();
            //Exercise26();
            //Exercise27();
            //Exercise28();
            //Exercise29();
            //Exercise30();
            //Exercise31();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        #region "Sample Code"
        /// <summary>
        /// Sample, load and print all the product objects
        /// </summary>
        static void PrintAllProducts()
        {
            List<Product> products = DataLoader.LoadProducts();
            PrintProductInformation(products);
        }

        /// <summary>
        /// This will print a nicely formatted list of products
        /// </summary>
        /// <param name="products">The collection of products to print</param>
        static void PrintProductInformation(IEnumerable<Product> products)
        {
            string line = "{0,-5} {1,-35} {2,-15} {3,6:c} {4,6}";
            Console.WriteLine(line, "ID", "Product Name", "Category", "Unit", "Stock");
            Console.WriteLine("==============================================================================");

            foreach (var product in products)
            {
                Console.WriteLine(line, product.ProductID, product.ProductName, product.Category,
                    product.UnitPrice, product.UnitsInStock);
            }

        }

        /// <summary>
        /// Sample, load and print all the customer objects and their orders
        /// </summary>
        static void PrintAllCustomers()
        {
            var customers = DataLoader.LoadCustomers();
            PrintCustomerInformation(customers);
        }

        /// <summary>
        /// This will print a nicely formated list of customers
        /// </summary>
        /// <param name="customers">The collection of customer objects to print</param>
        static void PrintCustomerInformation(IEnumerable<Customer> customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("==============================================================================");
                Console.WriteLine(customer.CompanyName);
                Console.WriteLine(customer.Address);
                Console.WriteLine("{0}, {1} {2} {3}", customer.City, customer.Region, customer.PostalCode, customer.Country);
                Console.WriteLine("p:{0} f:{1}", customer.Phone, customer.Fax);
                Console.WriteLine();
                Console.WriteLine("\tOrders");
                foreach (var order in customer.Orders)
                {
                    Console.WriteLine("\t{0} {1:MM-dd-yyyy} {2,10:c}", order.OrderID, order.OrderDate, order.Total);
                }
                Console.WriteLine("==============================================================================");
                Console.WriteLine();
            }
        }
        #endregion

        /// <summary>
        /// Print all products that are out of stock.
        /// </summary>
        static void Exercise1()
        {
            var allProducts = DataLoader.LoadProducts();

            var filtered = allProducts.Where(p => p.UnitsInStock == 0);

            PrintProductInformation(filtered);
        }

        /// <summary>
        /// Print all products that are in stock and cost more than 3.00 per unit.
        /// </summary>
        static void Exercise2()
        {
            var allProducts = DataLoader.LoadProducts();
            var filtered = allProducts.Where(p => p.UnitPrice > 3.00M);
            PrintProductInformation(filtered);
        }

        /// <summary>
        /// Print all customer and their order information for the Washington (WA) region.
        /// </summary>
        static void Exercise3()
        {
            var allCustomers = DataLoader.LoadCustomers();
            var filiteredCustomers = allCustomers.Where(c => c.Region == "WA");
            PrintCustomerInformation(filiteredCustomers);
        }

        /// <summary>
        /// Create and print an anonymous type with just the ProductName
        /// </summary>
        static void Exercise4()
        {
            var allProducts = DataLoader.LoadProducts();
            var justNames = allProducts.Select(n => new
            {
                Name = n.ProductName
            });
            foreach (var name in justNames)
            {
                Console.WriteLine(name);
            }
        }

        /// <summary>
        /// Create and print an anonymous type of all product information but increase the unit price by 25%
        /// </summary>
        static void Exercise5()
        {
            var allProducts = DataLoader.LoadProducts();
            var updatedProduct = allProducts.Select(p => new
            {
                Price = p.UnitPrice += p.UnitPrice * 25 / 100,
                Name = p.ProductName,
                ID = p.ProductID,
                Cat = p.Category,
                UnitsHere = p.UnitsInStock

            });
            foreach (var prod in updatedProduct)
            {
                Console.WriteLine(prod);
            }
        }

        /// <summary>
        /// Create and print an anonymous type of only ProductName and Category with all the letters in upper case
        /// </summary>
        static void Exercise6()
        {
            var allProducts = DataLoader.LoadProducts();
            var prodnprodc = allProducts.Select(p => new
            {
                productName = p.ProductName.ToUpper(),
                productCategory = p.Category.ToUpper()
            });
            foreach (var product in prodnprodc)
            {
                Console.WriteLine(product);
            }
        }

        /// <summary>
        /// Create and print an anonymous type of all Product information with an extra bool property ReOrder which should 
        /// be set to true if the Units in Stock is less than 3
        /// 
        /// Hint: use a ternary expression
        /// </summary>
        static void Exercise7()
        {
            var allProducts = DataLoader.LoadProducts();
            var editedProducts = allProducts.Select(p => new
            {
                Price = p.UnitPrice,
                Name = p.ProductName,
                ID = p.ProductID,
                Cat = p.Category,
                UnitsHere = p.UnitsInStock,
                ReOrder = p.UnitsInStock < 3 ? true : false
            });
            foreach (var prod in editedProducts)
            {
                Console.WriteLine(prod);
            }
        }

        /// <summary>
        /// Create and print an anonymous type of all Product information with an extra decimal called 
        /// StockValue which should be the product of unit price and units in stock
        /// </summary>
        static void Exercise8()
        {
            var allProducts = DataLoader.LoadProducts();
            var editedProducts = allProducts.Select(p => new
            {
                Price = p.UnitPrice,
                Name = p.ProductName,
                ID = p.ProductID,
                Cat = p.Category,
                UnitsHere = p.UnitsInStock,
                StockValue = p.UnitPrice * p.UnitsInStock
            });
            foreach (var prod in editedProducts)
            {
                Console.WriteLine(prod);
            }
        }

        /// <summary>
        /// Print only the even numbers in NumbersA
        /// </summary>
        static void Exercise9()
        {
            var Numbers = DataLoader.NumbersA;
            var EvenNumbers = Numbers.Where(n => n % 2 == 0);
            foreach (var num in EvenNumbers)
            {
                Console.WriteLine(num);
            }
        }

        /// <summary>
        /// Print only customers that have an order whos total is less than $500
        /// </summary>
        static void Exercise10()
        {
            var allCustomers = DataLoader.LoadCustomers();
            var lessThan500 = allCustomers.Where(c => c.Orders.Any(o => o.Total < 500));
            PrintCustomerInformation(lessThan500);
        }

        /// <summary>
        /// Print only the first 3 odd numbers from NumbersC
        /// </summary>
        static void Exercise11()
        {
            var Numbers = DataLoader.NumbersC;
            var firstThreeOdd = Numbers.Where(n => n % 2 != 0).Take(3);
            foreach (var num in firstThreeOdd)
            {
                Console.WriteLine(num);
            }
        }

        /// <summary>
        /// Print the numbers from NumbersB except the first 3
        /// </summary>
        static void Exercise12()
        {
            var Numbers = DataLoader.NumbersB;
            var after3 = Numbers.Skip(3);
            foreach (var num in after3)
            {
                Console.WriteLine(num);
            }
        }

        /// <summary>
        /// Print the Company Name and most recent order for each customer in Washington
        /// </summary>
        static void Exercise13()
        {
            var allCustomers = DataLoader.LoadCustomers();
            var updatedCustomers = allCustomers.Where(d => d.Region == "WA").Select(c => new
            {
                cName = c.CompanyName,
                recentOrder = c.Orders.OrderBy(g => g.OrderDate).Last()
            });
            foreach (var custom in updatedCustomers)
            {
                Console.WriteLine("Company Name: " + custom.cName + " Total: " + custom.recentOrder.Total + " Order ID: " + custom.recentOrder.OrderID + " OrdreDate: " + custom.recentOrder.OrderDate);
            }
        }

        /// <summary>
        /// Print all the numbers in NumbersC until a number is >= 6
        /// </summary>
        static void Exercise14()
        {
            var allNumbers = DataLoader.NumbersC;
            var filteredNumbers = allNumbers.TakeWhile(n => n <= 6);
            foreach (var num in filteredNumbers)
            {
                Console.WriteLine(num);
            }
        }

        /// <summary>
        /// Print all the numbers in NumbersC that come after the first number divisible by 3
        /// </summary>
        static void Exercise15()
        {
            var allNumbers = DataLoader.NumbersC;
            var filteredNumbers = allNumbers.SkipWhile(n => n % 3 != 0);
            foreach (var num in filteredNumbers)
            {
                Console.WriteLine(num);
            }
        }

        /// <summary>
        /// Print the products alphabetically by name
        /// </summary>
        static void Exercise16()
        {
            var allProducts = DataLoader.LoadProducts();
            var filteredProducts = allProducts.OrderBy(p => p.ProductName);
            foreach (var prod in filteredProducts)
            {
                Console.WriteLine(prod.ProductName);
            }
        }

        /// <summary>
        /// Print the products in descending order by units in stock
        /// </summary>
        static void Exercise17()
        {
            var allProducts = DataLoader.LoadProducts();
            var filteredProducts = allProducts.OrderByDescending(p => p.UnitsInStock);
            foreach (var prod in filteredProducts)
            {
                Console.WriteLine(prod.ProductName + " " + prod.UnitsInStock);
            }
        }

        /// <summary>
        /// Print the list of products ordered first by category, then by unit price, from highest to lowest.
        /// </summary>
        static void Exercise18()
        {
            var allProducts = DataLoader.LoadProducts();
            var orderByCat = allProducts.OrderBy(p => p.Category);
            var orderByPrice = allProducts.OrderByDescending(p => p.UnitPrice);
            foreach (var prod in orderByCat)
            {
                Console.WriteLine(prod.ProductName + " " + prod.Category);

            }
            foreach (var prod in orderByPrice)
            {
                Console.WriteLine(prod.ProductName + " " + prod.UnitPrice);
            }
        }

        /// <summary>
        /// Print NumbersB in reverse order
        /// </summary>
        static void Exercise19()
        {
            var allNumbers = DataLoader.NumbersB;
            var filteredNumbers = allNumbers.Reverse();
            foreach (var num in filteredNumbers)
            {
                Console.WriteLine(num);
            }
        }

        /// <summary>
        /// Group products by category, then print each category name and its products
        /// ex:
        /// 
        /// Beverages
        /// Tea
        /// Coffee
        /// 
        /// Sandwiches
        /// Turkey
        /// Ham
        /// </summary>
        static void Exercise20()
        {
            var allProducts = DataLoader.LoadProducts();
            var allProductsCats = allProducts.GroupBy(g => g.Category);
            foreach (var cat in allProductsCats)
            {
                Console.WriteLine(cat.Key);
                foreach (var prod in cat)
                {
                    Console.WriteLine(prod.ProductName);
                }
                Console.WriteLine("");
            }
        }

        /// <summary>
        /// Print all Customers with their orders by Year then Month
        /// ex:
        /// 
        /// Joe's Diner
        /// 2015
        ///     1 -  $500.00
        ///     3 -  $750.00
        /// 2016
        ///     2 - $1000.00
        /// </summary>
        static void Exercise21()
        {

        }

        /// <summary>
        /// Print the unique list of product categories
        /// </summary>
        static void Exercise22()
        {
            var allProducts = DataLoader.LoadProducts();
            var allProductsCats = allProducts.GroupBy(g => g.Category);
            foreach (var cat in allProductsCats)
            {
                Console.WriteLine(cat.Key);
                Console.WriteLine("");
            }
        }

        /// <summary>
        /// Write code to check to see if Product 789 exists
        /// </summary>
        static void Exercise23()
        {
            var allProducts = DataLoader.LoadProducts();
            var specnum = allProducts.Where(p => p.ProductID == 789);
            if (specnum.Any())
            {
                Console.WriteLine("Product exists");
            }
            else
            {
                Console.WriteLine("Product does not exist");
            }
        }

        /// <summary>
        /// Print a list of categories that have at least one product out of stock
        /// </summary>
        static void Exercise24()
        {
            var outOfStock = DataLoader.LoadProducts()
               .GroupBy(g => g.Category, i => i.UnitsInStock);


            foreach (IGrouping<string, int> group in outOfStock)
            {
                if (group.Contains(0)) Console.WriteLine(group.Key);
            }
        }

        /// <summary>
        /// Print a list of categories that have no products out of stock
        /// </summary>
        static void Exercise25()
        {
            var outOfStock = DataLoader.LoadProducts()
               .GroupBy(g => g.Category, i => i.UnitsInStock);

            foreach (IGrouping<string, int> group in outOfStock)
            {
                if (!group.Contains(0))
                {
                    Console.WriteLine(group.Key);
                }
            }
        }

        /// <summary>
        /// Count the number of odd numbers in NumbersA
        /// </summary>
        static void Exercise26()
        {
            var allNumbers = DataLoader.NumbersA;
            var count = 0;
            var evenNums = allNumbers.Where(num => num % 2 != 0);
            foreach (var num in evenNums)
            {
                count += 1;
            }
            Console.WriteLine(count);
        }

        /// <summary>
        /// Create and print an anonymous type containing CustomerId and the count of their orders
        /// </summary>
        static void Exercise27()
        {
            var allCustomers = DataLoader.LoadCustomers();
            var customerAndCount = allCustomers.Select(c => new
            {
                cusID = c.CustomerID,
                orderCount = c.Orders.Length
            });
            foreach (var cus in customerAndCount)
            {
                Console.WriteLine(cus.cusID + " " + cus.orderCount);
            }
        }

        /// <summary>
        /// Print a distinct list of product categories and the count of the products they contain
        /// </summary>
        static void Exercise28()
        {
            var allProducts = DataLoader.LoadProducts();
            var allProdCats = allProducts.GroupBy(p => p.Category);
            var catAndCount = allProdCats.Select(g => new
            {
                cName = g.Key,
                cCount = g.Count()
            });
            foreach(var cat in catAndCount)
            {
                Console.WriteLine(cat.cName + " " + cat.cCount);
            }
        }

        /// <summary>
        /// Print a distinct list of product categories and the total units in stock
        /// </summary>
        /// need help
        static void Exercise29()
        {
            var allProducts = DataLoader.LoadProducts();
            var result = from product in allProducts
                         orderby product.Category, product.UnitsInStock
                         group product by product.Category;
            foreach (var group in result)
            {
                Console.WriteLine(group.Key);
                foreach (var prod in group.OrderByDescending(p => p.UnitsInStock))
                {
                    Console.WriteLine("\t{0}, {1}", prod.ProductName, prod.UnitsInStock);
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Print a distinct list of product categories and the lowest priced product in that category
        /// </summary>
        static void Exercise30()
        {
            var catsAndLowUnits = DataLoader.LoadProducts()
               .GroupBy(g => g.Category)
               .Select(i => new
               {
                   Cat = i.Key,
                   Prod = i.OrderBy(o => o.UnitPrice).First(),
                   Price = i.Min(m => m.UnitPrice)

               });

            foreach (var units in catsAndLowUnits)
            {
                Console.WriteLine($"{units.Cat} has {units.Prod.ProductName} at  + {units.Price:c}");
            }
        }

        /// <summary>
        /// Print the top 3 categories by the average unit price of their products
        /// </summary>
        static void Exercise31()
        {
            var filteredlist = DataLoader.LoadProducts()
                .GroupBy(g => g.Category)
                .Select(g => new
                {
                    cat = g.Key,
                    average = g.Average(o => o.UnitPrice )
                });
            var orderdlist = filteredlist.OrderByDescending(g => g.average).Take(3);
            foreach(var cat in orderdlist)
            {
                Console.WriteLine(cat.cat + " " + cat.average);
            }
        }
    }
}
