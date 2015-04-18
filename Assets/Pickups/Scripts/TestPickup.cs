using UnityEngine;
using System.Collections;

public class TestPickup : BasePickup {
	public float destroyDelay = 1.0f;

	protected override void Activate(GameObject player) {
		isActive = false;
		StartCoroutine(DestroyIn(destroyDelay));
	}
}
