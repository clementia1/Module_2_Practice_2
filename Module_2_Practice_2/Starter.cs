using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_2_Practice_2.Services;
using Module_2_Practice_2.Models;
using Module_2_Practice_2.Helpers.Extensions;
using Module_2_Practice_2.Helpers.Comparers;
using Module_2_Practice_2.Models.Enums;
using Module_2_Practice_2.Models.Animals;
using Module_2_Practice_2.Models.Animals.Herbivore;
using Module_2_Practice_2.Models.Animals.Carnivore;
using Module_2_Practice_2.Models.Animals.Herbivore.Antelopes;

namespace Module_2_Practice_2
{
    public class Starter
    {
        public void Run()
        {
            var parkArea = new ParkArea();
            var parkAreaService = new ParkAreaService();

            parkArea.Animals = new Animal[7];
            parkAreaService.Push(parkArea, new Lion(LionType.TransvaalLion, new DateTime(2015, 05, 09), true, true));
            parkAreaService.Push(parkArea, new Tiger(TigerType.BengalTiger, new DateTime(2012, 11, 23), false, true));
            parkAreaService.Push(parkArea, new Buffalo(BuffaloType.AmericanBuffalo, new DateTime(2010, 3, 04), true, false));
            parkAreaService.Push(parkArea, new Buffalo(BuffaloType.CapeBuffalo, new DateTime(2010, 07, 12), true, false));
            parkAreaService.Push(parkArea, new RoanAntelope(new DateTime(2014, 07, 12), true, false));
            parkAreaService.Push(parkArea, new SableAntelope(new DateTime(2015, 07, 12), true, false));
            parkAreaService.Push(parkArea, new ImpalaAntelope(new DateTime(2016, 07, 12), true, false));

            var dangerousAnimals = parkAreaService.FindDangerousByAge(parkArea, 7, 10);
            parkAreaService.PrintAnimals(dangerousAnimals);

            Array.Sort(parkArea.Animals, new SortAnimalsByAgeDescending());
            parkAreaService.PrintAnimals(parkArea.Animals);

            Console.WriteLine($"Different animal types in park: {parkArea.CountAnimalTypes()}");
        }
    }
}
