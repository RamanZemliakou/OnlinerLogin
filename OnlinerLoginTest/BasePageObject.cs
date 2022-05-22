using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinerLoginTest
{
    class BasePageObject
    {
        
        private IWebDriver webDriver;
        public static readonly string url = "https://www.onliner.by/";
        private readonly By _loginButton = By.XPath("//div[@class='auth-bar__item auth-bar__item--text']");
        private readonly By _usernameField = By.XPath("//input[@placeholder='Ник или e-mail']");
        private readonly By _passwordField = By.XPath("//input[@placeholder='Пароль']");
        public readonly By _submitButton = By.XPath("//button[@class='auth-button auth-button_primary auth-button_middle auth-form__button auth-form__button_width_full']");
        private readonly By _captcaLocator = By.XPath("//*[@id='recaptcha-anchor-label']");
        private string _username = "raman.zemliakou@gmail.com";
        private string _password = "TestTest123";

        public BasePageObject(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public void MaximizeWindow()
        {
            webDriver.Manage().Window.Maximize();
        }
        public void NavigateToLoginPage()
        {
            //_driver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl(url);
            webDriver.FindElement(_loginButton).Click();
        }

        public void LoginRegistred()
        {
            webDriver.FindElement(_usernameField).SendKeys(_username);
            webDriver.FindElement(_passwordField).SendKeys(_password);
            webDriver.FindElement(_submitButton).Click();
        }
        public void CaptchaClick()
        {
            webDriver.FindElement(_captcaLocator).Click();
        }
    }
}
