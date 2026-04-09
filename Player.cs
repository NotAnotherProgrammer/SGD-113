using UnityEngine;
//////////////////////////////////////////////
//Project: While Loops Assignments
//Name: Alex Freeman
//Section: SGD.113.2121
//Instructor: Mr. Cox
//Date: 2/16/2026
/////////////////////////////////////////////
public class Player : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    public GameObject pickup;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        FixedUpdate();
        GeneratePickup();
        

    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        rb.AddForce(new Vector3(moveHorizontal, 0, moveVertical) * speed);
    }
     void GeneratePickup()
    {
        int Pickups = 0;

        while (Pickups < 10)
        {

            Vector3 position = new Vector3(Random.Range(-4.0f, 4.0f), 0.75f, Random.Range(-4.0f, 4.0f));
            Instantiate(pickup, position, Quaternion.identity);
            Pickups--;
        }

    }

    void HandleClick()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hitInfo;

        if(Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hitInfo, 100.0f))
            {
                if(hitInfo.collider.tag == "PaintPuddle")
                {
                    Renderer rend = hitInfo.collider.GetComponent<Renderer>();
                    rend.material.color = 
                
                }
            
                
            }
        }
        
          
    }

    // Update is called once per frame
    void Update()
    {
        HandleClick();
    }
}
