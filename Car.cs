using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsMethodOverloading
{
    public class Car
    {
        //Create a class: Car ✔ 

        //FIELDS : ✔ 
        string _make;
        string _model;
        int _year;
        int _mileage;

        //3 needed constructors 

        //1. DEFAULT CONSTRUCTOR: ✔ 
        public Car()
        {

        }

        //2. - Car(make, model) // Takes two arguments - Might be used for a new car year and mileage should be set to 0  ✔ 
        public Car(string make, string model)
        {
            Make = make;
            Model = model;
            _mileage = 0; 
        }

        //3. Car (make, model, year, mileage)✔ 
        public Car(string make, string model, int year, int mileage)
        {
            Make = make;
            Model = model;
            Year = year;
            Mileage = mileage;
        }
        //4. Properties for all ✔ 
        public string Make { get => _make; set => _make = value; }
        public string Model { get => _model; set => _model = value; }
        public int Year { get => _year; set => _year = value; }
        public int Mileage { get => _mileage; set => _mileage = value; }

        //5. Override ToString()  Year Make Model - Mileage ✔ 

        public override string ToString()
        {
            return $"The Car - \n Year: {_year} \n Make: {_make} \n Model: {_model} \n Mileage: {_mileage} miles"; 
        }
    }
}
