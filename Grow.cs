using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow : MonoBehaviour
{
    // Start is called before the first frame update
    public float time;
    public float time2;
    private float random;
    public float randomA;
    public float randomB;

    void Start()
    {
        random = Random.Range(0.15f, 0.4f);
        randomA = Random.Range(-70f, -50f); 
        randomB = Random.Range(2f, 3f);

        //print(random);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        time2 = (time-3)/15;
        if (0 < time2 && time2 * 15 < random)
        {
            transform.Translate(time2, randomA * (time2) * (time2) + randomB * (time2), 0);
        }

        else
        {
            transform.Translate(0, 0, 0);
        }

    }
}