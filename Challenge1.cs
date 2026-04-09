using UnityEngine;

//////////////////////////////////////////////////////
// Assignment/Lab/Project: Chalenge Problem 1 
//Name: Alex Freeman
//Section: 2026SP.SGD.113.
//Instructor: George Cox
// Date: 04/06/2026
//////////////////////////////////////////////////////

public class Challenge1 : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed = 5.0f; //Made a public float and set the move speed to 5f.
    public float sprintSpeed = 10.0f; //Made a public floar and set the spring speed to 10f.
    public float currentSpeed;//set the currentSpeed to public.
    private Rigidbody rb; //reference the rigidbody component for physics movment

    [Header("Jmuping")]
    public float jumpForce = 5.0f; //set the public float of jumpForce to 5.0f.
    public bool isGrounded; //Also set isGrounded as a public bool. 


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>(); //Gives the ball movement
        currentSpeed = moveSpeed;
    }


    // Update is called once per frame
    void Update()
    {
        Move(); //Called the move method in update 
        Sprint(); //Called the Spritn method in update 
        Jump(); //Called the jump method in update 
    }

    void Move() //Created a move method 
    {
     float moveX = Input.GetAxis("Horizontal"); //move left to right
     float moveZ = Input.GetAxis("Vertical"); //move up and down 

        Vector3 movment = new Vector3(moveX, 0.0f, moveZ); //Creates movment based on input   
        transform.Translate(movment * currentSpeed * Time.deltaTime);
    }

    void Sprint() //created a spirnt method 
    {
        if(Input.GetKey(KeyCode.LeftShift)) //when shift is pressed player sprints 
        {
            currentSpeed = sprintSpeed;
        }
        else //if playes is not pressing down the shift key the players speed is normal. 
        {
            currentSpeed = moveSpeed;
        }

    }

    void Jump() //created a jump method
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded) //if the player presses the space key force will be applied to the ridgidbody making the 
            //player just upwards. AND if not the player isGrounded
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Force);
        }
    }

    private void OnCollisionEnter(Collision collision) //checking to make sure gameObject is touching the ground 
    {
        if(collision.gameObject.CompareTag("Ground")) //Made a tag called "ground" and set it on the plane. Letting the code know 
            //know to check if the gameObject is touding the groud. If fiund true the the player is grounded. 
        {
            isGrounded = true;
        }
    }
}
