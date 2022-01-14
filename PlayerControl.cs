using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Vector3 leftPos = new Vector3(-4, -3, 0);
    Vector3 midPos = new Vector3(0, -3, 0);
    Vector3 rightPos = new Vector3(4, -3, 0);

    void Start()
    {
        transform.position = midPos;
    }

  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (transform.position == midPos)
            {
                transform.position = leftPos;
            }else if (transform.position == rightPos)
            {
                transform.position = midPos;
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (transform.position == midPos)
            {
                transform.position = rightPos;
            }else if (transform.position == leftPos)
            {
                transform.position = midPos;
            }
        }
    }
}
