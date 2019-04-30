using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eleTrigger : MonoBehaviour
{
    public GameObject ele;
    public GameObject eleDoor;
	public GameObject eleSound;
	
    moveUp move;

    private void Start()
    {
        move = ele.GetComponent<moveUp>();
        eleDoor.SetActive(false);
		eleSound.SetActive(false);
		
    }

    private void OnTriggerEnter(Collider other)
    {
		
        move.enabled = true;
        eleDoor.SetActive(true);
        Debug.Log("Moving");
		eleSound.SetActive(true);
		
    }

}
