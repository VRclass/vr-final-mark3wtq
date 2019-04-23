using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onTrain : MonoBehaviour
{
    public GameObject Struct;
    public GameObject ele;
    public GameObject theater;
    public GameObject platform;
    public GameObject stairs;

    private void Start()
    {
        platform.SetActive(false);
        stairs.SetActive(false);
    }


    private void OnTriggerEnter(Collider other)
    {

        Struct.SetActive(false);
        ele.SetActive(false);
        theater.SetActive(false);
        platform.SetActive(true);
        stairs.SetActive(true);


    }
}
