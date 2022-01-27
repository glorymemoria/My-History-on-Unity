using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickToHappen : MonoBehaviour
{


    public void Transparent()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
    }

    public void Distransparent()
    {
        gameObject.GetComponent<Renderer>().enabled = true;
    }


    
}

