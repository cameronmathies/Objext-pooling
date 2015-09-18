using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {

	public float speed = 5;
	
	// Update is called once per frame
	void Update () {
	//	Input.GetKey(KeyCode.Space);
		transform.Translate (0, speed * Time.deltaTime, 0);
		//InvokeRepeating ("Update", speed, speed);
	}
}
