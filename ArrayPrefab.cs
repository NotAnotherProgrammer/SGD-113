using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



//REMEBER TO ATTACH PREFABS!!!!! REFERENCED IN BOTH UNITY AND SCRIPT!!!!
public class ArrayPrefab : MonoBehaviour
{
    // The prefabs, materials, and UI elements have been created for you.

    // Declare an array of game objects called prefabs. This will be initialized in Inspector
    public GameObject[] prefabs;
    // Declare an array called counters that will hold whole numbers values for each prefab instantiated 
    private int[] counters;
    // Declare an array called countersText (the data type should be for a TMP text object). This will be initialized in Inspector
    public TMP_Text[] countersText;



    // Start is called before the first frame update
    void Start()
    {
        // initiate the counters array so that each index value is 0
        counters = new int[] { 0 , 0 , 0 };
    }


    //Use 0 for the cube, 1 for the sphere, and 2 for the cylinder 
    public void OnClickGenerateButton()
    {


        //get a random position - adjust these values to make sure the shapes would be seen in game view

        Vector3 randPos = new Vector3(Random.Range(-5, 10), Random.Range(1, 5), Random.Range(0, 10));

        int randPrefabIndex = Random.Range(0, 3);

        // Instantiate a random prefab from the array
        Instantiate(prefabs[randPrefabIndex], randPos, Quaternion.identity);


        // Declare a string named shape and assign an empty string.
        // This will hold a string value based on which index of the prefab array is selected.
        // Then check to see which index (by its location number) so you can assign either "Cubes" or "Spheres" or "Capsules" to your string variable.
        string shape = " ";

        if (randPrefabIndex == 0)
        {
            shape = "Cubes ";

        }

        else if (randPrefabIndex == 1)
        {
            shape = "spheres";
        }

        else if (randPrefabIndex == 2)
        {
            shape = "Capsules";
        }

        counters[randPrefabIndex]++;

        // Finally, assign the proper message (shape string + counters array index value) to the countersText array.
        // This should display the proper numeric value to the associated prefab text object in Unity.

        countersText[randPrefabIndex].text = shape + counters[randPrefabIndex];
    }


}
