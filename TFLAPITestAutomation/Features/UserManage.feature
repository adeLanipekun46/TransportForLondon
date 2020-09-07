Feature: User Manage

#Add description



Scenario: Create a single user
Given post request to create user with name 'tony' and job 'leader' is sent
Then the status code should be 201
And created details should be
| name | job    |
| tony | leader |

Scenario: Retrieve a single user

Scenario: Retrieve list of users

Scenario: Update single user

Scenario: Retrieve unknown user