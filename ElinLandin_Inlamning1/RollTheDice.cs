using System;

namespace Inlamning1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Välkommen till Roll The Dice!");
            Console.WriteLine("För att vinna måste du kasta två sexor på samma kast!");
            Console.WriteLine("Tryck k för att kasta tärningarna, avsluta med x");
            Console.WriteLine("------------------------------------------------------");
   

        while(true)
            {
                
                string? input = Console.ReadLine();

                if (input =="k")
                {
                Random randomNumber = new Random();
                Random randomNumber2 = new Random();

                    int dice = randomNumber.Next(1, 7);
                    int dice2 = randomNumber2.Next(1, 7);
                    Console.WriteLine($"{dice}, {dice2}");

                        if (dice + dice2 == 12)
                        {
                            Console.WriteLine("Grattis, du vann!");
                            Console.WriteLine("-----------------------------");
                            Console.WriteLine("Vill du spela igen? Tryck k, avsluta med x");
                        }
                        else
                        {
                            Console.WriteLine("Tyvärr ingen vinst, vill du spela igen? Tryck k, avsluta med x");
                        }
                }
                
                else if (input == "x")
                {
                    Console.WriteLine("Avslutar");
                    break;
                }
                
            }

       }
    }
}

