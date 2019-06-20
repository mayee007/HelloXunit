using System;
using OpenQA.Selenium; 
using OpenQA.Selenium.Chrome;

using Xunit; 

namespace XUnitTests.GuiTests
{
    public class ChromeDriverFixture : IDisposable
    {
        IWebDriver driver; 
        public ChromeOptions options { get; set; }

        public ChromeDriverFixture()
        {
            // this will make it to run browser in backend
            options = new ChromeOptions();
            options.AddArgument("--headless");            
        }

        public IWebDriver getDriver() 
        {
            driver = new ChromeDriver(options);
            return driver; 
        }

        public void Dispose() 
        {
            driver.Quit();
        }
    } // end of class 
}