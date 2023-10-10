namespace GearMethods;
 
public class GSBasic
{
    string ID;
    public int Np, Ng;
    public double ratio;
    public double GetRatio ()
    {
        ratio = (double) Ng/Np;
        return ratio;
    }
    
  


    public GSBasic (string iD,int np, int ng)
    {ID = iD; Np=np; Ng=ng; Ratio = Math.Round(GetRatio(),4);}

}

class Program
{
    
    
    static void Main(string[] args)
    {
        Console.WriteLine("-----------Gear Program Starting-----------");

    }
}
