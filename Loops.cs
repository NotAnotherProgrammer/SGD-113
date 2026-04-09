using UnityEngine;

//////////////////////////////////////////////////////

// Assignment/Lab/Project: For Loops Assignment 

//Name: Alex Freeman

//Section: 2026.SGD.113.2121

//Instructor: George Cox

// Date: 2/22/26

//////////////////////////////////////////////////////

public class Loops : MonoBehaviour
{
    public GameObject cubePrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SayHelloThrice();
        Debug.Log("-----");
        CountFingers();
          Debug.Log("-----");
        DisplayCountDown(Random.Range(5, 10));
        Debug.Log("-----");
        
        int firstNumber = Random.Range(1, 6);
        int secondNumber = Random.Range(20, 31);
        

        DisplayEvenNumbers(firstNumber, secondNumber);
        Debug.Log("-----");
        DisplaySquares();
        Debug.Log("-----");
        DisplayMultiplacationTable(3);
        Debug.Log("-----");

        for (int x = -8; x <=8; x += 2)
        {
            GenerateCube(x);
        }

        
    }
    


    //1. Started with definine a method with the name SayHelloThrice. Gave my data type a local variable by the name myMessage.
    //and since you want hello called thrice so i set the perameters as follows. int is the data type and gave it the local variable myMessage with a value of 1 because we want
    //the message shown 3 times. followed up with myMessage is less then 4 becasue we want it to be true up to 3 so to get myMessage (it was at this point i relized i couldve done i instead of myMessage).
    //up to 3 I added a value of one (++) every loop cycle. If perameters are true the the Debug.Log statement is exacuted. Called in the start as well to be called at once started.
    void SayHelloThrice()
    {

        for(int myMessage = 1; myMessage < 4; myMessage++)
        {
            Debug.Log("hello");
        }
    }

    //2. Started by calling a method named CountFingers wtih no parameters. We wanted to have the console display all 10 fingers starting with 1. For my for loop i gave it the pareameters as follows starting 
    // with the intager data type becuase we're working with whole numbers and giving it the value of 1. next we need to go up to ten not stop before it so we gave it the inequailty of less then or equal to
    //followed by 10. And since we want to go up numerically once statment is ran and beofre is loops around i will get + one added to it and then the methods starts over till it hits ten and leaves. Debug.Log will ensure its 
    //displayed in the console each loop. To finish i called it in start to be done everytime the program begins. 
    void CountFingers()
    {
        
        for (int i = 1; i <= 10; i++)
        {
            Debug.Log(i);
        }
        
    }

    //3. Started wtih a method called DisplayCountDown and gave it one perameter with the data type and namme Int downCount. At the same time calling DisplayCoundDown at the start with the RandomRange between 5 and 10 as its argument.
    //Going into the for loop i begain with my data type and local variable of i equals downCount and downCount being any number between 5 and 10. Whatever number that may be will be check to see if its >=1 which will be true so then starting with
    //that number we displayt that in cosole. Then we follow it up by subtracting (--) from it. Now i is = to that number and the loop procceds till it hits one.
    void DisplayCountDown(int downCount)
    {
        for(int i = downCount; i >= 1; i--)
        {
            Debug.Log(i);
        }
    }

    //4. Defined a method and gave it the name DisplayEvenNumber WITH NOT ONE BUT TWO intager perameters those being intager Y and intger Z. Those need value as well but we will get to that in a moment.
    //Intager value equals firstNumber (which will be the firstNumber randomly between 1 and 6 because we wanan stop at 5 for that set of numbers). Followed by if that value is less then or equal to secpndeNumber which it will.
    //THEN we drop down to the next step becase we are looking for only even numbers we need to add an extra stement so IF i equals whatver number we use the modulo method that divides the two numbers and leaves us only the remanider. So we use
    //0 to only show us the even numbers. After that runs we have a Debug.Log() ran string letting the player know there number is even and you the inital  i to insert the value. Up in start i called the values of firstNumber and secondeNumber between the ranges
    //given and readomly called. As well as calling DisplayEvenNumbers in the start with the given arguments of the 2 intager variables called.
    void DisplayEvenNumbers(int firstNumber, int secondeNumber)
    {
        
        for(int i = firstNumber; i <= secondeNumber; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log("Even number is " + i);
            }
        }
                
    }

    //5. Began by defining a method with the name DisplaySquares and we wanted the "squares" of each number to be displayed in the console. The numbers squared we're looking for are 1 to 5 with 5
    //being displayed. So we drop down in to our for loop giving it the parameters of intger i equals 1 cus weare goin up to 5. next we take 1 it is less then or equal to 5 so true. we drop down to the next step
    // this is were we take the i from above and drop it into a new variable by the name int square. So we take i and to square it we multiply it by its self. Now that give us a value for varialve int square.
    // Next step is to have it displayed in the console. We do that by using a Debug.Log statement stating first intial i value which was 1 at first cus 1 X 1 is 1. then using a concatenation 
    //put the phrase "squared is" followed by one mroe concatenation ending with square. Which was the variable decleration i did about to find the square of each number 1-5.
    void DisplaySquares()
    {
        for (int i = 1; i <=5; i++)
        {
            int square = i * i;
            Debug.Log(i + " squared is " + square);
        }
    }

    //6.Defined a method with the name DisplayMultiplcatioTable with one inger parameter. In the start i called the method and gave it an argument of 3 making the int number 3. Dropped into my for loop 
    //statment int i equals 1 followed by if i is <= 12 which will be true until 12 is hit. Since true we drop down to the next step which is delcaring a variable for the table so i called it multiTable (multi pass)
    //followed by out number with is 3 multiplying it by whatever number it is at that momen till we reach 3 times 12. To display it we do a Debug.Log number which will say 3 then concatenation then X for multiply then 
    //another concatenation "equals" followed by ONE MORE concatenation then my variable multiTable. This will display it in the flow youve requested. 
    void DisplayMultiplacationTable(int number)
    {
        for (int i = 1; i <= 12; i++)
        {
            int multiTable = number * i;
            Debug.Log(number + " x " + i + " = " + multiTable);
        }

    }

    //7.This one starts with calling a method name GenerateCube with one parameter being x. Next we need to give x value so in start before we call it we start a for loop to generate multiple cube at the start everytime giving x a value.
    //Below in out method we use Instantiate the cube prefab in a new vector3 location with the number of cubes show by the value of x going in the left to right postion, followed by the X and Y axis positions.
    //ending with a Quterion.identity so the postion of the cube is in the default facing foward. 
    void GenerateCube(int x) 
    {
        Instantiate(cubePrefab, new Vector3(x, 0, 0), Quaternion.identity);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
