using UnityEngine;
using System.Collections;

public class BrickController : MonoBehaviour {
	
	public int maxHits;
	private int timesHit;
	private LevelManager levelManager;

	// Use this for initialization
	void Start () {
		timesHit = 0;
		levelManager = GameObject.FindObjectOfType<LevelManager>();
	}
		
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionExit2D (Collision2D collision)
	{
		timesHit ++;
		if (timesHit >= maxHits)
		{
			Destroy(gameObject);
		}	
	}

	//TODO Remove once can actually win
	void SimulateWin()
	{
		levelManager.LoadNextLevel();
	}
}
