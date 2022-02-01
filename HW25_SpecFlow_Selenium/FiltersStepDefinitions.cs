using System;
using TechTalk.SpecFlow;

namespace HW25_SpecFlow_Selenium
{
    [Binding]
    public class FiltersStepDefinitions : BaseTest
    {
        [Given(@"user on the Rozetka homepage")]
        public void GivenUserOnTheRozetkaHomepage()
        {
            DriverHolder.chrome = StartDriverWithUrl("https://rozetka.com.ua/");
        }

        [When(@"user click on the search field")]
        public void WhenUserClickOnTheSearchField()
        {
            throw new PendingStepException();
        }

        [When(@"user enters '([^']*)' in the search field and pressed enter")]
        public void WhenUserEntersInTheSearchFieldAndPressedEnter(string смартфоны)
        {
            throw new PendingStepException();
        }

        [When(@"user click on the seller filter '([^']*)'")]
        public void WhenUserClickOnTheSellerFilter(string rozetka)
        {
            throw new PendingStepException();
        }

        [Then(@"user sees only the goods presented by the seller '([^']*)'")]
        public void ThenUserSeesOnlyTheGoodsPresentedByTheSeller(string rozetka)
        {
            throw new PendingStepException();
        }

        [When(@"user clicks on the filter '([^']*)'")]
        public void WhenUserClicksOnTheFilter(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"user sees those items that can be sending immediately after ordering")]
        public void ThenUserSeesThoseItemsThatCanBeSendingImmediatelyAfterOrdering()
        {
            throw new PendingStepException();
        }

        [When(@"user clicks on the minimum price field")]
        public void WhenUserClicksOnTheMinimumPriceField()
        {
            throw new PendingStepException();
        }

        [When(@"user enters the minimum price")]
        public void WhenUserEntersTheMinimumPrice()
        {
            throw new PendingStepException();
        }

        [When(@"user clicks on the maximum price field")]
        public void WhenUserClicksOnTheMaximumPriceField()
        {
            throw new PendingStepException();
        }

        [When(@"user enters the maximum price")]
        public void WhenUserEntersTheMaximumPrice()
        {
            throw new PendingStepException();
        }

        [When(@"user clicks on the ""([^""]*)"" button")]
        public void WhenUserClicksOnTheButton(string oK)
        {
            throw new PendingStepException();
        }

        [Then(@"the user sees products in the given price range")]
        public void ThenTheUserSeesProductsInTheGivenPriceRange()
        {
            throw new PendingStepException();
        }
    }
}
