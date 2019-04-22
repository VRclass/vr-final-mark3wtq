using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noShore : MonoBehaviour
{
   
    public GameObject shore;


    private void OnTriggerEnter(Collider other)
    {

   
        shore.SetActive(false);
       

        
    }
}
