Feature: TrendyolLogin
Login to Trendyol 

@login
Scenario: Perform Login of Trendyol with wrong password
	#steps
	Given I launch the trendyol
	#And I close the modal
	And I click login link
	And I enter the following details
		| Email                 | Password  |
		| tarkgulyuva@gmail.com | password |
	And I click login button 
	Then I should see Error Message