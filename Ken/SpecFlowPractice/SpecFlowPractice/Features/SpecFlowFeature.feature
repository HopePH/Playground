Feature: SpecFlowFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@Test
Scenario: Add two numbers
	Given I have entered "5" into the calculator
	And I have also entered "5" into the calculator
	When I press add
	Then the result should be "10" on the screen

Scenario: User entered a character
	Given I'm in the console app
	When I entered "a" and second no "b" into the calculator and add it
	Then I will show a message that saying "Please enter a number!"
	When I entered "5" and second no "7" into the calculator and add it
	Then the result should be "12" on the screen

