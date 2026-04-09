//////////////////////////////////////////////////////
// Assignment/Lab/Project: ControlFlow
//Name: Alex Freeman
//Section: SGD.113.
//Instructor: George Cox
// Date: 01/21/2026
//////////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ControlFlow : MonoBehaviour
{
    float playerSpeed;

    // Start is called before the first frame update
    void Start()
    {
        //DO NOT MODIFY THE START METHOD!!!
        QuestionOne();
        QuestionTwo();
        QuestionThree();
        QuestionFour();
        QuestionFive();
        QuestionSix();
        QuestionSeven();
        QuestionEight();
    }

    void QuestionOne()
    {
        //Declare a variable of the type int named number and assign to it a value of your choice (it must be a whole number, positive or negative).
        //Write an if statement that will display The number is positive in the console if number is greater than or equal to 0.
        int number = 28;

        if (number >= 0)
        {
            Debug.Log("Your number " + number + " is an even number");
        }     
    }
    //I declared 28 as the value to the variable "number" 
    //For my if statement to get the message to show i had to make it true. So I did 28(number) greater then or equal to 0. Which is true.
    // then Debug.log to show a message "your number" plus the int value plu "is an even number" in the cosole. 


    void QuestionTwo()
    {
        //Declare a variable of the type bool named isAlive and assign to it a value of your choice(true or false).
        //Write an if else statement that will display The player is alive if isAlive is true and The player is dead otherwise.
        bool isAlive = true;

        if(isAlive)
        {
            Debug.Log("player is alive");
        }
        else
        {
            Debug.Log("player is dead ");
        }
    }
    //Started by declaring isAlive a bool with a value of true. 
    //For my if else statements to display "player is alive" I displayed the variable isAlive as my condition.
    //Since my condition is true my if statment will be displayed.

    void QuestionThree()
    {
        //Declare two Boolean type variables named isAlive and hasAmmo.
        //Assign a valid value to these two variables.
        //If isAlive and hasAmmo are both true, display The player is alive and can shoot.
        bool isAlive = true;
        bool hasAmmo = true;

        if (isAlive && hasAmmo)
        { 
            Debug.Log("The Player is alive and can shoot");
        }
    }
    //Declared 2 bools and named he isAlive and hasAmmo sat both of them to true
    //For my if i did the && control and since 2 true equal true my if message of "player is alive and can shoot" will be displayed 
    void QuestionFour()
    {
        //Declare an integer variable named numOne and assign the value 20 to it.
        //Declare another integer variable named numTwo and assign the value 40 to it.
        //Write an if and else statement that will display Number 1 is greater than number 2 if numOne is greater than numTwo
        //and Number 1 is less than or equal to number 2 otherwise.
        int numOne = 20;
        int numTwo = 40;

        if(numTwo >= numOne)
        {
            Debug.Log("Number 1 is greater than number 2"); 
        }
        else
        {
            Debug.Log("Number 1 is less than or equal to number 2.");
        }
    }
    //Declared to int, named them, and delcared values to each of them.
    //for my IF condition I did the numTwo is greater then or equal do numOne. 
    //which would then make it false displaying my else message "number 1 is less then or equal to number 2"

    void QuestionFive()
    {
        //Declare a float variable named speed and assign a decimal value to it.
        //Write an if else statement that displays The speed is normal if the value of speed is greater than or equal to 25 and less than or equal to 55.
        //Otherwise, it should display The speed is abnormal.
        float speed = 100.0f;

        if (speed >= 25 && speed <= 55)
        {
            Debug.Log("the speed is normal");
        }
        else
        {
            Debug.Log("the speed is abnormal");
        }
    }
    //Declared my float named is speed with a value of 100.0.
    //wrote a if statemend first saying speed is greater then or equal to 25 which is true then control &&. Followed by speed is less then or equal to 55 which is false.
    //with a true && flase we get a flase. Thus showing my els statement "the speed is abnormal" 
    void QuestionSix()
    {
        //Declare an int variable named grade and assign a valid value to it.
        //Write an if else statement that displays Valid grade if the value of grade is greater than or equal to 0 and less than or equal to 100.
        //Otherwise, it should display Invalid grade.
        int grade = 42;

        if(0 >= grade && grade <= 100)
        {
            Debug.Log("Valid Grade");
        }
        else
        {
            Debug.Log("Invalid Grade");
        }
    }
    //delcared an int variable named grade and gave it the variable 42
    //wrote and if statement stating 0 is greater then or equal to 42(grade) making it false then control &&. Followed by 42(grade) is less then or equal to 100 which is true.
    //so false && true make false my else statment will be displayed. 

    void QuestionSeven()
    {
        //Declare a class-scoped variable of the type float and name it playerSpeed (this will not be inside void QuestionSeven(){ }).
        //Within QuestionSeven(), declare a Boolean variable named specialMode and assign a valid value to it.
        //Write an if else statement to assign the value 5.5 to the variable playerSpeed if specialMode is true and assign the value 3.5 otherwise.
        bool specialMode = true;
        
        if(specialMode)
        {
         playerSpeed = 5.5f;
        }
        else
        {
         playerSpeed = 3.5f;
        }    
    }
    //Delcared a class scope variable at the top and named it playerSpeed.
    //then in the local scope i place a bool variable name specialMode and set the value to true.
    //to set my playerSpeed i set my If statment to be specialMode which would make it true then my speed will be 5.5.
    //my els statment states that if this is false my player speed is 3.5.
    //Its true making my player speed 5.5.

    void QuestionEight()
    {
        //Write an if else statement that displays Special mode if playerSpeed is greater than 5 and Normal mode otherwise.
        if(playerSpeed > 5)
        {
            Debug.Log("Special mode");
        }
        else
        {
            Debug.Log("Normal Mode"); 
        }
    }
    //since I declared playerSpeed in my class scope to be used in my loacl scope.
    //and i set a value to playerSpeed above in this loacl scope.
    //I was simply able to do playerSpeed(5.5) is greater then 5 which is true.
    //thus showing my if statment of "special mode" 
}
