Feature: LogIn
	In order to make different actions AppointmentManager app
	As a regitered user
	I want to le able to log in

Background:
	Given I Acces AppointmentManager apllication

@SmokeTest
Scenario: Succesfull log in with valid user
	Given I log in with user Test1@test.ro and Parola1 password
	Then I am successfully logged in with Test1@test.ro

@SmokeTest
Scenario: Successfullt log out
	Given I log in with user Test1@test.ro and Parola1 password
	When I am successfully logged in with Test1@test.ro
	Then I tick Log out option

@SmokeTest
Scenario: Can't login with invalid password
 Given I log in with user Test1@test.ro and Licenta2 password
 Then The log in failed with Test1@Test.ro

 @SmokeTest
 Scenario: Can't login with invalid email
 Given I log in with user Invalid@test.ro and MLQL2dJetoKX+HG90ttMRA== password
  Then The log in failed with Invalid@test.ro

@SmokeTest
Scenario: Edit user profile
	Given I log in with user Test1@test.ro and Parola1 password
	When I tick My Profile option
	Then I can edit the user profile
		| key       | value      |
		| FirstName | Test       |
		| LastName  | TestABC    |
		| Phone     | 0712349862 |