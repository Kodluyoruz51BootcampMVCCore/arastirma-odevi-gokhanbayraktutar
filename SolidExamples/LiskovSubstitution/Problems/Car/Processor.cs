using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiskovSubstitution.Problems.Car
{
    public class Processor 
    {
        static void Main(string[] args)
        {
            Car car = new Ferrari();

            car.Run();
            car.OpenAirConditioning();


            car = new Şahin();

            car.Run();
            car.OpenAirConditioning(); // ?
        }
    }
}
