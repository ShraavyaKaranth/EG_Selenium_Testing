Feature: usingTable

A short summary of the feature

Scenario Outline: Automate using table
	Given User is on the Rahul Shetty angular practice page
 
	When User enters all information
	| Name     | Email          | Password       | LoveIcecreams | Gender | Employment | DateOfBirth |
	| Shravya  | shr@gmail.com  | Icecreams@123  | Yes            | Female | Student    | 22-04-2003  |
	And User clicks on Submit button
	Then form gets submitted


