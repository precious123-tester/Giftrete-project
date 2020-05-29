using GIFTRETEPROJECT.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace GIFTRETEPROJECT.PageObject
{
    class LoginPage
    {
        IWebDriver driver;
        public LoginPage()
        {
            driver = Hook.driver;
        }

        IWebElement Signin => driver.FindElement(By.XPath("/html/body/section[1]/nav/div/div[1]/a[3]"));
        public void ClickLogin()
        {
            Signin.Click();
        }

        IWebElement Email => driver.FindElement(By.XPath("//*[@id='user_email']"));
        public void EnterEmailAddress()
        {
            Email.SendKeys("ejiasabor11@gmail.com");
        }

        IWebElement Password => driver.FindElement(By.XPath("//*[@id='user_password']"));
        public void EnterPassword()
        {
            Password.SendKeys("omon1988");
        }

        IWebElement SignIn => driver.FindElement(By.XPath("//*[@id='btn_signin']"));
        public void Clicksignin()
        {
            SignIn.Click();
        }
    }
}
