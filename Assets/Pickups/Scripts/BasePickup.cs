using UnityEngine;
using System.Collections;

public abstract class BasePickup : MonoBehaviour {
	[SerializeField] bool isRotating = true;
	[SerializeField] float rotationalSpeed = 90.0f;
	
	protected bool isActive = true;

	void Update() {
		if (isRotating) {
			transform.Rotate(Vector3.up * rotationalSpeed * Time.deltaTime);
		}
	}

	void OnTriggerEnter2D(Collider2D collider) {
		if (isActive && collider.tag.Equals("Player")) {
			Activate(collider.gameObject);
		}
	}

	protected IEnumerator DestroyIn(float seconds) {
		yield return new WaitForSeconds(seconds);
		Destroy(gameObject);
	}

	protected abstract void Activate(GameObject player);
}
