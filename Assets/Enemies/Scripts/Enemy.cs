using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	public Animation deathAnimation;
	public bool isAlive = true;

	void OnCollisionEnter2D(Collision2D collision) {
		if (isAlive && collision.collider.tag.Equals("Player")
			&& collision.contacts[0].normal == -Vector2.up) {
			DeathAnimation();
			isAlive = false;
		}
	}

	IEnumerable DeathAnimation() {
		// TODO: Start death animation

		do {
			yield return null;
		} while (deathAnimation.isPlaying);

		Destroy(gameObject);
	}
}
