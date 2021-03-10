Feature: Interview
	Background: 
	Given I enter amazon page

@mytag
Scenario: First test case
	Given I search for 'Samsung Galaxy Note 20'
	When I click in the first result
	Then I compare prices and add to cart
	Then I go to cart and verify price
	Then I delete the item

Scenario: Second test case
	Given I click Sign in button
	Then I click star right here option
	When I fill name and email fields
	Then I click on condition of use link
	When I locate search bar and search for Echo
	Then I click Echo support
	Then I verify Getting started, Wi-Fi and bluetooth, Device Software and hardware, Troubleshooting elements are present