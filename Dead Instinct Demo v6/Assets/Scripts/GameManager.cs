using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public static GameManager instance = null;
    public SoundManager soundManager;
    
    public int numberOfBullets = 30;
	// Use this for initialization

	void Awake () {
        //We dont want more than one instance of game manager. The code below ensures that
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        soundManager = GetComponent<SoundManager>();
        InitGame();
	}
	
    void InitGame()
    {

    }

	// Update is called once per frame
	void Update ()
    {
		
	}
    public void AddBullets(int bulletToAdd)
    {
        numberOfBullets = numberOfBullets + bulletToAdd;
    }
}
