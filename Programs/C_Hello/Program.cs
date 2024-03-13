namespace Chello;

class Program
{
    static void Main(string[] args)
    {
        
        var rand = new Random(); 

        Console.WriteLine("THIS IS CORRECT");

        double[] arrayone  = new double[15];
        int len = arrayone.Length;

        for (int i=0; i<len; i++ )
        {
            arrayone[i] = i*0.8714;
            Console.WriteLine(arrayone[i]);
        }

    }
}
