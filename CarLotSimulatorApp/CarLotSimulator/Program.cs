using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Done



            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var bronco = new Car();
            bronco.Make = "Ford";
            bronco.Model = "Bronco";
            bronco.Year = 1977;
            bronco.IsDriveable = true;

            bronco.MakeEngineNoise("a sea lion");
            bronco.MakehonkNoise("honk honk");
            Console.WriteLine();


            var bmw = new Car()
            {
                Make = "Bmw",
                Model = "M3",
                Year = 2023,
                IsDriveable = true

            };

            bmw.MakeEngineNoise("vroom vroom");
            bmw.MakehonkNoise("beep");
            Console.WriteLine();

            var chevy = new Car()
            {
                Make = "Chevy",
                Model = "Impala",
                Year = 1967,
                IsDriveable = true 

            };

            chevy.MakeEngineNoise("boom boom");
            chevy.MakehonkNoise("beep bop");
            Console.WriteLine();
        }


    }
}
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        
