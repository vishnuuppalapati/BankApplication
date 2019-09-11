Feature: Registration Process
	In order to register user
	I want to provide all the details

@mytag
Scenario: New User Registration
	Given I have entered FullName 
	And I have entered FatherName And MotherName
	And I have entered Dateofbirth And Age
	And I have entered MobileNumber
	Given I have entered PermanentAddress
	And I have entered 
	When I press add
	Then the result should be 120 on the screen
