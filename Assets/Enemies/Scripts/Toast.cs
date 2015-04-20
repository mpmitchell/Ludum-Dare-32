using UnityEngine;
using System.Collections;

public class Toast : MonoBehaviour {
	[SerializeField] float timeOut = 1.0f;

	bool isAlive = true;
	float timer = 0.0f;

	new Rigidbody2D rigidbody;

	void Start() {
		rigidbody = GetComponent<Rigidbody2D>();
	}

	void OnCollisionEnter2D(Collision2D collision) {
		if (rigidbody.velocity.y <= 1.0f && collision.collider.name.Equals("Toaster")) {
			GetComponent<Collider2D>().enabled = false;
			isAlive = false;
		}
	}

	void OnCollisionStay2D(Collision2D collision) {
		timer += Time.deltaTime;
		if (timer > timeOut) {
			GetComponent<Collider2D>().enabled = false;
			isAlive = false;
		}
	}

	void OnCollisionExit2D(Collision2D collision) {
		timer = 0.0f;
	}

	void Update() {
		if (!isAlive) {
			if (Camera.main.WorldToScreenPoint(transform.position).y < 0.0f) {
				Destroy(gameObject);
			}
		}
	}
}
