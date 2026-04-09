using UnityEngine;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine.UI;
using TMPro;
//////////////////////////////////////////////////////

// Assignment/Lab/Project: List Assignment

//Name: Alex Freeman

//Section: 2026SP.SGD.113.2121

//Instructor: Proffesor Cox 

// Date: 04/01/2026

//////////////////////////////////////////////////////
public class Lists : MonoBehaviour
{
    //1) I declared a class scope List with a integer variable and gave it the name evenNumbers. 
    List <int> evenNumbers = new List <int>();

    //8) I declared a class scope list with a string variable and gave its the name "names".
    List<string> names = new List<string>();

    public TMP_InputField InputField;
    public TMP_Text outputText;

    
    void Start()
    {
    //2) Here I used a for loop method to give me 20 random values between 0 and 100.
    //inside the for loop i initiated a randoomNum giving it the value of Random.Range between 0 and 100.
    //Then add those random Numbers (randomNum) to the evenNumbers list. 
       for (int i = 0; i < 20; i++)
        {
            int randomNum = Random.Range(0, 100);
            evenNumbers.Add(randomNum);
        }
        

        DisplayList(evenNumbers);

        //5) This one was tricky but I started by using the RemoveAt method to remove the last value in the list.
        //Then I called it one more time to remove it two times. Removing the last two values in the list.
        evenNumbers.RemoveAt(evenNumbers.Count - 1);
        evenNumbers.RemoveAt(evenNumbers.Count - 1);

        //6) Here I used the Insert method for our evenNumbers list to add the value of 50 at the beginning of the list by using 0.
        //After that I called DiisplayList to show the new list with the value of 50 at the beginning.
        evenNumbers.Insert(0, 50);
        DisplayList(evenNumbers);


        //9c) Here I called the UpdateNameDisplay Method created below to show the names List on the screen whent the game starts.
        UpdateNameDisplay();

    }

    //3) Below I defined a method with the name ChangeToEven and gave it a parameter of a list of intgers.
    //Inside the method i used a for loop statment to loop through the list and check if the value at the current index is odd or even. 
    // In the if statment I check if the value of the index is odd by using a modulus operator to check if the value is odd. 
    //If the value is found to be odd then we add 1 to the value at the current index to make it even and then we move on to the next index.
    void ChangeToEven(List<int> list)
    {
        for(int i = 0; i < list.Count; i++)
        {
            if (list[i] % 2 != 0)
            {
                list[i] += 1;
            }
        }
    }

    //4) Below I started by defeining a method with the name DisplayList and gave it a parameter of a list of integers.
    //Inside the method i stated a string variable with the name "output" and set it equal to an empty string.
    //Then I used a for loop to loop through the list using list.Count as the condition for the loop. 
    //Inside the for loop I took the output and added the list value at the current index and wtih a cancatination operator
    //Once the loop is done I used Debug.log(output) to display the list in the console.
    void DisplayList(List<int> list)
    {
        string output = "";

        for (int i = 0; i < list.Count; i ++)
        {
            output += list[i] + " ";
        }
        Debug.Log(output);
    }

    //9) I defined a method named OnClickSubmitButton that is called when the "submit" button is clicked. 
    //Inside the method I started by declaring a string variable named "inputName" and set it equal to the text in the InputField.
    //Then I used an if statment to check if the inputName is not empty by placing an exclamation mark before the inputName to check if it is not empty.
    //IF the inputName is not empty then we used the Add method to add the inputName to the names list.
    //Followed by calling the UpdateNameDisplay method to update the display of the names list and then we set the inputField text to
    //be an empty string to clear the input field for the next name to be entered.
    public void OnClickSubmitButton()
    {
        string inputName = InputField.text;

        if(inputName != "")
        {
            names.Add(inputName);
            UpdateNameDisplay();
            InputField.text = "";
        }
    }

    //9c) To have the names displayed after being entered I decided to create a method with the name DisplayNames
    //Inside the method I ser the ouputText.text to and empty string to clear the text field before a new name is added.
    //Next we used a for loop to loop through the names list using names.Count as the condion for the loop.
    //Inside the for loop I took the outputText.text and added the current index plus one to show the number of the name in the list
    //followed by a period and a space using a concatenation and then using another concatenation to add the "name" at the current index.
    //Ended with a "\n" to move to the next line down for the next name to be added.
    void UpdateNameDisplay()
    {
        outputText.text = "";

        for (int i = 0; i < names.Count; i++)
        {
            outputText.text += (i + 1) + ". " + names[i] + "\n";
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
