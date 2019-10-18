﻿using OpenQA.Selenium;

namespace POMFramework.PageObjects
{
    // This class stores all of the methods availible to the page class

    public class Homepage : BasePage
    {
        private HomepageMap Map;
        public Homepage(IWebDriver driver) : base(driver)
        {
            // Creates a new mapping file when the page object is created

            Map = new HomepageMap(Driver);
        }

        // Test methods availible to the tast cases. Accessible by typing Pages.<name>.*

        public void GoTo()
        {
            Driver.Navigate().GoToUrl("http://automationpractice.com/");
        }

        public void GoToContactUsPage()
        {
            Map.ContactUsLink.Click();
        }
    }
}