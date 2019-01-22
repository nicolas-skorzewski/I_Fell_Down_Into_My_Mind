using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorLower : MonoBehaviour
{
    public float speed;
    public GameObject box;
    public Collider box_c;
    Vector3 target = new Vector3(0, 1, 0);
    Vector3 etarget = new Vector3(0, 0, 0);

    private void Update()
    {
        OnTriggerExit(box_c);
    }

    private void OnTriggerExit(Collider box_c)
    {
        float step = speed * Time.deltaTime;
        box.transform.position = Vector3.MoveTowards(box.transform.position, etarget, step);
    }
}