using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTimer : MonoBehaviour
{
    public float force;
    public Rigidbody timer;

    void Start()
    {
        force = 0.5f;
        timer = GetComponent<Rigidbody>();

    }

    private void FixedUpdate()
    {
        timer.AddForce(transform.forward * force);
    }
}
