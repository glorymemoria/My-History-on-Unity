using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareBehaviour : MonoBehaviour
{
    public Vector3 speed;
    public float xSpeed;
    public float rotSpeed;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("This is the start.");
        // transform.position = new Vector3(3, 3, 2);
        // transform.rotation = Quaternion.fromEuler(0,0,1);
        //gameObject.GetComponent<Renderer>().enabled = false;//make sth unseenable
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("This is update.");
        //GetComponent<SpriteRenderer>().color = Color.cyan;
        if (Input.GetKey(KeyCode.Space))
        {
            // transform.position = transform.position + new Vector3(-1, 0, 0);
            // transform.position += new Vector3(-0.1f, 0, 0);
            transform.position += speed;
            // transform.position += new Vector3(xSpeed, 0, 0);
            // transform.Rotate(Vector3.forward * -0.1f);
            // transform.Rotate(Vector3.forward * rotSpeed);
            // transform.localScale += new Vector3(0.1f, 0.1f, 0);
            // transform.Rotate(new Vector3(0, 0, 1) * rotSpeed);//to set up for a quickly used rotSpeed in Unity
            /*   if (Input.GetMouseButton(0))
   {
       gameObject.GetComponent<Renderer>().enabled = true;//make sth seenable
   }*/
        }
        if (Input.GetMouseButton(0))
         {
             Debug.Log("Left Mouse Button");
             transform.Rotate(Vector3.forward * rotSpeed);
         }

    }
    /*private void OnMouseDown()
    {
        //gameObject.GetComponent<Renderer>().enabled = true;//make sth seenable
        GetComponent<SpriteRenderer>().color = Color.cyan;
    }*/
}
