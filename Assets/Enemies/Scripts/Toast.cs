using UnityEngine;
using System.Collections;

public class Toast : MonoBehaviour {
	bool isAlive = true;
	Rigidbody2D rigidBody;

	void Start() {
		rigidBody = GetComponent<Rigidbody2D>();
	}

	void OnCollisionEnter2D(Collision2D collision) {
		if (rigidBody.velocity.y <= 1.0f && collision.collider.name.Equals("Toaster")) {
			GetComponent<Collider2D>().enabled = false;
			isAlive = false;
		}
	}

	void Update() {
		if (!isAlive) {
			if (Camera.main.WorldToScreenPoint(transform.position).y < 0.0f) {
				Destroy(gameObject);
			}
		}
	}
}
