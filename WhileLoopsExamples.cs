using UnityEngine;

public class WhileLoops : MonoBehaviour
{
    public GameObject pickup;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //for(int i = 0; i < 5; i++)
        //{
        //    Debug.Log(i);
        //}

        //for (int i = 4; i > 0; i--)
        //{
        //    Debug.Log(i);
        //}

        //AddNumber()
        //AddNumbers(Random.Range(10,21)); //you want 10 to 20 make sure you say 21
       
    }

    //ADD all nummber 1-10 with a for loop
    //void AddNumbers()
    //void AddNumbers(int loopCount)
    //{
    //    int sum = 0;
    //    for (int i = 1; i <= loopCount; i++) //changes the number to loopcount 
    //    {
    //        sum += i; //instantiare() if you want enemys to spawn
    //    }
    //    Debug.Log("the number of loops if" + loopCount);
    //    Debug.Log(sum);
    //}

    //button event for the rules
   public void OnClickRulesButton()
    {
        Debug.Log("the Rules button works");
    }

    //button event for play 

    public void OnClickPlayButton()
    {
        Debug.Log("the play button wokrs");
    }

    //button event for quit
    public void OnClickQuitButton()
    {
        Debug.Log("the quit button wokrs");
        Application.Quit(); //Closes the application 
    }

    void GeneratePickup(int loopcount)
    {
        int sum = 0;
        for (int i = 1; i <= loopcount; i++)
        {
            Vector3 pos = new Vector3(Random.Range(-5, 6), Random.Range(-5,6), Random.Range(-5, 6));

            Instantiate(pickup, pos, Quaternion.identity);
        }
        Debug.Log("the nuber of loops is " + loopcount);
    }

    private void Collect ()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo))
        {
            if(hitInfo.collider.gameObject.tag == "pickup")
            {
                Destroy(hitInfo.collider.gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Collect();
        }
        if(Input.GetKeyDown(KeyCode.P))
        {
            GeneratePickup(Random.Range(10, 21));
        }
    }
}
