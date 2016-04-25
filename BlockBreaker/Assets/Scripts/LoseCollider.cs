using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

	public LevelManager levelManger;
	
	
	void OnTriggerEnter2D (Collider2D collider)
	{
		print ("Trigger");
	}
	
	void OnCollisionEnter2D (Collision2D collision)
	{
		print ("Collision");
		levelManger.LoadLevel("Win");
	}
	
}
