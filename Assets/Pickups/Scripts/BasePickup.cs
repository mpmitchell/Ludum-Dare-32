using UnityEngine;
using System.Collections;

public abstract class BasePickup : MonoBehaviour {
	public bool isRotating = true;
	public float rotationalSpeed = 90.0f;
	
	public bool isActive = true;

	void Update() {
		transform.Rotate(Vector3.up * rotationalSpeed * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D collider) {
		if (isActive && collider.tag.Equals("Player")) {
			Activate(collider.gameObject);
		}
	}

	protected virtual IEnumerator DestroyIn(float seconds) {
		yield return new WaitForSeconds(seconds);
		Destroy(gameObject);
	}

	protected abstract void Activate(GameObject player);
}
