using UnityEngine;
using System.Collections;

public class Background : MonoBehaviour {
	void Update () {
		transform.position = new Vector3(ServiceLocator.player.transform.position.x, transform.position.y, transform.position.z);
	}
}
