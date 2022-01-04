using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintBehaviour : MonoBehaviour
{
    public float xSpeed;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(35, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            gameObject.GetComponent<Renderer>().enabled = false;//make sth unseenable
        }
       /* if (Input.GetKey(KeyCode.RightArrow) && transform.position.x > -50)
        {
            transform.position += new Vector3(xSpeed, 0, 0);
            if (transform.position.x <= -50)
            {
                transform.position = new Vector3(-49.9f, 0, 0);
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-xSpeed, 0, 0);
            if (transform.position.x >= 50)
            {
                transform.position = new Vector3(49.9f, 0, 0);
            }
        }*/
    }
}