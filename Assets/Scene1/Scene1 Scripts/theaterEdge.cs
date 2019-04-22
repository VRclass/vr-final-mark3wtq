using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class theaterEdge : MonoBehaviour
{
    public GameObject edge;


    private void Start()
    {
        edge.SetActive(false);


    }

    private void OnTriggerEnter(Collider other)
    {


        edge.SetActive(true);
    }
}
