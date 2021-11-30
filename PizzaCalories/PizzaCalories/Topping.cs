using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private string type;
        private int grams;
        Dictionary<string, double> topings = new Dictionary<string, double>()
        {
            {"meat",1.2 },
            {"veggies", 0.8 },
            {"cheese", 1.1 },
            {"sauce", 0.9 }
        };

        public Topping(string type, int grams)
        {
            Type = type;
            Grams = grams;
        }

        public string Type
        {
            get 
            {
                return type; 
            }

            private set 
            {
                if (!topings.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                type = value; 
            }
        }

        public int Grams
        {
            get 
            {
                return grams;
            }

            private set 
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{Type} weight should be in the range [1..50].");
                }
                grams = value;
            }
        }

        public double CalculateCalorie => (2 * Grams) * topings[Type.ToLower()];
    }
}
