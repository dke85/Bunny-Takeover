using System;


namespace BunnyTakeover

{
    class Program
    {
        static void Main()
        {
            Bunny BasicBun = new Bunny(500, 1.0);
            Console.WriteLine($"Bunny Multiplier: {BasicBun.Spawn}");
            Console.WriteLine($"Bunny Base: {BasicBun.Count}");

            while (BasicBun.Count < 7874965825){
                Console.Write($"Current Buns:{BasicBun.Count}, ");
                BasicBun.Count = BasicBun.Count + (BasicBun.Count*(long)Math.Round(BasicBun.Spawn));
                Console.Write($"increased to: {BasicBun.Count} \n");
            }
        }
    }
}
