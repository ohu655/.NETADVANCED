using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private List<Topping> toppings;
        private Dough dough;


        public Pizza(string name, Dough dough)
        {
            Name = name;
            Dough = dough;
            toppings = new List<Topping>();
        }

        public string Name
        {
            get 
            {
                return name;
            }

            private set 
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                name = value; 
            }
        }

        public IReadOnlyCollection<Topping> Toppings => toppings;

        public Dough Dough
        {
            get { return dough; }
            set { dough = value; }
        }

        public void AddTopping(Topping topping)
        {
            if (toppings.Count > 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            toppings.Add(topping);
        }

        public double CalculateAllCalories()
        {
            double result = Dough.CalculateCalorie + toppings.Sum(x => x.CalculateCalorie);
            return result;
        }

        public override string ToString()
        {
            return $"{Name} - {CalculateAllCalories():f2} Calories.";
        }
    }
}
