using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour {
	public GameObject cube;
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.name == "Cube") 
		{
			Debug.Log ("1");
			SceneManager.LoadScene ("2");
		}
}
}

