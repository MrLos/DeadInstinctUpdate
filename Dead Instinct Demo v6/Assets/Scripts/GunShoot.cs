using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShoot : MonoBehaviour {
    public AudioSource shootingSound;
    public GameObject bullet;
	public float delayShot = 0.2f;
	private float timer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey ("space")&&timer>=delayShot)
        {
			Instantiate (bullet, gameObject.transform.position, gameObject.transform.rotation);
            timer = 0;
            shootingSound.Play();
		}
		timer += Time.deltaTime;
	}
}
