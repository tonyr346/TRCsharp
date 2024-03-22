namespace STREAMER;



class Program
{
    public class dataRow 
    {
        public string N="";
        public double VAL=0;
        public string U="";

        public dataRow (string n, double val, string u)
        {
            N=n;
            VAL = val;
            U = u;
        }

    }
    
    static void Main(string[] args)
    {
        string outputfolder = "/workspaces/TRCsharp/Programs/TRMAR/STREAMER";
        string defaultstr = "default.csv";
        string defaultOut = outputfolder + defaultstr;
        string name = "Position";
        

        dataRow val1 = new dataRow(name, 1.00, "IN");

        List<dataRow> Position = new List<dataRow>();

        for (int i=1; i<10; i++)
        {
            
            string nm = name + Convert.ToString(i);
            double p = 2*i+Math.Pow(i,2)/Math.Pow(i,3);

            dataRow nm1 = new dataRow(Convert.ToString(i+1), p , "in" );
            Position.Add(nm1);
        }        


        
        foreach (dataRow row in Position)
        {
            
            string rounded =Math.Round(row.VAL, 3).ToString("F3");
            string paddedb = rounded.PadLeft(8,'0');
            Console.WriteLine(paddedb);
        }
        
              
        
       
        
    }
}
