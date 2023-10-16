using System.Transactions;

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
    {ID = iD; Np=np; Ng=ng; ratio = Math.Round(GetRatio(),4);}

}

class Program
{
   
    
    static void Main(string[] args)
    {
        GSBasic HS = new GSBasic("010",19,64);
        GSBasic INTER = new GSBasic("010",17,82);
        GSBasic SS = new GSBasic("010",19,64);

        
        
        Console.WriteLine("-----------Gear Program Starting-----------");
        Console.WriteLine(HS.Np);
        double totalRatio = HS.ratio*INTER.ratio*SS.ratio;
        Console.WriteLine(Convert.ToString(Math.Round(totalRatio,4)));
        

    }
}
