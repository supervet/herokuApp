using Aquality.Selenium.Browsers;
using NUnit.Framework;

namespace HerokuApp
{
    public class HerokuTests
    {


        [Test]
        public void Test1()
        {
            var driver = AqualityServices.Browser.Driver;
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
            //AqualityServices.Browser.GoTo("https://the-internet.herokuapp.com/");
            driver.Quit();
            Assert.Pass();
        }
        
    }
}
