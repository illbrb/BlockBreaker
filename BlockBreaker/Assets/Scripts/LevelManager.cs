﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour 
{
	public void LoadLevel(string levelName)
	{
		SceneManager.LoadScene(levelName);	
	}
	public void QuitGame(){
		Application.Quit();		
	}	
	
	public void LoadNextLevel()
	{
		Application.LoadLevel(Application.loadedLevel + 1);
	}
}

