﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death1 : MonoBehaviour {
	private GameObject gm1;

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.name == "CatTrigger") 
		{
			Debug.Log ("1");
			SceneManager.LoadScene ("2");
		}
		if (col.gameObject.name == "Cube1") 
		{
			Debug.Log ("2");
			SceneManager.LoadScene ("2");
		}
		if (col.gameObject.name == "TrPlane") 
		{
			Debug.Log ("3");
			gm1 = GameObject.Find ("Cubeadd");
			gm1.GetComponent<Rigidbody> ().AddForce (300, 0,0);
			//gm1.AddForce (0,0,10);
		}
	}
	void OnCollisionEnter (Collision coll)
	{
		if (coll.rigidbody == true) {
			Debug.Log ("gf");
			SceneManager.LoadScene ("2");
		}
	}
}
