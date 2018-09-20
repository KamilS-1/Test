using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{

    int max;
    int min;
    int guess;

    // Use this for initialization
    void Start ()
    {
        StartGame();
    }
	
    void StartGame ()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Welcome to number wizard");
        Debug.Log("Pick a number in your head and I will try to guess what it is");
        Debug.Log("Highest possible number is: " + max);
        Debug.Log("Lower possible number is: " + min);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Push Up = Higher, push Down = Lower, Push Enter = Correct");
        max = max + 1;
    }


	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("GOT IT, Game Over");
            StartGame();
        }
    }
    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is this your number? " + guess);
        Debug.Log("If not, is it Higher or Lower?");
    }
}
