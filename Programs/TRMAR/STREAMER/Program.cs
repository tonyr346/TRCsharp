namespace STREAMER;
using System.IO;
using Newtonsoft.Json;
using CsvHelper;
using CsvHelper.Configuration;


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
        string outputfolder = "/workspaces/TRCsharp/Programs/TRMAR/STREAMER/outputs";
        string defaultstr = "default.csv";
        string defaultOut = Path.Combine(outputfolder, defaultstr);
        string name = "Position";
        double j = 2;

        dataRow val1 = new dataRow(name, 1.00, "IN");

        List<dataRow> Position = new List<dataRow>();

        for (double i=2; i<500;i++)
            {
            
            string nm = name + Convert.ToString(i);
            double p = 2*j+Math.Pow(j,2)/Math.Pow(j,3)-Math.Pow(j,2);

            dataRow nm1 = new dataRow(Convert.ToString(i), p , "in" );
            Position.Add(nm1);
            j = j+.002;
            
        }        


        
        foreach (dataRow row in Position)
        {
            
            string rounded =Math.Round(row.VAL, 3).ToString("F3");
            string paddedb = rounded;
            Console.WriteLine(paddedb);
        }
        

          using (StreamWriter writer = new StreamWriter(defaultOut))
            {
                foreach (dataRow row in Position)
                {
                    string roundedValue = Math.Round(row.VAL, 3).ToString("F5"); // Round to 3 decimal places
                    string paddedValue = roundedValue;
                    string line = string.Join(",",row.N, paddedValue, row.U);
                    writer.WriteLine(line);
                }
            } 
        
       
        
    }
}
