using UnityEngine;
using System.Collections;

public class GunScript : MonoBehaviour {
	[SerializeField] float firePeroid = 1.0f;
	[SerializeField] float maxDistance = 10.0f;
	[SerializeField] float force = 80.0f;

	float timer = 0.0f;

	new Rigidbody2D rigidbody;

	void Start() {
		rigidbody = ServiceLocator.player.GetComponent<Rigidbody2D>();
	}

	void Update() {
		Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		Vector3 direction = mousePosition - transform.position;

		if (Time.timeScale != 0.0f) {
			float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
			transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
		}

		if (timer <= 0.0f) {
			if (Input.GetButtonDown("Fire1")) {
				RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, 100, LayerMask.GetMask("World"));
				if (hit.distance <= maxDistance) {
					Vector2 forceVector = mousePosition - ServiceLocator.player.transform.position;
					rigidbody.AddForce(-forceVector.normalized * force * Time.deltaTime, ForceMode2D.Impulse);

					timer = firePeroid;
				}
			}
		} else {
			timer -= Time.deltaTime;
		}
	}
}
