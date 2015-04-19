using UnityEngine;
using System.Collections;

public class PlayerService : MonoBehaviour {
	void Awake() {
		if (ServiceLocator.player == null) {
			ServiceLocator.player = gameObject;
		} else {
			Debug.LogWarning("Multiple players in scene");
		}
	}

	void OnDestroy() {
		if (ServiceLocator.player == gameObject) {
			ServiceLocator.player = null;
		}
	}
}
