using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noPlatform : MonoBehaviour
{
    public GameObject magicLight;
    public Light stairLight;
    public GameObject platform;
    public GameObject Timer;
    moveTimer Move;
   
    void Start()
    {
        magicLight.SetActive(false);
        Move = Timer.GetComponent<moveTimer>();
        Move.enabled = false;

    }

    private void OnTriggerEnter(Collider other)
    {
        platform.SetActive(false);
        magicLight.SetActive(true);
        stairLight.enabled = false;
        Move.enabled = true;
    }
}
