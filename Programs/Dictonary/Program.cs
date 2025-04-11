namespace Dictonary;

class Program
{
    static void Main(string[] args)
    {
       List<string> list1 = new List<string>();
       
       Dictionary<int, string> myDictionary = new Dictionary<int, string>();

        // Adding elements to the dictionary
        myDictionary.Add(1, "Apple");
        myDictionary.Add(2, "Banana");
        myDictionary.Add(3, "Cherry");

        // Accessing elements by key
        Console.WriteLine(myDictionary[1]); // Output: Apple

        // Iterating through the dictionary
        foreach (var kvp in myDictionary)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            list1.Add(kvp.Value);
        }

        foreach(var kvp1 in list1)
        {Console.WriteLine(list1);};

    }
}
