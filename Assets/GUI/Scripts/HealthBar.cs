using UnityEngine;
using System.Collections;

public class HealthBar : MonoBehaviour {
	[SerializeField] RectTransform healthbar;
	[SerializeField] GameObject gameOver;
	[SerializeField] GameObject pauseButton;

	Health health;

	bool isAlive = true;

	void Start() {
		health = ServiceLocator.player.GetComponent<Health>();
	}

	void Update() {
		if (isAlive) {
			healthbar.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, health.health * 3);

			if (health.health <= 0) {
				isAlive = false;
				Time.timeScale = 0.0f;
				gameOver.SetActive(true);
				healthbar.parent.gameObject.SetActive(false);
				pauseButton.SetActive(false);
			}
		}
	}
}
