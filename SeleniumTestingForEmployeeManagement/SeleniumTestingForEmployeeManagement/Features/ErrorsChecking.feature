Feature: ErrorsChecking

Error checking related operations

@tag1
Scenario: EmptyFormLogin
Given User navigate to URL
And User click to MyPortal
And User click to login
Then User see error message
