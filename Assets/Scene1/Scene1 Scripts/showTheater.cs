using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showTheater : MonoBehaviour
{
    public GameObject theater;
   


    private void OnTriggerEnter(Collider other)
    {

        theater.SetActive(true);
        
    }
}
