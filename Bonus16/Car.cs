using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus16
{ //number of cars
  //details for each car
  //print all cars

    //1. new class Car
    //2. string for make,model, int year, double for price
    //field is private
    //property is public
    //3. default constructor
    //4. another constructor that takes input for each of the 4 arguments
    //5. override ToString method returning a formatted string with the car details
    //6. class CarApp - creates a car object, and displays the car information
    class Car
    {
        string make;
        string model;
        int year;
        double price;
        
        public string Make
        {
            get
            {
                return make;
            }
            set
            {
                make = value;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }


         public Car()
            {
          
            }
       
    public Car(string CarMake, string carModel, int carYear, double carPrice)
        {
            make = CarMake;
            model = carModel;
            year = carYear;
            price = carPrice;

        }
        public override string ToString()
        {
            return make + "\t" + model + "\t" + year + "\t" + price;
        }
    }
}
