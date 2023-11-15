using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public bool BreathesAir {  get; set; }
        public string PrimaryDiet { get; set; }
        public bool IsItPetWorth { get; set; }
        public bool IsItCreepy { get; set; }

    }
}
