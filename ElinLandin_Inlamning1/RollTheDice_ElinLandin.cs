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
   
            string? input = "";
            
        do
        {
                
            input = Console.ReadLine();

            switch (input)
            {
                case "k":

                    Random randomNumber = new Random();

                    int dice1 = randomNumber.Next(1, 7);
                    int dice2 = randomNumber.Next(1, 7);
                    
                    Console.WriteLine($"{dice1} | {dice2}");

                            if (dice1 + dice2 == 12)
                            {
                                Console.WriteLine("Grattis, du vann!");
                                Console.WriteLine("-----------------------------");
                                Console.WriteLine("Vill du spela igen? -> Tryck k | Avsluta med x");
                            }

                            else
                            {
                                Console.WriteLine("Tyvärr ingen vinst, vill du spela igen? -> Tryck k | Avsluta med x");
                            }

                    break;
                
                case "x":

                    Console.WriteLine("Avslutar");
                
                    break;
                
            }
        }
        while(input != "x");
        }
    }
}

