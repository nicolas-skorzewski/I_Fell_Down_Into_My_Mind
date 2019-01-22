using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aspen_lookAt : MonoBehaviour {

    public Transform target;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(target);
	}
}
