using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TSD.Linq.Cars
{
    public class Car
    {
        // Task 1.2
        public string Make { get; private set; }
        public int Sales2015 { get; set; }
        public int Sales2014 { get; set; }

        // Task 1.6
        public int? NumberOfSeats { get; set; }
        
        // Task 1.3
        public Car(string make) {
            Make = make;
        }
    } 
}
