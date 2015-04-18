using UnityEngine;
using System.Collections;

public class TestController : MonoBehaviour {
	public float speed = 5.0f;

	void Update() {
		transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime);
	}
}
