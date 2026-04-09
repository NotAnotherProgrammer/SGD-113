using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    public GameObject PickupPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        GeneratePickup();
        GenerateAllPickups();
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        rb.AddForce(new Vector3(moveHorizontal, 0, moveVertical) * speed);
    }

    void GeneratePickup()
    {
        Vector3 pos = new Vector3(Random.Range(-3, 3), Random.Range(-3, 3), Random.Range(-3, 3));
        Instantiate(PickupPrefab, pos, Quaternion.identity);

    }

    void GenerateAllPickups()
    {

    }


        // Update is called once per frame
        void Update()
    {
        
    }
}
