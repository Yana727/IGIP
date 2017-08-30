namespace IGIP
{
    public class Marines : Soldier
    {
        public Marines(string name, string rank, int serialNumber) : base (new Bombs()) 
        {
         this.Name = name;
         this.Rank = rank; 
         this.SerialNum= serialNumber; 
        }
    }
}