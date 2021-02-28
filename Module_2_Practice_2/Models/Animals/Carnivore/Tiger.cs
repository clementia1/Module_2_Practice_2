using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_2_Practice_2.Models.Enums;

namespace Module_2_Practice_2.Models.Animals.Carnivore
{
    public class Tiger : Carnivore
    {
        public Tiger(TigerType tigerType, DateTime birthDate, bool isFertile, bool isDangerous)
            : base(birthDate, isFertile, isDangerous)
        {
            TigerType = tigerType;
        }

        public override string Name { get; set; } = "Tiger";

        public TigerType TigerType { get; set; }
    }
}
