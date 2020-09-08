Feature: User Manage

#Add description



Scenario: Create a single user
Given post request to create user with name 'tony' and job 'leader' is sent
Then the status code should be 201
And created details should be
| name | job    |
| tony | leader |

Scenario: Retrieve a single user
Given GET request to create user with firstname 'Janet' and lastname 'Weaver' is sent
Then the status code should be 201
And created details should be
| firstname | lastname      |
| Janet      | Weaver       |

Scenario: Retrieve list of users


Scenario: Update single user
Given put request to update user with name 'John' and job 'coach' is sent
Then the status code should be 201
And created details should be
| name | job    |
| John | coach  |


Scenario: Retrieve unknown user
Given GET request to create user with blankfirstname '  ' and blank lastname ' ' is sent
Then the status code should be 404
       |