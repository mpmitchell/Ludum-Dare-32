﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private bool moveRight = false;
	private bool moveLeft = false;

	private bool moveDisabled = true;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown(KeyCode.D) && moveDisabled==false)
		{
			moveRight = true;

		}
		if (Input.GetKeyUp (KeyCode.D))
		{
				moveRight = false;
		}
		
		if (Input.GetKeyDown (KeyCode.A) && moveDisabled==false) 
		{
			moveLeft = true;

		}

		if(Input.GetKeyUp (KeyCode.A))
		{
			moveLeft = false;
		}

		if(moveRight ==true)
		{
			transform.Translate(7.0f*Time.deltaTime, 0.0f, 0.0f);
		}
		if(moveLeft==true)
		{
			transform.Translate(-7.0f*Time.deltaTime, 0.0f, 0.0f);
		}


	} 

	void OnCollisionEnter2D (Collision2D other)
	{
		if(other.collider.gameObject.tag == "World")
		{
			moveDisabled = false;
		}
	}

	void OnCollisionExit2D (Collision2D other)
	{
		if(other.collider.gameObject.tag == "World")
		{
			moveDisabled = true;
		}
	}


}

 