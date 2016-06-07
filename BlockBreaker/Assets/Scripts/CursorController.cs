using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CursorController : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		Scene scene = SceneManager.GetActiveScene();
		if (scene.name == "Start" | scene.name == "Lose" | scene.name == "Win")
			Cursor.visible = true;
		else
		{
			Cursor.visible = false;
		}
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
