Feature: EmployeeTesting

All operations done by employee will be tested using Selenium

Background: 
Given Employee navigate to URL
And Employee click to MyPortal
Given Employee enter "saddam@gmail.com" in emailID field
And Employee enter "itsme12345" in password field

Scenario: EmployeeLogin
When Employee click to login
Then Employee can see "Login Successfully"

#Scenario Outline
Scenario Outline: EditingDetails
Given Employee Click to login
And Employee click to edit button
And Change city to <city>
When Employee click to Save Changes
Then Employee city updated to <result>
Examples:
| city  | result |
| Nasik | Nasik  |
| Delhi | Delhi  |

Scenario: Logout
Given Employee Click to login
When Employee click logout
Then Employee see "Logout Successfully"
