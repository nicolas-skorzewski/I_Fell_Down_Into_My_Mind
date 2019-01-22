using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AspenIntroduction : MonoBehaviour {

    public GameObject aspen;
    public float speed = 1f;
    public GameObject scripts;
    public GameObject interactiveScript;

	// Update is called once per frame
	void Update () {
        
        if (aspen.transform.position.y <= .35f)
        {
            aspen.transform.position += Vector3.up * speed * Time.deltaTime;
           // scripts.SetActive(true);
        }
        if (aspen.transform.position.y >= .35f)
        {
            interactiveScript.SetActive(false);
           
        }
    }
}
