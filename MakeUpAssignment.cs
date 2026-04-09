using System;
using System.Collections;
using System.Globalization;
using System.Security.Cryptography;
using NUnit.Framework;
using Unity.VisualScripting;
using UnityEditor.MPE;
using UnityEngine;
using UnityEngine.Rendering;
//////////////////////////////////////////////////////
// Assignment/Lab/Project: Make Up Assignment 
//Name: Alex Freeman
//Section: SGD.113.
//Instructor: George Cox
// Date: 01/26/2026
//////////////////////////////////////////////////////
public class MakeUpAssignment : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       //Question 1
       //I started with delcaring an intager variable named health and giving it a value of 100.
       //Using the if, else-if, and else statements I was able to break the if up into multiple statments 
       //After setting up the all the possible outcomes the message "Health is Strong" will be displayed in console due to my health being at 100. 
       
       int health = 100;

       if(health <= 20)
        {
            Debug.Log("Warning: Health is dangerously low!");
        }
        else if (health >= 21 && health <= 60)
        {
            Debug.Log("Health is getting low; find a health pack");
        }
        else if (health >= 60 && health <= 80)
        {
            Debug.Log("Health is stable; keep playing");
        }
        else
        {
            Debug.Log("Health is Strong");
        }
        //Question 2
        //I began by delcaing an integer named health and assign it a value of 69. 
        //Using if, else-if, else statments i was able to set up the statment to evalute what message should be displayed
        //when the score matches the correct statement. My score being 69 will then be showed in the else statment being less then 
        //or equal to 70 and it is not greater then or equal to 79. Itll bump down one more and the console will read "C Rank". 
        
        int score = 69;

        if(score >= 90)
        {
            Debug.Log("S rank");
        }
        else if (score >= 80 && score <= 89)
        {
            Debug.Log("A rank");
        }
        else if (score >= 70 && score <= 79)
        {
            Debug.Log("B rank");
        }
        else
        {
            Debug.Log("C Rank");
        }
        //Question 3
        //Started by delcaring a float variable named temperature and gave it a value of 39.73. We wanted the
        //if, else if, else statments to be set up to evalute the temperature. Mine being 39.73 it would fall in the 
        //catagory of "cold" because its greater then or equal to 33 but it is less then or equal to 50.
       
        float temperature = 39.73f;

        if(temperature <= 32)
        {
            Debug.Log("Freezing");
        }
        else if (temperature >= 33 && temperature <= 50)
        {
            Debug.Log("Cold");
        }
        else if (temperature >= 51 && temperature <= 79)
        {
            Debug.Log("cool");
        }
        else if (temperature >= 73 && temperature <= 95)
        {
            Debug.Log("warm");
        }
        else
        {
            Debug.Log("Hot");
        }
         //Question 4
        //Dlecalred and intger and named it "choice" while giving it a value of 3. By using a switch statment we're 
        //able to declare multiple menu options using cases and giving them numbers between 1 and 4. By delacing the
        //value of 3 the case 3 "show the credits" will be exacuted. 
       
        int choice = 3;

        switch(choice)
        {
            case 1:
            Debug.Log("Start game.");
            break;

            case 2:
            Debug.Log("Open the options menu.");
            break;

            case 3:
            Debug.Log("Show the credits menu.");
            break;

            case 4:
            Debug.Log("Quits Game.");
            break;
        }
         //Question 5
        // Here I had to set it up so the weapon would be eqquiped when the right statment is reached. Declaring an int named level with a value
        //of 52. With the level of the weapon being 52 its greath then or equal to 10 and with preamium being true we get a true && true 
        //statement. Thus exacuting the Debug.Log "you can eqiup legendary".
        int level = 52;
        bool isPremium = true;

        if(level >= 10 && isPremium)
        {
            Debug.Log("You can equip a legendary.");
        }
        else if(level >= 10 && !isPremium)
        {
            Debug.Log("You can equip aa standard weapon.");        
        }
        else
        {
            Debug.Log("You cannot equip an item yet.");
        }


        //Question 6
        //Here we used the switch method for when a player chooses between 1 of 3 classes. With multiple outcomes we put the three classes in to cases. 
        //if the appropriate class is inputed then the coraspoding case will be exacuted and the message will then be dipslayed in console. 
        string playerClass = "warrior";

         switch(playerClass)
        {
            case "warrior":
            Debug.Log("Warrior: Strong melee attacks.");
            break;

            case "mage":
            Debug.Log("Mage: Casts spells.");
            break;

             case "rouge":
            Debug.Log("Rogue: Stealth and speed.");
            break;
        
             default:
            Debug.Log("Unknown Class");
            break;

        }

    }
    

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
