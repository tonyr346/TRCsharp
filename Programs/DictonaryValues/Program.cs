namespace DictonaryValues;


class Program
{
    
        
    public class Messages
    {
        public string M1 = "Hello";
        public string M2 = "Program Complete";
        public string UsrIn = "Enter a value: ";

        public string fail = "Failed";

        public string line = "----------------------------------";

      
    }

    static void Display(string a)
    {
        Console.WriteLine(a);
        return;
    }

    static string GetData(string Message)
    {
        string usrstr = "";
        Console.Write(Message);
        usrstr = Console.ReadLine()!;
        return usrstr;
    }
    public static bool check(string s) 
    { 
        return (s == null || s == String.Empty) ? true : false; 
    } 

    public static bool IsDouble(string text)
    {
         Double num = 0;
         bool isDouble = false;
 
        // Check for empty string.
        if (check(text))
        {
            return false;
        }
 
        isDouble = Double.TryParse(text, out num);
 
            return isDouble;
    }

    public static double RetDbl(string text)
    {
        double value = Convert.ToDouble(text);
        return value;
    }

  




    static void Main(string[] args)
     {
       
        Messages Dialog = new Messages(); 

        string value = GetData(Dialog.UsrIn);
        double a;

        if (IsDouble(value))
        {   a = RetDbl(value);
            double b = a * 5;
            Console.WriteLine(b);}
    
        else
        {Display(Dialog.fail);};

                
     
        
        
        Display(Dialog.line);
        Display(Dialog.M2);
        Display(Dialog.line);
    }
}
