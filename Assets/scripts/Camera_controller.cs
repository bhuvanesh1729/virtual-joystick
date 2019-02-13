using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class Camera_controller : MonoBehaviour {

	public GameObject target;
	public Vector3 offset;
	public float SmoothSpeed=0.125f;




	void LateUpdate () {
		if (target != null) {
			Vector3 nextpos = Vector3.Lerp (transform.position, target.transform.position, SmoothSpeed);
			transform.position = nextpos + offset;
		}

	}
}
