using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleCamera : MonoBehaviour
{
    public GameObject a;
    public Camera mainCam;

    void Start()
    {
        Vector3 p = a.transform.position;

        mainCam.transform.position = new Vector3( p.x, p.y+5,p.z-5);


    }
    
}