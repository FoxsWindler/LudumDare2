using System.Collections;
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
			//SceneManager.LoadScene ("2");
		}
		if (col.gameObject.name == "CatTriggerMao") 
		{
			Debug.Log ("Mao!");
		}
		if (col.gameObject.name == "KidTrigger") 
		{
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
			gm1 = GameObject.Find("Cubeadd");
			gm1.GetComponent<Rigidbody> ().AddForce (300, 0,0);
			gm1 = GameObject.Find("Cubeadd1");
			gm1.GetComponent<Rigidbody> ().AddForce (300, 0,0);
			gm1 = GameObject.Find("Cubeadd2");
			gm1.GetComponent<Rigidbody> ().AddForce (300, 0,0);
			gm1 = GameObject.Find("Cubeadd3");
			gm1.GetComponent<Rigidbody> ().AddForce (300, 0,0);
			gm1 = GameObject.Find("Cubeadd4");
			gm1.GetComponent<Rigidbody> ().AddForce (300, 0,0);
			gm1 = GameObject.Find("Cubeadd5");
			gm1.GetComponent<Rigidbody> ().AddForce (200, 0,0);
			gm1 = GameObject.Find("Cubeadd6");
			gm1.GetComponent<Rigidbody> ().AddForce (300, 0,0);
			gm1 = GameObject.Find("Cubeadd7");
			gm1.GetComponent<Rigidbody> ().AddForce (0, 0,300);
			gm1 = GameObject.Find("Cubeadd8");
			gm1.GetComponent<Rigidbody> ().AddForce (0,1000,0);
			gm1 = GameObject.Find("Cubeadd9");
			gm1.GetComponent<Rigidbody> ().AddForce (0,1000,0);
			gm1 = GameObject.Find("Cubeadd10");
			gm1.GetComponent<Rigidbody> ().AddForce (300, 0,0);
			gm1 = GameObject.Find("Cubeadd11");
			gm1.GetComponent<Rigidbody> ().AddForce (300, 0,0);
			gm1 = GameObject.Find("Cubeadd12");
			gm1.GetComponent<Rigidbody> ().AddForce (0, 0,500);
			gm1 = GameObject.Find("Cubeadd13");
			gm1.GetComponent<Rigidbody> ().AddForce (0, 0,500);
			gm1 = GameObject.Find("Cubeadd14");
			gm1.GetComponent<Rigidbody> ().AddForce (0, 800,0);
			gm1 = GameObject.Find("Cubeadd15");
			gm1.GetComponent<Rigidbody> ().AddForce (300, 1000,0);
			gm1 = GameObject.Find("Cubeadd16");
			gm1.GetComponent<Rigidbody> ().AddForce (0, 800,0);
			gm1 = GameObject.Find("Cubeadd17");
			gm1.GetComponent<Rigidbody> ().AddForce (300, 0,900);
			gm1 = GameObject.Find("Cubeadd18");
			gm1.GetComponent<Rigidbody> ().AddForce (300, 0,0);
			gm1 = GameObject.Find("Cubeadd19");
			gm1.GetComponent<Rigidbody> ().AddForce (300, 0,0);

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
