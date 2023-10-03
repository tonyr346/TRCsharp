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

        Console.WriteLine(d);
    }
}
