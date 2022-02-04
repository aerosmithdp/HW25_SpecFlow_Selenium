@Work
Feature: Work

As a user test
I want to test
In order to test

Background: 
	Given user on the Dou homepage
	When user clicks on the Work button at header

Scenario: Browse jobs through categories
	When user clicks on the category QA
	Then user is redirected to the QA category page
	When user selected experience < one year
	And user selected the city Dnipro
	Then user sees a list of vacancies for Dnipro in the QA category with less than a year of experience

Scenario: Job search
	When user enters "Junior QA" text into the search field
	And user clicks on Find button 
	Then user is redirected to a search page that displays a list of vacancies for Junior QA
	When user selected experience one...three years
	And user selected the city Kiev
	Then user sees list of vacancies in Kiev with experience from one to three years for Junior QA 


Scenario: View first job
	When user clicks on the First job link
	Then user is redirected to the First job page
	When user selected city Kharkiv
	Then user sees a list of vacancies in Kharkiv


Scenario: Viewing Trends
	When user clicks on the Trends link
	Then user is redirected to the Trends page
	When user selected the city Odessa
	And user selected category QA
	And user selected experience five plus years
	Then user sees trends for Dnipro in the QA category with more than five years of experience
