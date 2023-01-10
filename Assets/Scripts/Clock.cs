using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Globalization;

public class Clock : MonoBehaviour
{

    public GameObject hoursHand;
    public GameObject minutesHand;
    public GameObject secondsHand;



    DateTime timenow = DateTime.Now;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hoursHand.transform.rotation = Quaternion.Euler(new Vector3((DateTime.Now.Hour * 30) + (DateTime.Now.Minute)/2, 0, 0));
        minutesHand.transform.rotation = Quaternion.Euler(new Vector3(DateTime.Now.Minute * 6, 0, 0));
        secondsHand.transform.rotation = Quaternion.Euler(new Vector3(DateTime.Now.Second * 6, 0, 0));

        
    }
}
