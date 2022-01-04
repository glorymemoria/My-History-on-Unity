using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birds : MonoBehaviour
{
    public Vector3 speed;
    public float xSpeed;
    public Animation anim;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
        anim = GetComponent<Animation>();
        foreach (AnimationState state in anim)
        {
            state.speed = 0.5F;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x > -6)
        {
            transform.position += new Vector3(xSpeed, 0, 0);
            //transform.GetComponent<Animation>().Play("Take 001");
            if (transform.position.x <= -6)
            {
                transform.position = new Vector3(-5.99f, 0, 0);
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x < 5)
        {
            transform.position += new Vector3(-xSpeed, 0, 0);
            //transform.GetComponent<Animation>().Play("Take 001");
            if (transform.position.x >= 5)
            {
                transform.position = new Vector3(4.99f, 0, 0);
            }
        }
    }
}
