using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkNumCount : MonoBehaviour
{
    public static int pplsHope = 5, techLevel = 5, govPurse = 1000;
    public static float birthRateFx, ecoRateFx, crimeRateFx;

    void Start()
    {
        
    }


    void FixedUpdate()
    {
       birthRateFx = PolicyList.BirthRate;
        crimeRateFx = PolicyList.CrimeRate;
        ecoRateFx = PolicyList.EcoRate;


    }
}
