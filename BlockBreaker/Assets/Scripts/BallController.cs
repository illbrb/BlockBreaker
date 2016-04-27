using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {
	
	private PaddleControl paddle;
	private Vector3 paddleToBallVector;
	private bool hasGameStarted = false;
	
	public float velX;
	public float velY;
	
	// Use this for initialization
	void Start () {
		paddle = GameObject.FindObjectOfType<PaddleControl>();
		paddleToBallVector = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (!hasGameStarted)
		{
			//Lock ball to paddle until mouse input
			this.transform.position = paddle.transform.position + paddleToBallVector;
			
			//Sets gamestarted to true, and fires ball
			if (Input.GetMouseButtonDown(0))
			{
			hasGameStarted = true;
			var ballfire = GetComponent<Rigidbody2D>();
			ballfire.velocity = new Vector2(velX, velY);
			}
		}	
	}
}