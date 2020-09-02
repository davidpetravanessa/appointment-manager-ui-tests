Feature: Services
	In to have available services
	As a AppointmentManager user
	I want to be able to add new services

Background:
	Given I Acces AppointmentManager apllication

@SmokeTest
Scenario: Create a service
	Given I log in with user Test1@test.ro and Parola1 password
	And I access My Services page
	When I create a service with the name Reparatii telefoane mobile
	Then The Reparatii telefoane mobile service should be successfully created
	And I Delete the new created service

@SmokeTest
Scenario: Make an appointment
	Given I log in with user test2@test2.com and Parola2 password
	And I access Services page
	Then I make an appointment to a service

@SmokeTest
Scenario:Failed-Can't update others user profile
	Given I log in with user Test2@test.ro and Parola2 password
	And I access Services page
	When I tick a user
	Then I can't edit others user profile

@SmokeTest
Scenario: Accept Appointment- verify status
	Given I log in with user test2@test2.com and Parola2 password
	And I access Services page
	And I make an appointment to a service
	And I tick Log out option
	Given I log in with user Test1@test.ro and Parola1 password
	When I access My Services page
	Then I can Confirm an appointment
	And The apoointment state should be updated to CONFIRMED
	Then I can Set to Done an appointment

@SmokeTest
Scenario: HappyFlow of an appointment from confirm to done
	Given I log in with user test2@test2.com and Parola2 crypted password
	And I access Services page
	And I make an appointment to a service
	And I tick Log out option
	When I log in with user Test1@test.ro and Parola1 password
	And I access My Services page
	And I can Confirm an appointment
	Then I can Set to Done an appointment

#Then The apoointment state should be updated to DONE
@SmokeTest
Scenario: Decline appointment
	Given I log in with user test2@test2.com and Parola2 password
	And I access Services page
	And I make an appointment to a service
	And I tick Log out option
	When I log in with user Test1@test.ro and Parola1 password
	And I access My Services page
	And I can Decline an appointment

#And The apoointment state should be updated to DECLINED
Scenario: Edit servicce name that delete
	Given I log in with user Test1@test.ro and Parola1 password
	When I access My Services page
	And I create a service with the name Zugrav
	And The Zugrav service should be successfully created
	And I choose the Edit option from the desired service
	Then I can edit the service
	And The the new service name Livrari exist
	And I Delete the new created service