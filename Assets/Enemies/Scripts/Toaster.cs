using UnityEngine;
using System.Collections;

public class Toaster : MonoBehaviour {
	[SerializeField] GameObject toast = null;
	[SerializeField] float firePeriod = 5.0f;
	[SerializeField] float initialVelocity = 20.0f;
	
	public Vector2 toastSpawnPoint;
	[HideInInspector] public float distanceThreshold = 10.0f;

	float timer = 0.0f;

	void Update() {
		float distance = Vector3.Distance(transform.position, Player.player.transform.position);

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
