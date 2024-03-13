namespace JSON2CSV;
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using CsvHelper;
using CsvHelper.Configuration;

    public class Inputs
    {
        public string? zp { get; set; }
        public string? zg { get; set; }
        public string? fw { get; set; }
        public string? Ha { get; set; }
        public string? npa { get; set; }
        public string? mod { get; set; }
        public string? oprcd { get; set; }
        public string? pinspan { get; set; }
        public string? geaspan { get; set; }
        public string? pinsbest { get; set; }
        public string? geasbest { get; set; }
        public string? pinOD { get; set; }
        public string? geaOD { get; set; }
        public string? pinRoot { get; set; }
        public string? geaRoot { get; set; }
        public string? desiredCD { get; set; }
    }

    public class TextBoxValues
    {
        public string? tbSetNumber { get; set; }
        public string? tbModule { get; set; }
        public string? tbNpa { get; set; }
        public string? tbHa { get; set; }
        public string? tbWDSys { get; set; }
        public string? tbAstd { get; set; }
        public string? tbHa0 { get; set; }
        public string? tbToolRad { get; set; }
        public string? tbBmin { get; set; }
        public string? tbBMax { get; set; }
        public string? tbFWidth { get; set; }
        public string? tbNp { get; set; }
        public string? tbNg { get; set; }
        public string? tbX1 { get; set; }
        public string? tbX2 { get; set; }
        public string? tbA1 { get; set; }
        public string? tbA2 { get; set; }
        public string? tbDesiredCD { get; set; }
    }

    public class RootObject
    {
        public Inputs? Inputs { get; set; }
        public TextBoxValues? TextBoxValues { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
             try
            {
                string jsonFilePath = "/workspaces/TRCsharp/Programs/TRMAR/JSON2CSV/JSON/712504-010_data.json";
                string jsonData = File.ReadAllText(jsonFilePath);

                // Deserialize JSON to objects
                RootObject? gearData = JsonConvert.DeserializeObject<RootObject>(jsonData);

                // Write objects to CSV
                string setNumber = gearData.TextBoxValues!.tbSetNumber ?? "Unknown";
                string csvFilename = "/workspaces/TRCsharp/Programs/TRMAR/JSON2CSV/CSV/" + setNumber + ".csv";
                
                using (var writer = new StreamWriter(csvFilename))
                using (var csv = new CsvWriter(writer, new CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture)))
                {
                    if (gearData.Inputs != null)
                    {
                        // Write Inputs properties
                        foreach (var property in typeof(Inputs).GetProperties())
                        {
                            csv.WriteField(property.Name);
                            csv.WriteField(property.GetValue(gearData.Inputs));
                            csv.NextRecord();
                        }
                    }

                    if (gearData.TextBoxValues != null)
                    {
                        // Write TextBoxValues properties
                        foreach (var property in typeof(TextBoxValues).GetProperties())
                        {
                            csv.WriteField(property.Name);
                            csv.WriteField(property.GetValue(gearData.TextBoxValues));
                            csv.NextRecord();
                        }
                    }
                }

                Console.WriteLine("Conversion completed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
