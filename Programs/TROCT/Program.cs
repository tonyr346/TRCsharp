namespace TROCT;

class Program
{
    
    static void StartMessage()
    {
        Console.WriteLine("---1, ADD DATA----");
        Console.WriteLine("---2, COMPUTE-----");
        Console.WriteLine("---3, COMPUTE-----");
        Console.WriteLine("---9, EXIT--------");
        return ;
    }

    static string GetInput(string message)
    {
        Console.Write(message);
        string a = Console.ReadLine()!;
        return a;
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine("-----------PROGRAM STARTING-----------");

        int b;
                
        StartMessage();

        int e = Convert.ToInt32(GetInput("Enter a Number: "));

        if (e==9)
        {}
        else
        {   

        switch (e)
        {

            case 1:
            Console.WriteLine("You Chose Add");
            break;

            case 2: 
            Console.WriteLine("You Chose Compute");
            b = e*5;
            Console.WriteLine($"A x 5 = {b}");
            break;

            case 3:
            for (int i = 0; i<10; i++)
            {
                int counter = i+1;
                Console.WriteLine(counter);
            }
            break;


            default:
            Console.WriteLine("Invalid Input");
            break;


        }

        }



        
        Console.WriteLine("-----------PROGRAM END-----------");
    }
}
