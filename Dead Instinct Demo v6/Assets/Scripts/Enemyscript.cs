using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyscript : MonoBehaviour {
	public float speed = 2;
	private Transform target;
	// Use this for initialization
	void Start () {
	GameObject GO = GameObject.FindGameObjectWithTag ("Player");
	target = GO.transform;
	}

	// Update is called once per frame
	void Update () {
		Vector3 targetDir = target.position - transform.position;
	Quaternion rotation = Quaternion.LookRotation (Vector3.forward, targetDir);     transform.rotation = rotation;
	transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x,transform.rotation.eulerAngles.y,transform.rotation.eulerAngles.z+90);
	transform.Translate(Vector3.right*Time.deltaTime*speed);
	}
}



