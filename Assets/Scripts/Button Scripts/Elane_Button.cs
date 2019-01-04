using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class GloablVariables
{

    public static bool characterChoice;

}

public class Elane_Button : MonoBehaviour {
   

    void Start()
    {
        if (GloablVariables.characterChoice == true)
        {

            Destroy(gameObject);

        }

    }

 
}

