namespace SCRAPEX
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Support.UI;
    using System.Drawing; // Required for ImageFormat
    using System.Drawing.Imaging; // Required for ImageFormat
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Set Chrome options to run in headless mode with necessary flags
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless"); // Run Chrome in headless mode
            options.AddArgument("--disable-gpu"); // Disable GPU for compatibility
            options.AddArgument("--no-sandbox"); // Bypass OS security model
            options.AddArgument("--disable-dev-shm-usage"); // Overcome limited resource problems
            options.AddArgument("--remote-debugging-port=9222"); // Fix DevToolsActivePort issue
            options.AddArgument("user-agent=Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/128.0.0.0 Safari/537.36");


            // Set up the ChromeDriver with the defined options
            using (IWebDriver driver = new ChromeDriver(options))
            {
                try
                {
                    // Walmart product URL for Great Value Milk
                    string productUrl = "https://www.walmart.com/ip/Great-Value-Milk-Whole-Vitamin-D-Half-Gallon-Plastic-Jug/10450118?classType=REGULAR&athbdg=L1600&from=/search";
                    
                    // Navigate to the product page
                    driver.Navigate().GoToUrl(productUrl);

                    // Create an explicit wait for up to 15 seconds for the price element to appear
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));

                    // Use a lambda to wait for the price element to be visible
                    var priceElement = wait.Until(d =>
                    {
                        try
                        {
                             var element = d.FindElement(By.CssSelector("div.price-container span[itemprop='price']"));
                            // Check if the element is displayed
                            return element.Displayed ? element : null;
                        }
                        catch (NoSuchElementException)
                        {
                            return null; // Return null if the element is not found
                        }
                    });

                    // Retrieve and display the price
                    string productPrice = priceElement.Text;
                    Console.WriteLine($"Price: {productPrice}");
                }
                catch (WebDriverTimeoutException)
                {
                    // Handle the case where the price element is not found within the wait time
                    Console.WriteLine("Price element not found within the given time.");

                    Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                    screenshot.SaveAsFile("screenshot.png"); // Save the screenshot without specifying format
                    Console.WriteLine("Screenshot saved as screenshot.png.");
                }
                catch (NoSuchElementException)
                {
                    // Handle the case where the price element isn't found
                    Console.WriteLine("Price element not found.");
                }
                finally
                {
                    // Close the browser
                    Console.WriteLine(driver.PageSource);
                    driver.Quit();
                }
            }
        }
    }
}
