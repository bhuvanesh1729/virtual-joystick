using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Enemy_controller : MonoBehaviour {

	public GameObject player;
 	NavMeshAgent agent;
	public float damage;
	public float _speed;
	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent> ();
		agent.speed = _speed;
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if (player != null) {
			agent.destination = player.transform.position;
		}
		}

	void OnCollisionStay(Collision col)
	{
		if (col.gameObject.tag == "Player") {
			col.gameObject.GetComponent<Health> ().health -= damage;
		}
	}
}
