using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderPlant : MonoBehaviour
{

    float horInput;
    float vertInput;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horInput = Input.GetAxis("Horizontal") * speed;
        transform.Translate(horInput, 0, 0);
        print(horInput);
        vertInput = Input.GetAxis("Vertical") * speed;
        transform.Translate(0, vertInput, 0);

    }
}