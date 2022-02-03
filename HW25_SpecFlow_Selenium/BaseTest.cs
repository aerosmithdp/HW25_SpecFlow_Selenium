using System;
using HW25_SpecFlow_Selenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HW25_SpecFlow_Selenium
{
    public class BaseTest : IDisposable
    {
        public IWebDriver StartDriverWithUrl(string url)
        {
            DriverHolder.chrome = new ChromeDriver();
            DriverHolder.chrome.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            DriverHolder.chrome.Manage().Window.Maximize();
            DriverHolder.chrome.Navigate().GoToUrl(url);
            return DriverHolder.chrome;
        }

        public void Dispose()
        {
            //DriverHolder.chrome.Quit();
        }
    }
}
