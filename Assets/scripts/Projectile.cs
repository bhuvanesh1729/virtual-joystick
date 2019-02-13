using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {


	public float projectile_speed;
	public float damage;
	 Vector3 startposition;
	public float maxdistance;
	// Use this for initialization
	void Start () {
		startposition=transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate (Vector3.forward * this.projectile_speed * Time.deltaTime);
		if(Vector3.Distance(startposition,transform.position)>maxdistance)
		{
			Destroy(this.gameObject);
		}
	}
	void OnCollisionEnter(Collision coll)
	{
		if(coll.gameObject.tag=="Enemy")
		{
			coll.gameObject.GetComponent<Health>().health-=damage;
			Destroy (this.gameObject);
		}

	}
}
