namespace JSON2CSV;
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using CsvHelper;
using CsvHelper.Configuration;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
       string jsonFilePath = "/workspaces/TRCsharp/Programs/TRMAR/JSON2CSV/JSON/data.json";
        string jsonData = File.ReadAllText(jsonFilePath);

        // Deserialize JSON to objects
        List<Person> people = JsonConvert.DeserializeObject<List<Person>>(jsonData);

        // Write objects to CSV
        using (var writer = new StreamWriter("output.csv"))
        using (var csv = new CsvWriter(writer, new CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture)))
        {
            csv.WriteRecords(people);
        }

        Console.WriteLine("Conversion completed.");
    }
    }

