using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noTrain : MonoBehaviour
{
    public GameObject train;

    private void OnTriggerEnter(Collider other)
    {
        train.SetActive(false);
    }

}
