namespace TRDEC;

class Program
{
    
    public class Person
    {
        
        public string? Name {get; set;}
        public string? Age  {get; set;}

    }

    public class Manager : Person
    {
        
        public string? Role {get; set;}
        public string? StartDate {get; set;}

        public double PayScale = 1.877;

    }

    public class Employee : Person
    {
        
        public string? Role {get; set;}
        public string? StartDate {get; set;}

        public double PayScale = 1.23;

    }

        public class Student : Person
    {
        
        public string? Role {get; set;}
        public string? StartDate {get; set;}

        public double PayScale = 1.03;

    }
    
    
    
    static void Main(string[] args)
    {
        
        Person Tony = new Person();
        Tony.Name = "Tony Roggenbuck";

        Manager TR = new Manager();
        TR.Role = "Owner";
        TR.Name = "Tony Roggenbuck";
        TR.StartDate = "07/23/2023";
        TR.Age = "38";

        Employee TR2 = new Employee();
        Student TR3 = new Student();


        Console.WriteLine(TR.Name);
        Console.WriteLine(TR.Role);
        Console.WriteLine(TR.Age);
        Console.WriteLine(TR.StartDate);

        double payMan = TR.PayScale * 40;
        double payEmp = TR2.PayScale*40;
        double payStu = TR3.PayScale*40;

        Console.WriteLine(payMan);
        Console.WriteLine(payEmp);
        Console.WriteLine(payStu);



    }
}
