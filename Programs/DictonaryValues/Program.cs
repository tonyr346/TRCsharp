namespace DictonaryValues;


class Program
{
    
    public class Messages
    {
        public string M1 = "Hello";
        public string M2 = "Program Complete";
        public string UsrIn = "Enter a value: ";

        public string lne = "----------------------------------";

      
    }

    static void Display(string a)
    {
        Console.WriteLine(a);
        return;
    }

    static string GetData(string Message)
    {
        string usrstr = "";
        Console.WriteLine(Message);
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




    static void Main(string[] args)
     {
        Messages Dialog = new Messages(); 
        
        
        Display(Dialog.lne);
        Display(Dialog.M2);
        Display(Dialog.lne);
    }
}
