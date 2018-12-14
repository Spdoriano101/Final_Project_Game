using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Spawner : MonoBehaviour {

    //Creates a list of game objects that can be accessed
    public GameObject[] Characters;

    //creates a variable for the variable
    public Transform PlayerSpawnPoint;

    
    void Awake () {

        //pulls the object from thenumber on the list and spawns it at the place and rotation that is set in the other variables.
        GameObject newObject = Instantiate(Characters[Character_Select.PlayerNum], PlayerSpawnPoint.position, PlayerSpawnPoint.rotation);
        newObject.name = "Player";
    }
	
}
