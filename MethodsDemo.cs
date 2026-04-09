using UnityEngine;


public class MethodsDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int numberOne = 10;
        int numberTwo = 20;
        AddNumbers(2, 3); //arguments pitch a value
        AddNumbers(numberOne, numberTwo);
        

        Multiply(2, 3);
        Multiply(numberOne, numberTwo);

        PlayerMessage("Alex", 80);

        AgeConversion;

        LoanQualification(2100, 1100, 700);
    }
      //Create a methos to add 2 numbers passed as arguments to the method.
      void AddNumbers(int firstNumber, int secondNumber)
      {
       
        int sum = firstNumber + secondNumber;

        Debug.Log(("the sum of " + firstNumber + " and " + secondNumber + " is " + sum ));
     }
      //MULTIPLY IT arguments based on paramenter  
      void Multiply(int x, int y)
     {
        int product = x * y;
        Debug.Log(("the sum of " + x + " and " + y + " is " + product ));
     }
     //Message to player based on the score passed as an argument to the parameters 
     void PlayerMessage(int score, string name)
     {
        if (score <= 100)
        {
            Debug.Log("Your Score is " + score + " . " + " You are having a bad day," + name);
        }
        
        else if (score > 100 && score <= 200)
        {
            Debug.Log("Your Score is " + score + " . " + " Good effort" + name);
        }

        else if (score > 200 && score <= 300)
        {
            
        }

     //Method to determine if 2 numbers are equal
     void NumberEquality(int numb1, int numb2)
        {
            if (numb1 == num2)
            {
                Debug.Log();
            }
        }
     //Method to determine if a letter is a vowel or a consoant
     void LetterCheck(string leterTest)
        {
            
        }
     //Method to determine if a rider is eligable to ride the roller coaster based on height 
     //must be 49 inches to ride
     void HeightCheck()
        {
            
        }

     //Method to convert an age in years into months and weeks.
     void AgeConversion(int age)
        {
            int month = age * 12;
            int weeks = age * 52;

            Debug.Log("The person is " + age + " years old.");
             Debug.Log("The person is " + age + " months old.");
              Debug.Log("The person is " + age + " weeks old.");

        }

     //Method to convert Fahrenheit tempature to Celsius
     void TemperatureConversion(float tempTest)
        {
            float celsiusTemp;

            //convert F to C (temp - 32) * 5/9
            //convert C to F 1.8 * C + 32
            //32F = 0C
            //212F = 100C

            celsiusTemp = (tempTest - 32) * 5 / 9;
            Debug.Log(celsiusTemp);
        }
       
        //Method to determine loan eligibility based on certin criteria
    void LoanQualification(int income, int expense, int creditRating)
        {
            if(income > 2000)
            {
                if(expense < 1200)
                {
                    Debug.Log("Based on the net monthly income of");
                }
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
