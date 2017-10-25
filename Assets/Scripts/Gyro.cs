using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gyro : MonoBehaviour {
	public float galtitude = 0;

	// Use this for initialization
	void Start () {
		Input.gyro.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0, -Input.gyro.rotationRate.y, Input.gyro.rotationRate.z);
		//player.transform.Rotate (0, -Input.gyro.rotationRateUnbiased.y, 0);
		if (Input.gyro.enabled) {
//			Debug.Log (Input.gyro.rotationRate.y);
		}

		if (Input.touchCount >= 2) {
			transform.localEulerAngles = new Vector3 (0, 0, 0);
		}
	}
}
