using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int maxNumber = 1000;
    int minNumber = 1;
    int computerGuess = 500;
    int tryCounter = 1;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();   
    }

    void StartGame()
    {
        Debug.Log("Welcome to Number Wizard!");
        Debug.Log("Pick a number, but don't tell me what it is...");
        Debug.Log($"The lowest number you can pick is {minNumber}.");
        Debug.Log($"The highest number you can pick is {maxNumber}.");
        Debug.Log($"Tell me if your number is higher or lower than {computerGuess}");
        Debug.Log("Press the up arrow for higher and the down arrow for lower, or Enter for correct");
        maxNumber++;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            minNumber = computerGuess;
            NextGuess();
        }
            
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            
            maxNumber = computerGuess;
            NextGuess();
        }
        
        else if (Input.GetKeyDown(KeyCode.Return)) 
        {
            Win();
            ResetGame();
            StartGame();
        }
    }

    void NextGuess()
    {
        computerGuess = (maxNumber + minNumber) / 2;
        Debug.Log($"Okay... Is your number higher or lower than {computerGuess}?");
        tryCounter++;
    }

    void Recap()
    {
        Debug.Log($"Your number was: {computerGuess}");
        Debug.Log($"It took me {tryCounter} tries to get your number correct!");
    }

    void Win()
    {
        if (tryCounter == 1)
        {
            Debug.Log("(On my first try?!)");
            Recap();
            Debug.Log("Behold: my psychic abilities!");
        }

        else if (tryCounter > 4)
        {
            Debug.Log("(Whew, I finally got it!)");
            Recap();
            Debug.Log("(I'm not very good at this am I...)");
        }

        else
        {
            Debug.Log("(Wow! I got it!)");
            Recap();
        }
    }
    void ResetGame()
    {
        maxNumber = 1000;
        minNumber = 1;
        computerGuess = 500;
        tryCounter = 1;
    }
}