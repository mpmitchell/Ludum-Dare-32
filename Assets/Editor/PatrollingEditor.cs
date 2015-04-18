using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(Patrolling))]
public class PatrollingEditor : Editor {
	void OnSceneGUI() {
		Patrolling p = (Patrolling) target;

		Handles.color = Color.green;
		p.startPoint = new Vector3(Handles.Slider(p.startPoint, -Vector3.right, 0.3f, Handles.CubeCap, 0.0f).x, p.transform.position.y, p.transform.position.z);

		Handles.color = Color.red;
		p.endPoint = new Vector3(Handles.Slider(p.endPoint, Vector3.right, 0.3f, Handles.CubeCap, 0.0f).x, p.transform.position.y, p.transform.position.z);

		Handles.BeginGUI();
		GUI.Box(HandleUtility.WorldPointToSizedRect(p.startPoint, new GUIContent("Patrol start"), GUI.skin.label), "Patrol start");
		GUI.Box(HandleUtility.WorldPointToSizedRect(p.endPoint, new GUIContent("Patrol end"), GUI.skin.label), "Patrol end");
		Handles.EndGUI();

		if (p.startPoint.x > p.transform.position.x) {
			p.startPoint = p.transform.position;
		}

		if (p.endPoint.x < p.transform.position.x) {
			p.endPoint = p.transform.position;
		}

		if (GUI.changed) {
			EditorUtility.SetDirty(target);
		}
	}
}
