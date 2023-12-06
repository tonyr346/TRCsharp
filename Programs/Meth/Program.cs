namespace Meth;

class Program
{
    
  public class Calc
        {
            static public double DblRatio(double Np, double Ng)
            {
                double ratio = Ng / Np;
                return ratio;
            }
        }

        public class Gear : Calc
        {
            public double Np { get; set; }
            public double Ng { get; set; }
            public double Ratio { get; private set; }

            public void CalculateRatio()
            {
                // Calculate the ratio when needed
                Ratio = DblRatio(Np, Ng);
            }
        }

        static void Main(string[] args)
        {
            Gear Set1 = new Gear();

            // Set Np and Ng values
            Set1.Np = 18;
            Set1.Ng = 36.2;

            // Calculate the ratio after setting values
            Set1.CalculateRatio();

            // Access the ratio property
            Console.WriteLine(Set1.Ratio);

            // You can create additional sets
            Gear Set2 = new Gear();
            Set2.Np = 20;
            Set2.Ng = 40;

            // Calculate the ratio for Set2
            Set2.CalculateRatio();

            // Access the ratio property for Set2
            Console.WriteLine(Set2.Ratio);
        }
 }
