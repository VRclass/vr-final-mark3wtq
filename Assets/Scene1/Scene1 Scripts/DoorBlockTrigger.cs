using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBlockTrigger : MonoBehaviour
{
    public GameObject doorBlock;
	public GameObject filmSound;


    private void Start()
    {
        doorBlock.SetActive(false);



    }

    private void OnTriggerEnter(Collider other)
    {

		filmSound.SetActive(false);
        doorBlock.SetActive(true);


    }
}
