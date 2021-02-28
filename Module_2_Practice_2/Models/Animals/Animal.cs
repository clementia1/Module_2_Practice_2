using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice_2.Models.Animals
{
    public abstract class Animal
    {
        protected Animal(DateTime birthDate, bool isFertile, bool isDangerous)
        {
            BirthDate = birthDate;
            IsFertile = isFertile;
            IsDangerous = isDangerous;
        }

        public abstract string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsFertile { get; set; }
        public bool IsDangerous { get; set; }
        public int Age => DateTime.UtcNow.Year - BirthDate.Year;
    }
}
