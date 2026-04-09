using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.XR;

public class ArrayPractice : MonoBehaviour
{
    // declare a public array called wordsArray to hold some words of your choice

    string[] wordsArray;

    // declare a text object to display words in Unity Canvas
    // This have been done for you
    public TMP_Text displayWords;

    // declare an array called numbersArray that will hold soe random numbers. HINT: you will be averaging these later

    public float[] numbersArray;

    // declare a text object to display numbers in Unity Canvas
    // This have been done for you
    public TMP_Text displayNumbers;

    // declare an array called namesArray to hold names of your choice

    public string[] namesArray; 


    // declare a text object to display names in Unity Canvas
    // This have been done for you
    public TMP_Text displayNames;


    // Start is called before the first frame update
    void Start()
    {
        // Call the DisplayWords method
        DisplayWords();



        // Use the new keyword to assign a length for you numbersArray;  start with 10 and then you can change it later

        numbersArray = new float[10];


        // Use a for loop to loop through the array and assign random values to each index of this array
        // The loop should loop the number of times equal to the array length and the Random Range can be 1 to 1oo inclusive
        // In each loop cycle, display the number (with a space) to the displayNumbers text object (you will
        //    use the index value of the numbersArray for each cycle and convert it to a string when you assign the value
        //    to the text object).
        // Then call the DisplayNumbers method and use the array as an argument for the method parameter

        for(int index = 0; index < numbersArray.Length; index++)
        {
            numbersArray[index] = Random.Range(1, 101);
            displayNumbers.text += " " + numbersArray[index].ToString();
        }


        DisplayNumbers(numbersArray);



        // call the DisplayNames method

        DisplayNames();

    }



    // Define a method to display the names in a Unity Text Object

    private void DisplayNames()
    {
        // declare a length for the namesArray (you may want to use a low number like 5)
        // then assign to each index a name of your choice

        namesArray = new string[5];
        namesArray[0] = "Mike Spell";
        namesArray[1] = "hunter pool";
        namesArray[2] = "lord poop";
        namesArray[3] = "todd butt";
        namesArray[4] = "Kelly Like";




        // assign an empty string to the text component of your displayNames TMP text object
        displayNames.text = "";

        // use a foreach loop to go through each name in the namesArray and assign it to your displayNames text component.
        // You will want each name to appear on a separate line with the word Hello preceding the name

        foreach(string element in namesArray)
        {
            displayNames.text += "hello " + element + "\n";
        }

    }



    // Define a method that will execute the displaying of array called wordsArray
    // Then assign values for each array element in the proper index
    // Display a value in the text field in Unity for one of the array elements. 

    private void DisplayWords()
    {
        // declare a length for the wordsArray (use 8)
        // then assign to each index a word of your choice (they could combine into a sentence)
        wordsArray = new string[8];
        wordsArray[0] = "what";
        wordsArray[1] = "we";
        wordsArray[2] = "have";
        wordsArray[3] = "here";
        wordsArray[4] = "are";
        wordsArray[5] = "some";
        wordsArray[6] = "short";
        wordsArray[7] = "words";


        // declare an empty string (you can call it something like str or word).
        string words = "";


        // use a foreach loop to go through each element of the wordsArray and assign it to your newly declared string variable.
        // You will want each word to appear on a separate line.
        foreach(string element in wordsArray)
        {
            words += " " + element;
        }

        displayWords.text = "display words: " + words;

        // Finally, concatenate your string varialbe to the phrase Display words:  and assign this value to your displayWords text object.



    }
        

// Define a method that will execute the displaying of the sum and average of the array called numbersArray.
   
  
    private void DisplayNumbers(float[] numbers) //this perameter catches the numbersArray value 

    {
        // declare two float variables, one for the sum and one for the average
        float sum = 0;
        float average;


        // use a for loop to cycle through the length of the array adding each index value to the sum variable
        // then calculate the average
        // Finally, concatenate the sum and average variables word proper phrasing and assign this to the displayNumbers text object.

        for(int index = 0; index < numbers.Length; index++)
        {
            sum += numbers[index];
        }

        average = sum / numbers.Length;
        displayNumbers.text += "\nthe sum is " + sum + " and the avereage is " + average;



    }

}
