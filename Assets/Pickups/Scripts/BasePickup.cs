using UnityEngine;
using System.Collections;

public abstract class BasePickup : MonoBehaviour {
	public bool rotate = true;
	public float rotationalSpeed = 90.0f;

	void Update() {
		transform.Rotate(Vector3.up * rotationalSpeed * Time.deltaTime);
	}

	void OnCollisionEnter2D(Collision2D collision) {
		if (collision.collider.tag.Equals("Player")) {
			Activate(collision.collider.gameObject);
		}
	}

	protected abstract void Activate(GameObject player);
}
