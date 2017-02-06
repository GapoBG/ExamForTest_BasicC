using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Vacatin
    {
        static void Main(string[] args)
        {
            var brPeople = int.Parse(Console.ReadLine());
            var brStudents = int.Parse(Console.ReadLine());
            var sleepNights = int.Parse(Console.ReadLine());
            var transport = Console.ReadLine().ToLower();
            var people = 0;
            var student = 0;
            var razhodTRANS = 0.00;
            var hotel = 0.00;
            var comision = 0.00;
            var tax = 0.1;
            var result = 0.00;

            if (transport == "train")
            {
                if (brPeople + brStudents < 50)
                {
                    people = brPeople * sleepNights;
                    student = brStudents * sleepNights;
                    razhodTRANS = (brPeople * 24.99 + brStudents * 14.99) * 2;
                    hotel = sleepNights * 82.99;
                    comision = (razhodTRANS + hotel) * tax;
                    result = razhodTRANS + hotel + comision;
                }
                else
                {
                    people = brPeople * sleepNights;
                    student = brStudents * sleepNights;
                    razhodTRANS = (brPeople * 24.99 + brStudents * 14.99);
                    hotel = sleepNights * 82.99;
                    comision = (razhodTRANS + hotel) * tax;
                    result = razhodTRANS + hotel + comision;
                }
            }
            else if (transport == "bus")
            {
                people = brPeople * sleepNights;
                student = brStudents * sleepNights;
                razhodTRANS = (brPeople * 32.50 + brStudents * 28.50) * 2;
                hotel = sleepNights * 82.99;
                comision = (razhodTRANS + hotel) * tax;
                result = razhodTRANS + hotel + comision;
            }
            else if (transport == "boat")
            {
                people = brPeople * sleepNights;
                student = brStudents * sleepNights;
                razhodTRANS = (brPeople * 42.99 + brStudents * 39.99) * 2;
                hotel = sleepNights * 82.99;
                comision = (razhodTRANS + hotel) * tax;
                result = razhodTRANS + hotel + comision;
            }

            else if (transport == "airplane")
            {
                people = brPeople * sleepNights;
                student = brStudents * sleepNights;
                razhodTRANS = (brPeople * 70 + brStudents * 50) * 2;
                hotel = sleepNights * 82.99;
                comision = (razhodTRANS + hotel) * tax;
                result = razhodTRANS + hotel + comision;

            }

            Console.WriteLine("{0:f2}",result);
        }
    }
}
