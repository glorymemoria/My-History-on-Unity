using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionToHappen : MonoBehaviour
{
    public GameObject glow;

    private bool mugCollided;
    private bool bowlCollided;

    private List<GameObject> currentlyColliding;

    public int numCollisionsToTrigger = 2;

    void Start()
    {
        glow.SetActive(false);
        currentlyColliding = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if(currentlyColliding.Count >= numCollisionsToTrigger)
        {
            Debug.Log("Collision number reached!");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        /*
        if (other.gameObject.tag == "mug")
        {
            mugCollided = true;
        }

        if (other.gameObject.tag == "bowl")
        {
            bowlCollided = true;
        }
        */

        currentlyColliding.Add(other.gameObject);
    }

    void OnTriggerExit(Collider other)
    {
        /*
        if (other.gameObject.tag == "mug")
        {
            mugCollided = false;
        }

        if (other.gameObject.tag == "bowl")
        {
            bowlCollided = false;
        }
        */

        if (currentlyColliding.Contains(other.gameObject))
        {
            currentlyColliding.Remove(other.gameObject);
        }
    }
}
