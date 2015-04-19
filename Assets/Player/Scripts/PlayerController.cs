using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	[SerializeField] float speed = 50.0f;
	[SerializeField] float airSpeed = 20.0f;
	[SerializeField] float maxSpeed = 100.0f;

	bool isGrounded;

	new Rigidbody2D rigidbody;
	new Collider2D collider;

	void Start() {
		rigidbody = GetComponent<Rigidbody2D>();
		collider = GetComponent<Collider2D>();
	}

	void Update() {
		if (Physics2D.BoxCast(transform.position, collider.bounds.size, 0.0f, -Vector2.up, collider.bounds.extents.y, LayerMask.GetMask("World")).normal == Vector2.up) {
			isGrounded = true;
		} else {
			isGrounded = false;
		}
	}

	void FixedUpdate() {
		Vector2 force = Vector2.right * Input.GetAxis("Horizontal") * Time.fixedDeltaTime;

		if (isGrounded) {
			force *= speed;
		} else {
			force *= airSpeed;
		}

		rigidbody.AddForce(force);

		if (Mathf.Abs(rigidbody.velocity.x) > maxSpeed) {
			rigidbody.velocity = new Vector2(Mathf.Clamp(rigidbody.velocity.x, -maxSpeed, maxSpeed), rigidbody.velocity.y);
		}
	}
}

