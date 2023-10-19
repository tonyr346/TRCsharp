namespace TROCT;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-----------PROGRAM STARTING-----------");

        Console.WriteLine("---1, ADD DATA----");
        Console.WriteLine("---2, COMPUTE-----");

        string a = Console.ReadLine()!;
        int c = Convert.ToInt32(a);
        int b;

        switch (c)
        {

            case 1:
            Console.WriteLine("You Chose Add");
            break;

            case 2: 
            Console.WriteLine("You Chose Compute");
            b = c*5;
            Console.WriteLine($"A x 5 = {b}");
            break;

            default:
            Console.WriteLine("Invalid Input");
            break;


        }

        



        
        Console.WriteLine("-----------PROGRAM END-----------");
    }
}
