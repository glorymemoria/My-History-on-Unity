using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundBehaviour : MonoBehaviour
{
    public float xSpeed;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("This is the start.");
        transform.position = new Vector3(50.9f, 0, 0);
        gameObject.GetComponent<Renderer>().enabled = false;//make sth unseenable
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update.");
        if (Input.GetKeyDown(KeyCode.Escape))//if press esc the game quit, should not be put here next time
        {
            Application.Quit();
        }
        if (Input.GetMouseButton(0))
        {
            gameObject.GetComponent<Renderer>().enabled = true;//make sth seenable
        }
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x > -51)
        {
            transform.position += new Vector3(xSpeed, 0, 0);
            if (transform.position.x <= -51)
            {
            transform.position = new Vector3(-50.9f, 0, 0);
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-xSpeed, 0, 0);
            if (transform.position.x >= 51)
            {
                transform.position = new Vector3(50.9f, 0, 0);
            } 
        }
    }
}

