using UnityEngine;
using System.Collections;

public class Toast : MonoBehaviour {
	[SerializeField] float timeOut = 1.0f;

	float timer = 0.0f;

	new Rigidbody2D rigidbody;

	void Start() {
		rigidbody = GetComponent<Rigidbody2D>();
	}

	void OnCollisionEnter2D(Collision2D collision) {
		if (rigidbody.velocity.y <= 1.0f &&
			collision.gameObject.tag == "Toaster" || collision.gameObject.tag == "Player") {
			Destroy(gameObject);
			Destroy(gameObject);
		}
	}

	void OnCollisionStay2D(Collision2D collision) {
		timer += Time.deltaTime;
		if (timer > timeOut) {
			Destroy(gameObject);
		}
	}

	void OnCollisionExit2D(Collision2D collision) {
		timer = 0.0f;
	}
}

