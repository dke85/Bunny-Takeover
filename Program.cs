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
            Bunny MegaBun = new Bunny(1000, 10.0);

            Console.WriteLine($"Bunny Multiplier: {BasicBun.Spawn}");
            Console.WriteLine($"Bunny Base: {BasicBun.Count}");
            Console.WriteLine($"Super Bunny Multiplier: {SuperBun.Spawn}");
            Console.WriteLine($"Super Bunny Base: {SuperBun.Count}");
            Console.WriteLine($"Mega Bunny Multiplier: {MegaBun.Spawn}");
            Console.WriteLine($"Mega Bunny Base: {MegaBun.Count}");
            Console.WriteLine("Press Any Key To Continue...");
            Console.ReadKey();

            while ( BunTotal < 7874965825){


                for( int LoopCount = 0; LoopCount <= 100; LoopCount++){

                    Console.Write($"Current Buns: {BunTotal}, ");

                    BunTotal = BunTotal + (
                    BasicBun.Count*(long)Math.Round(BasicBun.Spawn) +
                    SuperBun.Count*(long)Math.Round(SuperBun.Spawn) +
                    MegaBun.Count*(long)Math.Round(MegaBun.Spawn)
                    );

                    Console.Write($"increased to: {BunTotal} \n");

                    if(LoopCount == 100){

                        Console.WriteLine($"You have {BasicBun.Count} Basic bunnies, {SuperBun.Count} Super bunnies, and {MegaBun.Count} Mega bunnies.");
                        Console.WriteLine($"How many Bunnies would you like?");
                        BasicBun.Count = BasicBun.Count + long.Parse(Console.ReadLine());
                        Console.WriteLine($"How many Super Bunnies would you like?");
                        SuperBun.Count = SuperBun.Count + long.Parse(Console.ReadLine());
                        Console.WriteLine($"How many Mega Bunnies would you like?");
                        MegaBun.Count = MegaBun.Count + long.Parse(Console.ReadLine());

                    }

                    if(BunTotal > 7874965825){
                        break;
                    }

                }

            }
        }
    }
}
