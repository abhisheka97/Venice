using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class Click2 : MonoBehaviour
{
    public GameObject vcam1;
    public GameObject vcam2;
    public GameObject vcam3;
    public GameObject vcam4;
    public Camera mcam;
    public GameObject sphere2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseOver()
    {
        // this object was clicked - do something

        if (Input.GetKey(KeyCode.Mouse0))
        {
            vcam1.gameObject.SetActive(false);
            vcam2.gameObject.SetActive(true);
            vcam3.gameObject.SetActive(false);
            var mo = mcam.GetComponent<MouseOrbit>();
            mo.target = sphere2.transform;
            mo.distance = 10.0f;
            vcam2.gameObject.SetActive(false);
        }
        else if (Input.GetKey(KeyCode.Mouse1))
        {
            vcam2.gameObject.SetActive(false);
            vcam4.gameObject.SetActive(true);
            vcam3.gameObject.SetActive(false);
            vcam1.gameObject.SetActive(false);
        }

    }

}

