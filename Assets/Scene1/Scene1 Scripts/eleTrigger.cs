using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eleTrigger : MonoBehaviour
{
    public GameObject ele;
    public GameObject eleDoor;
    moveUp move;

    private void Start()
    {
        move = ele.GetComponent<moveUp>();
        eleDoor.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        move.enabled = true;
        eleDoor.SetActive(true);
        Debug.Log("Moving");
    }

}
