using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using Xunit;

namespace HW25_SpecFlow_Selenium
{
    [Binding]
    public class SalariesStepDefinitions : BaseTest
    {
        [Given(@"user on the homepage")]
        public void GivenUserOnTheHomepage()
        {
            DriverHolder.chrome = StartDriverWithUrl("https://dou.ua/");
        }

        [When(@"user clicks on the Salaries button at header")]
        public void WhenUserClicksOnTheSalariesButtonAtHeader()
        {
            DriverHolder.chrome.FindElement(By.XPath("//a[contains(@href, 'https://jobs.dou.ua/salaries/')]")).Click();
        }

        [When(@"user selected '([^']*)' in City drop-down menu")]
        public void WhenUserSelectedInCityDrop_DownMenu(string дніпро)
        {
            DriverHolder.chrome.FindElement(By.CssSelector("option[value='Dnipro']")).Click();
        }

        [When(@"user selected '([^']*)' in Positon drop-down menu")]
        public void WhenUserSelectedInPositonDrop_DownMenu(string p0)
        {
            DriverHolder.chrome.FindElement(By.XPath("//*[contains(text(),'Junior QA engineer')]")).Click();   
        }

        [When(@"user selected position '([^']*)' in Specialization drop-down menu")]
        public void WhenUserSelectedPositionInSpecializationDrop_DownMenu(string p0)
        {
            DriverHolder.chrome.FindElement(By.XPath("//*[contains(text(),'Manual QA')]")).Click();

        }

        [Then(@"user sees information according to the selected criteria")]
        public void ThenUserSeesInformationAccordingToTheSelectedCriteria()
        {
            string actual = DriverHolder.chrome.Url;
            string expected = "https://jobs.dou.ua/salaries/#period=jun2021&city=Dnipro&title=Junior%20QA%20engineer&language=&spec=Manual%20QA&exp1=0&exp2=10";
            Assert.Equal(expected, actual);
        }


        [When(@"user clicks on the Dynamics button")]
        public void WhenUserClicksOnTheDynamicsButton()
        {
            DriverHolder.chrome.FindElement(By.XPath("//a[contains(@href, 'https://jobs.dou.ua/salaries/dynamics/')]")).Click();
        }

        [When(@"user selected city '([^']*)' in Dynamics of programmers salaries drop-down menu")]
        public void WhenUserSelectedCityInDynamicsOfProgrammersSalariesDrop_DownMenu(string дніпро)
        {
            DriverHolder.chrome.FindElement(By.CssSelector("option[value='https://jobs.dou.ua/salaries/dynamics/Dnipro/']")).Click();
        }

        [Then(@"user sees the dynamics of salaries in the city '([^']*)'")]
        public void ThenUserSeesTheDynamicsOfSalariesInTheCity(string дніпро)
        {
            string actual = DriverHolder.chrome.Url;
            string expected = "https://jobs.dou.ua/salaries/dynamics/Dnipro/";
            Assert.Equal(expected, actual);
        }


        [When(@"user clicks on the By cities button")]
        public void WhenUserClicksOnTheByCitiesButton()
        {
            DriverHolder.chrome.FindElement(By.XPath("//a[contains(@href, 'https://jobs.dou.ua/salaries/cities/')]")).Click();
        }

        [When(@"user selected period '([^']*)' in Salaries by cities drop-down menu")]
        public void WhenUserSelectedPeriodInSalariesByCitiesDrop_DownMenu(string p0)
        {
            DriverHolder.chrome.FindElement(By.CssSelector("option[value='https://jobs.dou.ua/salaries/cities/dec2020/']")).Click();
        }

        [Then(@"user sees the salary by city for the period '([^']*)'")]
        public void ThenUserSeesTheSalaryByCityForThePeriod(string p0)
        {
            string actual = DriverHolder.chrome.Url;
            string expected = "https://jobs.dou.ua/salaries/cities/dec2020/";
            Assert.Equal(expected, actual);
        }


        [When(@"user clicks on the Demographics button")]
        public void WhenUserClicksOnTheDemographicsButton()
        {
            DriverHolder.chrome.FindElement(By.XPath("//a[contains(@href, 'https://jobs.dou.ua/salaries/demography/')]")).Click();
        }

        [When(@"user selected period '([^']*)' in Demography of the salary survey drop-down menu")]
        public void WhenUserSelectedPeriodInDemographyOfTheSalarySurveyDrop_DownMenu(string p0)
        {
            DriverHolder.chrome.FindElement(By.CssSelector("option[value='/salaries/demography/dec2019']")).Click();
        }

        [Then(@"user then sees the payroll survey demographics for '([^']*)'")]
        public void ThenUserThenSeesThePayrollSurveyDemographicsFor(string p0)
        {
            string actual = DriverHolder.chrome.Url;
            string expected = "https://jobs.dou.ua/salaries/demography/dec2019/";
            Assert.Equal(expected, actual);
        }

    }
}
