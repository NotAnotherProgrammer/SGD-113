using UnityEngine;

public class PreFabexample3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("ObjectSpawn", 3.0f, 0.5f);
        
    }

    void ObjectSpawn()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
