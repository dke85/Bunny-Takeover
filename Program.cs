using System;


namespace BunnyTakeover

{
    class Program
    {
        static void Main()
        {
            long BunTotal = 0;
            
            Bunny BasicBun = new Bunny(500, 1.0);
            Bunny SuperBun = new Bunny(500, 5.0);

            Console.WriteLine($"Bunny Multiplier: {BasicBun.Spawn}");
            Console.WriteLine($"Bunny Base: {BasicBun.Count}");

            while ( BunTotal < 7874965825){


                for( int LoopCount = 0; LoopCount <= 100; LoopCount++){

                    Console.Write($"Current Buns:{BunTotal}, ");

                    BunTotal = BunTotal + (
                    BasicBun.Count*(long)Math.Round(BasicBun.Spawn) +
                    SuperBun.Count*(long)Math.Round(SuperBun.Spawn)
                    );

                    Console.Write($"increased to: {BunTotal} \n");

                    if(LoopCount == 100){

                        Console.WriteLine($"You have {BasicBun.Count} Basic bunnies and {SuperBun.Count} Super bunnies. How many Super Buns would you like?");
                        SuperBun.Count = SuperBun.Count + long.Parse(Console.ReadLine());

                    }

                }

            }
        }
    }
}
