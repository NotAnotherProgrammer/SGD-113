using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class listdemo : MonoBehaviour
{
    //declare a list of string and add 5 gretting to it. 
    //In start use random number (from 0 to the count) and dispay the correct 
    //Modify the code to use a value returning method (returns a string)

    List <string> greetings = new List<string>() { "hello", "bon jor", "hola", "good day", "whats up" };

    //alt method for displaying all the greetings
    string DisplayGreetings()
    {
        int randomNumber = Random.Range(0, greetings.Count);
        return "your greeting is " + greetings[randomNumber];
    }

    void DisplayGrades()
    {
        string output = "";
        foreach (float element in grades) 
        {
            output += element + " - ";
        }
        Debug.Log(output);
    }

    //Declare a list of int for five grades
    //List will be int at start() using the add method 

    List<float> grades = new List<float>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(DisplayGreetings());

        Debug.Log(grades.Count);

        grades.Add(75.5f);
        grades.Add(67.0f);
        grades.Add(100.0f);
        grades.Add(100.0f);
        grades.Add(87.6f);
        grades.Add(55.5f);

        DisplayGrades();
        Debug.Log(grades.Count);

        grades.Insert(0, 90.5f);
        grades.Remove(100.0f);
        grades.Add(105.0f);
        grades.RemoveAt(grades.Count - 1);  
        DisplayGrades();
        Debug.Log(grades.Count);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


//advantage of list you dont need to know the number of inventory in the list.
