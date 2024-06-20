namespace AMORT;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Enter Principle:     ");
        int P = Convert.ToInt32(Console.ReadLine());
        
        
        Console.Write("Enter Years:         ");
        int A = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Rate (%APR):   ");
        double b =  Convert.ToDouble(Console.ReadLine());

        double r = (double)b/100/12;
        int n = A*12;
      
        
        double Payment = P*((r*Math.Pow((1+r),n))/((Math.Pow((1+r),n)-1)));

        string PMT = "$ " + Convert.ToString(Math.Round(Payment, 2));

        Console.WriteLine("Payment:           " + PMT);


    }
}
