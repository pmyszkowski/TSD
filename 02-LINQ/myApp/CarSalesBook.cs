using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1;
using TSD.Linq.Cars;

namespace TSD.Linq.Cars
{
    public class CarSalesBook
    {
        public IList<Car> CarsFromHand { get; private set; }
        public IList<Car> CarsFromCsv  { get; private set; }

        public CarSalesBook()
        {
            CarsFromHand = GenerateCars();
            CarsFromCsv  = ReadCarsFromFile();
        }
        private IList<Car> GenerateCars()
        {
            // Task 1.4 & 1.5
            var cars = new List<Car>()
            {
                new Car("Skoda") {Sales2014 = 45529, Sales2015 = 44243},
                new Car("Toyota") {Sales2014 = 36465, Sales2015 = 31484},
                new Car("BMW") {Sales2014 = 9549, Sales2015 = 7714},
            };

            IList<Car> sortedCars = cars.OrderBy(c => c.Sales2015).ToList();
        
            return cars;
        }

        public IList<Car> ReadCarsFromFile()
        {
            return CarDataFileReader.ReadCarsFromCSVFile();
        }
    }
}
