using UnityEngine;
//////////////////////////////////////////////////////
// Assignment/Lab/Project: Variables Assignment 
//Name: Alex Freeman
//Section: XXXXXX.SGD.113.XXXX
//Instructor: Professor Cox
// Date: 1/14/2026
//////////////////////////////////////////////////////
///
public class Variables : MonoBehaviour
{
    //Question 1a -Here I am declaring a private class to store a int number for "myScore".
    private int myScore = 10;
    
    //Question 2 -Here you see me delcaring a class scope thats not visable to the inspector. 
    //Also comes with a meanningful message.
    private string myString = "Be kind to others";
    
    //Question 5 -Here Im declaring a class to be public to be visable in the inspector.
    public string myMessage;
    
    //Question 9 - Delcaring a private float for the int speed.
    private float speed = 100.0f;




    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Question 1b -Asking the console nicely to display myScore in console with a Debug.Log command.
        Debug.Log(myScore);
        
        //Question 3a -Kindly inputing a char of the letter 'a' as myChoice. And requesting the console to display it withe Debug.Log of myChoice.
        char myChoice = 'a';
        Debug.Log(myChoice);
        
        //Question 4a -Staring a string int with my first and last name.
        string firstName = "Alex";
        string lastName = "Freeman";
        
        //Questoin 4b -Putting string into the console for it to be seen by the world. While adding a message and combining the two name strings.
        Debug.Log("my full name is" + " " + firstName + " " + lastName);
        
        //Question 5a -Commanding the console to display the variable myMessage with a qoute from Sean Connory
        Debug.Log(myMessage = "your the man now dog");
        
        //Question 6 -Declaring a bool by calling it myBool. Then I Debug.Log to console with the bool being displayed "True".
        bool myBool = true;
        Debug.Log(myBool);
        
        //Question 7 -Making a float for two seperate numbers. Taking the two floats, adding them together while asking for the average. 
        // Then a simple Debug.Log to console to have the average displayed.
        float numberOne = 10.5f;
        float numberTwo = 50.3f;
        float average = (numberOne + numberTwo);
        Debug.Log(average);
        
        //Question 8 -Below are two double variable that include my weight and height. Then taking the weight adding it to 703.
        //While multiplying the height twice to square it then taking the sum of those two numbers and dividing them. 
        //Displaying wtih Debug.Log then adding "BMI" with a space as well to keep it clean.
        double weight = 145.0;
        double height = 67.0;
        Debug.Log("BMI" + " " + (weight + 703 / (height * height)));
        
        //question 9a -I pulled my variable speed from above and inialized it with speedAsInt
        int speedAslnt = (int)speed;
        
        //Question 10 - Takeing a string that has number in it then declaring "number" as a numberAsString. 
        //Then displaying with Debug.Log number instead of numberAsString.
        string numberAsString = "88";
        int number = int.Parse(numberAsString);
        Debug.Log(number);

        





     




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
