using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour 
{
	public void CursorHide()
	{
		Cursor.visible = false;
	}
	
	public void LoadLevel(string levelName)
	{
		SceneManager.LoadScene(levelName);	
		CursorHide();
	}
	public void QuitGame(){
		Application.Quit();		
	}	
	
	public void LoadNextLevel()
	{
		Application.LoadLevel(Application.loadedLevel + 1);
		CursorHide();
	}
}

