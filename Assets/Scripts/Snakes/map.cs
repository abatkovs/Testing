using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//qwe
public class map : MonoBehaviour {

	public GameObject groundPrefab;
	public Transform mapCreate;
	public int groundSize_X = 5;
	public int groundSize_Y = 5;
	public float groundDistX = 1.15F;
	// Use this for initialization
	void Start () {
		Instantiate (mapCreate, new Vector3 (0, 0, 0), Quaternion.Euler (new Vector3 (0, 0, 0)));
	}

	public void genMap(){
		
		var clones = GameObject.FindGameObjectsWithTag ("Ground");
		foreach (var clone in clones){
			Destroy(clone);
		}

		for (int i = 0; i < groundSize_X; i++) {
			Instantiate (mapCreate, new Vector3 (i* groundDistX, 0, 0), Quaternion.Euler (new Vector3 (0, 0, 0)));
			for (int o = 0; o < groundSize_Y; o++) {
				Instantiate (mapCreate, new Vector3 (o* groundDistX, 0,  i* groundDistX + groundDistX), Quaternion.Euler (new Vector3 (0, 0, 0)));
			}
		}
	}

	// Update is called once per frame
	void Update () {



	}
}
