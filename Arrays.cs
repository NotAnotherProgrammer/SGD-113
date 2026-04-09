using UnityEngine;

public class Arrays : MonoBehaviour
{
    //1)Below I declared an array with the name randomNumbers and assigned it 10 elemnts inside the [].
    int[] randomNumbers = new int[10];
    // Below I declared an array for GameObjects setting it to be an array with [] and I named it projectiles.
    public GameObject[] projectiles;

    void Start()
    {
        //2) I called the FillWithRandomNumbers method to fill the randomNumbers array with random integers between 1 and 100.
        FillWithRandomNumbers();
        //3) I called the DisplayArray method and passed the randomNumbers array as the argument.
        DisplayArray(randomNumbers);
    
        //4) I called this method and assigned the result to an integer variable called largest. 
        // Then I log a message that says "The largest element of randomNumbers is " followed by a cancatination of the largest variable.
        int largest = GetLargestValue(randomNumbers);
        Debug.Log("The largest element of randomNumbers is " + largest);
        
        //5) I stated a boolean variable called contains50 and assigned it the 
        // result of calling the ContainValue method with the argument 50.
        //followed by an if statement that checks if contains50 is true. If it is, I log a message saying "50 is found".
        // If it is not, I log a message saying "50 is not found".
        bool contains50 = ContainValue(50);
        if (contains50)
            Debug.Log("50 is found");
        else
            Debug.Log("50 is not found");
           


    }

    //2) I defined a method with the name FillWithRandomNumbers that fills the randomNumbers array
    //  with random integers between 1 and 101 using a for loop.
    void FillWithRandomNumbers()
        {
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = Random.Range(1, 101);
            }
        }

        //3) I started with defining a method with the name DisplayArray that takes an integer[] array as the parameter
        // then I created a string variable called output and initialized it to an empty string using "". 
        //Followed by a for loop that goes through eatch element of the array and adds 1 to the output string.
        //in the body of the loop, I concatenate the current element of the array to the output string, followed by a space.
        void DisplayArray(int[] array)
    {
            string output = "";
            for (int i = 0; i < array.Length; i++)
            {
                output += array[i] + " ";
            }
            Debug.Log(output);
        }

    //4) Started wtih defing a method with the name GetLargestValue that take an integer array as the parameter.
    //Next I created an integer variable called largest and initialized it to the first element of the array.
    //followed up by a for loop that starts from the second element of the array and goes through each element.
    //In the body of the loop, I check if the current element is greater than the largest variable. 
    // If it is, I update the largest variable to the current element.
    //Finished it off by returning the largest variable after the loop has completed.
    int GetLargestValue(int[] array)
    {
        int largest = array[0];

        for (int index = 1; index < array.Length; index++)
        {
            if (array[index] > largest)
            {
                largest = array[index];
            }

        }
            return largest;
    }

    //5) I defined a method with the name ContainValue gave it the data type of bool and an integer parameter called value.
    //next I did a for loop that goes through each element of the randomNumbers array and checks if the current element is equal to the value parameter using ==.
    // If it is, it returns true. If the loop completes without finding the value, it returns false.
    private bool ContainValue(int value)
    {
        for(int i = 0; i < randomNumbers.Length; i++)
        {
            if (randomNumbers[i] == value)
            {
                return true;
            }
        }
                return false;
    }

    //8) Defined a method with the name Shoot and inside the method, I generate a random index of 0 and the length of the 
    // projectiles array using Random.Range. Then I use Instantiate the projectile at the current position of the object with no rotation (Quaternion.identity).
    void Shoot()
    {
        int index = Random.Range(0, projectiles.Length);
        Instantiate(projectiles[index], transform.position, Quaternion.identity);
    }
    
    //9) In Update i defined a condition that checks IF the space key is pressed down using Input.GetKeyDown(KeyCode.Space). 
    // If it is, I call the Shoot method to instantiate a random projectile.
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }
}
