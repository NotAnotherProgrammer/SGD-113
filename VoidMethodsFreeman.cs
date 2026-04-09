
using UnityEngine;
//////////////////////////////////////////////////////

// Assignment/Lab/Project: VoidMethods

//Name: Alex Freeman

//Section: SP2026.113.2121

//Instructor: Proffesor Cox 

// Date: 02/05/2026

//////////////////////////////////////////////////////
public class VoidMethodsFreeman : MonoBehaviour
{
    public GameObject minePrefab;
    void Start()
    {
        DisplayFavrioteQuote();
        DisplayLotteryNumbers(true);
        DisplayInternationalGreeting(Random.Range(1, 5));
        DisplayInternationalGreeting(6);
        DisplayTotalAmount(2, 1, 1, 3);
        GenerateMine();
        InvokeRepeating("GenerateMine", 3.0f, 2.0f);

    }
    //Question 1 
    //I defined a method then called DisplayFavrioteQuote that prints a message to the console. Went to the start and called it. 
    void DisplayFavrioteQuote()
    {
        Debug.Log("May the force be with you said by the great Yoda");
    }
    //Question 2
    //I started by defining my method and giving it a name. Then added the appropriate parameter starting with bool as my data type and loto as the name.
    //Went into a IF ELSE statement making loto the if statment so if, loto meing true because i called true in the method at start. If will be displayed which is the NC num
    void DisplayLotteryNumbers(bool loto)
    {
       if (loto)
        {
            Debug.Log(Random.Range(1, 71) + "-" + Random.Range(1, 71) + "-" + Random.Range(1, 71) + "-" + Random.Range(1, 71) + "-" + Random.Range(1, 71) + "-" + Random.Range(1, 26) + "*");
        }
       else
        {
            Debug.Log(Random.Range(1, 50) + "-" + Random.Range(1, 50) + "-" + Random.Range(1, 50) + "-" + Random.Range(1, 50) + "-" + Random.Range(1, 50) + "-" + Random.Range(1, 11) + "*");
        }
    }
    //Question 3
    void DisplayInternationalGreeting(int greeting)
    {
        switch (greeting)
        {
            case 1:
                Debug.Log("hello");
                break;

            case 2:
                Debug.Log("Hola");
                break;

            case 3:
                Debug.Log("Bonjor");
                break;

            case 4:
                Debug.Log("Salam");
                break;

            case 5:
                Debug.Log("Ni Hao");
                break;

            default:
                Debug.Log("invaild");
                break;
         }
    }
    //question 4
    void DisplayTotalAmount(int quater, int dime, int nickle, int penny)
    {
        float sum = quater * .25f + dime * 0.10f + nickle * 0.05f + penny * 0.01f;
        Debug.Log("the number of coins you have is " + quater + " quater " + dime + " dime " + nickle + " nickel " + penny + " penny " + "equals " + sum);
    }
    //Question 6
    void GenerateMine()
    {
        Vector3 pos = new Vector3(Random.Range(-3, 3), Random.Range(-3, 3), Random.Range(-3, 3));
        Instantiate(minePrefab, pos, Quaternion.identity); 
    }
    //Question 7
    void ShootRay(Vector3 aim)
    {
        Ray ray = Camera.main.ScreenPointToRay(aim);

        RaycastHit hitInfo;

        if(Input.GetMouseButtonDown(0))
        {

            if (Physics.Raycast(ray, out hitInfo, 100.0f))
            {
                if(hitInfo.collider.tag == "Mine")
                {
                    Destroy(hitInfo.transform.gameObject);
                }
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        ShootRay(Input.mousePosition);
    }
}
