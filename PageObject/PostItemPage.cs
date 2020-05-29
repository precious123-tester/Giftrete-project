using GIFTRETEPROJECT.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace GIFTRETEPROJECT.PageObject
{
    class PostItemPage
    {
        IWebDriver driver;
        public PostItemPage()
        {
            driver = Hook.driver;
        }
        IWebElement PostItem => driver.FindElement(By.XPath("/html/body/div[1]/header[1]/div/div[2]/div/div[3]/ul/li[1]/a"));
        public void ClickPostItem()
        {
            PostItem.Click();
        }

        IWebElement ItemName => driver.FindElement(By.XPath("//*[@id='title']"));
        public void EnterItemName()
        {
            ItemName.SendKeys("book");
        }
        IWebElement ItemDescription => driver.FindElement(By.XPath("/html"));
        public void EnterItemDescription()
        {
            ItemDescription.SendKeys("Inspirational Book");  
        }

        IWebElement ItemCategory => driver.FindElement(By.XPath("//*[@id='categoryone']"));
        public void SelectItemCategory()
        {
            SelectElement item = new SelectElement(ItemCategory);
            item.SelectByValue("4");
        }

        IWebElement ItemType => driver.FindElement(By.XPath("//*[@id='type']"));
        public void SelectItemType()
        {
            SelectElement type = new SelectElement(ItemType);
            type.SelectByValue("Offered");
        }

        IWebElement ItemWeight => driver.FindElement(By.XPath("//*[@id='weight']"));
        public void EnterItemWeight()
        {
            ItemWeight.SendKeys("");
        }

        IWebElement ItemLocation => driver.FindElement(By.XPath("//*[@id='autocomplete']"));
        public void EnterItemLocation()
        {
            ItemLocation.SendKeys("LondonUK");
        }

        IWebElement ItemImage => driver.FindElement(By.XPath("//*[@id='files']"));
        public void ChooseItemImage()
        {
            ItemImage.SendKeys("C:\\Users\\ingri\\Desktop\\book.jpg");
        }

        IWebElement Add => driver.FindElement(By.CssSelector("body > div.cp-chat.cp-chat-position-right.cp-chat-type-chat.cp-minimized.cp-animation-shake"));
        public void ClickOnAdd()
        {
            Add.Click();
        }
    }
}
