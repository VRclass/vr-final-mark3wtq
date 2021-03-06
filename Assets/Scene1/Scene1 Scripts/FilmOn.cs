﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FilmOn : MonoBehaviour
{
    public Light onScreen;
    public Light onSeats;
    public GameObject timer;
	public GameObject filmSound;

    // Start is called before the first frame update
    void Start()
    {
        onScreen.enabled = false;
        onSeats.enabled = false;
        timer.SetActive(false);
		filmSound.SetActive(false);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        onScreen.enabled = true;
        onSeats.enabled = true;
        timer.SetActive(true);
		filmSound.SetActive(true);
    }
}
