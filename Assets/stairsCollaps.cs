using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stairsCollaps : MonoBehaviour
{
    //public Rigidbody stairs;
    public GameObject MagicLight;

    private void OnTriggerEnter(Collider other)
    {
        //stairs.useGravity = true;
        MagicLight.SetActive(false);
    }
}
