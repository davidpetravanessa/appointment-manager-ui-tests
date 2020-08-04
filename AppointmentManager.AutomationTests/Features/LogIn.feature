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

@SmokeTest
Scenario: Successfullt log out
	Given I log in with user Test1@test.ro and MLQL2dJetoKX+HG90ttMRA== crypted password
	When I am successfully logged in with Test1@test.ro
	Then I tick Log out option 

@SmokeTest
Scenario: Edit user profile
	Given I log in with user Test1@test.ro and MLQL2dJetoKX+HG90ttMRA== crypted password
	When I tick My Profile option
	Then I can edit the user profile
	| key       | value      |
	| FirstName | Test       |
	| LastName  | TestABC    |
	| Phone     | 0712349862 |