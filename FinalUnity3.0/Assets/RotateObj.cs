using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObj : MonoBehaviour
{
    public float speed = 30;
    void Update()
    {
        //rotate object on the y axis
        transform.Rotate(0, speed * Time.deltaTime, 0, Space.Self);
    }
}