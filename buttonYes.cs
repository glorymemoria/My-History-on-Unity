using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttonYes : MonoBehaviour
{
    //public float timeLeft = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        //gameObject.GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
     //   timeLeft += Time.deltaTime;
     //   if (timeLeft > 5)
     //   {
     //       gameObject.GetComponent<Renderer>().enabled = true;//make sth seenable
     //   }
    }
    void OnMouseDown()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }

    void OnMouseOver()
    {
        GetComponent<SpriteRenderer>().color = Color.green;
    }
    void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
    }
}
