using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePrice
{
    class HousePrice
    {
        static void Main(string[] args)
        {
            var smallRoom = double.Parse(Console.ReadLine());
            var kitchenRoom = double.Parse(Console.ReadLine());
            var priceM2 = double.Parse(Console.ReadLine());

            var bathRoom = smallRoom / 2;
            var secondRoom = smallRoom + smallRoom * 0.1;
            var thirdRoom = secondRoom + secondRoom * 0.1;
            var allRooms = smallRoom + kitchenRoom + bathRoom + secondRoom + thirdRoom + (smallRoom + kitchenRoom + bathRoom + secondRoom + thirdRoom)*0.05;
            var result = allRooms * priceM2;

            Console.WriteLine("{0:f2}", result);
        }
    }
}
