using UnityEngine;
using System.Collections;

public class Patrolling : MonoBehaviour {
	[SerializeField] bool isMoving = true;
	[SerializeField] float speed = 5.0f;
	[SerializeField] bool isMovingLeft = true;

	public Vector3 startPoint;
	public Vector3 endPoint;

	Enemy enemy;
	float distance;
	float t;

	void Start() {
		enemy = GetComponent<Enemy>();

		if (endPoint.x == startPoint.x) {
			isMoving = false;
		}

		endPoint.x -= startPoint.x;
		distance = Mathf.Abs(endPoint.x - startPoint.x);
		t = (transform.position.x - startPoint.x) / endPoint.x;
	}

	void Update() {
		if (enemy.isAlive && isMoving) {
			if (isMovingLeft) {
				t -= speed * Time.deltaTime / distance;
				if (t <= 0.0f) {
					t = 0.0f - t;
					isMovingLeft = false;
				}
			} else {
				t += speed * Time.deltaTime / distance;
				if (t >= 1.0f) {
					t = 1.0f - (t - 1.0f);
					isMovingLeft = true;
				}
			}

			transform.position = new Vector3(startPoint.x + t * endPoint.x, transform.position.y, transform.position.z);
		}
	}
}
