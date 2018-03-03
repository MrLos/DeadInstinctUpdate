using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script is added to the camera object to control its position
public class CameraController : MonoBehaviour
{
    // This variable should be initialized to the player object. This is done by dragging the player object
    // into the "target" variable
    public GameObject target;

    // why do we have the follow ahead 
    public float followAhead;
    public float smoothing;
    private Vector3 targetPosition;

    // these variables are used to store the new position of the camera
    // the diagram below shows the value of the target local scale 
    //                    y
    //                    ^
    //    x<0 and y>0     |      x>0 and y>0
    //                    |
    // -------------------0-----------------> x
    //                    |
    //    x<0 and y<0     |      x>0 and y<0
    //                    |
    // we are going to use this knowledge to calcuate the position of the camera 
    // for instance if the player moves to the top left then 
    // x<0 and y>0 we want the camera to move ahead to the top left of the screen 
    // targetXposition = x-followahead and targetYposition= y+followahead 
    private float targetXPosition;
    private float targetYPosition;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        targetPosition = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z);

        targetXPosition = targetPosition.x;
        targetYPosition = targetPosition.y;
        // this moves the target of the camera ahead of the player in the x position
        if (target.transform.localScale.x > 0f)
        {
             targetXPosition = targetPosition.x + followAhead;
        }
        else if (target.transform.localScale.x < 0f)
        {
             targetXPosition = targetPosition.x - followAhead;
        } 
        
        // this moves the target of the camera ahead of the player in the y position
        if (target.transform.localScale.y > 0f)
        {
            targetYPosition = targetPosition.y + followAhead;
        }
        else if (target.transform.localScale.y < 0f)
        {
            targetYPosition = targetPosition.y - followAhead;
        }
        targetPosition = new Vector3(targetXPosition, targetYPosition, targetPosition.z);

        // the following line makes the movement of the camera a little bit jerky
        // a good solution is to use lerp witch will move smoothly within a certain amount of time
        //transform.position = targetPosition;
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing * Time.deltaTime);
    }
}

