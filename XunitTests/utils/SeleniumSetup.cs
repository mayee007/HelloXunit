using System; 
using OpenQA.Selenium; 
using OpenQA.Selenium.Chrome; 
namespace XUnitTests.Utils
{
    // implement "IDisposable" interface which make the "Dispose()" function to be called at the end of class 
    public class SeleniumSetup : IDisposable
    {
        public String url { get; set; }
        public String title { get; set; }
        public IWebDriver driver { get; set; }
        public ChromeOptions options { get; set; }
        public SeleniumSetup()
        {
            url = "http://google.com";
            title = "Google";
            options = new ChromeOptions();
            options.AddArgument("--headless"); 
            driver = new ChromeDriver(options);
            Console.WriteLine("inside SeleniumSetup::SeleniumSetup()"); 
        }
        public void Dispose() 
        {
            Console.WriteLine("inside SeleniumSetup::Dispose()"); 
            driver.Quit(); 
        }
    } // end of class 
}