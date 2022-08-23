Feature: AdminTesting

All operations done by admin will be tested using Selenium

Background: CommonTask
Given User navigate to URL
And User click to MyPortal
Given User enter "yogita@gmail.com" in emailID field
And User enter "winteriscoming" in password field

Scenario: SuccessfullLogin
When User click to login
Then Admin can see "List of all Employees"

Scenario Outline: AddDepartment
And User click to login
And Admin click to Add department
And Admin enter <department>
When Admin click Create
Then Admin can see notification <Message>
Examples: 
| department    | Message                       |
| Administrator | Department already exists     |
| IT            | Department Added Successfully |

Scenario: DeleteUser
And User click to login
And Admin click to Delete for specific user by Id "anshika@gmail.com"
When Admin click delete
Then Admin can see deleted successfull message "Employee Deleted Successfully"

Scenario Outline: EditUser
And User click to login
And Admin click to Edit for specific user by Id "2"
And Change role to <role>
When Admin click update
Then Admin can see updation successfull message "Updation Done Successfully"
Examples: 
| role     |
| Admin    |
| Employee |

Scenario Outline: AddUser
And User click to login
And Admin click to AddUser
And enter EmpName <name>
And enter EmailId <mail>
And enter Password <password>
And enter Confirm Password <confirmPass>
And enter City <city>
And enter phone <phone>
And Admin select Department name <department>
And Admin select Role <role>
When Admin click Add
Then Admin can see addded successfull message "Employee Added Successfully"
Examples: 
| name    | mail             | password       | confirmPass    | city  | phone      | department  | role     |
| Anshika | anshika@gmail.com | winteriscoming | winteriscoming | Delhi | 9910840698 | Engineering | Employee |



