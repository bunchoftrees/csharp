using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int maxNumber = 1000;
        int minNumber = 1;
        Debug.Log("Welcome to Number Wizard!");
        Debug.Log("Pick a number, but don't tell me what it is...");
        Debug.Log($"The lowest number you can pick is {minNumber}.");
        Debug.Log($"The highest number you can pick is {maxNumber}.");
        Debug.Log($"Tell me if your number is higher or lower than my guess...");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
