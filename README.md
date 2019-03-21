# E-Voting System

### Introduction
This E-Voting system is an MVP of the previously created design. With a focus on casting a vote, the user is able to log into the system, be shown multiple candiates for a single election. The candidates are popuated by an external data store, with the vote they have been given, and an admin can login to the system to see which votes have been given to each. 
The overall system has been implemented according to the design, with the flow matching what is shown in the wireframes. Documention that is provided with the project describes and illustrates the implemention. 

### Using the Voting System
Download, or checkout the master branch, and load into Visual Studio 2017. With the project loaded in and running, login with either a voter, or admin user. 
##### Voter
Username: Robin

Password: password
##### Admin
Username: Super

Password: password

After checking your not a robot, if logged in as a user, you're brought to a screen describing how the voting system works, and how to vote for a candidate. Selecting next, you're now able to select from the candidates, and submit your vote. Finally, the screen moves to the confirmation, where you can either go back, or successfully put your vote in. Ending the session now brings you back to the login screen.
Logging in as admin allows you to view the total votes for the candidates in an easy to read format.

# Personal Addition 
The class diagram showed additional powers and permissions for administrator accounts. These powers were not required for the base version so I have added them.

Additions include:

Permission class,

Expansion to the AdminGUI,

Unit tests for methods in AdminGUI,

Automated UI testing for new features

Admin users now have a Permission field. When a admin is constructed pass in one of the premade ADMIN_TYPES to give that role. Roles are currently "Super", "OnSite", "AuthReseter", "Auditor", "None", and "Test". 

Super has all the powers 
OnSite has all powers available in the new onSite panel in the AdminGUI
AuthReseter has limited accsess to the powers available on the onSite panel
Auditor can see the results of the election
None has no permissions and will see a blank screen on login 
Test can only see the list of Voters

Each type has a account to log into all have the password "password" (Inventive I know)
Super - "Super"
onSite - "Site"
Auditor - "Auditor"
AuthReseter - "Auth"
Test - "Test"

Unit tests can be run in Visual studio 
Automated tests must be run in Visual studio and have a window of bin/Debug open 
