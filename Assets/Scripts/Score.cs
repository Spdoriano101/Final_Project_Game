using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Using statement for the Unity UI code
using UnityEngine.UI;

public class Score : MonoBehaviour {

    //Variable to track the visible text score
    // Public to let us drag and drop in the editor 
    public Text scoreText;

    //Variable to track the numerical score
    //Private because other scripts sould not change it directly
    //Default to 0 since we should not have any score when starting
    private int numericalScore = 0;

    // Use this for initialization
    void Start()
    {

        //Get the score from the prefs database
        //Use a defualt of 0 of no score was saved
        //Score the result in our numerical score varaiable
        numericalScore = PlayerPrefs.GetInt("score", 0);

        //update the visual score
        scoreText.text = numericalScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Function to incrase the score 
    //public so other scirpts can use it (such as the coin)

    public void Addscore(int _toAdd)
    {

        //Add amount to the numerical score
        numericalScore = numericalScore + _toAdd;

        //Update the visual score 
        scoreText.text = numericalScore.ToString();

    }


    //function to save the score to the player preference 
    //public so it can be triggered from another scrpit (aka door)
    public void SaveScore()
    {

        PlayerPrefs.SetInt("score", numericalScore);

    }

}
