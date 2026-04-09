
using UnityEngine;

public class PreFabExampleOneHalf : MonoBehaviour
{
        public GameObject randCube;
        public GameObject randSphere;
        public GameObject randCylinder;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RandomObjectSpawn();

        
    }
    //mether that will randomly spwan (instantiate) a prefab object
    void RandomObjectSpawn()
    {
        // int randomNumb = Random.Range(1,31);

       // if(randomNumb >= 1 && randomNumb <= 10)
        {
        // Vector3 pos = new Vector3(Random.Range(-3, 3), Random.Range(-3, 3), Random.Range(-3, 3));
         //Instantiate(randCube, new Vector3 (0, 0, 0), Quaternion.identity);
        // Instantiate(randCube, pos, Quaternion.identity); 
        }
        // if(randomNumb >= 11 && randomNumb <= 20)
        {
         //Vector3 pos = new Vector3(Random.Range(-3, 3), Random.Range(-3, 3), Random.Range(-3, 3));
         //Instantiate(randSphere, pos, Quaternion.identity); 
        }
         //if(randomNumb >= 21 && randomNumb <= 30)
        {
         //Vector3 pos = new Vector3(Random.Range(-3, 3), Random.Range(-3, 3), Random.Range(-3, 3));
        // Instantiate(randCylinder, pos, Quaternion.identity); 
        }


        int randNumb = Random.Range(1,4);
        Vector3 pos = new Vector3(Random.Range(-3, 3), Random.Range(-3, 3), Random.Range(-3, 3));

            switch(randNumb)
        {
            case 1:
             Instantiate(randSphere, pos, Quaternion.identity);
            break;

             case 2:
            
            Instantiate(randSphere, pos, Quaternion.identity);
            break;

             case 3:
           
            Instantiate(randSphere, pos, Quaternion.identity);
            break;
        }

    }

    void MouseClick()
    {
        if (input.GetMouseButtonDown(0))
        {
            //creates a ray object that starts from the camera in the scene and moves in the direction of where the mouse was on the screen
Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//declares a RaycastHit object that will store the information about the object our raycasting will hit
RaycastHit hitInfo;
//this is where we do the raycasting. It returns if it hits a collider and false otherwise. So, we can use an if statement
//to check if the player clicked on anything with a collider. 100 is an arbitrary distance for how far it will check along th e ray
//If we hit something it is stored in the variable hitInfo. This code belongs in the Update
if(Input.GetMouseButtonDown(0)) //if the left button of the mouse was clicked
{
if (Physics.Raycast(ray, out hitInfo, 100.0f))
{
if (hitInfo.collider.tag == "myTag") //check if the clicked object has the tag we are looking for
{
//destroy the game object the player clicked on because it has the tag we are looking for
Destroy(hitInfo.transform.gameObject);
}
}
}
        }
    }
     void KeyObjectSpawn()
    {
        if(Input.GetKeyUp(KeyCode.P))
        {
            RandomObjectSpawn();
        }
    }




    // Update is called once per frame
    void Update()
    {
        KeyObjectSpawn();
    }
}
