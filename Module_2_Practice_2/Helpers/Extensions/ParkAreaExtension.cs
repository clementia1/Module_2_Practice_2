using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_2_Practice_2.Models;
using Module_2_Practice_2.Models.Animals;

namespace Module_2_Practice_2.Helpers.Extensions
{
    public static class ParkAreaExtension
    {
        public static int Push(this ParkArea parkArea, Animal animal)
        {
            var index = Array.IndexOf(parkArea.Animals, default(Animal));

            if (index != -1)
            {
                parkArea.Animals[index] = animal;
            }

            return index;
        }

        public static void Pop(this ParkArea parkArea)
        {
            for (int i = parkArea.Animals.Length - 1; i >= 0; i--)
            {
                if (parkArea.Animals[i] != default(Animal))
                {
                    parkArea.Animals[i] = default(Animal);
                    break;
                }
            }
        }

        public static bool Clear(this ParkArea parkArea)
        {
            Array.Clear(parkArea.Animals, 0, parkArea.Animals.Length);
            return true;
        }

        public static ParkArea FilterDangerous(this ParkArea parkArea)
        {
            var res = new ParkArea();
            res.Animals = Array.FindAll(parkArea.Animals, item => item.IsDangerous == true);
            return res;
        }

        public static ParkArea FilterByAge(this ParkArea parkArea, int minAge, int maxAge)
        {
            var res = new ParkArea();
            res.Animals = Array.FindAll(parkArea.Animals, item => item.Age > minAge && item.Age < maxAge);
            return res;
        }

        public static int CountAnimalTypes(this ParkArea parkArea)
        {
            var counter = 0;
            var types = new Type[parkArea.Animals.Length];

            static bool CheckItem(Type[] array, Type item)
            {
                return Array.Exists(array, element => element == item);
            }

            for (int i = 0; i < parkArea.Animals.Length; i++)
            {
                if (!CheckItem(types, parkArea.Animals[i].GetType()))
                {
                    types[i] = parkArea.Animals[i].GetType();
                    counter++;
                }
            }

            return counter;
        }
    }
}
