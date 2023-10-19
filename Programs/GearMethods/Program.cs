using System;
using System.Security.AccessControl;

namespace GearMethods
{
    public class GSBasic
    {
        private string ID;
        public int Np, Ng;
        public double Ratio { get; private set; }

        public GSBasic(string id, int np, int ng)
        {
            ID = id;
            Np = np;
            Ng = ng;
            CalculateRatio();
        }

        private void CalculateRatio()
        {
            Ratio = (double)Ng / Np;
        }
    }

    public static class AngleConversion
    {
        public static double InvRad(double a) => Math.Tan(a) - a;
        public static double Conv2Deg(double a) => a * 180 / Math.PI;
        public static double Conv2Rad(double a) => a * Math.PI / 180;
    }

    public static class NewtonMethod
    {
        public static double CalculateRoot(double x0, double tolerance, int maxIterations, double inva)
        {
            double x = x0;

            for (int iterations = 0; iterations < maxIterations; iterations++)
            {
                double fxc = inva - Math.Tan(x) + x;
                double fxd = -1+(1/(Math.Pow(Math.Cos(x),2)));

                double deltaX = x - fxc / fxd;

                if (Math.Abs(deltaX) < tolerance)
                {
                    return x;
                }

                x = deltaX;
            }

            throw new InvalidOperationException("Failed to converge");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------Gear Program Starting-----------");

            double x0 = 0.15;
            double tolerance = 0.0001;
            int maxIterations = 1000000000;
            double inva = 0.019;

            try
            {
                double x = NewtonMethod.CalculateRoot(x0, tolerance, maxIterations, inva);
                double angle = AngleConversion.Conv2Deg(x);
                Console.WriteLine("Value: " + angle);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
