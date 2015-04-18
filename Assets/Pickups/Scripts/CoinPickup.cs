using UnityEngine;
using System.Collections;

public class CoinPickup : BasePickup {
	protected override void Activate(GameObject player) {
		isActive = false;
		
		Score score = player.GetComponent<Score>();
		if (score != null) {
			score.score++;
		}

		Destroy(gameObject);
	}
}
