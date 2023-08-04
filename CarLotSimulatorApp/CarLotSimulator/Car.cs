using System;
namespace CarLotSimulator
{
    public class Car
    {

    
        public Car()
        {

        }

        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;  
        }
    

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise(string engineNoise)
        {
            EngineNoise = engineNoise;
            Console.WriteLine($"{Make} {Model} has engine noise that sounds like {EngineNoise}");

        }

        public void MakehonkNoise(string honkNoise)
        {
            HonkNoise = honkNoise;
            Console.WriteLine($"{Make} {Model} has an honk noise that sounds like {honkNoise}");

        }


            
    }
}

