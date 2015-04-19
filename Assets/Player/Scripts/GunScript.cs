using UnityEngine;
using System.Collections;

public class GunScript : MonoBehaviour {
	private float timer = 0;
	int raycastMask = 1 << 8;
	// Update is called once per frame
	void Update () {
		timer-= Time.deltaTime;
		Vector3 mPosition = Camera.main.WorldToScreenPoint (transform.position);
		Vector3 mDirection = Input.mousePosition - mPosition;
		float angle = Mathf.Atan2 (mDirection.y, mDirection.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis (angle, Vector3.forward);

		if (Input.GetMouseButtonDown (0))
		{  
			RaycastHit2D hit = Physics2D.Raycast(transform.position, mDirection, 100, raycastMask);
		

			if(hit.distance <=5)
			{
				Debug.Log (hit.collider.tag);
			if(hit != null && hit.collider != null){

				if (timer<=0){

					ServiceLocator.player.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
					mPosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
					Vector2 ForceVector =(mPosition - ServiceLocator.player.transform.position).normalized;
					ServiceLocator.player.GetComponent<Rigidbody2D>().AddForce(ForceVector.normalized*60*-1);

					timer = 1;
				} 
				}
			}
		}
		
		}


	}


