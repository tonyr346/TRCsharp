namespace id2;

class Program
{
    
    public class Messages
    {
        public string M1 = "Begin";
        public string M2 = "End";
        public string M3 = "Enter Value";
        public string M4 = "Solution";
    }


    
    
    
    static void Main(string[] args)
    {
        Messages Message = new Messages();

       double [] doubles = {0,0,1,0,1,0,1};
        
        Console.WriteLine(Message.M1);
         int i = 0;
         
        int dLength = doubles.Length;

        foreach (double d in doubles)
        {  
            if (d ==1)
            {
            Console.WriteLine($"{i} {d} ON"); 
            }
            else
            {
            Console.WriteLine($"{i} {d} OFF");
            }
            i++;
        
            
        
        
        }

    

        Console.WriteLine($"Total Items: {dLength}");
        Console.WriteLine(Message.M2);




    }
}
