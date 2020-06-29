using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class Click3 : MonoBehaviour
{

	
    public GameObject vcam1;
    public GameObject vcam2;
    public GameObject vcam3;
    public GameObject vcam4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        // this object was clicked - do something

        if (Input.GetKey(KeyCode.Mouse0))
        {
            vcam3.gameObject.SetActive(true);
            vcam2.gameObject.SetActive(false);
            vcam1.gameObject.SetActive(false);
        }
        else if (Input.GetKey(KeyCode.Mouse1))
        {
            vcam3.gameObject.SetActive(false);
            vcam2.gameObject.SetActive(false);
            vcam1.gameObject.SetActive(false);
            vcam4.gameObject.SetActive(true);
        }

    }
   

}

