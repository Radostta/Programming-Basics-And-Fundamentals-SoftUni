using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreyAndBilliard_Original
{
    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> ProductsAndQuantity { get; set; }
        public decimal Bill { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Entering product list with product - price:
            var products = new Dictionary<string, decimal>();
            GetProductsAndPrices(products);

            //Taking orders:
            string line = Console.ReadLine();

            List<Customer> customers = new List<Customer>();
                
            while (line != "end of clients")
            {
                var order = line.Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string name = order[0];
                string product = order[1];
                int quantity = int.Parse(order[2]);

                if (products.ContainsKey(product))
                {
                    bool customerIsPresent = false;

                    Customer customer = new Customer();
                    customer.Name = name;
                    customer.ProductsAndQuantity = new Dictionary<string, int>();
                    customer.ProductsAndQuantity.Add(product, quantity);
                    customer.Bill = customer.Bill + products[product] * quantity;
                    
                    foreach (var c in customers)
                    {
                        if (c.Name == customer.Name)
                        {
                            customerIsPresent = true;
                            if (c.ProductsAndQuantity.ContainsKey(product))
                            {
                                c.ProductsAndQuantity[product] += quantity;
                            }
                            else
                            {
                                c.ProductsAndQuantity.Add(product, quantity);
                            }
                            c.Bill += products[product] * quantity;
                        }
                    }

                    if (!customerIsPresent)
                    {
                        customers.Add(customer);

                    }
                }
                line = Console.ReadLine();
            }

            //Printing:
            decimal totalBill = 0m;

            foreach (var c in customers.OrderBy(s => s.Name))
            {
                Console.WriteLine(c.Name);
                foreach (var productAndQuantity in c.ProductsAndQuantity)
                {
                    Console.WriteLine($"-- {productAndQuantity.Key} - {productAndQuantity.Value}");
                }
                Console.WriteLine($"Bill: {c.Bill:f2}");
                totalBill += c.Bill;
            }

            Console.WriteLine($"Total bill: {totalBill:f2}");
        }

        private static void GetProductsAndPrices(Dictionary<string, decimal> products)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split('-');
                var product = line[0];
                var price = decimal.Parse(line[1]);

                if (!products.ContainsKey(product))
                {
                    products.Add(product, 0); //price is 0, instead of "price", because later we may have to override it
                }

                products[product] = price; //overrides the price, instead of adding the new one to the hardcoded one 
            }
        }
    }
}
