using UnityEngine;
using UnityEngine.SceneManagement; //needs for reseting the scene
using TMPro; //need this directory for using TMP objects

public class UIPractice : MonoBehaviour
{
    [Header("Texts")]
    public TMP_Text text_Name;
    public TMP_Text text_Random;
    public TMP_Text text_Sum;
    public TMP_Text text_Number;
    public TMP_Text text_Product;
    public TMP_Text text_Counter;

    [Header("Inputs")]
    public TMP_InputField input_First;
    public TMP_InputField input_Last;
    public TMP_InputField input_numb1;
    public TMP_InputField input_numb2;

    int number1;
    int number2;
    int sum;
    int counter;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        counter = 0;
    }

    //The Quit Button
    public void OnQuitButtonClick()
    {
        Application.Quit();
        Debug.Log("The Quit button Works!");
    }

    //The Reset Button
    public void OnResetButtonClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("the Reset Button Works!");
    }

    //Method for displating a users name gatherd from 2 input fields and displaying 
    public void OnNameButtonClick()
    {
        //Check to make sure that both input fields have data. If one/both is empty then display an error

        if (input_First.text != "" && input_Last.text != "")
        {
            text_Name.color = Color.white;
            text_Name.text = "Hello " + input_First.text + " " + input_Last.text;
        }
        else
        {
            text_Name.color = Color.red;
            text_Name.text = "One or more input fields is empty";
        }

        //clea the input text field by resetting it to an empty string
        input_First.text = "";
        input_Last.text = "";
    }

    //Method for displaying a users name gathered form two fields and displaying in a message
    //public void OnNameButtonClick()

    public void OnProductButttonClick()
    {
        int product;

        if (input_numb1.text != "" && input_numb2.text != "")
        {
            number1 = int.Parse(input_numb1.text);
            number2 = int.Parse(input_numb2.text);

            text_Product.color = Color.black;
            product = number1 * number2;
            text_Product.text = "the product of" + number1 + "and" + number2 + " is " + product.ToString();
        }

        else
        {
            text_Product.color = Color.blue;
            text_Product.text = "One or more input fields are empty";
        }
    }

    public void OnCounterButtonClick()
    {
        counter++;
        text_Counter.text = counter.ToString();
    }
   
    //Method for displaying 2 random numbers 
    public void OnRandomButtonClick()
    {
        int firstRand = Random.Range(1, 101);
        int secondRand = Random.Range(1, 101);

        if(firstRand > secondRand)
        {
            text_Random.text = "Two Random Number are" + firstRand + " " + secondRand + "\n" + firstRand + " Is greater than " + secondRand;
        }

        else if (firstRand < secondRand)
        {
            text_Random.text = "Two Random Number are" + firstRand + " " + secondRand + "\n" + secondRand + " Is greater than " + firstRand;
        }

        else
        {
            text_Random.text = "Two Random Number are" + firstRand + " " + secondRand + "\n" + firstRand + " Is equal to " + secondRand;
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
