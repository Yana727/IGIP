namespace IGIP
{
    public class Navy : Soldier
    {
        public Navy(string name, string rank, int serialNum) : base (new Boats())
        {
        this.Name = name;
        this.Rank = rank; 
        this.SerialNum = serialNum;
        }
    }
}