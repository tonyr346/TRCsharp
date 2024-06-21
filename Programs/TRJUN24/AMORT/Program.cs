namespace AMORT;

class Program
{
    
    static double PmtCalc(int Years, double rate, double Principle)
    {
        double P = Principle;
        double r = (double) rate / 12/100;
        int n  = Years*12;

        double pmt =  P*((r*Math.Pow((1+r),n))/((Math.Pow((1+r),n)-1)));
        return pmt;

    }

    static string ToDollars(double value)
    {
        string Value = "$ " + Convert.ToString(Math.Round(value, 2));
        return Value;
    }
    
    public class Messages
    {
        public string Principle = "Enter Principle:   ";
        public string APR = "Enter APR:  ";
        public string Years = "Enter Years:   ";


    }

    static int GetValueInt()
    {
        return Convert.ToInt32(Console.ReadLine());
    }
    
    static double GetValueDbl()
    {
        return Convert.ToDouble(Console.ReadLine());
    }

    static void WriteMessage(string a)
    {
        Console.Write(a);
        
    }
   
    static void Main(string[] args)
    {

        Messages messages= new Messages();

        WriteMessage(messages.Principle);    
        double P = GetValueDbl();
        WriteMessage(messages.Years);    
        int Years = GetValueInt();
        WriteMessage(messages.APR);    
        double Rate = GetValueDbl();

        double pMT = PmtCalc(Years, Rate, P);

        string PMT = ToDollars(pMT);

        Console.WriteLine("Payment:           " + PMT);


    }
}
