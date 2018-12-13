using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

[CreateAssetMenu (menuName = "Character")]
public class Start_Button : ScriptableObject {


    public string characteName = "Default";
    public int startingHp = 100;

    

    
    
    
    
    
    
    
    
    
    
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
