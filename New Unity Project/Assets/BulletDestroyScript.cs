using UnityEngine;
using System.Collections;
using UnityEditor;
using System.Collections.Generic;
public class BulletDestroyScript : MonoBehaviour {

	// Use this for initialization
	void onEnable()
	{
		Invoke ("Destroy", 2f);
	}
	
	// Update is called once per frame
	void Destroy() {
		gameObject.SetActive(false);


	}


	void OnDisable()
	{
		CancelInvoke ();
	}
}

