@Salaries
Feature: Salaries

As a user test
I want to test
In order to test

Background: 
	Given user on the homepage
	When user clicks on the Salaries button at header

Scenario: View salaries using the widget
	When user selected Dnipro in City drop-down menu 
	And user selected Junior QA Engineer in Positon drop-down menu
	And user selected position Manual QA in Specialization drop-down menu
	Then user sees information according to the selected criteria


Scenario: View salary dynamics
	When user clicks on the Dynamics button
	And user selected city Dnipro in Dynamics of programmers salaries drop-down menu
	Then user sees the dynamics of salaries in the city Dnipro


Scenario: View salaries by city
	When user clicks on the By cities button
	And user selected period december 2020 in Salaries by cities drop-down menu
	Then user sees the salary by city for the period december 2020


Scenario: View salary survey demographics
	When user clicks on the Demographics button 
	And user selected period december 2019 in Demography of the salary survey drop-down menu
	Then user then sees the payroll survey demographics for december 2019
