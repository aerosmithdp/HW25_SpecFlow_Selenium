Feature: Filters
As a user
I want to use filters for Price
In order to search for products in the desired price range

As a user
I want to use the Ready to sending filter
In order to see products that can be sending immediately 

As a user
I want to use the Seller filter
To order products only from Rozetka

Background: 
	Given user on the Rozetka homepage
	When user click on the search field
	And user enters 'смартфоны' in the search field and pressed enter

@regression
Scenario: Product search by Seller filter
	When user click on the seller filter 'Rozetka' 
	Then user sees only the goods presented by the seller 'Rozetka'


@regression
Scenario: Product search by Ready to sending filter
	When user clicks on the filter 'Ready to sending'
	Then user sees those items that can be sending immediately after ordering


@regression
Scenario: Product search by Price filter
	When user clicks on the minimum price field
	And user enters the minimum price
	And user clicks on the maximum price field
	And user enters the maximum price
	And user clicks on the "OK" button
	Then the user sees products in the given price range