﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoom
{
    class HotelRoom
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int days = int.Parse(Console.ReadLine());
 
            double studio = 0.0;
            double apartment = 0.0;
 
            if (month == "may" || month == "october")
            {
                if (days > 14)
                {
                    studio = 50.0 - (50.00 * 0.30);
                    apartment = 65.0 - (65.00 * 0.10);
                }
                else if (days < 8)
                {
                    studio = 50.0;
                    apartment = 65.0;
                }
                else if (days > 7 || days <= 14)
                {
                    studio = 50.0 - (50.00 * 0.05);
                    apartment = 65.0;
                }
            }
            else if (month == "june" || month == "september")
            {
                if (days > 14)
                {
                    studio = 75.20 - (75.20 * 0.20);
                    apartment = 68.70 - (68.70 * 0.10);
                }
                else
                {
                    studio = 75.20;
                    apartment = 68.70;
                }
            }
            else if (month == "july" || month == "august")
            {
                if (days > 14)
                {
                    studio = 76.00;
                    apartment = 77.00 - (77.00 * 0.10);
                }
                else
                {
                    studio = 76.00;
                    apartment = 77.00;
                }
            }
            double studioPrice = studio * days;
            double apartmentPrice = apartment * days;
 
            Console.WriteLine("Apartment: {0:f2} lv.", apartmentPrice);
            Console.WriteLine("Studio: {0:f2} lv.", studioPrice);
        }
    }
}
