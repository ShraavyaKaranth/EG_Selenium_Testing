Feature: XYZBank

A short summary of the feature

@customer
Scenario: Customer Login
	Given Customer is on login page
	When Customer clicks on Customer Login button
	And selects the name
	And User Clicks on login button
	Then User is logged in and can see data
@manager
Scenario: Bank Manager Login
	Given Manager is on login page
	When Customer clicks on Bank Manager Login button
	And Clicks on Add Customer Button
	And enters firstname, lastname, postalcode
	| firstname | lastname | postalcode |
	| Shravya3  | Karanth3 | 234567     |
	And clicks on Add new Customer Button
	Then new Customer is added 
	When Clicks on Open Account Button
	And chooses customer name and currency
	| cname        | currency |
	| Harry Potter | Dollar   |
	And clicks on Process Button
	Then new Account gets created
	When Clicks on Customer Button
	Then Customer data can be viewed
