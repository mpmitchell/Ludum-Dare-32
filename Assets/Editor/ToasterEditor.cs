using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(Toaster))]
public class ToasterEditor : Editor {
	void OnSceneGUI() {
		Toaster t = (Toaster) target;

		t.toastSpawnPoint = Handles.PositionHandle(t.toastSpawnPoint, Quaternion.identity);
		t.distanceThreshold = Handles.RadiusHandle(Quaternion.identity, t.transform.position, t.distanceThreshold);

		Handles.BeginGUI();
		GUI.Box(HandleUtility.WorldPointToSizedRect(t.toastSpawnPoint, new GUIContent("Toast spawn"), GUI.skin.label), "Toast spawn");
		GUI.Box(HandleUtility.WorldPointToSizedRect(t.transform.position - Vector3.right * t.distanceThreshold, new GUIContent("Trigger"), GUI.skin.label), "Trigger");
		Handles.EndGUI();

		if (GUI.changed) {
			EditorUtility.SetDirty(target);
		}
	}
}
