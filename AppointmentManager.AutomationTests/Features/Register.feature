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