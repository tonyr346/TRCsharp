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
        public double X=0;
        public double V = 0; 

        public double Z = 0;
        public dataRow (string n, double val, double u, double v)
        {
            N=n;
            VAL = val;
            X = u;
            V = v;
            Z = (X-V)/(X+V);
        }

    }
    
    static void Main(string[] args)
    {
        string outputfolder = "/workspaces/TRCsharp/Programs/TRMAR/STREAMER/outputs";
        string defaultstr = "default.csv";
        string defaultOut = Path.Combine(outputfolder, defaultstr);
        string name = "Position";
        double j = 2;
    

        List<dataRow> Position = new List<dataRow>();

        for (double i=2; i<500;i++)
            {
            
            string nm = name + Convert.ToString(i);
            double p = 2*j+Math.Pow(j,2)/Math.Pow(j,3)-Math.Pow(j,2);
            double k = 3*j+(10/j)*Math.Pow(j,2)/Math.Pow(j,4)-Math.Pow(j,2);
            
            dataRow nm1 = new dataRow(Convert.ToString(i), p , j , k);
            Position.Add(nm1);
            j = j+.002;
            
        }        


        
        foreach (dataRow row in Position)
        {
            
            string rounded =Math.Round(row.VAL, 3).ToString("F3");
            string paddedb = rounded;

           
        }
        

          using (StreamWriter writer = new StreamWriter(defaultOut))
            {
                foreach (dataRow row in Position)
                {
                    string roundedValue = Math.Round(row.VAL, 5).ToString("F5"); // Round to 3 decimal places
                    string paddedValue = roundedValue;
                    string roundedX = Math.Round(row.X, 5).ToString("F5");
                    string roundedV = Math.Round(row.V,5).ToString("F5");
                    string roundedZ = Math.Round(row.Z,5).ToString("F5");
                    string line = string.Join(",",roundedX, paddedValue, roundedV, roundedZ);
                    writer.WriteLine(line);
                }
            } 

            Console.WriteLine("CSV Created Successfully");
        
       
        
    }
}
