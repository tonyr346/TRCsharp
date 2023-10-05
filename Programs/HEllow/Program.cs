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

        ///foreach (double number in numbers1)
        /// {
        ///    Console.WriteLine($"{number}");
        /// }

        List<int> Values = new List<int>();

        Values.Add(5);
        Values.Add(7);
        Values.Add(a);
        Values.Add(b);
        Values.Add(c);
        Values.Add(9);

        int [] numbers2 = new int [Values.Count];
        int [] numbers3 = new int [Values.Count];
        
        Console.WriteLine($"Length of List = {Values.Count}");

        int tot1=0;

        for (int i=0; i<Values.Count; i++)
        {
            tot1 = tot1+Values[i];
            numbers2[i] = tot1;
            numbers3[i] = i;
        }

        var res = numbers2.Zip(numbers3,(n,w) => new {Number = n, Word = w});
        
        Console.WriteLine($"Total Value of List = {tot1}");

    
        foreach(int numbers in numbers2)
        {
           
            Console.WriteLine(numbers);
         }

        foreach(var z in res)
        {
            Console.WriteLine($"Index {z.Word} = {z.Number}");
        }

    }
}
