using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coke_Machine
{
    class Calculate
    {
        public static void MakeCalculation()
        {

            int c1 = 0;
            int c5 = 0;
            int c10 = 0;

            int Cokes;
            int cokeCost = 8;

            Console.WriteLine("This app calculates the minimum amount of Coins");
            Console.WriteLine("You need to buy soda(s).");

            Console.WriteLine();

            Console.WriteLine("Soda Cost: 8 Sek");
            Console.Write("How many Sodas would you like to buy? ");

            string stringCokes = Console.ReadLine();

            try
            {
                Cokes = Convert.ToInt32(stringCokes);

                int Price = Cokes * cokeCost;

                Console.WriteLine(Cokes + " Bottles of Coke will be: " + Price + " kr");
                Console.WriteLine();

                while (Price > 9)
                {
                    c10++;
                    Price = Price - 10;
                }
                while (Price > 4)
                {
                    c5++;
                    Price = Price - 5;
                }
                while (Price > 0)
                {
                    c1++;
                    Price = Price - 1;
                }

                Console.WriteLine(c10 + " Tens ");
                Console.WriteLine(c5 + " Fives ");
                Console.WriteLine(c1 + " Ones");
                Console.WriteLine("Is the minimal amount of coins needed.");
                Console.ReadKey();


            }
            catch (FormatException)
            {
                Console.Clear();
                MakeCalculation();
            }



        }
    }
}
