using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 10F; //how strong the force is when we apply it to the ball
    private Rigidbody rb;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      rb = GetComponent<Rigidbody>();   //grab the rigidbody
    }



    // FixedUpdate is called at a fixed interval for physics updates
    void FixedUpdate()
    {
        float moveHorizontal = 0f; //initialize horizontal movement variable
        float moveVertical = 0f; // initialize vertical movement variable

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) moveHorizontal = -1f; //check if left arrow or A key is pressed, if so set horizontal movement to -1
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) moveHorizontal = 1f; //check if right arrow or D key is pressed, if so set horizontal movement to 1
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) moveVertical = 1f; //check if up arrow or W key is pressed, if so set vertical movement to 1
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)) moveVertical = -1f; //check if down arrow or S key is pressed, if so set vertical movement to -1

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical).normalized; //create a movement vector based on the horizontal and vertical input, and normalize it to ensure consistent speed in all directions
        rb.AddForce(movement * speed); //apply the movement force to the rigidbody, scaled by the speed variable
    }
}
