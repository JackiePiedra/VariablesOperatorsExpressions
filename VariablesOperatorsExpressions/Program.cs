using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesOperatorsExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Jackie";
            //Console.WriteLine(name);

            name = "Dave";
            //Console.WriteLine(name);

            string birthMonth = "September";
            //Console.WriteLine(birthMonth);
            //integers
            int birthMonthNumber = 9;
            int age = 33;
            int population = 100000;
            //Floating type variables
            float number = 2.164403304897294383961032f;
            double someNumber = 2.164403304897294383961032d;
            decimal partialNumber = 2.164403304897294383961032m;

            //Console.WriteLine(number);
            //Console.WriteLine(someNumber);
            //Console.WriteLine(partialNumber);

            //Boolean
            bool isPresent = true;
            bool seatTaken = false;

            //Character
            char lastLetter = 'p';

            int jessicaAge = 23;
            int samAge = 47;
            Console.WriteLine(jessicaAge > samAge);

            //Mike and three friends split a bill
            //Each person pays $13
            //What is the total bill?
            int numberGuests = 4;
            int guestPay = 13;
            Console.WriteLine(numberGuests * guestPay);

            //Lisa needs 7 cups sugar
            //She's used 2 cups
            //How many cups does she need?
            int totalNeeded = 7;
            int totalUsed = 2;
            Console.WriteLine(totalNeeded - totalUsed);

            //How many packages of diapers can you buy for $40 if each costs $8
            int totalMoney = 40;
            int diaperPrice = 8;
            Console.WriteLine(totalMoney / diaperPrice);
        }
    }
}
