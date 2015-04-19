using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(Dishwasher))]
public class DishwasherEditor : Editor {
	void OnSceneGUI() {
		Dishwasher d = (Dishwasher) target;

		d.distanceThreshold = d.transform.position.x - Handles.Slider(new Vector3(d.transform.position.x - d.distanceThreshold, d.transform.position.y, d.transform.position.z), -Vector3.right, 0.5f, Handles.CubeCap, 0.0f).x;

		Handles.BeginGUI();
		GUI.Box(HandleUtility.WorldPointToSizedRect(d.transform.position - Vector3.right * d.distanceThreshold, new GUIContent("Trigger"), GUI.skin.label), "Trigger");
		Handles.EndGUI();

		if (GUI.changed) {
			EditorUtility.SetDirty(target);
		}
	}
}
