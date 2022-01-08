using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class para : MonoBehaviour
{
    // Start is called before the first frame update
    public float time;
    private float random;
    private float randomA;
    private float randomB;
    private float randomC;

    void Start()
    {
        random = Random.Range(0.5f, 1f);
        randomA = Random.Range(-4,-1);
        randomB = Random.Range(0.5f, 3f);
        randomC = Random.Range(-2, 0);

        print(random);
    }

    // Update is called once per frame
    void Update()
    {
        

        if (time < random)
        {
            time += Time.deltaTime;
            transform.Translate(time / 10,randomA*(time/10)*(time/10)+randomB*(time/10), 0);
        }

        else
        {
            transform.Translate(0, 0, 0);
        }

    }
}
