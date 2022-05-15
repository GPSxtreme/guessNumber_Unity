using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class GameLogic : MonoBehaviour
{
    //random number
    
    public int randomNum ;
    //UI
    public InputField userInput;
    public TMP_Text hint;
    void Start()
    {
        hint.text = "Guess a number between 1 to 20!";
        randomNum = getRandomNumber(1 , 20);
    }
    void Update()
    {
        
    }
    public void onBtnClick ()
    {
        string userInputValue = userInput.text;
        if(userInputValue != "") 
        {
            int answer = int.Parse(userInput.text);
            if(answer == randomNum) 
        {
            hint.text = "Correct!";
        }
        else if (answer < randomNum)
        {
             hint.text = "Try higher!";
        }
        else if (answer > randomNum){
             hint.text = "Try lower!";
        }   
        else 
        {
           hint.text = "Please enter a number";
        }
        
        }
    }
    //random number generator 
    private int getRandomNumber(int min , int max)
    {
        int random = UnityEngine.Random.Range(min,max);
        return random ;
    }
}
