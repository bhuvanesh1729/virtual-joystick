using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Load_Scene : MonoBehaviour {
	public GameObject img;
	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
		
	}

	public void loadscene(string scenename)
	{
		SceneManager.LoadScene (scenename);
	}
}
