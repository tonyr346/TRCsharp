namespace IFz;

class Program
{
   
    
    
    static double Add(double a, double b)
    {return a+b;}
   
    static double Sub(double a, double b)
    {return a-b;}
   
   
   
    static void Main(string[] args)
    {
        
        double A = 10;
        double B = 24;
        double D=1;
        
        bool C = false;

        if (A>B)
        {C = true;}

        if (C==true)
        {
            D = Sub(A,B);
        }
        else if (B>A)
        {
            D = Add(A,B);
        }
        else
        {
            Console.WriteLine("Sorry");
            D = 0;
        }

        if (D==0)
        {Console.WriteLine("A = B");}
        else
        {Console.WriteLine($"D = {D}");}


    }
}
