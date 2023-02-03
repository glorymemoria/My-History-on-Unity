using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lineGraphGdp : MonoBehaviour
{
    protected float gdpRateY;
    float timer, randomHold;

    void Start()//223.3336,165.2832,-13.70563
    {
        //transform.position = new Vector3(-21.7f, 12.6f, 0f);
        Debug.Log(transform.position);
    }

    void FixedUpdate()
    {
        gdpRateY = 12.0f + DarkNumCount.ecoRateFx;

        timer += Time.deltaTime;
        if (timer >= 5.0f)
        {
            randomHold = Random.Range(-0.05f, 0.05f);
            transform.position += new Vector3(0.05f, DarkNumCount.ecoRateFx + randomHold, 0);
            //Debug.Log(DarkNumCount.crimeRateFx);
            //Debug.Log(transform.position);
            timer = 0.0f;
        }
    }




}
