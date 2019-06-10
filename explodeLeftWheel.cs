using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explodeLeftWheel : MonoBehaviour {
    Vector3 initialPosition;
    float distance=0;
    float speed = 0;
    float explodeDistance =0;
    bool goingOut = true;
	// Use this for initialization
	void Start () {
         initialPosition=transform.position;
        speed = transform.parent.GetComponent<mirtoGroupsScript>().speed;
        explodeDistance = transform.parent.GetComponent<mirtoGroupsScript>().explodeDistance; 
    }

    void Update()
    {
        // Move the object forward along its z axis 1 unit/second.
        distance = Vector3.Distance(initialPosition, transform.position);
      //  Debug.Log("leftwheel " + distance);
        if (goingOut)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            if (distance >= explodeDistance) goingOut = false;
        }
        else
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            if (initialPosition.x <= transform.position.x) goingOut = true;
        }
    }
}
