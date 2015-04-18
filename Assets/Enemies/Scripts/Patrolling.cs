using UnityEngine;
using System.Collections;

public class Patrolling : MonoBehaviour {
	public bool isMoving = true;
	public float speed = 5.0f;
	public bool isMovingLeft = true;

	public Vector3 startPoint;
	public Vector3 endPoint;

	float t;

	void Start() {
		if (endPoint.x == startPoint.x) {
			isMoving = false;
		}

		if (isMoving) {
			endPoint.x -= startPoint.x;
			t = (transform.position.x - startPoint.x) / endPoint.x;
		}
	}

	void Update() {
		if (!isMoving) {
			return;
		}

		if (isMovingLeft) {
			t -= speed * Time.deltaTime / Mathf.Abs(endPoint.x - startPoint.x);
			if (t <= 0.0f) {
				t = 0.0f - t;
				isMovingLeft = false;
			}
		} else {
			t += speed * Time.deltaTime / Mathf.Abs(endPoint.x - startPoint.x);
			if (t >= 1.0f) {
				t = 1.0f - (t - 1.0f);
				isMovingLeft = true;
			}
		}

		transform.position = new Vector3(startPoint.x + t * endPoint.x, transform.position.y, transform.position.z);
	}
}
