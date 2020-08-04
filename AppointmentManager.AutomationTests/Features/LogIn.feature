Feature: LogIn
	In order to make different actions AppointmentManager app
	As a regitered user
	I want to le able to log in

Background:
	Given I Acces AppointmentManager apllication

@SmokeTest
Scenario: Succesfull log in with valid user
	Given I log in with user Test1@test.ro and MLQL2dJetoKX+HG90ttMRA== crypted password
	Then I am successfully logged in with Test1@test.ro