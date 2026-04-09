using UnityEngine;

public class ControlFlowPt2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CheckHighestScore();
        
        CheckAge();

        UserChoice();

        NumberGuess();

    }
    


      // write a method to execute the check score code when method is called Start()
        void CheckHighestScore()
    {
        float scoreOne = Random.Range(50.00f, 201.00f);
        Debug.Log("Scor eone is " + scoreOne + " and will be rounded to " + scoreOne.ToString("f2"));

        float scoreTwo = Random.Range(50.00f, 201.00f);
        Debug.Log("Scor two is " + scoreTwo + " and will be rounded to " + scoreTwo.ToString("f"));

        float scoreThree = Random.Range(50.00f, 201.00f);
        Debug.Log("Score three is " + scoreThree + " and will be rounded to " + scoreTwo.ToString("2"));

        if(scoreOne > scoreTwo && scoreOne > scoreThree)
        {
            Debug.Log(scoreOne.ToString("f2") + " is the higher score ");
        }

        else if (scoreTwo > scoreThree)
        {
            Debug.Log(scoreTwo.ToString("f2") + " is the higher score ");
        }
        else
        {
            Debug.Log(scoreThree.ToString("f2") + " is the higher score ");
        }
    }

     // write a method to execute the check age code when method is called in Start()
        void CheckAge()
    {
        int age = 12;
        if(age > 0 && age < 13)
        {
            Debug.Log("You are " + age + " so you are a child."); //age 1 to 12
        }
     else if(age > 12 && age < 18)
        {
           Debug.Log("You are " + age + " so you are a teenager."); //age 13 to 17
        }
     else if (age > 17 && age < 65)
        {
            Debug.Log("You are " + age + " so you are a adult."); //age 18 to 64
        }
        else
        {
            Debug.Log("You are " + age + " so you are a senior."); //age 65 and older
        }
    }


     // write method to exectue a suer's choice
        void UserChoice()
    {
        int choice = Random.Range(1, 5);
        switch(choice)
        {
            case 1:
                Debug.Log("You chose the sword");
                break;

            case 2:
                Debug.Log("you chose gun");
                break;

            case 3:
                Debug.Log("You Chose flamethrower");
                break;

            case 4:
                Debug.Log("you chose kinfe");
                break;
            default:
                Debug.Log("choice and invalid. Select a number from 1 to 4. ");
                break;
        }
        
    }


     //write method to execute the number guess code when method is called in Start()
        void NumberGuess()
    {
        int choice = Random.Range(0 , 5);
        switch(choice)
        {
            case 0:
            Debug.Log("You chose number 0");
            break;

            case 1:
            Debug.Log("You chose number 1");
            break;

            case 2:
            Debug.Log("You chose 2");
            break;

            case 3:
            Debug.Log("You chose 3");
            break;

            default:
            Debug.Log("Your choice is invalid");
            break;
        }
        
    }

      // NumberInput Guessing KeyCodes
        void NumberInputGuessing()
    {
        if (Input.GetKeyUp(KeyCode.A))
        {
            int playerChoice = 1;
            int computerChoice = 0;

         int choice = Random.Range(1 , 4);
         switch(choice)
         {
            case 1:
            computerChoice = 1;
            break;

            case 2:
            computerChoice = 2;
            break;

            case 3:
            computerChoice = 3;
            break;

            default:
            Debug.Log("Invalid Data");
            break;
         }

         if (computerChoice == playerChoice)
         {
            Debug.Log("The player chose " + playerChoice + " and the computer chose " + computerChoice +
             ", so they chose the same number");   
         }
         else if (computerChoice >= playerChoice)
         {
             Debug.Log("The player chose " + playerChoice + " and the computer chose " + computerChoice +
             ", so they chose the same number");  
         }
            else if (computerChoice < playerChoice)
         {
             Debug.Log("The player chose " + playerChoice + " and the computer chose " + computerChoice +
             ", so they chose the same number");  
         }
        }

        if (Input.GetKeyUp(KeyCode.B))
        {
            int playerChoice = 2;
            int computerChoice = 0;

         int choice = Random.Range(1 , 4);
         switch(choice)
         {
            case 1:
            computerChoice = 1;
            break;

            case 2:
            computerChoice = 2;
            break;

            case 3:
            computerChoice = 3;
            break;

            default:
            Debug.Log("Invalid Data");
            break;
         }

         if (computerChoice == playerChoice)
         {
            Debug.Log("The player chose " + playerChoice + " and the computer chose " + computerChoice +
            ", so they chose the same number");   
            }
         else if (computerChoice >= playerChoice)
         {
            Debug.Log("The player chose " + playerChoice + " and the computer chose " + computerChoice +
            ", so they chose the same number");  
            }
            else if (computerChoice < playerChoice)
         {
            Debug.Log("The player chose " + playerChoice + " and the computer chose " + computerChoice +
            ", so they chose the same number");  
            }
        }

        if (Input.GetKeyUp(KeyCode.C))
        {
            int playerChoice = 3;
            int computerChoice = 0;

         int choice = Random.Range(1 , 4);
         switch(choice)
         {
            case 1:
            computerChoice = 1;
            break;

            case 2:
            computerChoice = 2;
            break;

            case 3:
            computerChoice = 3;
            break;

            default:
            Debug.Log("Invalid Data");
            break;
         }

         if (computerChoice == playerChoice)
         {
            Debug.Log("The player chose " + playerChoice + " and the computer chose " + computerChoice +
            ", so they chose the same number");   
            }
            else if (computerChoice >= playerChoice)
            {
            Debug.Log("The player chose " + playerChoice + " and the computer chose " + computerChoice +
            ", so they chose the same number");  
            }
            else if (computerChoice < playerChoice)
            {
            Debug.Log("The player chose " + playerChoice + " and the computer chose " + computerChoice +
            ", so they chose the same number");  
            }
        }

    }
     // checks every frame -- movment, clicking a key/mouse button, raycasting.
    void Update()
    {
       NumberInputGuessing(); 
    } 
}
