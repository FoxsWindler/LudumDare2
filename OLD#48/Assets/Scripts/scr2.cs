using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr2 : MonoBehaviour {

	// Use this for initialization
	private GameObject gm2;
	private GameObject sc;
	// Use this for initialization
	void Start () {		
		gm2 = GameObject.Find ("Sfera");
		gm2.GetComponent<Rigidbody> ().AddForce (0, 0, 1000);
		gm2 = GameObject.Find ("Sfera1");
		gm2.GetComponent<Rigidbody> ().AddForce (1000, 0, 1000);
		gm2 = GameObject.Find ("Sfera2");
		gm2.GetComponent<Rigidbody> ().AddForce (1000, 0, 0);
		gm2 = GameObject.Find ("Sfera3");
		gm2.GetComponent<Rigidbody> ().AddForce (1500, 0, 1700);
		gm2 = GameObject.Find ("Sfera4");
		gm2.GetComponent<Rigidbody> ().AddForce (1000, 0, 1000);
	}

	// Update is called once per frame
	void Update () {

	}
}
