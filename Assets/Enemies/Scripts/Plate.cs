using UnityEngine;
using System.Collections;

public class Plate : MonoBehaviour {
	public float speed;
	private GameObject audioPlate;

	void Start()
	{
		audioPlate = GameObject.Find("Plate Hit Audio");
	}
	void Update() {
		transform.Translate(-Vector3.right * speed * Time.deltaTime);
	}

	void OnCollisionEnter2D(Collision2D collision) {
		audioPlate.GetComponent<AudioSource>().Play ();

		Destroy(gameObject);
	}
}
 