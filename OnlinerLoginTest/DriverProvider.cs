using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinerLoginTest
{
    public class DriverProvider
    {
        private static readonly ThreadLocal<IWebDriver> _storedDriver = new ThreadLocal<IWebDriver>();

        public IWebDriver GetDriver()
        {
            if (_storedDriver.Value == null)
            {
                ChromeOptions options = new ChromeOptions();

                _storedDriver.Value = new ChromeDriver(@"C:\Users\User-PC\source\repos\OnlinerLoginTest\OnlinerLoginTest\bin\Debug\net6.0", options)
                {
                    Url = BasePageObject.url
                };
            }
            return _storedDriver.Value;
        }
        public void Quit()
        {
            _storedDriver.Value.Quit();
        }
    }
}
