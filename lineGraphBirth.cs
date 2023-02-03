using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lineGraphBirth : MonoBehaviour
{
    protected float birthRateY;
    float timer, randomHold;

    void Start()//223.3336,165.2832,-13.70563
    {
        //transform.position = new Vector3(-21.7f, 12.6f, 0f);
        Debug.Log(transform.position);
    }

    void FixedUpdate()
    {
        birthRateY = 12.0f + DarkNumCount.birthRateFx;

        timer += Time.deltaTime;
        if(timer >= 5.0f)
        {
            randomHold = Random.Range(-0.045f, 0.045f);
            Debug.Log(randomHold);
            transform.position += new Vector3(0.05f, DarkNumCount.birthRateFx+randomHold, 0);
            Debug.Log(DarkNumCount.birthRateFx);
            Debug.Log("birth rate " + transform.position);
            timer = 0.0f;
        }
    }
    



}

#region can be used in Scene1
/*void Update()
{
    if (gameStart == true)
    {
        timer += Time.deltaTime;
        Debug.Log(timer);
        movingX += 0.0001f;
        transform.position += new Vector3(movingX, movingX * (DarkNumCount.birthRateFx - 1), 0);
    }
}*/
#endregion
