using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour {


    public Transform followTarget;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (followTarget != null)
        {
            Vector3 newPosition = followTarget.position;
            newPosition.z = transform.position.z;
            transform.position = newPosition;

        }
    }
}



