using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level2Trigger : MonoBehaviour
{
        public GameObject Struct;
        public GameObject ele;
        public GameObject eleDoor;
        moveUp move;


    private void Start()
    {
        move = ele.GetComponent<moveUp>();

    }

        private void OnTriggerEnter(Collider other)
        {

            Struct.SetActive(false);
            move.enabled = false;
            eleDoor.SetActive(false);
            


        }
}
