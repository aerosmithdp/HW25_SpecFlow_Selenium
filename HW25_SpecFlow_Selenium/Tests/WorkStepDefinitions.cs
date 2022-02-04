using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using Xunit;

namespace HW25_SpecFlow_Selenium
{
    [Binding]
    public class WorkStepDefinitions : BaseTest
    {

        [Given(@"user on the Dou homepage")]
        public void GivenUserOnTheDouHomepage()
        {
            DriverHolder.chrome = StartDriverWithUrl("https://dou.ua/");
        }

        [When(@"user clicks on the Work button at header")]
        public static void WhenUserClicksOnTheWorkButtonAtHeader()
        {
            DriverHolder.chrome.FindElement(By.XPath("(//a[contains(@href, 'https://jobs.dou.ua/')])[2]")).Click();
        }
 
        [When(@"user clicks on the category QA")]
        public static void WhenUserClicksOnTheCategoryQA()
        {
            DriverHolder.chrome.FindElement(By.XPath("//a[contains(@href, 'https://jobs.dou.ua/vacancies/?category=QA')]")).Click();
        }

        [Then(@"user is redirected to the QA category page")]
        public static void ThenUserGoesToTheQACategoryPage()
        {
            string actual = DriverHolder.chrome.Url;
            string expected = "https://jobs.dou.ua/vacancies/?category=QA";
            Assert.Equal(expected, actual);
        }

        [When(@"user selected experience < one year")]
        public static void WhenUserSelectedExperienceOneYear()
        {
            DriverHolder.chrome.FindElement(By.XPath("//a[contains(@href, 'https://jobs.dou.ua/vacancies/?category=QA&exp=0-1')]")).Click();
        }

        [When(@"user selected the city Dnipro")]
        public static void WhenUserSelectedTheCityOfDnipro()
        {
            DriverHolder.chrome.FindElement(By.XPath("//a[contains(@href, 'https://jobs.dou.ua/vacancies/?city=%D0%94%D0%BD%D1%96%D0%BF%D1%80%D0%BE&category=QA&exp=0-1')]")).Click();
        }

        [Then(@"user sees a list of vacancies for Dnipro in the QA category with less than a year of experience")]
        public static void ThenUserIsThenShownInformationAccordingToTheSelectedCriteria()
        {
            string actual = DriverHolder.chrome.Url;
            string expected = "https://jobs.dou.ua/vacancies/?city=%D0%94%D0%BD%D1%96%D0%BF%D1%80%D0%BE&category=QA&exp=0-1";
            Assert.Equal(expected, actual);
        }



        [When(@"user enters ""([^""]*)"" text into the search field")]
        public static void WhenUserEntersTextIntoTheSearchField(string p0)
        {
            DriverHolder.chrome.FindElement(By.XPath("//input[@name='search']")).SendKeys(p0);
        }

        [When(@"user clicks on Find button")]
        public static void WhenUserClicksOnFindButton()
        {
            DriverHolder.chrome.FindElement(By.CssSelector(".btn-search")).Click();
        }

        [Then(@"user is redirected to a search page that displays a list of vacancies for Junior QA")]
        public static void ThenTheUserIsRedirectedToTheSearchPageWhichDisplaysAQuery()
        {
            string actual = DriverHolder.chrome.Url;
            string expected = "https://jobs.dou.ua/vacancies/?search=Junior+QA";
            Assert.Equal(expected, actual);
        }

        [When(@"user selected experience one\.\.\.three years")]
        public static void WhenUserSelectedExperienceOne_ThreeYears()
        {
            DriverHolder.chrome.FindElement(By.XPath("//a[contains(@href, 'https://jobs.dou.ua/vacancies/?search=Junior%20QA&exp=1-3')]")).Click();
        }

        [When(@"user selected the city Kiev")]
        public static void WhenUserSelectedTheCityKiev()
        {
            DriverHolder.chrome.FindElement(By.XPath("//a[contains(@href, 'https://jobs.dou.ua/vacancies/?city=%D0%9A%D0%B8%D1%97%D0%B2&search=Junior%20QA&exp=1-3')]")).Click();
        }

        [Then(@"user sees list of vacancies in Kiev with experience from one to three years for Junior QA")]
        public static void ThenUserSeesTheInformationAccordingToTheQuery()
        {
            string actual = DriverHolder.chrome.Url;
            string expected = "https://jobs.dou.ua/vacancies/?city=%D0%9A%D0%B8%D1%97%D0%B2&search=Junior%20QA&exp=1-3";
            Assert.Equal(expected, actual);
        }



        [When(@"user clicks on the First job link")]
        public static void WhenUserClicksOnTheFirstJobLink()
        {
            DriverHolder.chrome.FindElement(By.XPath("//a[contains(@href, 'https://jobs.dou.ua/first-job/')]")).Click();
        }

        [Then(@"user is redirected to the First job page")]
        public static void ThenUserRedirectedToTheFirstJobPage()
        {
            string actual = DriverHolder.chrome.Url;
            string expected = "https://jobs.dou.ua/first-job/";
            Assert.Equal(expected, actual);
        }

        [When(@"user selected city Kharkiv")]
        public static void WhenUserSelectedCityKharkiv()
        {
            DriverHolder.chrome.FindElement(By.XPath("//a[contains(@href, 'https://jobs.dou.ua/first-job/?city=kharkiv')]")).Click();
        }

        [Then(@"user sees a list of vacancies in Kharkiv")]
        public static void ThenUserSeesAListOfVacanciesInKharkiv()
        {
            string actual = DriverHolder.chrome.Url;
            string expected = "https://jobs.dou.ua/first-job/?city=kharkiv";
            Assert.Equal(expected, actual);
        }



        [When(@"user clicks on the Trends link")]
        public static void WhenUserClicksOnTheTrendsLink()
        {
            DriverHolder.chrome.FindElement(By.XPath("//a[contains(@href, 'https://jobs.dou.ua/trends/')]")).Click();
        }

        [Then(@"user is redirected to the Trends page")]
        public static void ThenUserIsRedirectedToTheTrendsPage()
        {
            string actual = DriverHolder.chrome.Url;
            string expected = "https://jobs.dou.ua/trends/";
            Assert.Equal(expected, actual);
        }

        [When(@"user selected the city Odessa")]
        public static void WhenUserSelectedTheCityOdessa()
        {
            DriverHolder.chrome.FindElement(By.CssSelector("option[value='Odesa']")).Click();
        }

        [When(@"user selected category QA")]
        public static void WhenUserSelectedCategoryQA()
        {
            DriverHolder.chrome.FindElement(By.CssSelector("option[value='QA']")).Click();
        }

        [When(@"user selected experience five plus years")]
        public static void WhenUserSelectedExperienceFivePlusYears()
        {
            DriverHolder.chrome.FindElement(By.CssSelector("option[value='5plus']")).Click();
        }

        [Then(@"user sees trends for Dnipro in the QA category with more than five years of experience")]
        public static void ThenUserSeesTrendsForDniproInTheQACategoryWithMoreThanFiveYearsOfExperience()
        {
            string actual = DriverHolder.chrome.Url;
            string expected = "https://jobs.dou.ua/trends/?city=Odesa&category=QA&exp=5plus";
            Assert.Equal(expected, actual);
        }


    }
}
