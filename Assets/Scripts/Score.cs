﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    //Sets the variable "ScoreValue" to and integar and sets bease score to 0
    public static int scoreValue = 0;
        Text score; 

	// Use this for initialization
	void Start () {

        //tells the program that we will be using the variable "Score" to
        //Give the value to the "Text"
        score = GetComponent<Text>();


	}
	
	// Update is called once per frame
	void Update () {

        score.text = scoreValue.ToString(); 


	}
}
