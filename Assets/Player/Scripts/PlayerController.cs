using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	bool moveRight = false;
	bool moveLeft = false;
	bool moveDisabled = true;
	int raycastMask = 1 << 8;

	Collider2D collider;

	void Start() {
		collider = GetComponent<Collider2D>();
	}

	void Update() {
		if (Input.GetKeyDown(KeyCode.D) && moveDisabled == false) {
			moveRight = true;

		}
		if (Input.GetKeyUp(KeyCode.D)) {
			moveRight = false;
		}

		if (Input.GetKeyDown(KeyCode.A) && moveDisabled == false) {
			moveLeft = true;
		}
		if (Input.GetKeyUp(KeyCode.A)) {
			moveLeft = false;
		}

		if (moveRight == true) {
			transform.Translate(7.0f * Time.deltaTime, 0.0f, 0.0f);
		}
		if (moveLeft == true) {
			transform.Translate(-7.0f * Time.deltaTime, 0.0f, 0.0f);
		}

		if (Physics2D.BoxCast(transform.position, collider.bounds.size, 0.0f, -Vector2.up, collider.bounds.extents.y, raycastMask).normal == Vector2.up) {
			moveDisabled = false;
		} else {
			moveDisabled = true;
		}
	}
}

