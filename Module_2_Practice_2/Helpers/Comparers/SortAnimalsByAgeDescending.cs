using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_2_Practice_2.Models;
using Module_2_Practice_2.Models.Animals;

namespace Module_2_Practice_2.Helpers.Comparers
{
    public class SortAnimalsByAgeDescending : IComparer<Animal>
    {
        public int Compare(Animal a, Animal b)
        {
            if (a.Age > b.Age)
            {
                return 1;
            }

            if (a.Age < b.Age)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
