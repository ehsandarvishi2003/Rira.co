namespace ConsoleApp3
{
    internal class Program
    {
        public class Public
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Category { get; set; }
            public int Price { get; set; }
        }
        static void Main(string[] args)
        {
            #region Static data

            List<Public> products = new List<Public>
            {
                new Public { Id = 1, Name = "Product A", Category = "Category 1", Price = 100
            },
                new Public { Id = 2, Name = "Product B", Category = "Category 2", Price = 150
            },
                new Public { Id = 3, Name = "Product C", Category = "Category 1", Price = 120
            },
                new Public { Id = 4, Name = "Product D", Category = "Category 3", Price = 200
            },
                new Public { Id = 5, Name = "Product E", Category = "Category 2", Price = 80 }
            };

            #endregion

            #region 1
            //Find Product with Id=1
            var ProductWithId1 = products.FirstOrDefault(p => p.Id == 1);

            //Print result
            if (ProductWithId1 != null) 
            {
                Console.WriteLine($"Id:{ProductWithId1.Id}," +
                    $"Name:{ProductWithId1.Name}," +
                    $"Category:{ProductWithId1.Category}," +
                    $"Price:{ProductWithId1.Price}");
            }
            Console.WriteLine();

            #endregion

            #region 2
            //Find the most expensive product
            var MaxPriceProduct =products.OrderByDescending(p=>p.Price).FirstOrDefault();

            //Print result
            if (MaxPriceProduct != null)
            {
                Console.WriteLine($"Id:{MaxPriceProduct.Id}," +
                    $"Name:{MaxPriceProduct.Name}," +
                    $"Category:{MaxPriceProduct.Category}," +
                    $"Price:{MaxPriceProduct.Price}");
            }
            Console.WriteLine();
            #endregion

            #region 3
            //Find total price of all products
            var TotalPrice=products.Sum(p=>p.Price);

            //Print result
            if (TotalPrice != null)
            {
                Console.WriteLine($"Total price:{TotalPrice}");
            }
            else
            {
                Console.WriteLine("The price value is empty");
            }
            Console.WriteLine();
            #endregion

            #region 4
            //Sort by grouping
            var GroupedProducts =products.GroupBy(p=>p.Category);

            //Print result
            foreach(var group in GroupedProducts)
            {
                Console.WriteLine($"Ctegory:{group.Key}");
                foreach(var product in group)
                {
                    Console.WriteLine(
                        $"Product name:{product.Name}," +
                        $"Product price;:{product.Price}");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            #endregion

            #region 5

            var AveragePrice=products.Average(p=>p.Price);

            Console.WriteLine($"Average price:{AveragePrice}");

            #endregion

        }
    }
}