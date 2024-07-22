namespace idk;

class Program
{
    public class Asset
    {
        public string Name;
        public double Value;

        

        public Asset(string name, double value)
        {
            Name = name;
            Value = value;
        }
    }


    static void Main(string[] args)
    {
        Asset House = new Asset("House", 150000);
        double InitialValue = House.Value;
        

        for (int i=1; i<11;i++)
        {
            House.Value = House.Value*1.07;
        }

        double Increase = House.Value/InitialValue*100;


        Console.WriteLine(House.Name);
        Console.WriteLine(House.Value);
        Console.WriteLine($"{Math.Round(Increase,0)} Percent");

    }
}
