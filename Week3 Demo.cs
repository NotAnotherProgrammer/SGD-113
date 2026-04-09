using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class Week3 : MonoBehaviour
{
    int age = 27; //assiging a literal value






    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        //assign a random value
        age = Random.Range(13, 31);


        if (age >= 18)

        {
            Debug.Log("You are " + age + " and can vote");


        }
        else

        {
            Debug.Log("at " + age + ", you are to young to vote");
        }

        //check to see if a number is even or odd
        int randomNumber = Random.Range(0, 101);

        if (randomNumber % 2 == 0)
        {
            Debug.Log("Your number " + randomNumber + " is an even number.");
        }

        else
        {
            Debug.Log("your Number " + randomNumber + " is an odd number.");
        }
       
        
        //cheching gradeAverage with random.range
        
        float gradeAverage = Random.Range(0.0f, 100.1f);

        if (gradeAverage <= 100 && gradeAverage >= 60)
        {
            Debug.Log("your grade average of " + gradeAverage + " is passing.");
        }


        else
        {
            Debug.Log("your grade average of " + gradeAverage + " is FaILING.");
        }
        //checking bool condiotion 

        bool isPlayerAlive = true;

        if (isPlayerAlive == true)
        {
            Debug.Log("player is alive! Keep Playing!");
        }
        else
        {
            Debug.Log("player is dead! game over!");
        }
       
        //checking 2 bool conditions
        
        bool hasMoney = false;
        bool hasCredit = true;

        if (!hasMoney && !hasCredit)
        {
            Debug.Log("you Cannot buy this item.");
        }
        else
        {
            Debug.Log("you CAN buy this item");
        }

        //using || operator

        bool hasGold = false;
        bool hasSmeckles = true;

        if (hasGold || hasSmeckles)
        {
            Debug.Log("you can buy this");
        }
        else
        {
            Debug.Log("still cant buy this");
        }
    }

  
    
    
   




}
