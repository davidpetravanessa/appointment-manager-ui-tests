Feature: Register
	In order to have acces in AppointmentManager app
	As an user
	I want to be able to register succesfully

Background:
	Given I Acces AppointmentManager apllication

@SmokeTest
Scenario: Access aplication
	Given I Acces AppointmentManager apllication
	Then I should be on home page

@SmokeTest
Scenario: Register with valid user
	Given I create a new user with Test2401191@test.ro username and Parola1 password
	Then I am on login page

@SmokeTest
Scenario: Can't register with invalid email
	Given I create a new user with Test3 username and abc password
	Then The following error message should be displayed must be a well-formed email address

@SmokeTest
Scenario: Can't register with an existing username
	Given I create a new user with Test1@test.ro username and Parola1 password
	Then The following error message should be displayed An user with this email already exists.

@SmokeTest
Scenario: Can't register with invalid password
	Given I create a new user with Test1@test.ro username and a12 password
	Then The following error message should be displayed length must be between 6 and 2147483647
