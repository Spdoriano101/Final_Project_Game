﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour {


    public Transform followTarget;
    public float cameraDistance = 30.0f;
    public GameObject Player;

    void Start()
    {
        //Find the player and set player to the found player GameObject
        Player = GameObject.Find("Player");

        //store player.transform in follow target 
        followTarget = Player.transform;

        GetComponent<UnityEngine.Camera>().orthographicSize = ((Screen.height / 2) / cameraDistance);
    }
    // Update is called once per frame
    void FixedUpdate()

    {

        transform.position = new Vector3(followTarget.position.x, followTarget.position.y, transform.position.z);

        }
    }




