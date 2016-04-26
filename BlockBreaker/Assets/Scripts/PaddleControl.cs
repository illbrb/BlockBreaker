using UnityEngine;
using System.Collections;

public class PaddleControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
		Vector3 paddlePosition = new Vector3 (8f, transform.position.y, 0f);
		paddlePosition.x = Mathf.Clamp(mousePosInBlocks, 0.5f, 15.5f);
		transform.position = paddlePosition;
		print (mousePosInBlocks);
	}
}
