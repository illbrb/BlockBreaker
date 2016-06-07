using UnityEngine;
using System.Collections;

public class BrickController : MonoBehaviour {
	
    public Sprite[] hitSprites;

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
		bool isBreakable = (tag == "Breakable");
		if (isBreakable)
		{
			HandleHits();
		}
		
	}
	
	void HandleHits ()
	{
		timesHit ++;
		int maxHits = hitSprites.Length + 1;
		if (timesHit >= maxHits)
		{
			Destroy(gameObject);
		}
		else 
		{
			LoadSprites();
		}	
	}
	
	void LoadSprites()
	{
		int spriteIndex = timesHit -1;
		GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
	}

	//TODO Remove once can actually win
	void SimulateWin()
	{
		levelManager.LoadNextLevel();
	}
}
