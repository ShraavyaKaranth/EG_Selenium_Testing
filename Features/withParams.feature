Feature: Test Login functionality with Parameters

A short summary of the feature
Background: 
Given User is on the orange hrm login page

Scenario: Verify login with valid credentials
	When User enters the username and password
	When User clicks on submit button
	Then User is navigated to home page

Scenario Outline: Verify login with test parameters
	When User enters the "<username>" and "<password>"
	And User Clicks on the login button
	Then User is navigated to home page
	Then User selects city and country information
	| city   | country |
	| Delhi  | India   |
	| Boston | USA     |

Examples: 
| username | password |
| tom      | harry    |
| jerry    | mathew   |