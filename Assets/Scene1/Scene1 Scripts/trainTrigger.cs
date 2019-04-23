using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trainTrigger : MonoBehaviour
{
    public GameObject train;
    public GameObject screen;
    public GameObject stage;
    public GameObject timer;
    public Light onScreen;
    public Light onTrain;




    private void Start()
    {
        train.SetActive(false);
        onTrain.enabled = false;
  
    }

    private void OnTriggerEnter(Collider other)
    {

        onScreen.enabled = false;
        onTrain.enabled = true;
        screen.SetActive(false);
        stage.SetActive(false);
        train.SetActive(true);
        timer.SetActive(false);

    }
}
