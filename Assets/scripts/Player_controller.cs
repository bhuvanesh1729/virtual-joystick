using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;	
using UnityEngine.EventSystems;
public class Player_controller : MonoBehaviour {

	NavMeshAgent agent;
	RaycastHit hit =new RaycastHit();
	public GameObject cam;
	GameObject t;
	public float _speed;



	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent> ();
		t=Instantiate (cam);
		t.GetComponent<Camera_controller> ().target = this.gameObject;
		agent.speed = _speed;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			if (EventSystem.current.IsPointerOverGameObject () == false) {
				Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
				if (Physics.Raycast (ray.origin, ray.direction, out hit)) {
					agent.destination = hit.point;
				}
			}
		
		}
	}
}
