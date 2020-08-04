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
	Given I create a new user with Test1@test.ro username and Parola1 password
	Then I am on login page

@SmokeTest
Scenario: Register with another valid user
	Given I create a new user with Test2@test2.com username and Parola2 password
	Then I am on login page