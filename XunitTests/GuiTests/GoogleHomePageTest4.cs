using System;
using OpenQA.Selenium; 
using OpenQA.Selenium.Chrome;

using Xunit; 
using XUnitTests.Utils; 
using Xunit.Abstractions; 
namespace XUnitTests.GuiTests
{
    [Trait("Category", "gui")]
    [Collection("toRunParallel")]
    // implement "IClassFixture" interface which gets called only once per class  
    public class GoogleMainPageTest4 : IClassFixture<SeleniumSetup>, IDisposable
    {
        IWebDriver driver;
        SeleniumSetup setup; 

        private ITestOutputHelper output; 
 
        public GoogleMainPageTest4(SeleniumSetup setup, ITestOutputHelper output) 
        {
            this.setup = setup; 
            driver = new ChromeDriver(setup.options);
            this.output = output; 
        }

        [Fact] 
        public void openHomePageTest()
        {
            driver.Navigate().GoToUrl(setup.url);
            driver.Manage().Window.Maximize(); // maximizes window  
            output.WriteLine("inside GoogleHomePageTest4::openHomePageTest()");                       
        }

        [Fact] 
        public void getTitleTest()
        {
            driver.Navigate().GoToUrl(setup.url);
            Assert.Equal(setup.title, driver.Title);    
            output.WriteLine("inside GoogleHomePageTest4::getTitleTest()");                     
        }
      
        public void Dispose() { 
            output.WriteLine("inside GoogleHomePageTest4::Dispose()"); 
            driver.Close(); 
        }
    } // end of class
}