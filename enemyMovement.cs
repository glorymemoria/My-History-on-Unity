using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        int speed = 5;

        void FixedUpdate()
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);

            if (transform.position.y < -6)
            {
                Destroy(gameObject);
            }
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        other.GetComponent<SpriteRenderer>().color = new Color(1, 0, 0, 1);
    }
}
