using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {
	[SerializeField] Text scoreLabel;

	public int score;

	void Update() {
		scoreLabel.text = score.ToString();
	}
}
