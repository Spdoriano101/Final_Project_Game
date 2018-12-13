using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class Character_Select : MonoBehaviour {

    public static int PlayerNum;


	public void CharacterSelect (int selectedNum) {

        PlayerNum = selectedNum;

        Application.LoadLevel("Level_1");
	}
}
