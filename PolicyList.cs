using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolicyList : MonoBehaviour
{
    #region Policy Define

    public static List<string> policyTitle = new List<string>();

    public static List<float> policyBirth = new List<float>();
    public static List<float> policyCrime = new List<float>();
    public static List<float> policyEco = new List<float>();
    public static List<float> policyHope = new List<float>();

    public static List<bool> policyFinished = new List<bool>();
    public static List<bool> policyShowing = new List<bool>();
    public static List<bool> policyApprove = new List<bool>();

    #endregion

    public static float BirthRate = -0.03f, CrimeRate = 0.0f, EcoRate = 0.0f, PplsHope = 10f;

    public static bool finishedGame;

    void Start()
    {
        finishedGame = false;

        #region policyTitle
        policyTitle.Insert(0, "Bachelor Tax");
        policyTitle.Insert(1, "Restriction Abortion");
        policyTitle.Insert(2, "Forbidden Abortion");
        policyTitle.Insert(3, "Cool Period Divorce");
        policyTitle.Insert(4, "Artificial Tech");

        policyTitle.Insert(5, "Advertising Benefits");
        policyTitle.Insert(6, "Birth Point to Conpanies");
        policyTitle.Insert(7, "Gender Career Equal");
        policyTitle.Insert(8, "Limit Contraception Products");
        policyTitle.Insert(9, "Country Hold Reproduction");

        policyTitle.Insert(10, "Low Income Mother");
        policyTitle.Insert(11, "SelfSex Limit");
        policyTitle.Insert(12, "Upgrade Medical Treat");
        policyTitle.Insert(13, "Womb use by Public");
        policyTitle.Insert(14, "Fake Women Welfare");

        #endregion

        #region policyBirth
        policyBirth.Insert(0, 0.003f);
        policyBirth.Insert(1, 0.005f);
        policyBirth.Insert(2, 0.008f);
        policyBirth.Insert(3, 0.001f);
        policyBirth.Insert(4, 0f);

        policyBirth.Insert(5, 0.0015f);
        policyBirth.Insert(6, 0.004f);
        policyBirth.Insert(7, -0.002f);
        policyBirth.Insert(8, 0.004f);
        policyBirth.Insert(9, 0.025f);

        policyBirth.Insert(10, 0.002f);
        policyBirth.Insert(11, 0.003f);
        policyBirth.Insert(12, 0.003f);
        policyBirth.Insert(13, 0.008f);
        policyBirth.Insert(14, 0.002f);
        #endregion

        #region policyCrime
        policyCrime.Insert(0, 0.01f);
        policyCrime.Insert(1, 0.02f);
        policyCrime.Insert(2, 0.05f);
        policyCrime.Insert(3, 0.01f);
        policyCrime.Insert(4, 0f);

        policyCrime.Insert(5, -0.01f);
        policyCrime.Insert(6, 0.02f);
        policyCrime.Insert(7, -0.04f);
        policyCrime.Insert(8, 0.04f);
        policyCrime.Insert(9, 0f);

        policyCrime.Insert(10, -0.01f);
        policyCrime.Insert(11, 0.04f);
        policyCrime.Insert(12, -0.02f);
        policyCrime.Insert(13, -0.02f);
        policyCrime.Insert(14, 0.02f);
        #endregion

        #region policyEco
        policyEco.Insert(0, 0.003f);
        policyEco.Insert(1, -0.003f);
        policyEco.Insert(2, -0.005f);
        policyEco.Insert(3, -0.001f);
        policyEco.Insert(4, 0.003f);

        policyEco.Insert(5, 0.001f);
        policyEco.Insert(6, 0.004f);
        policyEco.Insert(7, 0.005f);
        policyEco.Insert(8, -0.003f);
        policyEco.Insert(9, 0f);

        policyEco.Insert(10, 0.002f);
        policyEco.Insert(11, -0.003f);
        policyEco.Insert(12, 0.002f);
        policyEco.Insert(13, 0.001f);
        policyEco.Insert(14, -0.003f);
        #endregion

        #region policyHope
        policyHope.Insert(0, -1f);
        policyHope.Insert(1, -4f);
        policyHope.Insert(2, -6f);
        policyHope.Insert(3, -1f);
        policyHope.Insert(4, 2f);

        policyHope.Insert(5, 0f);
        policyHope.Insert(6, 4f);
        policyHope.Insert(7, -2f);
        policyHope.Insert(8, -4f);
        policyHope.Insert(9, 0f);

        policyHope.Insert(10, 3f);
        policyHope.Insert(11, -3f);
        policyHope.Insert(12, 3f);
        policyHope.Insert(13, 2f);
        policyHope.Insert(14, 0f);
        #endregion

        #region policyFinished
        policyFinished.Insert(0, false);
        policyFinished.Insert(1, false); 
        policyFinished.Insert(2, false);
        policyFinished.Insert(3, false);
        policyFinished.Insert(4, false);

        policyFinished.Insert(5, false);
        policyFinished.Insert(6, false);
        policyFinished.Insert(7, false);
        policyFinished.Insert(8, false);
        policyFinished.Insert(9, false);

        policyFinished.Insert(10, false);
        policyFinished.Insert(11, false);
        policyFinished.Insert(12, false);
        policyFinished.Insert(13, false);
        policyFinished.Insert(14, false);
        #endregion

        #region policyShowing
        policyShowing.Insert(0, false);
        policyShowing.Insert(1, false);
        policyShowing.Insert(2, false);
        policyShowing.Insert(3, false);
        policyShowing.Insert(4, false);

        policyShowing.Insert(5, false);
        policyShowing.Insert(6, false);
        policyShowing.Insert(7, false);
        policyShowing.Insert(8, false);
        policyShowing.Insert(9, false);

        policyShowing.Insert(10, false);
        policyShowing.Insert(11, false);
        policyShowing.Insert(12, false);
        policyShowing.Insert(13, false);
        policyShowing.Insert(14, false);
        #endregion

        #region policyApprove
        policyApprove.Insert(0, false);
        policyApprove.Insert(1, false);
        policyApprove.Insert(2, false);
        policyApprove.Insert(3, false);
        policyApprove.Insert(4, false);

        policyApprove.Insert(5, false);
        policyApprove.Insert(6, false);
        policyApprove.Insert(7, false);
        policyApprove.Insert(8, false);
        policyApprove.Insert(9, false);

        policyApprove.Insert(10, false);
        policyApprove.Insert(11, false);
        policyApprove.Insert(12, false);
        policyApprove.Insert(13, false);
        policyApprove.Insert(14, false);
        #endregion


    }


    public static void GetRandomPolicy()
    {
        int randomNum = Random.Range(0, 15);
        Debug.Log(randomNum);
            
        Debug.Log(policyFinished[randomNum]);
        if (policyFinished[randomNum] == false)
        {
            policyShowing[randomNum] = true;
            Debug.Log(policyTitle[randomNum] + " is chosen to be shown");
            
        }
        else if (policyFinished[randomNum] == true) GetRandomPolicy();
        else return;
        
    }

    public static void ApprovePolicy()
    {
        Debug.Log("policy approving!");
        for (int i = 0; i < 15; i++)
        {
            Debug.Log("Check if " + policyTitle[i] + " is showing: " + policyShowing[i]);

            if (policyFinished[0] == true && policyFinished[1] == true && policyFinished[2] == true && policyFinished[3] == true && policyFinished[4] == true
                && policyFinished[5] == true && policyFinished[6] == true && policyFinished[7] == true && policyFinished[8] == true && policyFinished[9] == true
                   && policyFinished[10] == true && policyFinished[11] == true && policyFinished[12] == true && policyFinished[13] == true && policyFinished[14] == true)
            {
                finishedGame = true;
                Debug.Log("finished game = " + finishedGame);
            }
            else if (policyShowing[i] == true)
            {
                Debug.Log(policyTitle[i] + " is approved!");
                policyShowing[i] = false;
                policyFinished[i] = true;
                policyApprove[i] = true;

                //Debug.Log("Current birth rate = " + policyBirth[i]);
                CountingPolicy
                    (policyBirth[i], policyBirth[i], policyBirth[i], policyBirth[i]);
            }
            else if (policyShowing[i] != true)
            {
                continue;
            }
            

            else return;
        }
    }

    public static void RejectPolicy()
    {
        for (int i = 0; i < 15; i++)
        {
            if (policyFinished[0] == true && policyFinished[1] == true && policyFinished[2] == true && policyFinished[3] == true && policyFinished[4] == true
                && policyFinished[5] == true && policyFinished[6] == true && policyFinished[7] == true && policyFinished[8] == true && policyFinished[9] == true
                   && policyFinished[10] == true && policyFinished[11] == true && policyFinished[12] == true && policyFinished[13] == true && policyFinished[14] == true)
            {
                finishedGame = true;
                Debug.Log("finished game = " + finishedGame);
            }
            
            else if (policyShowing[i] == true)
            {
                Debug.Log(policyTitle[i] + " is rejected!");
                policyShowing[i] = false;
                policyFinished[i] = true;
                policyApprove[i] = false;
            }
            else if (policyShowing[i] != true)
            {
                continue;
            }
            

            else return;
        }
    }

    public static void CountingPolicy(float a, float b, float c, float d)
    {
        BirthRate += a;
        CrimeRate += b;
        EcoRate += c;
        PplsHope += d;
    }

    public static void FinishPolicy()
    {
        int showingNum = 100;
        //foreach ()
    }
}
