namespace GearOCT;
    
   
public class GearSet 
{
    public int np { get; set;}
    public int ng { get;set;}

    public double ratio => CalculateRatio();




    private double CalculateRatio()
    {
      return (double)ng/np;
    }
    
}


class Program
{
    
    static void Main(string[] args)
    {
        int Np = 21;
        int Ng = 64;
        int Np2 = 18;
        int Ng2 = 73;
        //int Ng = 66;
        //double Pn = 2.5000;
        //double PAn = 25.000;
       // double HA = 13.000;
        //string HAdir = "LEFT";
        //double PD = 2.1313;
        //double OD = 2.3870;
       // int Q = 11;
        //double Add = 0.1329;
        //double WD = 0.2350;
        //double BLmin = 0.007;
        //double BLmax = 0.011;
        //double X1 = 0.3500;
        //double a = 1.0000;
        //double ChAdd = 0.1366;
       //double TTmax = 0.1831;
        //double TTmin = 0.1803;
        //int Nspan = 4;
        //double SpanMax = 1.0672;
        //double SpanMin = 1.0646;
        //string Mate = "712501-203";
        //double CD = 4.4095;
       // double ODmate = 6.8259;

        GearSet Set1 = new GearSet();
        Set1.np = Np;
        Set1.ng = Ng;
        double ratio1 = Set1.ratio;

        GearSet Set2 = new GearSet();

        Set2.np = Np2;
        Set2.ng = Ng2;
        double ratio2 = Set2.ratio;

        double OAR = ratio1*ratio2;

        Console.WriteLine(Math.Round(Set1.ratio,4));
        Console.WriteLine(Math.Round(Set2.ratio,4));
        Console.WriteLine(Math.Round(OAR,4));
        

    }
}
