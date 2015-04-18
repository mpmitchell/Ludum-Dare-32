using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private bool moveRight = false;
	private bool moveLeft = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown(KeyCode.D))
		{
			moveRight = true;

		}
		if (Input.GetKeyUp (KeyCode.D))
		{
				moveRight = false;
		}
		
		if (Input.GetKeyDown (KeyCode.A))
		{
			moveLeft = true;

		}

		if(Input.GetKeyUp (KeyCode.A))
		{
			moveLeft = false;
		}

		if(moveRight ==true)
		{
			transform.Translate(11.0f*Time.deltaTime, 0.0f, 0.0f);
		}
		if(moveLeft==true)
		{
			transform.Translate(-11.0f*Time.deltaTime, 0.0f, 0.0f);
		}

	} 
}
 