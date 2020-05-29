using GIFTRETEPROJECT.Hooks;
using OpenQA.Selenium;
using System;
using System.Linq;

namespace GIFTRETEPROJECT.PageObject
{
    class RegistrationPage
    {
        IWebDriver driver;
        public RegistrationPage()
        {
            driver = Hook.driver;
        }
        public void NavigateToPage()
        {
            driver.Navigate().GoToUrl("https://www.qa.giftrete.com");
        }

        IWebElement CreateAccount => driver.FindElement(By.XPath("/html/body/section[1]/nav/div/div[1]/a[2]"));
        public void ClickCreateAccount()
        {
            CreateAccount.Click();
        }
        IWebElement FirstName => driver.FindElement(By.XPath("//*[@id='first_name']"));
        public void EnterFirstName()
        {
            FirstName.SendKeys("precious");
        }

        IWebElement LastName => driver.FindElement(By.XPath("//*[@id='last_name']"));
        public void EnterLastName()
        {
            LastName.SendKeys("Akaighe");
        }

        IWebElement Email => driver.FindElement(By.XPath("//*[@id='email']"));
        public void EnterEmail()
        {
            Email.SendKeys("ejiasabor11@gmail.com");
        }

        IWebElement MobileNumber => driver.FindElement(By.XPath("//*[@id='mobile']"));
        public void EnterMobileNumber()
        {
            MobileNumber.SendKeys("07493694327");
        }

        IWebElement Password => driver.FindElement(By.XPath("//*[@id='password']"));
        public void EnterPassword()
        {
            Password.SendKeys("omon1988");
        }

        IWebElement ConfirmPassword => driver.FindElement(By.XPath("//*[@id='confirm_password']"));
        public void EnterConfirmPassword()
        {
            ConfirmPassword.SendKeys("omon1988");
        }

        IWebElement TermsOfUse => driver.FindElement(By.CssSelector("#nav-register > p > span:nth-child(1) > a"));
        public void ClickTermsOfUse()
        {
            TermsOfUse.Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
        }

        IWebElement PrivacyPolicy=> driver.FindElement(By.CssSelector("#nav-register > p > span:nth-child(2) > a"));
        public void ClickPrivacyPolicy()
        {
            PrivacyPolicy.Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
        }

        IWebElement Register => driver.FindElement(By.XPath("//*[@id='btn_register']"));
        public void ClickRegister()
        {
            Register.Click();
        }
    }


}
