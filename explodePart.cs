using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explodePart : MonoBehaviour
{

    Vector3 initialPosition;
    public float distance = 0;
    private float speed = 20;
    private float explodeDistance = 10;
    public bool goingOut = true;
    public bool animate = false;
    public string explodeDirectionString;
    public Vector3 explodeDirectionOut;
    public Vector3 explodeDirectionIn;

    // Use this for initialization
    void Start()
    {
        initialPosition = this.transform.position;
        speed = transform.parent.GetComponent<mirtoGroupsScript>().speed;
        explodeDistance = transform.parent.GetComponent<mirtoGroupsScript>().explodeDistance;
        if (explodeDirectionString == "up")
        {
            explodeDirectionOut = Vector3.forward;
            explodeDirectionIn = Vector3.back;
            //limitCheckVariable
        }
        if (explodeDirectionString == "down")
        {
            explodeDirectionOut = Vector3.back;
            explodeDirectionIn = Vector3.forward;
        }
        if (explodeDirectionString == "right")
        {
            explodeDirectionOut = Vector3.left;
            explodeDirectionIn = Vector3.right;
        }
        if (explodeDirectionString == "left")
        {
            explodeDirectionOut = Vector3.right;
            explodeDirectionIn = Vector3.left;
        }
        if (explodeDirectionString == "forward")
        {
            explodeDirectionOut = Vector3.up;
            explodeDirectionIn = Vector3.down;
        }
        if (explodeDirectionString == "back")
        {
            explodeDirectionOut = Vector3.down;
            explodeDirectionIn = Vector3.up;
        }
        else { Debug.Log("Direction string not set in explode script"); }
    }

    // Update is called once per frame
    void Update()
    {
        if (animate)
        {
            distance = Vector3.Distance(initialPosition, transform.position);
            if (goingOut)
            {
                transform.Translate(explodeDirectionOut * speed * Time.deltaTime);
                if (distance >= explodeDistance) goingOut = false;
            }
            else
            {
                transform.Translate(explodeDirectionIn * speed * Time.deltaTime);
                if (explodeDirectionString == "up")
                {
                    if (initialPosition.y >= transform.position.y) goingOut = true;
                }
                else if (explodeDirectionString == "down")
                {
                    if (initialPosition.y <= transform.position.y) goingOut = true;
                }
                else if (explodeDirectionString == "right")
                {
                    if (initialPosition.x <= transform.position.x) goingOut = true;
                }
                else if (explodeDirectionString == "left")
                {
                    if (initialPosition.x >= transform.position.x) goingOut = true;
                }
                else if (explodeDirectionString == "forward")
                {
                    if (initialPosition.z <= transform.position.z) goingOut = true;
                }
                else if (explodeDirectionString == "back")
                {
                    if (initialPosition.z >= transform.position.z) goingOut = true;
                }

            }
        }
        else
        {
            transform.position = initialPosition;
        }
    }
}
