using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_2_Practice_2.Models.Enums;

namespace Module_2_Practice_2.Models.Animals.Herbivore
{
    public class Buffalo : Herbivore
    {
        public Buffalo(BuffaloType buffaloType, DateTime birthDate, bool isFertile, bool isDangerous)
            : base(birthDate, isFertile, isDangerous)
        {
            BuffaloType = buffaloType;
        }

        public override string Name { get; set; } = "Buffalo";

        public BuffaloType BuffaloType { get; set; }
    }
}
