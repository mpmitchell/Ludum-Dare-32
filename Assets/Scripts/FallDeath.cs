using UnityEngine;
using System.Collections;

public class FallDeath : MonoBehaviour {
	void OnCollisionEnter2D(Collision2D collision) {
		if (collision.collider.tag.Equals("Player")) {
			collision.collider.GetComponent<Health>().health = 0;
		}
	}
}
