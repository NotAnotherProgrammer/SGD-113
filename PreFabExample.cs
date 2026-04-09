using UnityEngine;

public class PreFabExample : MonoBehaviour
{
    public GameObject randCube;
    public GameObject randSphere;
    public GameObject randCylinder;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RandomObjectSpawn();
        
    }
    
    void RandomObjectSpawn()
    {
        
        int randNumb = Random.Range(1, 31);
    if (randNumb >= 1 && randNumb <= 10)
        {
            Vector3 pos = new Vector3(Random.Range(-3, 3), Random.Range(-3, 3), Random.Range(-3, 3));
            Instantiate(randCube, pos, Quaternion.identity);
            Debug.Log(randNumb + " was selected.");
        
        } 

        if (randNumb >= 11 && randNumb <= 20)
        {
            Vector3 pos = new Vector3(Random.Range(-3, 3), Random.Range(-3, 3), Random.Range(-3, 3));
            Instantiate(randCube, pos, Quaternion.identity);
            Debug.Log(randNumb + " was selected.");
        
        }   

        if (randNumb >= 21 && randNumb <= 30)
        {
            Vector3 pos = new Vector3(Random.Range(-3, 3), Random.Range(-3, 3), Random.Range(-3, 3));
            Instantiate(randCube, pos, Quaternion.identity);
            Debug.Log(randNumb + " was selected.");
        
        }     

    }

    void KeyObjectSpawn()
    {
        if(Input.GetKeyUp(KeyCode.P))
        {
            RandomObjectSpawn();
        }
    }

    void MouseClick()
    {
        if(Input.GetMouseButtonDown(0))
        {
            
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        KeyObjectSpawn();
    }
}
