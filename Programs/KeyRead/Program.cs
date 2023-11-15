using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Collect user inputs and perform calculations
        Console.Write("Enter File Name:");
        string fn = Console.ReadLine();
        string fn2 = "TR347";

        Console.Write("Enter input 1:");
        int input1 = int.Parse(Console.ReadLine());

        Console.Write("Enter input 2:");
        int input2 = int.Parse(Console.ReadLine());

        int result = input1 + input2;

        int result2 = result * 5;

        // Save to text file with key-value pairs
        SaveToText(fn, input1, input2, result, result2);

        // Read and display specific data from text file
        ReadSpecificDataFromText(fn, "Result");
        ReadSpecificDataFromText(fn, "Result2");

        string input3 = ReadSpecificData(fn2, "Result2");
       

        Console.WriteLine($"Input3={input3}");

    }

    static string ReadSpecificData(string filename, string key)
    {
        string filePath = Path.Combine("/workspaces/TRCsharp/Programs/KeyRead/Outputs", filename);

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('=');
                if (parts.Length == 2 && parts[0] == key)
                {
                    return parts[1]!;
                }
            }
        }

        // Return a default value (you may want to choose a meaningful default based on your use case)
        return "Key not found";
    }

    static void SaveToText(string filename, int input1, int input2, int result, int result2)
    {
        // Combine the directory path and the filename using Path.Combine
        string outputPath = Path.Combine("/workspaces/TRCsharp/Programs/KeyRead/Outputs", filename);

        using (StreamWriter writer = new StreamWriter(outputPath))
        {
            writer.WriteLine($"FileName={filename}");
            writer.WriteLine($"Input1={input1}");
            writer.WriteLine($"Input2={input2}");
            writer.WriteLine($"Result={result}");
            writer.WriteLine($"Result2={result2}");
        }
    }

    static void ReadSpecificDataFromText(string filename, string key)
    {
        // Combine the directory path and the filename using Path.Combine
        string filePath = Path.Combine("/workspaces/TRCsharp/Programs/KeyRead/Outputs", filename);

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('=');
                if (parts.Length == 2 && parts[0] == key)
                {
                    Console.WriteLine($"{key}: {parts[1]!}");
                    break; // Stop reading once the desired key is found
                }
            }
        }
    }
}
