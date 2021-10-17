using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    class Car
    {
        private string make;

        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }

        private string model;

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        private int year;

        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }
    }
}
