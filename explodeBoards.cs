using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explodeBoards : MonoBehaviour {

    Vector3 initialPosition;
    float distance = 0;
    float speed = 0;
    float explodeDistance = 10;
    bool goingOut = true;

    // Use this for initialization
    void Start()
    {
        initialPosition = this.transform.position;
        speed= transform.parent.GetComponent<mirtoGroupsScript>().speed;
        explodeDistance = transform.parent.GetComponent<mirtoGroupsScript>().explodeDistance;
    }

    // Update is called once per frame
    void Update()
    {
        
        distance = Vector3.Distance(initialPosition, transform.position);
       // Debug.Log("boards " + distance);
        if (goingOut)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            if (distance >= explodeDistance) goingOut = false;
        }
        else
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
            if (initialPosition.y >= transform.position.y) goingOut = true;
        }
    }
}
