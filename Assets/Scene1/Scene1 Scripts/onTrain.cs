using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onTrain : MonoBehaviour
{
    public GameObject Struct;
    public GameObject ele;
    public GameObject theater;


    private void OnTriggerEnter(Collider other)
    {

        Struct.SetActive(false);
        ele.SetActive(false);
        theater.SetActive(false);


    }
}
