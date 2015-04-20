using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour {
	public bool topTrigger = false;
	public int damage = 20;
	public float knockback = 50;

	Health health;

	void Start() {
		health = Player.player.GetComponent<Health>();
	}

	void OnCollisionEnter2D(Collision2D collision) {
		if (collision.collider.tag.Equals("Player") &&
			(topTrigger || !topTrigger && collision.contacts[0].normal != -Vector2.up)) {
			health.health -= damage;
			collision.collider.gameObject.GetComponent<Rigidbody2D>().AddForce(-collision.contacts[0].normal * knockback);
		}
	}
}
