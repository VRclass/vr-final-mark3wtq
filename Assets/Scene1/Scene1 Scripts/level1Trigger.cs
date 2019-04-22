using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level1Trigger : MonoBehaviour
{
    public GameObject Struct;
    public GameObject shore;
    public Light eleLight;
    public Light InsideLight;
    public GameObject theater;


    private void Start()
    {
        Struct.SetActive(false);
        theater.SetActive(false);
        eleLight.enabled = false;
        InsideLight.enabled = true;


    }

    private void OnTriggerEnter(Collider other)
    {

        shore.SetActive(false);
        Struct.SetActive(true);
        eleLight.enabled = true;
        InsideLight.enabled = false;
            
            Debug.Log("showing");

      
    }
}
