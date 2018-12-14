using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Extra using statement to allow the use scene management functions
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {
   
    // designer variables
    public float speed = 7;
    public float jumpSpeed = 10;
    public Rigidbody2D physicsBody;
    public string horizontalAxis = "Horizontal";
    public string jumpButton = "Jump";

    
    public Animator playerAnimator;
    public SpriteRenderer playerSprite;
    public Collider2D playerCollider;

    public Lives livesObject;

    // Use this for initialization
    void Start()
    {

    }

    
    void Update()
    {

        // Get axis input from Unity
        float leftRight = Input.GetAxis(horizontalAxis);


        // Create direction vector from axis input
        Vector2 direction = new Vector2(leftRight, 0);

        // Make direction vector length 1
        direction = direction.normalized;

        // Calculate velocity
        Vector2 velocity = direction * speed;

        // preserve vertical velocity from physics
        velocity.y = physicsBody.velocity.y;

        // Give the velocity to the rigidbody
        physicsBody.velocity = velocity;



        //Flip the sprite when moving backwards/opposite way
        if (velocity.x < 0)
        {
            playerSprite.flipX = true;
        }
        else
        {
            playerSprite.flipX = false;
        }


        //Animation for the animator script
        playerAnimator.SetFloat("Walk", Mathf.Abs(leftRight));

        // Jumping

        //Detect sprite touching the ground
        //Get the LayerMask from Unity using the name of the layer
        LayerMask groundLayerMask = LayerMask.GetMask("Ground");

        //Ask the player's collider if it is touching the LayerMask
        bool touchingGround = playerCollider.IsTouchingLayers(groundLayerMask);

        //Detects input of jump button
        bool jumpButtonPressed = Input.GetButtonDown(jumpButton);

        if (jumpButtonPressed == true && touchingGround == true)
        {
            //pressed Jump so should set upward velocity to jumpSpeed
            velocity.y = jumpSpeed;

            //Give the velocity to the rigidbody
            physicsBody.velocity = velocity;
        }

        }


    public void Kill()
    {
        //Take away a life and save that change
        livesObject.LoseLife();
        livesObject.saveLives();

        //Check if its game over

        bool gameOver = livesObject.IsGameOver();

        if (gameOver == true)
        {
            //If it IS game over...
            //Load the game over scene

            SceneManager.LoadScene("Game_Over");

        }

        else
        {
            //try and fix this you need to try and get the game to take away a life but not reset 
#//but still check to see if the gme is over and the get the game to reset


        }


        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check the thing we bump into is an enemy
        if (collision.collider.GetComponent<EnemyScript>())
        {
            // die
            Destroy(gameObject);
        }

    }



}



