using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickUp : MonoBehaviour {
    public AudioSource ammopickupSound;
    private GameManager theGameManager;
    public int bulletNumber;

    // Use this for initialization
    void Start () {
        theGameManager = FindObjectOfType<GameManager>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            // play pick up sound
            ammopickupSound.Play();
            theGameManager.AddBullets(bulletNumber);
            Destroy(gameObject);
        }

    }
}
