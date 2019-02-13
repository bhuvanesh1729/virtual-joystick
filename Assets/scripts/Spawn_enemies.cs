using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Spawn_enemies : MonoBehaviour {

	public GameObject[] enemies;
	public float max_Cooldown;
	 float cooldown;
	public GameObject[] Spawn_points;
	public Text _text;
	public int enemy_count;
  	// Use this for initialization
	void Start () {
		enemy_count = 0;
	}
	
	// Update is called once per frame
	void Update () {
		cooldown -= Time.deltaTime;
		if (cooldown <= 0 && enemy_count<=4) {
			cooldown = max_Cooldown;
			Instantiate (enemies [Random.Range (0, enemies.Length)], Spawn_points [Random.Range (0, Spawn_points.Length)].transform.position, Quaternion.identity);
			enemy_count++;
		}
	}
}
