Feature: SearchFeature
	

@scenario1
Scenario: Search by domain name
	Given I have navigated to 'http://www.google.co.uk' in my web browser
	And I have entered 'example.com' into the search box
	When I click on 'Google Search'
	Then I am presented with a list of results
	And 'Example Domain' is the first result

@scenario2
Scenario: Search by keyword
	Given I have navigated to 'http://www.google.co.uk' in my web browser
	And I have entered 'example' into the search box
	When I click on 'Google Search'
	Then I am presented with a list of results
	And 'Example Domain' is the fifth result

@scenario3
Scenario: I'm feeling lucky
	Given I have navigated to 'http://www.google.co.uk' in my web browser
	And I have entered 'example' into the search box
	When I click on 'I'm feeling lucky'
	Then I am automatically redirected to 'http://example.com' in my web browser