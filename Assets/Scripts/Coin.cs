using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {


    //Variable to let us add to the score
    // Public so we can drag and drop
    public Score scoreObject;

    //Variable to ghold the coin's point value 
    //Public so we can change it in the editor 
    public int coinValue;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //Unity calls this funstion when our coin touches any other object 
    // If the player touched us, the coin should vanish and the score should increase
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Check if the thing we touched was the player 
        Elane playerScript = collision.collider.GetComponent<Elane>();

        //If the thing we touched HA a player script, hat means
        //it IS a player, so....
        if (playerScript)
        {

            //We hit the player


            //Add to the score based on our value
            scoreObject.Addscore(coinValue);

            // Destroy the gameObject that this script is attracted to
            // (the coin) 

            Destroy(gameObject);
        }
    }
}
