using UnityEngine;
using System.Collections;

public class Plate : MonoBehaviour {
	public float speed;

	void Update() {
		transform.Translate(-Vector3.right * speed * Time.deltaTime);
	}

	void OnCollisionEnter2D(Collision2D collision) {
		Destroy(gameObject);
	}
}
