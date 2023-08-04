using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Done

            var carLot = new Carlot();
            {
                

                var bronco = new Car();
                bronco.Make = "Ford";
                bronco.Model = "Bronco";
                bronco.Year = 1977;
                bronco.IsDriveable = true;
                bronco.EngineNoise = "a sea lion";
                bronco.HonkNoise = "honk honk";

                carLot.ParkingLot.Add(bronco);



                var bmw = new Car();

                bmw.Make = "Bmw";
                bmw.Model = "M3";
                bmw.Year = 2023;
                bmw.IsDriveable = true;
                bmw.EngineNoise = "vroom";
                bmw.HonkNoise = "beep";


                carLot.ParkingLot.Add(bmw);



                var chevy = new Car();

                chevy.Make = "Chevy";
                chevy.Make = "Chevy";
                chevy.Model = "Impala";
                chevy.Year = 1967;
                chevy.IsDriveable = true;
                chevy.EngineNoise = "boom";
                chevy.HonkNoise = "bip";


                carLot.ParkingLot.Add(chevy);

                carLot.CheckCars();







            }
        }


    }
}       
    

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        
