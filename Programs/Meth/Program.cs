namespace Meth;

class Program
{
    
  public class SetData:Calc
  {
    public double Np, Ng, Mod, Ratio;
    public double CD {get; private set;}

    public SetData(Gear A, double mod)
    {
        Np = A.Np;
        Ng = A.Ng;
        Mod = mod;
        CD = CalcCD1(A.Np, A.Ng, Mod);
        Ratio = DblRatio (A.Np, A.Ng);
        
    }




  }
  
  public class Calc
        {
            static public double DblRatio(double Np, double Ng)
            {
                double ratio = Ng / Np;
                return ratio;
            }

            static public double CalcCD1(double Np, double Ng, double Mod)
            {
                double CD1 = (Np+Ng)*Mod/2;
                return CD1;
            }


        }

        public class Gear : Calc
        {
            public double Np { get; set; }
            public double Ng { get; set; }
        }

        static void Main(string[] args)
        {
            Gear Set1 = new Gear();

            // Set Np and Ng values
            Set1.Np = 18;
            Set1.Ng = 39;
            
            SetData Set1D = new SetData(Set1, 4);
            
                 

            Console.WriteLine($"CD: {Set1D.CD}");
            Console.WriteLine($"Ratio: {Set1D.Ratio}");




        }
 }
