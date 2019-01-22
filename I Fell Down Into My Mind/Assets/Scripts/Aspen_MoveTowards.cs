using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aspen_MoveTowards : MonoBehaviour {

   // public float speed;
    public float fSpeed;
    public float cSpeed;
    public GameObject aspen_stop;
    private Vector3 aspenFollow;
    public Transform aspen;
    public GameObject interactiveScript;
    
    // Use this for initialization
    void Start () {
		
	}
    
    // Update is called once per frame
    void Update () {
        if (interactiveScript.activeInHierarchy == false)
        {


            float dist = Vector3.Distance(aspen.position, aspen_stop.transform.position);

            if (dist >= 5)
            {
                aspenFollow = new Vector3(aspen_stop.transform.position.x, transform.position.y, aspen_stop.transform.position.z);
                transform.position = Vector3.MoveTowards(transform.position, aspenFollow, fSpeed * Time.deltaTime);
            }
            else if (dist <= 4.9)
            {
                aspenFollow = new Vector3(aspen_stop.transform.position.x, transform.position.y, aspen_stop.transform.position.z);
                transform.position = Vector3.MoveTowards(transform.position, aspenFollow, cSpeed * Time.deltaTime);
            }
        }
	}
}
