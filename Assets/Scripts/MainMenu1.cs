﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu1 : MonoBehaviour {

	void OnGUI()
	{
		if (GUI.Button (new Rect (580,255, 150, 30), "Play"))
			SceneManager.LoadScene ("CabStart", LoadSceneMode.Single);
		if (GUI.Button(new Rect (580,295, 150, 30), "Quit Game"))
			SceneManager.LoadScene ("QuitGame", LoadSceneMode.Single);
}
	/*void Update () {
		
	}
		void QuitGame () {
			Application.Quit ();
			Debug.Log("Game is exiting");
		}*/
} 
 