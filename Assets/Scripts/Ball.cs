using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Touch th = Input.GetTouch (0);
		if (Input.touchCount >= 2) {
			Debug.Log (Input.touchCount);
			transform.position = new Vector3 (0, 1, -6);
		}
	}
}
