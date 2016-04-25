﻿using UnityEngine;
using System.Collections;

public class MusicController : MonoBehaviour 
{

static MusicController instance = null;
	
	void Awake ()
	{
		if (instance != null)
		{
			Destroy(gameObject);
		}
		else
		{
			instance = this;
			GameObject.DontDestroyOnLoad(gameObject);
		}		
	}
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
