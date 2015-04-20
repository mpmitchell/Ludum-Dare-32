using UnityEngine;
using System.Collections;

public class Music : MonoBehaviour {
	static bool isInitialised = false;

	void Awake() {
		if (isInitialised) {
			Destroy(gameObject);
		} else {
			isInitialised = true;
			DontDestroyOnLoad(this);
		}
	}
}
