using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textPlants : MonoBehaviour
{
    public float timeLeft = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft += Time.deltaTime;
        if (timeLeft > 3)
        {
            gameObject.GetComponent<Renderer>().enabled = true;//make sth seenable
        }
    }
}
