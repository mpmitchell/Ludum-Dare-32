using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public static GameObject player;

	void Awake() {
		if (player == null) {
			player = gameObject;
		} else {
			Debug.LogWarning("Multiple players in scene");
		}
	}

	void OnDestroy() {
		if (player == gameObject) {
			player = null;
		}
	}
}
