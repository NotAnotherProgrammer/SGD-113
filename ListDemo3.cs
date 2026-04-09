using UnityEngine;
using TMPro;
using System.Collections.Generic;

using System.Net.NetworkInformation;
public class ListDemo3 : MonoBehaviour
{
        List<string> gamerNames = new List<string>()
        { "dude", "guy", "buddy", "mah dude", "buddy-guy"};
    
    public TMP_Text outputText;
    public TMP_InputField nameInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    public void OnCLickGetGamerNameButton()
    {
        //get random index
        int randomIndex = Random.Range(0, gamerNames.Count);

        //display the gamerNames element at the indext in the output
        outputText.text = gamerNames[randomIndex];
    }

    public void OnClickSaveButton()
    {
             //get random index

         string name = nameInput.text;

        //add to list of names if somthing has been entered

        if(name != "")
        {
            gamerNames.Add(name);

            
        }
            else
        {
            outputText.text = "Invalid";
        }
    }
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
