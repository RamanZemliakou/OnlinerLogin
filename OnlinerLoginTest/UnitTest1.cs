using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace OnlinerLoginTest
{
    public class Tests
    {
        DriverProvider _driverProvider;
        [SetUp]
        public void Setup()
        {
            _driverProvider = new DriverProvider();

        }

        [Test]
        public void Test1()
        {
            var basePageObject = new BasePageObject(_driverProvider.GetDriver());
            //var loginPageObject = new LoginPageObject(_driverProvider.GetDriver());
            basePageObject.MaximizeWindow();
            basePageObject.NavigateToLoginPage();
            basePageObject.LoginRegistred();
            Thread.Sleep(1000);
            basePageObject.CaptchaClick();
            
            //Assert.Pass();
        }
        [TearDown]
        public void Teardown()
        {
            //_driverProvider.Quit();
        }
    }
}