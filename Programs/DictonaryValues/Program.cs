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

        public string path = "/workspaces/TRCsharp/Programs/DictonaryValues/Outputs";
        
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

     static void SaveToText(double Np, double Ng, double Pitch, double Center, double ratio)
    {
        // Combine the directory path and the filename using Path.Combine
        string fn = "Array.txt";
        string usrFn = "";
        bool isok = true;
       
        Console.Write("Enter File Name:");
       
        usrFn = Console.ReadLine()!;

        isok = string.IsNullOrEmpty(usrFn);

         if (isok == true)
        usrFn = fn;
         else
         usrFn = usrFn +".txt";
       
       
       
        string outputPath = Path.Combine("/workspaces/TRCsharp/Programs/DictonaryValues/Outputs/", usrFn);

        using (StreamWriter writer = new StreamWriter(outputPath))
        {
            writer.WriteLine($"FileName={usrFn}");
            writer.WriteLine($"Np={Np}");
            writer.WriteLine($"Ng={Ng}");
            writer.WriteLine($"Pitch={Pitch}");
            writer.WriteLine($"Center={Center}");
            writer.WriteLine($"Ratio={ratio}");
        }
    }
    
    static void ReadSpecificDataFromText(string path, string filename, string key)
    {
        // Combine the directory path and the filename using Path.Combine
        string filePath = Path.Combine(path, filename);

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line="";
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('=');
                if (parts.Length == 2 && parts[0] == key)
                {
                    Console.WriteLine($"{key}: {parts[1]!}");
                    break; // Stop reading once the desired key is found
                }
            }
        }
    }
    
    static void CreateTXT(List<double> A)
    {
       

       string stpath = (@"/workspaces/TRCsharp/Programs/DictonaryValues/Outputs/");
       
       string fn = "Array.txt";
       string usrFn = "";
       bool isok = true;
       
       Console.Write("Enter File Name:");
       
       usrFn = Console.ReadLine()!;

       isok = string.IsNullOrEmpty(usrFn);

       if (isok == true)
       usrFn = fn;
       else
       usrFn = usrFn +".txt";

       using (StreamWriter sw = new StreamWriter(Path.Combine(stpath,usrFn)))
       {
         foreach (var i in A)
        {
            sw.WriteLine(i);
        }
       
         return;

       }    
    }

    static List<double> CreLis(double a, double b, double c, double d)
    {
        List <double> AList = new List<double>();
    
       AList.Add(a);
       AList.Add(b);
       AList.Add(c);
       AList.Add(d);

       return AList;
    }
  
    static void Main(string[] args)
     {
       
        Messages Dialog = new Messages(); 
        List<double> Outputs = new List<double>(); 

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

        Outputs = CreLis(np, ng, P, center);

        SaveToText(np,ng,P,center,ratio1);

        string userreq = GetData("Enter Which Set you want the ratio for: ");
        string pt2 = userreq+".txt";

        ReadSpecificDataFromText(Dialog.path,pt2, "Ratio");

  

        Display(Dialog.line);
        Display(Dialog.M2);
        Display(Dialog.line);
    }
}
