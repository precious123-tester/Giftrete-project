Feature: Registration
In order to join a community
	As an interested new user
	I need to create account and register

@mytag
Scenario: Registration
	Given Given I open a browser
	And I navigate to giftrete websit
	And I click on create account
	And I enter first name
	And I enter last name
	And I enter my email address
	And I enter mobile number
	And I enter password
	And I enter confirm password
	When I click on terms of use
	And I click on privacy policy
	And I click on register
	Then I am sucessfully registered