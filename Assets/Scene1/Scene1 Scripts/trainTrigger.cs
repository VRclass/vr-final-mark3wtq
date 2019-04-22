using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trainTrigger : MonoBehaviour
{
    public GameObject train;
    public GameObject screen;
    public GameObject stage;



    private void Start()
    {
        train.SetActive(false);


    }

    private void OnTriggerEnter(Collider other)
    {

        screen.SetActive(false);
        stage.SetActive(false);
        train.SetActive(true);
    }
}
