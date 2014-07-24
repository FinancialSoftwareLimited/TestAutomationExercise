FSL Test Automation Exercise
============================

Below are the following exercises are to be completed by candidates prior to a face-to-face interview at FSL. The exercises are designed to be sort and should take no more than 2 hours to complete.

The starting code base can be found at: https://github.com/FinancialSoftwareLimited/TestAutomationExercise

Exercise 1 (max 2hours)
-----------------------
Write an automated test for the following scenarios

>```
Scenario: Search by domain name
Given I have navigated to 'http://www.google.co.uk' in my web browser
And I have entered 'example.com' into the search box
When I click on 'Google Search'
Then I am presented with a list of results
And 'Example Domain' is the first result
```

>```
Scenario: Search by keyword
Given I have navigated to 'http://www.google.co.uk' in my web browser
And I have entered 'example' into the search box
When I click on 'Google Search'
Then I am presented with a list of results
And 'Example Domain' is the fifth result
```

>```
Scenario: I'm feeling lucky
Given I have navigated to 'http://www.google.co.uk' in my web browser
And I have entered 'example' into the search box
When I click on 'I'm feeling lucky'
Then I am automatically redirected to 'http://example.com' in my web browser
```

Exercise 2 (max 15mins)
-----------------------

Explain how these scenarios could be improved

Exercise 3 (max 15mins)
-----------------------

Explain the Page Object Model design pattern, why you would use it

- Bonus points for expaining when you would not use the Page Object Model design pattern
