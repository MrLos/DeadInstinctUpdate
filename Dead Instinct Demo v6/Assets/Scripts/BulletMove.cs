using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour {
	public float speed = 2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.up * speed * Time.deltaTime);
	}

	void OnCollisionEnter2D(Collision2D coll){
        if (coll.gameObject.tag == "Solid")
        {
            Destroy(gameObject);
        }
        if (coll.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
