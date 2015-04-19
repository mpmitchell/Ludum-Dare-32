using UnityEngine;
using System.Collections;

public class cameraScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 ((ServiceLocator.player.transform.position.x)+5, transform.position.y, transform.position.z);
	}
}
