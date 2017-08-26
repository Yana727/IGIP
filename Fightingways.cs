using System;

namespace IGIP
{ //prevents from creating many other classes
    public interface IFightingways
    {
     void DoDamage(); 
    }
    public class Bombs: IFightingways
    {
        public void DoDamage()
        {
            Console.WriteLine("Plant bombs");
        }
    }

    public class Airplanes: IFightingways 
    {
        public void DoDamage()
        {
            Console.WriteLine("Fly airplanes"); 
        }
    }

    public class Boats: IFightingways 
    {
        public void DoDamage()
        {
            Console.WriteLine("Work on ships"); 
        }
    }
}