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
        public static void WhenUserClicksOnTheSalariesButtonAtHeader()
        {
            DriverHolder.chrome.FindElement(By.XPath("//a[contains(@href, 'https://jobs.dou.ua/salaries/')]")).Click();
        }

        [When(@"user selected Dnipro in City drop-down menu")]
        public static void WhenUserSelectedDniproInCityDrop_DownMenu()
        {
            DriverHolder.chrome.FindElement(By.CssSelector("option[value='Dnipro']")).Click();
        }

        [When(@"user selected Junior QA Engineer in Positon drop-down menu")]
        public static void WhenUserSelectedJuniorQAEngineerInPositonDrop_DownMenu()
        {
            DriverHolder.chrome.FindElement(By.XPath("//*[contains(text(),'Junior QA engineer')]")).Click();   
        }

        [When(@"user selected position Manual QA in Specialization drop-down menu")]
        public static void WhenUserSelectedPositionManualQAInSpecializationDrop_DownMenu()
        {
            DriverHolder.chrome.FindElement(By.XPath("//*[contains(text(),'Manual QA')]")).Click();

        }

        [Then(@"user sees information according to the selected criteria")]
        public static void ThenUserSeesInformationAccordingToTheSelectedCriteria()
        {
            string actual = DriverHolder.chrome.Url;
            string expected = "https://jobs.dou.ua/salaries/#period=jun2021&city=Dnipro&title=Junior%20QA%20engineer&language=&spec=Manual%20QA&exp1=0&exp2=10";
            Assert.Equal(expected, actual);
        }



        [When(@"user clicks on the Dynamics button")]
        public static void WhenUserClicksOnTheDynamicsButton()
        {
            DriverHolder.chrome.FindElement(By.XPath("//a[contains(@href, 'https://jobs.dou.ua/salaries/dynamics/')]")).Click();
        }

        [When(@"user selected city Dnipro in Dynamics of programmers salaries drop-down menu")]
        public static void WhenUserSelectedCityDniproInDynamicsOfProgrammersSalariesDrop_DownMenu()
        {
            DriverHolder.chrome.FindElement(By.CssSelector("option[value='https://jobs.dou.ua/salaries/dynamics/Dnipro/']")).Click();
        }

        [Then(@"user sees the dynamics of salaries in the city Dnipro")]
        public static void ThenUserSeesTheDynamicsOfSalariesInTheCityDnipro()
        {
            string actual = DriverHolder.chrome.Url;
            string expected = "https://jobs.dou.ua/salaries/dynamics/Dnipro/";
            Assert.Equal(expected, actual);
        }



        [When(@"user clicks on the By cities button")]
        public static void WhenUserClicksOnTheByCitiesButton()
        {
            DriverHolder.chrome.FindElement(By.XPath("//a[contains(@href, 'https://jobs.dou.ua/salaries/cities/')]")).Click();
        }

        [When(@"user selected period december 2020 in Salaries by cities drop-down menu")]
        public static void WhenUserSelectedPeriodDecember2020InSalariesByCitiesDrop_DownMenu()
        {
            DriverHolder.chrome.FindElement(By.CssSelector("option[value='https://jobs.dou.ua/salaries/cities/dec2020/']")).Click();
        }

        [Then(@"user sees the salary by city for the period december 2020")]
        public static void ThenUserSeesTheSalaryByCityForThePeriodDecember2020()
        {
            string actual = DriverHolder.chrome.Url;
            string expected = "https://jobs.dou.ua/salaries/cities/dec2020/";
            Assert.Equal(expected, actual);
        }



        [When(@"user clicks on the Demographics button")]
        public static void WhenUserClicksOnTheDemographicsButton()
        {
            DriverHolder.chrome.FindElement(By.XPath("//a[contains(@href, 'https://jobs.dou.ua/salaries/demography/')]")).Click();
        }

        [When(@"user selected period december 2019 in Demography of the salary survey drop-down menu")]
        public static void WhenUserSelectedPeriodDecember2019InDemographyOfTheSalarySurveyDrop_DownMenu()
        {
            DriverHolder.chrome.FindElement(By.CssSelector("option[value='/salaries/demography/dec2019']")).Click();
        }

        [Then(@"user then sees the payroll survey demographics for december 2019")]
        public static void ThenUserThenSeesThePayrollSurveyDemographicsForDecember2019()
        {
            string actual = DriverHolder.chrome.Url;
            string expected = "https://jobs.dou.ua/salaries/demography/dec2019/";
            Assert.Equal(expected, actual);
        }

    }
}
