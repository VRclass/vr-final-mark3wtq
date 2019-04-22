using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FilmOn : MonoBehaviour
{
    public Light onScreen;
    public Light onSeats;
    // Start is called before the first frame update
    void Start()
    {
        onScreen.enabled = false;
        onSeats.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        onScreen.enabled = true;
        onSeats.enabled = true;
    }
}
