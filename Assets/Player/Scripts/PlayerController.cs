using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private bool moveRight = false;
	private bool moveLeft = false;

	private bool moveDisabled = true;
	public int raycastMask = ~(1 << 8);
	//Vector3 colliderOffset;
	// Use this for initialization
	void Start () {
	//	BoxCollider2D boxCollider = (BoxCollider2D) GetComponent<Collider2D>();
	//	colliderOffset = boxCollider.offset;
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
		RaycastHit2D[] hits = Physics2D.BoxCastAll(transform.position , GetComponent<Collider2D>().bounds.size, 0.0f, -transform.up, 0.1f, raycastMask);
		foreach (RaycastHit2D hit in hits)
		{
			if (hit.collider != null && hit.collider.tag == "World")
			{
				Debug.Log ("Move");
				moveDisabled = false;
				break;
			}
			else
			{
				Debug.Log("Stay");
				moveDisabled = true;
				break;
			}
		}
	}

/*	void OnTriggerEnter2D (Collider2D other)
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
*/

}


