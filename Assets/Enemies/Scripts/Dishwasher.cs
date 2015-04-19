using UnityEngine;
using System.Collections;

public class Dishwasher : MonoBehaviour {
	[SerializeField] GameObject[] plates;
	[SerializeField] float firePeriod = 3.0f;
	[SerializeField] float reloadTime = 5.0f;
	[SerializeField] float plateSpeed = 5.0f;

	[HideInInspector] public float distanceThreshold = 10.0f;

	int currentPlate = 0;
	float timer = 0.0f;

	void Update() {
		if (timer <= 0.0f) {
			if (currentPlate == plates.Length) {
				foreach (GameObject plate in plates) {
					plate.SetActive(true);
				}

				currentPlate = 0;
			}

			if (Physics2D.BoxCast(plates[currentPlate].transform.position, plates[currentPlate].GetComponent<Collider2D>().bounds.size, 0.0f, -Vector2.right, distanceThreshold, (1 << 9)).collider != null) {
				GameObject plate = (GameObject) Instantiate(plates[currentPlate], plates[currentPlate].transform.position, Quaternion.identity);
				plate.transform.localScale = transform.localScale;
				plate.AddComponent<Plate>().speed = plateSpeed;

				plates[currentPlate].SetActive(false);

				currentPlate++;
				if (currentPlate == plates.Length) {
					timer = reloadTime;
				} else {
					timer = firePeriod;
				}
			}
		} else {
			timer -= Time.deltaTime;
		}
	}
}
