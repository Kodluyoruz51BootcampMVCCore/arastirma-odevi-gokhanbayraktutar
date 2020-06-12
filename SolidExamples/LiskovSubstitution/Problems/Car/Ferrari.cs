using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiskovSubstitution.Problems.Car
{
    public class Ferrari : Car
    {
        public override string OpenAirConditioning()
        {
            return "Klima açıldı.";
        }
    }
}
