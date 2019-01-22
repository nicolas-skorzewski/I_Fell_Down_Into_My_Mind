using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aspen_up_down : MonoBehaviour
{

    public float speed = 1f;
    public GameObject interactiveScript;



    // Update is called once per frame
    void Update()
    {
       if ( interactiveScript.activeInHierarchy == (false))
        {

            transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time * speed, .5f), transform.position.z);
        }
    }
}
