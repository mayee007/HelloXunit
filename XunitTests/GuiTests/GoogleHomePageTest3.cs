using System;
using OpenQA.Selenium; 
using OpenQA.Selenium.Chrome;

using Xunit; 

namespace XUnitTests.GuiTests
{
    [Trait("Category", "gui")]
    [Collection("toRunParallel")]
    // implement "IDisposable" interface which make the "Dispose()" function to be called at the end of class 
    public class GoogleMainPageTest3 : IDisposable
    {
        IWebDriver driver;
        ChromeOptions options;
        String url;
        String title;
 
        public GoogleMainPageTest3() 
        {
            // to run chrome headless 
            options = new ChromeOptions();
            options.AddArgument("--headless"); 
            driver = new ChromeDriver(options);
            
            //driver = new ChromeDriver(); // this pops up windows
            url = "http://google.com";
            title = "Google";
        }

        [Fact] 
        public void openHomePageTest()
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize(); // maximizes window       
            driver.Close(); //closes window                              
        }

        [Fact] // method 1 - simple 
        public void getTitleTest()
        {
            driver.Navigate().GoToUrl(url);
            Assert.Equal(title, driver.Title);
            driver.Close(); //closes window                              
        }
      
        [Theory] // multiple inputs 
        [InlineData("Google", true)] //format is "expectedTitle" and "expectedStatus" 
        [InlineData("something else", false)]
        [InlineData("", false)]
        public void getTitleTestMultiData(String expectedTitle, Boolean expectedStatus )
        {
            driver.Navigate().GoToUrl(url);
            Boolean actualStatus; 
            if (expectedTitle.Equals(driver.Title)) 
                actualStatus = true; 
            else 
                actualStatus = false; 
            driver.Close(); //closes window    
            Assert.Equal(expectedStatus, actualStatus);                          
        }

        [Fact(Skip = "skipping this test, because its not implemented yet")]
        public void futureFeature() 
        {

        } 

        // This function is implemented from "IDisposable" interface, gets called at the end  
        public void Dispose()
        {
            driver.Quit();
        }
    } // end of class
}