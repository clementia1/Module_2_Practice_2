using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice_2.Models.Animals
{
    public abstract class Animal
    {
        protected Animal(DateTime birthDate)
        {
            BirthDate = birthDate;
        }

        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age => DateTime.UtcNow.Year - BirthDate.Year;
    }
}
