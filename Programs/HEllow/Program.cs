namespace HEllow;

class Program
{
    static double CalcMain(int angle)
    {
        double c = Math.PI * angle / 180;
        c = Math.Sin(c);
        return c;
    }


    static void Main(string[] args)
    {
        int a = 30;
        int b = 7;
        int c = a +b;
        double d;
        d = CalcMain(a);

        d = Math.Round(d,2);

        double[] numbers1 = {0,32, 4,6} ;

        foreach (double number in numbers1)
        {
            Console.WriteLine($"{number}");
        }


        Console.WriteLine(d);
    }
}
