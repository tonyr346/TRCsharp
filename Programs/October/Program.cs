namespace October;

class Program
{
    static int Calc1 (int a, int b)
    {
        int c = a*b;
        return c;
    }
    
    static void Main(string[] args)
    {
        Console.Write("Enter a Number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"You Entered: {a}");

        Console.Write("Enter a Number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        int c = Calc1(a,b);
        
        Console.WriteLine($"Solution: {c}");


    }
}
