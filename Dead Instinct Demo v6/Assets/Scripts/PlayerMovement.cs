using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	public float speed = 7;
    private Animator myAnim;
   

	// Use this for initialization
	void Start () {
        myAnim = GetComponent<Animator>();       

    }

	// Update is called once per frame
	void Update ()
	{
        float walking = 0f;
		if (Input.GetKey ("d")) {
			transform.Translate (Vector3.right * Time.deltaTime * speed );
			transform.rotation = Quaternion.Euler (0, 0, 0);
            walking = 0.2f;
        }
		if (Input.GetKey ("a")) {
			transform.Translate (Vector3.right * Time.deltaTime * speed );
			transform.rotation = Quaternion.Euler (0, 0, 180);
            walking = 0.2f;
        }
		if (Input.GetKey ("w")) {
			transform.Translate (Vector3.right * Time.deltaTime * speed);
			transform.rotation = Quaternion.Euler (0, 0, 90);
            walking = 0.2f;
        }
		if (Input.GetKey ("s")) {
			transform.Translate (Vector3.right * Time.deltaTime * speed );
			transform.rotation = Quaternion.Euler (0, 0, -90);
            walking = 0.2f;
        }
        if (Input.GetKey("space"))
        {
            myAnim.SetBool("Shooting", true);
        }
        else
        {
            myAnim.SetBool("Shooting", false);
        }
        if (Input.GetKey("k"))
        {
            myAnim.SetBool("Kicking", true);
        }
        else
        {
            myAnim.SetBool("Kicking", false);
        }
        myAnim.SetFloat("MovingSpeed", walking);
       
	}
}
