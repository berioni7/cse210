using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineOrderingEncapsulation
{
    class Address
    {
        private string street;
        private string city;
        private string state;
        private string country;

        public Address(string street, string city, string state, string country)
        {
            this.street = street;
            this.city = city;
            this.state = state;
            this.country = country;
        }

        public bool IsUSA()
        {
            return country.ToUpper() == "USA";
        }

        public string GetFullAddress()
        {
            return $"{street}\n{city}, {state}\n{country}";
        }
    }

    class Customer
    {
        private string name;
        private Address address;

        public Customer(string name, Address address)
        {
            this.name = name;
            this.address = address;
        }

        public bool LivesInUSA()
        {
            return address.IsUSA();
        }

        public string GetName()
        {
            return name;
        }

        public string GetAddress()
        {
            return address.GetFullAddress();
        }
    }

    class Product
    {
        private string name;
        private string productId;
        private double price;
        private int quantity;

        public Product(string name, string productId, double price, int quantity)
        {
            this.name = name;
            this.productId = productId;
            this.price = price;
            this.quantity = quantity;
        }

        public string GetName()
        {
            return name;
        }

        public string GetProductId()
        {
            return productId;
        }

        public double GetPrice()
        {
            return price;
        }

        public int GetQuantity()
        {
            return quantity;
        }

        public double GetTotalPrice()
        {
            return price * quantity;
        }
    }

    class Order
    {
        private List<Product> products;
        private Customer customer;

        public Order(Customer customer)
        {
            this.customer = customer;
            this.products = new List<Product>();
        }

        public void AddProduct(Product p)
        {
            products.Add(p);
        }

        public double CalculateTotal()
        {
            double total = 0;
            foreach (Product p in products)
            {
                total += p.GetTotalPrice();
            }
            // Shipping cost
            total += customer.LivesInUSA() ? 5.0 : 35.0;
            return total;
        }

        public string GetPackingLabel()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Packing Label:");
            foreach (Product p in products)
            {
                sb.AppendLine($"{p.GetName()} (ID: {p.GetProductId()})");
            }
            return sb.ToString();
        }

        public string GetShippingLabel()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Shipping Label:");
            sb.AppendLine(customer.GetName());
            sb.AppendLine(customer.GetAddress());
            return sb.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create addresses
            Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
            Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

            // Create customers
            Customer customer1 = new Customer("John Smith", address1);
            Customer customer2 = new Customer("Alice Johnson", address2);

            // Create orders
            Order order1 = new Order(customer1);
            order1.AddProduct(new Product("Shirt", "SKU123", 25.99, 2));
            order1.AddProduct(new Product("Jeans", "SKU456", 45.50, 1));

            Order order2 = new Order(customer2);
            order2.AddProduct(new Product("Book", "SKU789", 15.00, 3));
            order2.AddProduct(new Product("Pen", "SKU321", 1.50, 10));

            // Display order 1
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order1.CalculateTotal():F2}");
            Console.WriteLine();

            // Display order 2
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order2.CalculateTotal():F2}");
        }
    }
}
