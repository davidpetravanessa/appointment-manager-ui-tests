Feature: Services
	In to have available services
	As a AppointmentManager user
	I want to be able to add new services

Background:
	Given I Acces AppointmentManager apllication
	Given I log in with user Test1@test.ro and MLQL2dJetoKX+HG90ttMRA== crypted password

@SmokeTest
Scenario: Create a service
	Given I log in with user Test1@test.ro and MLQL2dJetoKX+HG90ttMRA== crypted password
	And I access My Services page
	When I create a service with the name Tamplarie
	Then The Tamplarie service should be successfully created

@SmokeTest
Scenario: Make an appointment
Given I log in with user test2@test2.com and kjwekouejLl1bMBMWmVHTg== crypted password
And I access Services page
And I make an appointment to a service