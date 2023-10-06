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
        int bal = 1000;
       
        Console.Write("Enter a Number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter a Number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        int c = Calc1(a,b);

        bal = bal-c;

        Console.WriteLine($"Balence: {bal}");
        int counter = 0;
        for (int i=0; i<20; i++)
        {
            counter = counter+1;
            bal = bal-i;
        }
        Console.WriteLine($"Number of Transactions: {counter}");
        Console.WriteLine($"Balence: {bal}");
    }
}
