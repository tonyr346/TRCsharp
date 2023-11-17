namespace DictonaryValues;


class Program
{
            
    public class Messages
    {
        public string M1 = "Hello";
        public string M2 = "Program Complete";
        public string UsrIn = "Enter a value: ";
        public string Usrnp = "Enter Np: ";
        public string Usrng = "Enter Ng: ";

        public string fail = "Failed";
        public string mratio = "Ratio: ";
        
        public string line = "----------------------------------";

      
    }

    static void Display(string a)
    {
        Console.WriteLine(a);
        return;
    }

    static bool TryGetDouble(string dialog, out double result)
        {
            result = 0;
            bool isValid = false;

            while (!isValid)
            {
                string value = GetData(dialog);

                if (IsDouble(value))
                {
                    result = RetDbl(value);
                    isValid = true;
                }
                else
                {
                    Display("Failed");
                }
            }
            return isValid;
        }    

    static string GetData(string Message)
    {
        string usrstr = "";
        Console.Write(Message);
        usrstr = Console.ReadLine()!;
        return usrstr;
    }
   
    public static bool IsDouble(string text)
        {
            double num = 0;
            return !string.IsNullOrEmpty(text) && double.TryParse(text, out num);
        }

    public static double RetDbl(string text)
    {
        return Convert.ToDouble(text);
    }

    static double Ratio(double a, double b)
    {
        double ratio = b /a;
        return ratio;
    }

    static double Center(double np, double ng, double pitch)
    {
        double Ctr = (pitch*np+pitch*ng)/2;
        return Ctr;
    }
  
    static void Main(string[] args)
     {
       
        Messages Dialog = new Messages(); 
        double np, ng, P;

        Display(Dialog.line);
        Console.WriteLine();

        np = TryGetDouble(Dialog.Usrnp, out double temp) ? temp : 0;
        ng = TryGetDouble(Dialog.Usrng, out temp) ? temp : 0; 
        P = TryGetDouble("Enter Pitch: ", out temp) ? temp : 0; 
        
        double ratio1 = Math.Round(Ratio(np,ng),4);
        double center = Math.Round(Center(np,ng,P),3);

        Display($"The Ratio is: {ratio1}");
        Display($"The Ctr Dist is: {center}");







        Display(Dialog.line);
        Display(Dialog.M2);
        Display(Dialog.line);
    }
}
