using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus16
{
    class CarApp
    {
        public static void BuildCarList()
        {
            List<Car> myCarList = new List<Car>();
            int userInput = GetNumberOfCars();
          

            for (int i = 1; i <= userInput; i++)
            {
                Console.WriteLine("Enter car # "+ i +" make: ");
                string make = Console.ReadLine();
                Console.WriteLine("Enter car # " + i + " model: ");
                string model = Console.ReadLine();
                Console.WriteLine("Enter car # " + i + " year:");
                int year = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter car # " + i + " price:");
                double price = double.Parse(Console.ReadLine());

                Car myCar = new Car();
                myCar.Make = make;
                myCar.Model = model;
                myCar.Year = year;
                myCar.Price = price;

                myCarList.Add(myCar);

            }

            foreach (Car item in myCarList)
            {
                Console.WriteLine(item.ToString());
            }

            
        }

        public static int GetNumberOfCars()
        {
            Console.WriteLine("Please enter number of cars you want:");
            int userInput = int.Parse(Console.ReadLine());
            return userInput;
        }

    }
}
