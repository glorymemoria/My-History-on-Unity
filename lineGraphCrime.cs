using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lineGraphCrime : MonoBehaviour
{
    protected float crimeRateY;
    float timer, randomHold;

    void Start()//223.3336,165.2832,-13.70563
    {
        //transform.position = new Vector3(-21.7f, 12.6f, 0f);
        Debug.Log(transform.position);
    }

    void FixedUpdate()
    {
        crimeRateY = 12.0f + DarkNumCount.crimeRateFx;

        timer += Time.deltaTime;
        if (timer >= 5.0f)
        {
            randomHold = Random.Range(-0.06f, 0.06f);
            transform.position += new Vector3(0.05f, DarkNumCount.crimeRateFx + randomHold, 0);
            //Debug.Log(DarkNumCount.crimeRateFx);
            //Debug.Log(transform.position);
            timer = 0.0f;
        }
    }




}
