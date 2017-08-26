using System; 

namespace IGIP
{
    public abstract class Soldier : IFight //abstract, bc all others will inherit, but not create a "soldier"
    { //parent class for details
        public string Name { get; set; }

        public int Rank { get; set; }

        public int SerialNum { get; set; }

        public IFight Fightingways {get; set;} //WHY???? 

        public Soldier (IFight fighting) //WHY???

        {
         this.Fightingways = fighting; //WHY???
        }

        public void Fight()
        {
         this.Fightingways.DoDamage(); //WHY???
         
        }

    }

}