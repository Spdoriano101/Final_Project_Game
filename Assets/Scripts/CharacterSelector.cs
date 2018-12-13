using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelector : MonoBehaviour
{

    public GameObject player;
    public Vector3 playerSpawnPosition = new Vector3(-9, -1, 0);

    public Character[] characters;

    public GameObject characterSelectPanel;
    

    //Function that will be called when the button is pressed
    //will set the variable "StartGame" to an integer
    public void StartGame(int characterChoice)
    {
        characterSelectPanel.SetActive(false);

        //declares game object called spawn player which is equal to the playe, the players spawn coordinates and the rotation of the prefab 
        //also casts to a game object
        //GameObject spawnedPlayer = Instantiate(player, playerSpawnPosition, Quaternion.identity) as GameObject;
        //Character selectedCharacter = characters [characterChoice];

        SceneManager.LoadScene("Level_1");
    }


    




	
}
