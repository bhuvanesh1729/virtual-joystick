using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_death : MonoBehaviour {

	public Text _text;
	float _health;
	public int score_bonous;
	GameObject gamemanager;
	int score;
	public Slider _slider;
	public GameObject cam;
	// Use this for initialization
	void Start () {
		gamemanager = GameObject.FindGameObjectWithTag ("Game_manager");
		_text = gamemanager.GetComponent<Spawn_enemies> ()._text;
		score = 0;
		_slider.maxValue=GetComponent<Health> ().health;
		_slider.minValue = 0;
	}
	
	// Update is called once per frame
	void Update () {
		_health = GetComponent<Health> ().health;
		_slider.value = _health;
		if (_health <= 0) {
			score+=score_bonous;
			_text.text = score.ToString();
			gamemanager.GetComponent<Spawn_enemies>().enemy_count--;
			Destroy (this.gameObject);
		}
	}
}
