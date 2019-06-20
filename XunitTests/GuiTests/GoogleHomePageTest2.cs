using System;
using OpenQA.Selenium; 
using OpenQA.Selenium.Chrome;

using Xunit; 

namespace XUnitTests.GuiTests
{
    [Trait("Category", "gui")]
    public class GoogleMainPageTest2 : IClassFixture<ChromeDriverFixture>
    {
        ChromeOptions options;
        String url;
        String title;
        ChromeDriverFixture fixture;
        IWebDriver driver;  
        public GoogleMainPageTest2(ChromeDriverFixture fixture)
        {
            this.fixture = fixture; 
            url = "http://google.com";
            title = "Google";
        }

        [Fact] 
        public void openHomePageTest()
        {
            //driver = new ChromeDriver(); // this pops up windows
            driver = fixture.getDriver(); 
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize(); // maximizes window       
            driver.Close(); //closes window                              
        }

        [Fact] // method 1 - simple 
                              // repeat this test 5 times 
        public void getTitleTest()
        {
            driver = fixture.getDriver(); 
            driver.Navigate().GoToUrl(url);
            Assert.Equal(title, driver.Title);
            driver.Close(); //closes window                              
        }
    } // end of class
}