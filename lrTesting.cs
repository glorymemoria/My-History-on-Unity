using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lrTesting : MonoBehaviour
{

    [SerializeField] private Transform[] points;
    [SerializeField] private lineMark line;
    // Start is called before the first frame update

    private void Start()
    {
        line.SetUpLine(points);
    }
   /* void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
}
