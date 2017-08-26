using System;
using System.Linq; 
using System.Collections.Generic; 

namespace IGIP
{
    class Program 
    {
        static void Main(string[] args)
        {
            var Bobby = new Airforce ("Bobby Bond", "Sgt", "123"); //why doesn't it accept the class
            Bobby.Fight(); 
            var Wendy = new Navy ("Wendy Sammy", "Sgt", "123");
            Wendy.Fight(); 
            var Cindi = new Marines ("Cindy Smith", "123"); 
            Cindi.Fight(); 

            var Military = new List<Soldier>(); 
            Military.Add(Wendy);
            Military.Add(Bobby);
            Military.Add(Cindi); 

            Console.WriteLine($"Airforce: {Bobby.Name}. Rank:{Bobby.Rank}. Serial number{Bobby.SerialNum}. How he fights: {Bobby.Fightingways}"); 
            Console.WriteLine($"Airforce: {Wendy.Name}. Rank:{Wendy.Rank}. Serial number{Wendy.SerialNum}. How he fights: {Wendy.Fightingways}"); 
            Console.WriteLine($"Airforce: {Cindi.Name}. Rank:{Cindi.Rank}. Serial number{Cindi.SerialNum}. How he fights: {Cindi.Fightingways}"); 

            Bobby.NumBombs(); //What do these do?
            Wendy.NumSmokes();
            Cindi.NumBandages();

        }
    }
}
