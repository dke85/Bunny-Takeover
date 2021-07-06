using System;

namespace BunnyTakeover
{
    class Bunny : IBunny
    {

       public Bunny(long count, double spawn){
           Count = count;
           Spawn = spawn;
       }

       public long Count{get; set;}
       public double Spawn{ get; set;}

    }

}
