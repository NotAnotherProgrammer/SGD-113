using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Lists : MonoBehaviour
{
    // STEP 1: Declare a List of integers to store even numbers
    // Lists in C# are dynamic arrays that can grow or shrink in size
    // Here, we initialize an empty list of integers
    List<int> evenNumbers = new List<int>();

    // STEP 8: Declare a List of strings to store names entered by the user
    // This list will hold the names submitted through the UI input field
    List<string> names = new List<string>();

    // UI references: These are public variables that need to be assigned in the Unity Inspector
    // inputField: The TMP_InputField where users type their names
    // outputText: The TMP_Text component that displays the list of names
    public TMP_InputField inputField;
    public TMP_Text outputText;

    void Start()
    {
        // STEP 2: Populate the list with 20 random numbers between 0 and 99
        // We use a for loop to generate and add random integers to the evenNumbers list
        for (int i = 0; i < 20; i++)
        {
            int randomNum = Random.Range(0, 100); // Random.Range generates a random int from min (inclusive) to max (exclusive)
            evenNumbers.Add(randomNum); // Add the random number to the list
        }

        // STEP 3: Modify the list to ensure all numbers are even
        // Call the ChangeToEven method to convert any odd numbers to even by adding 1
        ChangeToEven(evenNumbers);

        // STEP 4: Display the current contents of the evenNumbers list
        // This will print the list to the Unity console for debugging purposes
        DisplayList(evenNumbers);

        // STEP 5: Remove the last two elements from the list
        // RemoveAt(index) removes the element at the specified index
        // We remove the last element twice to remove the final two items
        evenNumbers.RemoveAt(evenNumbers.Count - 1); // Remove the last element
        evenNumbers.RemoveAt(evenNumbers.Count - 1); // Remove the new last element

        // Log the current count of elements in the list after removals
        Debug.Log("List count: " + evenNumbers.Count);

        // STEP 6: Insert the number 50 at the beginning of the list
        // Insert(index, value) adds an element at the specified position, shifting others
        evenNumbers.Insert(0, 50); // Insert 50 at index 0 (the start of the list)

        // Display the updated list again
        DisplayList(evenNumbers);
    }

    // STEP 3 METHOD: ChangeToEven
    // This method takes a List<int> as a parameter and modifies it in place
    // It iterates through each element and ensures it's even by incrementing odd numbers
    void ChangeToEven(List<int> list)
    {
        // Loop through each index in the list
        for (int i = 0; i < list.Count; i++)
        {
            // Check if the current number is odd (not divisible by 2)
            if (list[i] % 2 != 0) // if odd
            {
                list[i] += 1; // make it even by adding 1
            }
            // If it's already even, do nothing
        }
    }

    // STEP 4 METHOD: DisplayList
    // This method takes a List<int> and prints all its elements to the console
    // Useful for debugging and seeing the current state of the list
    void DisplayList(List<int> list)
    {
        // Initialize an empty string to build the output
        string output = "";

        // Loop through each element and append it to the output string with a space
        for (int i = 0; i < list.Count; i++)
        {
            output += list[i] + " ";
        }

        // Print the concatenated string to the Unity console
        Debug.Log(output);
    }

    // STEP 9: BUTTON METHOD - OnClickSubmitButton
    // This method is called when the submit button is clicked in the UI
    // It reads the input from the inputField, adds it to the names list if not empty,
    // updates the display, and clears the input field
    public void OnClickSubmitButton()
    {
        // Get the text entered in the input field
        string inputName = inputField.text;

        // Check if the input is not empty (to avoid adding blank names)
        if (inputName != "")
        {
            // Add the name to the names list
            names.Add(inputName);
            // Update the UI display with the new list
            UpdateNameDisplay();
            // Clear the input field for the next entry
            inputField.text = "";
        }
    }

    // UpdateNameDisplay: Helper method to refresh the displayed list of names
    // This method formats the names list into a numbered list and sets it to the outputText
    void UpdateNameDisplay()
    {
        // Reset the output text to empty before rebuilding
        outputText.text = "";

        // Loop through the names list and append each name with a number and newline
        for (int i = 0; i < names.Count; i++)
        {
            // Format: "1. Name\n2. Name\n" etc.
            outputText.text += (i + 1) + ". " + names[i] + "\n";
        }
    }
}