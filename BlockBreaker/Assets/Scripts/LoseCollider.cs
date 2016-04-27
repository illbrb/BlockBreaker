using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

	private LevelManager levelManger;
	
	void Start ()
	{
		levelManger = GameObject.FindObjectOfType<LevelManager>();
	}
	
	void OnCollisionEnter2D (Collision2D collision)
	{
		levelManger.LoadLevel("Lose");
	}
	
}
