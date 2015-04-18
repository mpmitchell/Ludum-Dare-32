using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(Toaster))]
public class ToasterEditor : Editor {
	void OnSceneGUI() {
		Toaster t = (Toaster) target;

		t.toastSpawnPoint = Handles.PositionHandle(t.toastSpawnPoint, Quaternion.identity);

		Handles.BeginGUI();
		GUI.Box(HandleUtility.WorldPointToSizedRect(t.toastSpawnPoint, new GUIContent("Toast spawn"), GUI.skin.label), "Toast spawn");
		Handles.EndGUI();

		if (GUI.changed) {
			EditorUtility.SetDirty(target);
		}
	}
}
