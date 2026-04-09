using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using TMPro;
using UnityEditor;
public class ValueReturnMethods
{
    [Header("GameObject")]
    public GameObject Panel_Invalid;
    public GameObject cylinder;
    public GameObject cube;
    public GameObject sphere;

    [Header("Texts")]
    public TMP_Text text_Output;
    public TMP_Text text_Input;

    [Header("InputField")]
    public TMP_InputField inputNumber;
   
    
    void start()
    {
        Debug.Log(message: ("Fred"));

        int randomNumber = Random.Range(1, 51);
        Debug.Log("the double of " + randomNumber + " is " + GetDouble(randomNumber));

        Debug.Log(FullName("Alex, P, Freeman"));

        float random1 = Random.Range(1.0f, 51.0f);
        float random2 = Random.Range(1.0f, 51.0f);

        Debug.Log("Of the number" + random1.ToString("f1") + " and " + random2.ToString("f1") + " , " +
            HighestFloat(random1, random2).ToString("f1") + "is the highest score");

        Debug.Log(GetRandomNumber(2, 10));
        Debug.Log(GetRandomNumber(5, 5));
        Debug.Log(GetRandomNumber(100, 110));

        InvokeRepeating("GetRandomPickup");



    }
    //Value returing method to return a string
    private string Message(string name)
    {
        return "Hello, " + name;
    }

    //Define a methof that takes an int parameter and returns its double. Call it in the start and disply the retuned value

    private int GetDouble(int number)
    {
        return number * 2;
    }

    //Define a method that takes 2 strings paremeter and char  (first name, laste name) and returnds the full name. Call it in the start and display the retuned value

    private string FullName(string firstName, string lastName, char middleInitial)
    {
        string name = firstName + " " + middleInitial + " . " + lastName;
        return "My name is " + name;
    }

    //Define a method that takes 2 floar parameters and returns the highest.
    //Call it in the start with a random number and display the higher of the 2 random numbers.
    //Make sureall numbers are displayed (18.2 and 15.4 and 18.2 is the highest)

    private float HighestFloat(float numb1, float numb2)
    {
        if (numb1 > numb2)
        {
            return numb1;
        }
        else
        {
            return numb2;
        }
    }


    //Call the GetRandomNumber method in start with the following values 2 and 10 5 and 5 100 and 110
    //display the values returned and make sure it works as expected 

    private int GetRandomNumber(int lowerlimit, int upperlimit)
    {
        int coolRand = Random.Range(lowerlimit, upperlimit);


        if (lowerlimit < upperlimit)
        {
            return coolRand;
        }

        else
        {
            Debug.Log("ERROR!");
            return -1; //-1 is not a valid ID or index
        }

    }

    //Define a GetRandomPickup method that will randomly return one of the 3 prefabs previously created(Gameobject).
    private GameObject GetRandomPickup()
    {
        Vector3 ranPos = new Vector3(Random.Range(-10.0f, 10.0f) 2.0f, Random.Range(-10.0f, 10.0f));
        int random = Random.Range(0, 3);


        GameObject gameObject;
        switch (random)
        {
            case 0:
                gameObject = Instantiate(cube, ranPos, Quaternion.identity);
                return gameObject;
            case 1:
                gameObject = Instantiate(sphere, ranPos, Quaternion.identity);
                return gameObject;
            case 2:
                gameObject = Instantiate(cylinder, ranPos, Quaternion.identity);
                return gameObject;
            default:
                Debug.Log("ERROR!");
                return null;
        }
    }
 

        private bool IsInputValid(string input)
        {
        bool invalidInput;
        if(input == "")
        {
            invalidInput = true;
            Panel_Invalid.SetActive(true);
        }
        else
        {
            invalidInput = false;
            Panel_Invalid.SetActive(false);
        }
        return invalidInput;
        }

    public void OnSubmitButtonClick()
    {
        if (IsInputValid(inputNumber.text))
        {
            Panel_Invalid.SetActive(true);
        }
        else
        {
            Panel_Invalid.SetActive(false);
            text_Output.text = "your nunmber is" + inputNumber.text;
            text_Output.color = Color.crimson;
        }
        inputNumber.text = " "; 
    }
   
     public void OnCloseButtonClick()
    {
        Panel_Invalid.SetActive(false);
    }

    private bool ContainsPickup()
    {
        if (GameObject.FindGameObjectWithTag("Pickup"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    void update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            GetRandomPickup();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (ContainsPickup())
            {
                text_Pickup.text = "the scene contains \n a pickup!";
            }
            else
            {
                text_Pickup.text = "There are no pickups.";
            }
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            if (ContainsPickup())
            Destroy(GameObject.FindGameObjectWithTag("Pickup"));
            text_Pickup.text = "";
        }
    }
}