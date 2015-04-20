using UnityEngine;
using System.Collections;

public class HealthBar : MonoBehaviour {
	[SerializeField] RectTransform healthbar;

	Health health;

	void Start() {
		health = ServiceLocator.player.GetComponent<Health>();
	}

	void Update() {
		healthbar.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, health.health * 3);
	}
}
