using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cources08.Cars
{
    abstract class Car
    {
        private readonly string model;
        private readonly int year;

        public bool IsActive
        {
            get;
            set;
        }
        public string Model
        {
            get
            {
                return model;
            }
        }
        public int Year
        {
            get
            {
                return year;
            }
        }
        

        public Car(string model, int year)
        {
            this.model = model;
            this.year = year;
            this.IsActive = false;
        }
    }
}
