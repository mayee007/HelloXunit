using System;
using OpenQA.Selenium; 
using OpenQA.Selenium.Chrome;

using Xunit; 

namespace XUnitTests.GuiTests
{
    [Trait("Category", "gui")]
    [Collection("toRunParallel")]
    public class GoogleMainPageTest
    {
        IWebDriver driver;
        ChromeOptions options;
        String url;
        String title;
 
        [Fact] 
        public void openHomePageTest()
        {
            // to run chrome headless 
            options = new ChromeOptions();
            options.AddArgument("--headless"); 
            driver = new ChromeDriver(options);

            //driver = new ChromeDriver(); // this pops up windows
            url = "http://google.com";
            title = "Google";
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize(); // maximizes window       
            driver.Close(); //closes window                              
        }

        [Fact] // method 1 - simple 
                              // repeat this test 5 times 
        public void getTitleTest()
        {
            url = "http://google.com";
            title = "Google";
            options = new ChromeOptions();
            options.AddArgument("--headless"); 
            driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl(url);
            Assert.Equal(title, driver.Title);
            driver.Close(); //closes window                              
        }
      
        public void cleanup()
        {
            driver.Quit();
        }
    } // end of class
}