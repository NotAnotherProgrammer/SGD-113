using UnityEngine;
using System.Collections.Generic;
using TMPro;
using System;


public class NameListUI : MonoBehaviour
{
    public TMP_InputField nameInputField;
    public TMP_Text namesDisplayText;

    private List<string> savedNames = new List<string>();

    public void EnterName()
    {
        String name = nameInputField.text.Trim();
        if (string.IsNullOrEmpty(name))
        {
            return;// Do not add empty names
        }
        savedNames.Add(name);
        
        UpdateNameDisplay();
        
        nameInputField.text = "";

        nameInputField.ActivateInputField();

    }

    public void ResetNames()
    {
        savedNames.Clear();
        
        namesDisplayText.text = "";

        nameInputField.text = "";
    }

    void UpdateNameDisplay()
    {
        namesDisplayText.text = "";

        for (int i = 0; i < savedNames.Count; i++)
        {
            namesDisplayText.text +=  (i + 1) + ". " + savedNames[i] + "\n";
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
