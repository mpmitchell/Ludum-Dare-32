using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
	public int health = 100;

	void Update() {
		if (health <= 0) {
			Debug.Log("Load GameOver");
			// Game Over
		}
	}
}
