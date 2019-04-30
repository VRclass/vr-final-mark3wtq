using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level2Trigger : MonoBehaviour
{
        public GameObject Struct;
        public GameObject ele;
        public GameObject eleDoor;
		public GameObject DoorCloseSound;
		public GameObject eleSound;
        moveUp move;


    private void Start()
    {
        move = ele.GetComponent<moveUp>();
		DoorCloseSound.SetActive(false);

    }

        private void OnTriggerEnter(Collider other)
        {

            DoorCloseSound.SetActive(true);
			eleSound.SetActive(false);
			Struct.SetActive(false);
            move.enabled = false;
            eleDoor.SetActive(false);
            


        }
}
