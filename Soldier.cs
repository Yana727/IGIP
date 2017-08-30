using System; 

namespace IGIP
{
    public abstract class Soldier //abstract, bc all others will inherit, but not create a "soldier"
    { //parent class for details
        public string Name { get; set; }

        public string Rank { get; set; }

        public int SerialNum { get; set; }

        public IFightingways Fightingways {get; set;}  

        public Soldier(IFightingways fighting) //WHY???
        {
         this.Fightingways = fighting; //WHY???
        }

        public void Fight()
        {
             this.Fightingways.DoDamage(); //WHY???
        }
        // eat
        //method : 
        // accessModifier returnType Name(parameters)
        public void Eat()
        {
           Console.WriteLine("nom nom");
        }
        public void Sleep()
        {
            Console.WriteLine("Zzzzz"); 
        }
        public void Walk()
        {
            Console.WriteLine("Stride"); 
        }
    }

}