using UnityEngine;

public class ForLoopsPractice : MonoBehaviour
{
    public GameObject item;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        //// Logs 0-4 with for loop
        //for (int i = 0; i < 5; i++)
        //{
        //    Debug.Log(i);
        //}
        //// Logs 4-1 with for loop
        //for (int i = 4; i > 0; i--)
        //{
        //    Debug.Log(i);
        //}

        // AddNumbers calls with 10, 100, and 1000 for testing.  Should return 55, 5050, and 500500.
        //AddNumbers(10);
        //AddNumbers(100);
        //AddNumbers(1000);

        // Builds a random number of prefabs from 1-10.  Remember to give them Pickup tag!
        //buildPrefabs(Random.Range(1, 11));
    }

    // Adds all numbers from 1 through loopCount parameter.
    //void AddNumbers(int loopCount)
    //{
    //    int sum = 0;
    //    for (int i = 1; i <= loopCount; i++)
    //    {
    //        sum += i;
    //    }
    //    Debug.Log("The sum of 1 through " + loopCount + " inclusive is " + sum + "!");
    //}

    //Instantiates prefabs.
   void buildPrefabs(int count)
    {
        for (int i = 1; i <= count; i++)
        {
            Vector3 pos = new Vector3(Random.Range(-4, 4), Random.Range(-4, 4), Random.Range(-4, 4));

            Instantiate(item, pos, Quaternion.identity);
        }
    }

    // Shoots a prefab dead, cowpoke.  We've done this a few times.
    private void Collect()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo))
        {
            if (hitInfo.collider.gameObject.tag == "Pickup")
            {
                Destroy(hitInfo.collider.gameObject);
            }
        }
    }

    // Logs What Button Is Pressed
    public void OnClickNewGame()
    {
        Debug.Log("New Game selected!");
    }

    public void OnClickQuitGame()
    {
        Debug.Log("Quit selected!");
        Application.Quit(0);
    }
    // Update is called once per frame
    void Update()
    {
        // Shoots a prefab if you left-click on it.
        if (Input.GetMouseButtonDown(0))
        {
            Collect();
        }
        // Builds 1-5 prefabs on spacebar press.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            buildPrefabs(Random.Range(1,6));
        }
    }
}
