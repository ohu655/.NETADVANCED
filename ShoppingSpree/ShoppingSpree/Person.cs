using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bagOfProducts;

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            bagOfProducts = new List<Product>();
        }

        public IReadOnlyCollection<Product> BagOfProducts => bagOfProducts;

        public string Name
        {
            get 
            { 
                return name; 
            }

            private set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                name = value; 
            }
        }


        public decimal Money
        {
            get 
            { 
                return money; 
            }

            private set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value; 
            }
        }

        public void AddProduct(Product product)
        {
            if (product.Cost <= Money)
            {
                bagOfProducts.Add(product);
                Money -= product.Cost;
                Console.WriteLine($"{Name} bought {product.Name}");
            }
            else
            {
                Console.WriteLine($"{Name} can't afford {product.Name}");
            }
        }

        public override string ToString()
        {
            return string.Join(", ", BagOfProducts.Select(x => x.Name));
        }
    }
}
