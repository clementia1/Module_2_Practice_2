using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_2_Practice_2.Models;
using Module_2_Practice_2.Models.Animals;

namespace Module_2_Practice_2.Services.Interfaces
{
    public interface IParkArea
    {
        bool Push(ParkArea parkArea, Animal animal);

        bool Pop(ParkArea parkArea);

        bool Clear(ParkArea parkArea);

        public Animal[] FindDangerousByAge(ParkArea parkArea, int minAge, int maxAge);

        public void PrintAnimals(Animal[] animals);
    }
}
