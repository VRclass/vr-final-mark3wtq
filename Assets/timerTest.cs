using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timerTest : MonoBehaviour
{
    public GameObject ele;

    private void OnTriggerEnter(Collider other)
    {
        ele.SetActive(false);
    }

}
