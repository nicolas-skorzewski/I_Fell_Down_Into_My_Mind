using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateAround : MonoBehaviour
{
    public Vector3 player;
    void Update()
    {
        // Spin the object around the world origin at 20 degrees/second.
        transform.Rotate(player, 20 * Time.deltaTime);
    }
}
