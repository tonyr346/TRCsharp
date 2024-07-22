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

    static void Custom()
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
   
    static void Main(string[] args)
    {

        Messages messages= new Messages();
        Console.WriteLine("Enter 1 for 30yr Cur Rate, 2 for Custom");
        int selection = Convert.ToInt32(Console.ReadLine());

        if (selection == 1)
        {
            WriteMessage(messages.Principle);    
            double P = GetValueDbl();
            double pMT = PmtCalc(30, 6.4, P);

            string PMT = ToDollars(pMT);

            Console.WriteLine("Payment:  " + PMT);         
        }
        if (selection == 2)
        {
            Custom();
        }
        
    
        
           
            
        

             


    }
}
