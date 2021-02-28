using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice_2.Models.Animals.Herbivore.Antelopes
{
    public abstract class Antelope : Herbivore
    {
        public Antelope(DateTime birthDate, bool isFertile, bool isDangerous)
            : base(birthDate, isFertile, isDangerous)
        {
        }
    }
}
