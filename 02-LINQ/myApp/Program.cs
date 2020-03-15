using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
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

            // Task 2

            // 2.4
            IList<Car> query4 = (
                from car in book.CarsFromCsv
                orderby car.Sales2014 descending
                select car
            )
                .Take(5)
                .ToList();

            // 2.5 
            IList<Car> query5 = (
                from car in book.CarsFromCsv
                where car.Sales2015 >= 1.5 * car.Sales2014
                select car
            )
                .ToList();

            // 2.6 
            IList<Car> query6 = (
                from car in book.CarsFromCsv
                orderby car.Sales2015 descending
                select car
            )
                .Skip(10)
                .Take(3)
                .ToList();

            // 2.7 
            int sum = book.CarsFromCsv.Sum(car => car.Sales2014) 
                    + book.CarsFromCsv.Sum(car => car.Sales2015);

            // 2.8
            var tmp = (
                from car in book.CarsFromCsv
                orderby car.Sales2015 descending
                select car
                );
                
            IList<Car> query8 = 
                tmp
                .Take(10)
                .Concat(
                    tmp
                    .Skip(Math.Max(0, tmp.Count() - 10)))
                .ToList();

            //saveToXML
            var currentDirectory = Directory.GetCurrentDirectory();
            var filepath = Path.Combine(currentDirectory, "saved_cars.xml");

            var xml = new XElement("Cars", 
                    from car in book.CarsFromCsv
                    select new XElement("Car",
                        new XElement("Make", car.Make),
                        new XElement("Sales2014", car.Sales2014),
                        new XElement("Sales2015", car.Sales2015)
                    ));
            xml.Save(filepath);

            //loadFromXML
            XElement loadXML = XElement.Load(filepath);
            IList<Car> cars = loadXML
                .Descendants("Car")
                .Select(car => new Car(car.Element("Make").Value) {
                    Sales2014 = Convert.ToInt32(car.Element("Sales2014").Value),
                    Sales2015 = Convert.ToInt32(car.Element("Sales2015").Value)
                })
                .ToList();
        }   
    }
}
