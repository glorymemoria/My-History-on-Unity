using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windControl : MonoBehaviour
{

    //public void SetActive(bool value); 
    public GameObject windController;
    public GameObject windController2;
    public GameObject windController3;

    public GameObject faded;
    public GameObject faded1;
    public GameObject faded2;
    public GameObject faded3;
    public GameObject faded4;
    public GameObject faded5;
    public GameObject faded6;
    public GameObject faded7;
    public GameObject faded8;
    public GameObject faded9;
    public GameObject faded10;


    void Start()
    {
        //gameObject.FindGameObjectWithTag(Wind);
        //gameObject.SetActive(false);
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            windController.SetActive(true);
            windController2.SetActive(true);
            windController3.SetActive(true);
        }
        else
        {
            windController.SetActive(false);
            windController2.SetActive(false);
            windController3.SetActive(false);
        }

        /*if (Input.GetKey(KeyCode.Space))//GetButtonDown
        {
            gameObject.SetActive(true);
        }*/

        if (Input.GetKey(KeyCode.F))
        {
            faded.SetActive(false);
            faded1.SetActive(false);
            faded2.SetActive(false);
            faded3.SetActive(false);
            faded4.SetActive(false);
            faded5.SetActive(false);
            faded6.SetActive(false);
            faded7.SetActive(false);
            faded8.SetActive(false);
            faded9.SetActive(false);
            faded10.SetActive(false);
        }
        else
        {
            faded.SetActive(true);
            faded1.SetActive(true);
            faded2.SetActive(true);
            faded3.SetActive(true);
            faded4.SetActive(true);
            faded5.SetActive(true);
            faded6.SetActive(true);
            faded7.SetActive(true);
            faded8.SetActive(true);
            faded9.SetActive(true);
            faded10.SetActive(true);
        }
    }

}
