using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnOffKids : MonoBehaviour
{
    GameObject child1, child2, child3, child4, child5, child6, child7;
    float timeSpent=0;
    float interval=5;
    // Start is called before the first frame update
    void Start()
    {
        child1 = GameObject.Find("boards") as GameObject;
        child2 = GameObject.Find("bottomPlate") as GameObject;
        child3 = GameObject.Find("leftWheel") as GameObject;
        child4 = GameObject.Find("rightWheel") as GameObject;
        child5 = GameObject.Find("roller") as GameObject;
        child6 = GameObject.Find("skeleton") as GameObject;
        child7 = GameObject.Find("topPlate") as GameObject;
    }
    // boards bottomPlate leftWheel rightWheel roller skeleton topPlace
    // Update is called once per frame
    void Update()
    {
        timeSpent += Time.deltaTime;
        if (timeSpent > interval && timeSpent < interval * 2)
        {
            child1.SetActive(false);
        }
         if (timeSpent > interval * 2 && timeSpent < interval * 3)
        {
            child2.SetActive(false);
        }
         if (timeSpent > interval * 3 && timeSpent < interval * 4)
        {
            child3.SetActive(false);
        }
         if (timeSpent > interval * 4 && timeSpent < interval * 5)
        {
             child4.SetActive(false);
        }
        if (timeSpent > interval * 5 && timeSpent < interval * 6)
        {
            child5.SetActive(false);
        }
        if (timeSpent > interval * 6 && timeSpent < interval * 7)
        {
            child6.SetActive(false);
        }
        if (timeSpent > interval * 7 && timeSpent < interval * 8)
        {
            child7.SetActive(false);
        }
        if (timeSpent > interval * 8 )
        {
            child1.SetActive(true); child2.SetActive(true); child3.SetActive(true); child4.SetActive(true); child5.SetActive(true); child6.SetActive(true); child7.SetActive(true);
            timeSpent = 0;

        }

    }
}
