using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(Patrolling))]
public class PatrollingEditor : Editor {
	void OnSceneGUI() {
		Patrolling patrolling = (Patrolling) target;

		Handles.color = Color.green;
		patrolling.startPoint = Handles.Slider(patrolling.startPoint, -Vector3.right, 0.3f, Handles.CubeCap, 0.0f);

		Handles.color = Color.red;
		patrolling.endPoint = Handles.Slider(patrolling.endPoint, Vector3.right, 0.3f, Handles.CubeCap, 0.0f);

		if (GUI.changed) {
			EditorUtility.SetDirty(target);
		}
	}
}
