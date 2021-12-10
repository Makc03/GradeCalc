# GradeCalc
## Features

- User inputs Necessary Data 
  1. Subject
   2. Score Achieved
    3. Best Possible Score
- "Calculate" Button - when hit, calculates total based on user inputs
- Round total if user wants to with checkbox 
- Saves info to DataBase if user wants to

## Issues

- Only issue is that you need to calculate after inputting data
- If not, it will either save nothing, or whatever was calculated last time 

## More in-depth / General Description

###### **User Inputs**
- The user will input the subject, points scored out of the most points possible
- When the user hits the "Calculate" Button, it will take the two inputs and divide them to get the total 
- there is also a checkbox for if you want the total to be rounded up;
   1. (ex. 87.3% --> 87%, 78.8% --> 79%)

there is a separate button that saves the data and results to a database;
in this  database, it stores the subject,
score achieved with the most points possible,
and the result- being the grade calculated;
it will also keep a T/F record of if the grade was rounded or not;

a messagebox shows up when you hit the "calculate" button without filling in all the textboxes;
to make sure all data is filled in the database 

however, there is no exception if the user inputs the wrong datatype in a textbox where something specific like a double/int is needed;
which then leads the program to crash;
so just use the program as intended and all is well with life :)

also in order for the intended data to save in the db;
you need to hit the calculate button, then save;
or else either the last thing you put in there will save or nothing will

## Flow Chart
![alt text](https://i.imgur.com/CwVZnZP.jpg)

## Mock up
![alt text](https://i.imgur.com/wVjwxf9.jpg)
