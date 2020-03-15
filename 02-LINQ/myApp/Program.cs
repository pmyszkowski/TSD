using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSD.Linq.Cars;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {       
            // Task 1.7
            Car car7 = new Car("Toyota") { NumberOfSeats = null }; 
            int numOfSeats = car7.NumberOfSeats ??= 0; 
            Console.WriteLine("noSeats: " + numOfSeats);
            Console.WriteLine();
            // tests
            CarSalesBook book = new CarSalesBook();
            Console.WriteLine("1st car from hand is: " + book.CarsFromHand[0].Make);
            Console.WriteLine("2nd car from csv  is: " + book.CarsFromCsv[1].Make);
        }
    }
}
