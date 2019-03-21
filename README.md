# CSSDAssignment2
## Individual Assignment piece - Michael Walls
### Functionality
Adds functionality for multiple elections to be voted for within a single login instance

This involved rewriting:

- Parts of the UserGUI class to accomodate reloading the voting process.
- The entirety of votingStorage class, the original version wasn't able to accomdate the ability
to write multiple election votes to the same document. Also fixes the issues requiring
an election.vote to exist prior to starting the program.
- Some minor parts of the election class, as I only had to modify its link to the vote storage class 
for storing the new versions of elections.