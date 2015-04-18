using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	public Animation deathAnimation = null;
	public bool isAlive = true;

	void OnCollisionEnter2D(Collision2D collision) {
		if (isAlive && collision.collider.tag.Equals("Player")
			&& collision.contacts[0].normal == -Vector2.up) {
			// Start death animation
			isAlive = false;
		}
	}

	void Update() {
		if (!isAlive) {
			if (deathAnimation == null || !deathAnimation.isPlaying) {
				Destroy(gameObject);
			}
		}
	}
}
