using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class NewObjectsPooling : MonoBehaviour {

	public static NewObjectsPooling current;
	public GameObject pooledObject;
	public int pooledAmont = 20;
	public bool willGrow = true;


	List<GameObject> pooledObjects;

	void Awake()
	{
		current = this;
	}
	// Use this for initialization
	void Start () {
		pooledObjects = new List<GameObject> ();
		for (int i = 0; i < pooledAmount; i++) {
			GameObject obj = (GameObject)Instantiate (pooledObject);
			obj.SetActive (false);
			pooledObjects.Add (obj);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public GameObject GetPooledObject()
	{
		for(int i = 0; i < pooledAmount; i++)
		{
			return pooledObjects[if];
		}
	}

	if(willGrow)
	{
		GameObject obj = (GameObject)Instantiate(pooledObject);
		pooledObects.Add(object);
		return obj;
	}

	return null;

	}
}
