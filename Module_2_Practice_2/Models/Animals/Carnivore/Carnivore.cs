using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice_2.Models.Animals.Carnivore
{
    public abstract class Carnivore : Animal
    {
        public Carnivore(DateTime birthDate, bool isFertile, bool isDangerous)
            : base(birthDate, isFertile, isDangerous)
        {
        }
    }
}
