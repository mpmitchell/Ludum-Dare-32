using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {
	[SerializeField] GameObject healthbar;
	[SerializeField] GameObject levelComplete;
	[SerializeField] GameObject pauseButton;

	void OnCollisionEnter2D(Collision2D collision) {
		if (collision.collider.tag.Equals("Player")
			&& collision.contacts[0].normal == -Vector2.up) {
			Time.timeScale = 0.0f;
			levelComplete.SetActive(true);
			healthbar.SetActive(false);
			pauseButton.SetActive(false);
		}
	}
}
