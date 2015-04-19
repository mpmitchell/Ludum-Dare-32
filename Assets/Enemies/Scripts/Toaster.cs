﻿using UnityEngine;
using System.Collections;

public class Toaster : MonoBehaviour {
	[SerializeField] GameObject toast = null;
	[SerializeField] float distanceThreshold = 10.0f;
	[SerializeField] float firePeriod = 5.0f;
	[SerializeField] float initialVelocity = 20.0f;
	
	[HideInInspector] public Vector2 toastSpawnPoint;

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
