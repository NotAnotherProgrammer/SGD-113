using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class listdemo2 : MonoBehaviour
{
    List <int> ages = new List<int>();
    void FillAgesList(int numberOfAges)
    {
        for(int index = 0; index < ages.Count; ++index)
        {
            ages.Add(Random.Range(1, 61));
        }
    }

    void DisplayAges()
    {
        foreach(int element in ages)
        {
            Debug.Log(element);
        }
    }

    List<int> randomNumbers = new List<int>();
    void DisplayRandomNumbers()
    {
        foreach ( int element in randomNumbers)
        {
            Debug.Log(element);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        FillAgesList(5);

        DisplayAges();

        randomNumbers.Add(Random.Range(1, 101));
        randomNumbers.Add(Random.Range(1, 101));
        randomNumbers.Add(Random.Range(1, 101));
        randomNumbers.Add(Random.Range(1, 101));

        DisplayRandomNumbers();
        Debug.Log("the randomNumber array has a count of " + randomNumbers.Count);

        randomNumbers.Add(200);
        randomNumbers.Add(300);
        randomNumbers.Insert(0, 1000);

        DisplayRandomNumbers();
        Debug.Log("the randomNumber array has a count of " + randomNumbers.Count);

        randomNumbers.Remove(300);
        randomNumbers.RemoveAt(randomNumbers.Count - 1);
        DisplayRandomNumbers();
        Debug.Log("the randomNumber array has a count of " + randomNumbers.Count);

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
