using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
/*
 Number Wizard is a simple game where a player will need to mentally select a number that is between the displayed range. 
 Afterwards, the wizard will attempt to guess the number using binary search and hints from the player if their guess is higher or lower than their number.
 */
public class NumberWizard : MonoBehaviour
{
    // max, min, and guess are variables to be used in NumberWizard. 
    // max will be used to indicate the highest end of our range. 
    [SerializeField] int max;
    // min will indicate the lowest end of our range. 
    [SerializeField] int min;
    // guess will be our current guessing number, which will always be min + max /2
    int guess;
    // guessText will be a variable that corresponds the element in our UI that contains our test for Guess.
    [SerializeField] TextMeshProUGUI guessText;
    // guessCount is a variable that will hold the number of guess that it took our wizard to arrive at the correct number.
    public static int guessCount = 1;

    // Start is called before the first frame update
    void Start()
    {
        //The StartGame() function contains the text required to start a game of NumberWizard.
        StartGame();
    }

    //This function is used to indicate the start of a game of NumberWizard.
    //This function will also set max to max +1, as well as setting the guess to the starting value of min + max/2
    public void StartGame() {
        NextGuess();
        DisplayVariables();
       
        guessText.text = guess.ToString();

    }

    //This function removes the slighy redunant code of caculating our next guess and displaying our guess to the player.
    void NextGuess() {

        guess = Random.Range(min, (max + 1));
        Debug.Log("Our current guess is: " + guess + ".\n");
        DisplayVariables();
        guessCount++;
        guessText.text = guess.ToString();
    }

    // If the Higher Button is pressed on the UI, then this input from the player will indicate that the guess they were displayed, is a number lower than their number.
    // Our previous guess will become the new min, and our new guess will be calculated.
    public void OnPressHigher () {
        Debug.Log("Higher Button was pressed.\n");
        min = guess + 1;
        NextGuess();
    }

    // Otherwise, if the Lower Button is pressed on the UI, then this input from the player will indicate that the guess they were displayed, is a number higher than their number.
    // Our previous guess will become the new max, and our new guess will be calculated.
    public void OnPressLower (){
        Debug.Log("Lower Button was pressed.\n");
        max = guess - 1;
        NextGuess();
    }

    // This function contains text I have abstracted out of that will only display the current variables to the console.
    private void DisplayVariables() {
        Debug.Log("Our current min is: " + min + ".\n");
        Debug.Log("Our current max is: " + max + ".\n");
        Debug.Log("Our current guess is: " + guess + ".\n");
    }

    public static int GetGuessCounter() { return guessCount; }

}
