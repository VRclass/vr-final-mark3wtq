using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBlockTrigger : MonoBehaviour
{
    public GameObject doorBlock;


    private void Start()
    {
        doorBlock.SetActive(false);



    }

    private void OnTriggerEnter(Collider other)
    {


        doorBlock.SetActive(true);


    }
}
