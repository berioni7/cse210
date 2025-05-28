using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineOrderingEncapsulation
{
    class Product
    {
        private string name;
        private double price;

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public string GetName()
        {
            return name;
        }

        public double GetPrice()
        {
            return price;
        }
    }

    class Order
    {
        private List<Product> products;

        public Order()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product p)
        {
            products.Add(p);
        }

        public double CalculateTotal()
        {
            double total = 0;
            foreach (var p in products)
            {
                total += p.GetPrice();
            }
            return total;
        }

        public string GetOrderSummary()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order Summary:");
            foreach (var p in products)
            {
                sb.AppendLine($"- {p.GetName()}: $ {p.GetPrice():F2}");
            }
            sb.AppendLine($"Total: $ {CalculateTotal():F2}");
            return sb.ToString();
        }
    }

    class Customer
    {
        private string name;
        private string address;

        public Customer(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        public string GetName()
        {
            return name;
        }

        public string GetAddress()
        {
            return address;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("John Smith", "123 Flower Street");
            Order order = new Order();

            order.AddProduct(new Product("Shirt", 79.90));
            order.AddProduct(new Product("Jeans", 120.50));
            order.AddProduct(new Product("Sneakers", 250.00));

            Console.WriteLine($"Customer: {customer.GetName()}");
            Console.WriteLine($"Address: {customer.GetAddress()}");
            Console.WriteLine(order.GetOrderSummary());
        }
    }
}
