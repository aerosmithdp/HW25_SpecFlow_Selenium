using System;
using HW25_SpecFlow_Selenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HW25_SpecFlow_Selenium
{
    public class BaseTest : IDisposable
    {
        public void StartDriverWithUrl(string url)
        {
            DriverHolder.chrome = new ChromeDriver();
            DriverHolder.chrome.Navigate().GoToUrl(url);
            DriverHolder.chrome.Manage().Window.Maximize();
        }

        public void Dispose()
        {
            DriverHolder.chrome.Quit();
        }

    }
}
