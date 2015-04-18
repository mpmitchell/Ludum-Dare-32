using UnityEngine;
using System.Collections;

public class Toaster : MonoBehaviour {
	public GameObject toast = null;
	public float distanceThreshold = 10.0f;
	public float firePeriod = 5.0f;
	public float initialVelocity = 20.0f;
	
	public Vector2 toastSpawnPoint;

	float timer = 0.0f;

	void Update() {
		float distance = Vector3.Distance(transform.position, ServiceLocator.player.transform.position);

		if (timer <= 0.0f) {
			if (distance <= distanceThreshold) {
				GameObject newToast = (GameObject) Instantiate(toast, toastSpawnPoint, Quaternion.identity);
				newToast.GetComponent<Rigidbody2D>().velocity = Vector3.up * initialVelocity;
				timer += firePeriod;
			}
		} else {
			timer -= Time.deltaTime;
		}
	}
}
