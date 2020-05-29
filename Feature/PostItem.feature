Feature: PostItem
	In order to be a guru tester 
	I have to automat the post item page
	which have lots of feature to automate

@mytag
Scenario: verify item can be posted
	Given I navigate to giftrete websit
	And I click on login
	And I enter my emailaddress
	And I enter passwords
	When I click on sign in
	And I click on postitem
	And I enter itemname
	And I enter itemdescription
	And I select itemcategory
	And I select itemtype
	And I enter itemweight
	And I enter itemlocation
	And I choose a itemimage
	And I click on add
	Then An item should be posted
