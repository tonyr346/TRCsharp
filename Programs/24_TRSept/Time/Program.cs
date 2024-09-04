namespace Time;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;


class Program
{
    static async Task Main(string[] args)
    {
        // Make the API request and get the response
        string timeApiResponse = await GetTimeAsync("America/Detroit");

        // Parse the JSON response
        if (timeApiResponse != null)
        {
            ParseAndDisplayTime(timeApiResponse);
        }
        else
        {
            Console.WriteLine("Failed to retrieve time data.");
        }
    }

    static async Task<string> GetTimeAsync(string timezone)
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                string url = $"http://worldtimeapi.org/api/timezone/{timezone}";
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                return await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("Request error: " + e.Message);
                return "";
            }
        }
    }

    static void ParseAndDisplayTime(string jsonResponse)
    {
        // Parse the JSON response
        var data = JObject.Parse(jsonResponse);
        string datetime = data["datetime"]?.ToString() ?? "n/a";
        DateTime parsedDateTime;
        DateTime easternTime = DateTime.MinValue; // Initialize to avoid unassigned variable error

        if (DateTime.TryParse(datetime, out parsedDateTime))
        {
            // Convert to UTC
            DateTime utcTime = parsedDateTime.ToUniversalTime();
            

            try
            {
                // Convert to a specific timezone, e.g., "America/New_York"
                TimeZoneInfo easternZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
                easternTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, easternZone);
                
            }
            catch (TimeZoneNotFoundException)
            {
                Console.WriteLine("Timezone 'Eastern Standard Time' not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error converting time: " + ex.Message);
            }
        }
        else
        {
            Console.WriteLine("Failed to parse datetime.");
        }

        // Extract and display other relevant fields
        string timezone = data["timezone"]?.ToString() ?? "n/a";
        string utcOffset = data["utc_offset"]?.ToString() ?? "n/a";
        string dayOfWeek = data["day_of_week"]?.ToString() ?? "n/a";
        string dayOfYear = data["day_of_year"]?.ToString() ?? "n/a";

        Console.WriteLine("Current Time Information:");
        Console.WriteLine("-------------------------");
        Console.WriteLine($"Eastern Time: {easternTime}");
        Console.WriteLine($"Day of Year: {dayOfYear}");
    }
}
