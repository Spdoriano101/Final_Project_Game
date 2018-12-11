using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class Start_Button : MonoBehaviour {
    //This will be called by the button component
    // When the button is clicked
    public void StartGame()
    {
        //Reset the score
        PlayerPrefs.DeleteKey("score");

        PlayerPrefs.DeleteKey("lives");

        SceneManager.LoadScene("Level_1");
    }

}
