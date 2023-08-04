using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using CarLotSimulator;  

namespace CarLotSimulator
{
    public class Carlot
    { 
        public List<Car> ParkingLot { get; set; } = new List<Car>();
    
        public void CheckCars() 
        {
            foreach (var car in ParkingLot)
            {

                Console.WriteLine($"This is a {car.Make} {car.Model} made in the year {car.Year}");
                car.MakeEngineNoise(car.EngineNoise);
                car.MakehonkNoise(car.HonkNoise);
                Console.WriteLine();
            }
        }
        
    }

}    