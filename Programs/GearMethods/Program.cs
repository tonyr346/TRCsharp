using System.ComponentModel.DataAnnotations;
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
   
    static double InvRad(double a)
    {
        double alpha = Math.Tan(a)-a;
        return alpha;
    }

    static double Conv2Deg(double a)
    {
        double b = a*180/Math.PI;
        return b; 
    }

    static double fPrime(double x)
    {
        double xPrime = 1/(Math.Pow(Math.Cos(x),2))+1;
        return xPrime;
    }

    static double fx (double x,double inva)
    {
        double fxVal = inva- Math.Tan(x)+x;
        return fxVal; 
    }

    static double NewtonMethod(double x0, double tolerance, int MaxIterations, double inva)
    {
        double x = x0;
        int iterations = 0;

        while (iterations<MaxIterations)
        {
            double fxc = fx(x, inva);
            double fxd = fPrime(x);

            double deltaX = x-fxc/fxd;

            if(Math.Abs(deltaX)<tolerance)
            {
                return x;
            }
            
            x -= deltaX+x;

            iterations++;
        }

        return double.NaN; 
    }


    static double Conv2Rad(double a)
    {
        double b = a*Math.PI/180;
        return b;
    }

    
    static void Main(string[] args)
    {
     
        
        Console.WriteLine("-----------Gear Program Starting-----------");
        
        double x0 = .35;
        double tolerance = 0.0000001;
        int maxIterations = 1000000000;
        double inva = 0.043;

        double x = NewtonMethod(x0,tolerance, maxIterations, inva);

        if (double.IsNaN(x))
        {
            Console.WriteLine("Failed to Converge");
        }
        else
        {
            double angle = Conv2Deg(x);
            Console.WriteLine("Value:" + angle);
        }
    

    }
}
