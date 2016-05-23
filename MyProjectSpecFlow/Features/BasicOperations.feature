Feature: Answers
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@add
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have also entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen
	
@add
Scenario: Add two negative numbers
	Given I have entered -50 into the calculator
	And I have also entered -70 into the calculator
	When I press add
	Then the result should be -120 on the screen

@add
Scenario Outline: Adds two decimal numbers
	Given I have entered <numberOne> into the calculator
	And I have also entered <numberTwo> into the calculator
	When I press add
	Then the result should be <result> on the screen
	Examples: 
		| numberOne | numberTwo | result |
		| 1.5       | 1.2       | 2.7    |
		| 0.1       | -0.1      | 0.0    | 


@multiply
Scenario: Multiply two numbers
	Given I have entered 5 into the calculator
	And I have also entered 7 into the calculator
	When I press multiply
	Then the result should be 35 on the screen