namespace IGIP
{
    public class Airforce : Soldier
    {
        public  Airforce(string name, string rank, int serialNumber ) : base (new Airplanes ())
        {
            this.Name = name;
            this.Rank = rank;
            this.SerialNum = serialNumber;
        }
    }
}