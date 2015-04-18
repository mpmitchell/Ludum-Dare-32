using UnityEngine;
using System.Collections;

public class GunScript : MonoBehaviour {

	public GameObject player;
	private float timer = 0;
	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		timer-= Time.deltaTime;
		Vector3 mPosition = Camera.main.WorldToScreenPoint (transform.position);
		Vector3 mDirection = Input.mousePosition - mPosition;
		float angle = Mathf.Atan2 (mDirection.y, mDirection.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis (angle, Vector3.forward);

		if (Input.GetMouseButtonDown (0))
		{
			if (timer<=0){

			player.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
			mPosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			Vector2 ForceVector =(mPosition - player.transform.position).normalized;
			Debug.Log (ForceVector.normalized*50*-1);
			player.GetComponent<Rigidbody2D>().AddForce(ForceVector.normalized*50*-1);
			
				timer = 1;
			}
		} 
	}
}
     