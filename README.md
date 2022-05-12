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
      (ex. 87.3% --> 87%, 78.8% --> 79%)

###### **Saving Data**

- There will be a button that the user can hit if they want to save it to a database
- The data that will be saved will be
  1. The Subject
  2. Score Achieved
  3. Best Possible Score 
  4. Total  
  5. Whether or not the total was rounded or not 
- Saving is merely on option, just in case the user does not want to 

###### **Exceptions**

- A messagebox shows up when you hit the "Calculate" button without filling in all the textboxes 
- This is to make sure all data is filled in the database 

- However, there is no exception if the user inputs the wrong datatype in a textbox where something specific like a double/int is needed
- This then leads the program to crash
- So just use the program as intended and all is well with life :)

- In order for the intended data to save in the db
- You need to hit the calculate button, then save
- Or else either the last thing you put in there will save or nothing will

## Flow Chart
![alt text](https://i.imgur.com/CwVZnZP.jpg)

## Mock up
![alt text](https://i.imgur.com/aX3KRG3.png)
