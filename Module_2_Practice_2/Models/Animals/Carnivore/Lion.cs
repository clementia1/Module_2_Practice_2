﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_2_Practice_2.Models.Enums;

namespace Module_2_Practice_2.Models.Animals.Carnivore
{
    public class Lion : Carnivore
    {
        public Lion(LionType lionType, DateTime birthDate, bool isFertile, bool isDangerous)
            : base(birthDate, isFertile, isDangerous)
        {
            LionType = lionType;
        }

        public override string Name { get; set; } = "Lion";

        public LionType LionType { get; set; }
    }
}
