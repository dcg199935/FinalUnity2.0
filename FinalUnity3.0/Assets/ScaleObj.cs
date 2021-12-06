using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleObj : MonoBehaviour
{
    public float size = 20;

    void Update()
    {
        //change the scale from value between 0 and 'size' over time
        transform.localScale = new Vector3(10,15,20);
    }
}

//note: Vector3.one is the same as new Vector3(1,1,1);
