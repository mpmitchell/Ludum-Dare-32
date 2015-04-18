using UnityEngine;
using System.Collections;

public class GunScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 mPosition = Camera.main.WorldToScreenPoint (transform.position);
		Vector3 mDirection = Input.mousePosition - mPosition;
		float angle = Mathf.Atan2 (mDirection.y, mDirection.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis (angle, Vector3.forward);
	}
}
 