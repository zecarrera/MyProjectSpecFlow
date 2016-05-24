Feature: EmployeeForm
	As a RH manager
	I want to register a new employee
	In order to store all its details

@SmokeTest
Scenario: Create a new employee with all mandatory fields
	Given I have loaded new employee page
	When I fill all the mandatory details in form
		| Name | Age | Phone   | Email         |
		| john | 31  | 0123456 | john@hogh.com |
		| janet | 30  | 0654132 | jante@hogh.com |
	#Then the result should be 120 on the screen


@SmokeTest
Scenario: Create a new employee with all mandatory fields with dynamics
	Given I have loaded new employee page
	When I fill all the mandatory details in form using Dynamics
		| Name | Age | Phone   | Email         |
		| john | 31  | 0123456 | john@hogh.com |
		| janet | 30  | 0654132 | jante@hogh.com |
	#Then the result should be 120 on the screen
