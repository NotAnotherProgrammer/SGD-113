
using UnityEngine;
using UnityEngine.Rendering;

public class Movment : MonoBehaviour
{
    public float speed; // intialize in inspector

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMovment = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float verticalMovment = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        Vector3 movement = new Vector3(horizontalMovment, 0, verticalMovment);

        transform.position += movement;


        //use mouse button and keys inputs
        //GetButtonmDwon -- when user presses down a button
        //GetButtonUp -- when user releases button
        //Get Button -- when user hold button -- notice how many frames elapse with a quick button 

        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Shot fired button DOWN");
        }

        if (Input.GetButtonUp("Fire 1"))
        {
            Debug.Log("SHot FIierd button UP");
        }

        if(Input.GetButton("Fire1"))
        {
            Debug.Log("Shot fired button HELD");
        }

    }
}
