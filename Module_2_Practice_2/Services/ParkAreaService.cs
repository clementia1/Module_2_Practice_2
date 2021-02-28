using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_2_Practice_2.Services.Interfaces;
using Module_2_Practice_2.Helpers.Extensions;
using Module_2_Practice_2.Models;
using Module_2_Practice_2.Models.Animals;

namespace Module_2_Practice_2.Services
{
    public class ParkAreaService : IParkArea
    {
        public bool Push(ParkArea parkArea, Animal animal)
        {
            parkArea.Push(animal);
            return true;
        }

        public bool Pop(ParkArea parkArea)
        {
            parkArea.Pop();
            return true;
        }

        public bool Clear(ParkArea parkArea)
        {
            parkArea.Clear();
            return true;
        }

        public Animal[] FindDangerousByAge(ParkArea parkArea, int minAge, int maxAge)
        {
            var dangerousAnimals = parkArea.FilterDangerous();
            return dangerousAnimals.FilterByAge(minAge, maxAge).Animals;
        }

        public void PrintAnimals(Animal[] animals)
        {
            foreach (var item in animals)
            {
                Console.WriteLine($"{item.Name}, age: {item.Age}, dangerous: {item.IsDangerous}, fertile: {item.IsFertile}");
            }
        }
    }
}
