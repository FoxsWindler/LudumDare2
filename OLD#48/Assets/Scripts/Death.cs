using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class Death : MonoBehaviour {

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.name == "Player") 
		{
			Debug.Log ("1");
			EditorSceneManager.LoadScene ("2");
		}
}
	void OnParticleEnter (Collider col)
	{
		
			Debug.Log ("1");
			EditorSceneManager.LoadScene ("2");
		}
	}
