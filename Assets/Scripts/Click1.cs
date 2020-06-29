using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class Click1 : MonoBehaviour
{
    public GameObject vcam1;
    public GameObject vcam2;
    public GameObject vcam3;
    public GameObject vcam4;
    public Camera mcam;
    public GameObject sphere1;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    void OnMouseOver(){
   // this object was clicked - do something
    	
        if (Input.GetKey(KeyCode.Mouse0))
        {
            vcam1.gameObject.SetActive(true);
            vcam2.gameObject.SetActive(false);
            vcam3.gameObject.SetActive(false);
            var mo = mcam.GetComponent<MouseOrbit>();
            mo.target = sphere1.transform;
            mo.distance = 10.0f;
            vcam1.gameObject.SetActive(false);
        }
        else if (Input.GetKey(KeyCode.Mouse1))
        {
            vcam1.gameObject.SetActive(false);
            vcam4.gameObject.SetActive(true);
            vcam2.gameObject.SetActive(false);
            vcam3.gameObject.SetActive(false);
            //MouseOrbit mo = mcam.GetComponent<MouseOrbit>();
            //mo.Target = vcam1;
        }

    }

    

}

