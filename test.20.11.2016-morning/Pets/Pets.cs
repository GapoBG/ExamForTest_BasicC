using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Pets
    {
        static void Main(string[] args)
        {
            var brDays = int.Parse(Console.ReadLine());
            var foods = int.Parse(Console.ReadLine());
            var kgFoodDogs = double.Parse(Console.ReadLine());
            var kgFoodCats = double.Parse(Console.ReadLine());
            var kgFoodTurtle = double.Parse(Console.ReadLine())/1000;
            var delta = 0.0;

            var needFoodDogs = brDays * kgFoodDogs;
            var needFoodCats = brDays * kgFoodCats;
            var needFoodTurtle = brDays * kgFoodTurtle;

            var needFoodAll = (needFoodDogs + needFoodCats + needFoodTurtle);

            if (needFoodAll <= foods)
            {
                delta = Math.Floor(foods - needFoodAll);
                Console.WriteLine("{0} kilos of food left.", delta);
            }
            else
            {
                delta = Math.Ceiling(needFoodAll - foods);
                Console.WriteLine("{0} more kilos of food are needed.", delta);
            }
        }
    }
}
