using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player_death : MonoBehaviour {
	public float _health;
	public GameObject img;
	public  Slider _slider;
	float max_health;
	// Use this for initialization
	void Start () {
		max_health=GetComponent<Health> ().health;
		_slider.maxValue = max_health;
		_slider.minValue = 0;
		img.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		_health = GetComponent<Health> ().health;

		_slider.value = _health;
		if (_health <= 0) {
			
			img.SetActive (true);
			Destroy (this.gameObject);
		}
	}
}
